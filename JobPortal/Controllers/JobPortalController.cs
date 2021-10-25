using JobPortal.Models;
using JobPortal.Repositories;
using JobPortal.Shares;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace JobPortal.Controllers
{
    public class JobPortalController : ApiController
    {
        private JobPortalContext db = new JobPortalContext();

        public JobPortalController()
        {
        }

        private bool checkNullValue(string param)
        {
            if (param != null && param != "" && param != "undefined")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet]
        [Route("api/GetJobList")]
        [ActionName("LoadNew")]
        public List<JobList> GetJobList()
        {
            List<JobList> jobList = new List<JobList>();

            using (var context = new JobPortalContext())
            {
                jobList = context.JobList.Select(s => s).ToList();
            }
            return jobList;
        }

        [HttpPost]
        [Route("api/AddApplicant")]
        [ActionName("LoadNew")]
        public IHttpActionResult AddApplicant()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));

            var firstName = queryString["firstName"];
            var lastName = queryString["lastName"];
            var jobId = queryString["jobId"];
            var yearsExp = queryString["yearsExp"];
            var prefLocation = queryString["prefLocation"];
            var vacancyFoundIn = queryString["vacancyFoundIn"];
            var noticePeriod = queryString["noticePeriod"];
            var contactNo = queryString["contactNo"];
            var address = queryString["address"];
            var email = queryString["email"];
            var fileName = queryString["fileName"];
            var filePath = queryString["filePath"];
            var fileEncode = queryString["fileEncode"];
            var skills = queryString["skills"];
            string[] splitSkills = skills.Split(',');

            var status = true;
            var error_message = "";
            Applicant applicantDtl = new Applicant();
            Attachment AttachmentDtl = new Attachment();
            ApplicantSkill SkillsDtl = new ApplicantSkill();

            using (var context = new JobPortalContext())
            {
                using (var txn = context.Database.BeginTransaction())
                {
                    try
                    {
                        //Insert Data
                        applicantDtl.FirstName = firstName;
                        applicantDtl.LastName = lastName;
                        applicantDtl.JobTitle = jobId;
                        applicantDtl.YearsExp = int.Parse(yearsExp);
                        applicantDtl.PrefLocation = prefLocation;
                        applicantDtl.VacancyFoundIn = vacancyFoundIn;
                        applicantDtl.NoticePeriod = int.Parse(noticePeriod);
                        applicantDtl.ContactNo = contactNo;
                        applicantDtl.Address = address;
                        applicantDtl.Email = email;
                        context.Applicant.Add(applicantDtl);
                        context.SaveChanges();

                        txn.Commit();
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Failed Add Org", 1);
                    }
                }

                using (var txn2 = context.Database.BeginTransaction())
                {
                    try
                    {
                        //Insert Data
                        AttachmentDtl.ApplicantID = applicantDtl.ApplicantID;
                        AttachmentDtl.FileName = fileName;
                        AttachmentDtl.FilePath = filePath;
                        AttachmentDtl.FileEncode = fileEncode;
                        AttachmentDtl.UploadedDt = DateTime.Now;
                        AttachmentDtl.UploadedBy = firstName + ' ' + lastName;
                        context.Attachment.Add(AttachmentDtl);

                        context.SaveChanges();

                        txn2.Commit();
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }

                using (var txn3 = context.Database.BeginTransaction())
                {
                    try
                    {
                        List<Int64> ids = new List<Int64>();
                        foreach (string SkillsList in splitSkills.ToList())
                        {
                            if (!int.TryParse(SkillsList, out int skill))
                            {
                                //handle scenario where an id is not an int and return error
                            }
                            else
                            {
                                SkillsDtl.ApplicantID = applicantDtl.ApplicantID;
                                SkillsDtl.SkillID = skill;
                                SkillsDtl.CreatedDt = DateTime.Now;
                                SkillsDtl.CreatedBy = firstName + ' ' + lastName;
                                context.ApplicantSkill.Add(SkillsDtl);

                                context.SaveChanges();
                            }

                            //if (!int.TryParse(SkillsList, out int skill))
                            //{
                            //    // handle scenario where a tag id is not an int and return error
                            //}
                            //ids.Add(skill);
                        }
                        txn3.Commit();
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
            }
            if (status == true)
            {
                return Ok(new
                {
                    status = true
                });
            }
            else
            {
                return Ok(new
                {
                    status = false,
                    error_message = "Error: " + error_message
                });
            }
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        [HttpGet]
        [Route("api/GetCodeConfig")]
        [ActionName("LoadNew")]
        public List<CodeConfig> GetCodeConfig(int PrimeCode)
        {
            List<CodeConfig> codeList = new List<CodeConfig>();

            using (var context = new JobPortalContext())
            {
                codeList = context.CodeConfig.Where(x => x.PrimeCode == PrimeCode).ToList();
            }
            return codeList;
        }

        [HttpGet]
        [Route("api/GetSkills")]
        [ActionName("LoadNew")]
        public List<Skills> GetSkills()
        {
            List<Skills> skillList = new List<Skills>();

            using (var context = new JobPortalContext())
            {
                skillList = context.Skills.Select(s => s).ToList();
            }
            return skillList;
        }
    }
}