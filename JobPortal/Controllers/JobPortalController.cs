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
        public List<_JobList> GetJobList()
        {
            List<_JobList> jobList = new List<_JobList>();

            using (var context = new JobPortalContext())
            {
                //using (var manager = new JobPortalManager(context))
                //{
                //    jobList = manager.GetJobList(1);
                //}
                try
                {
                    //jobList = context.JobList.Select(s => s).ToList();
                    jobList = (
                        from j in context.JobList
                        select new _JobList
                        {
                            JobID = j.JobID,
                            JobTitle = j.JobTitle,
                            JobType = j.JobType,
                            JobDescription = j.JobDescription,
                            SalaryRange = j.SalaryRange,
                            PostedDt = j.PostedDt,
                            ClosingDt = j.ClosingDt,
                            Remarks = j.Remarks,
                            CreatedDt = j.CreatedDt,
                            CreatedBy = j.CreatedBy,
                            SubmittedApplication = (from a in context.Applicant where a.JobID == j.JobID select a).Count()
                        }).ToList();
                }
                catch (Exception ex)
                {
                    var error_message = ex.InnerException.InnerException.Message;
                }
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
            var jobId = int.Parse(queryString["jobId"]);
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
                        applicantDtl.JobID = jobId;
                        applicantDtl.YearsExp = int.Parse(yearsExp);
                        applicantDtl.PrefLocation = prefLocation;
                        applicantDtl.VacancyFoundIn = vacancyFoundIn;
                        applicantDtl.NoticePeriod = int.Parse(noticePeriod);
                        applicantDtl.ContactNo = contactNo;
                        applicantDtl.Address = address;
                        applicantDtl.Email = email;
                        applicantDtl.CreatedDt = DateTime.Now;
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

        [HttpGet]
        [Route("api/GetApplicantDetails")]
        [ActionName("LoadNew")]
        public List<_Applicant> GetApplicantDetails(string email)
        {
            List<_Applicant> applicantList = new List<_Applicant>();

            using (var context = new JobPortalContext())
            {
                applicantList = (from a in context.Applicant
                                 where a.Email == email
                                 select new _Applicant
                                 {
                                     ApplicantID = a.ApplicantID,
                                     FirstName = a.FirstName,
                                     LastName = a.LastName,
                                     JobID = a.JobID,
                                     YearsExp = a.YearsExp,
                                     PrefLocation = a.PrefLocation,
                                     VacancyFoundIn = a.VacancyFoundIn,
                                     NoticePeriod = a.NoticePeriod,
                                     ContactNo = a.ContactNo,
                                     Email = a.Email,
                                     Address = a.Address,
                                     CreatedDt = a.CreatedDt,
                                     JobTitle = context.JobList.Where(c => c.JobID == a.JobID).Select(b => b.JobTitle).ToList().FirstOrDefault(),
                                 }).ToList();
            }
            return applicantList;
        }
    }
}