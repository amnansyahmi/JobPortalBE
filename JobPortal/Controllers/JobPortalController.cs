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
        public string aaa = "";
        private JobPortalContext db = new JobPortalContext();

        [HttpGet]
        [Route("api/GetConfigCodesDtl")]
        [ActionName("LoadNew")]
        public List<_CONFIG_CODES_DTL> GetConfigCodesDtl(int codePrime)
        {
            List<_CONFIG_CODES_DTL> codeList = new List<_CONFIG_CODES_DTL>();

            using (var context = new JobPortalContext())
            {
                codeList = context.CONFIG_CODES_DTL.Where(x => x.CODE_PRIME == codePrime).ToList();
            }
            return codeList;
        }

        [HttpPost]
        [Route("api/UpdateConfigCodesDtl")]
        [ActionName("LoadNew")]
        public IHttpActionResult UpdateConfigCodesDtl()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var userId = queryString["userId"];
            var codePrime = int.Parse(queryString["codePrime"]);
            var codeSub = queryString["codeSub"];
            var codeSubBefore = queryString["codeSubBefore"];
            var infoDesc = queryString["infoDesc"];

            var status = true;
            var error_message = "";
            _CONFIG_CODES_DTL paramDtl = new _CONFIG_CODES_DTL(true);
            var boolName = true;
            var boolStatus = true;

            using (var context = new JobPortalContext())
            {
                using (var txn = context.Database.BeginTransaction())
                {
                    try
                    {
                        //......SingleOrDefault(PrimaryKey); P/s:PrimaryKey need to be set in the Model (Search [Key, Column(Order = 1)])
                        if (codeSub != codeSubBefore)
                        {
                            var dataTobeUpdated = context.CONFIG_CODES_DTL.SingleOrDefault(m => m.CODE_PRIME == codePrime && m.CODE_SUB == codeSubBefore);
                            paramDtl = dataTobeUpdated;
                            if (dataTobeUpdated != null)
                            {
                                //List of data to update.

                                context.CONFIG_CODES_DTL.Remove(dataTobeUpdated);
                                context.SaveChanges();

                                if (boolName = checkNullValue(codeSub))
                                {
                                    paramDtl.CODE_SUB = codeSub;
                                }

                                if (boolStatus = checkNullValue(infoDesc))
                                {
                                    paramDtl.INFO_DESC = infoDesc;
                                }

                                context.CONFIG_CODES_DTL.Add(paramDtl);
                                context.SaveChanges();
                            }
                            txn.Commit();
                        }
                        else if (codeSub == codeSubBefore)
                        {
                            var dataTobeUpdated = context.CONFIG_CODES_DTL.SingleOrDefault(m => m.CODE_PRIME == codePrime && m.CODE_SUB == codeSub);
                            paramDtl = dataTobeUpdated;
                            if (dataTobeUpdated != null)
                            {
                                if (boolStatus = checkNullValue(infoDesc))
                                {
                                    paramDtl.INFO_DESC = infoDesc;
                                }
                                context.SaveChanges();
                                txn.Commit();
                            }
                        }
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Success Update Org", 1);
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Unsuccessful Update Org", 1);
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

        [HttpPost]
        [Route("api/UpdateConfigCodesDtlDataValueI2")]
        [ActionName("LoadNew")]
        public IHttpActionResult UpdateConfigCodesDtlDataValueI2()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var userId = queryString["userId"];
            var codePrime = int.Parse(queryString["codePrime"]);
            var codeSub = queryString["codeSub"];
            var dataValueI2 = Int32.Parse(queryString["dataValueI2"]);

            var status = true;
            var error_message = "";
            _CONFIG_CODES_DTL paramDtl = new _CONFIG_CODES_DTL(true);

            using (var context = new JobPortalContext())
            {
                using (var txn = context.Database.BeginTransaction())
                {
                    try
                    {
                        var dataTobeUpdated = context.CONFIG_CODES_DTL.SingleOrDefault(m => m.CODE_PRIME == codePrime && m.CODE_SUB == codeSub);
                        paramDtl = dataTobeUpdated;
                        if (dataTobeUpdated != null)
                        {
                            paramDtl.DATA_VALUEI2 = dataValueI2;
                            paramDtl.AUDIT_UPDATED_DATE = DateTime.Now;
                            paramDtl.AUDIT_UPDATED_USER = userId;
                            context.SaveChanges();
                            txn.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Unsuccessful Update Org", 1);
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

        [HttpPost]
        [Route("api/DeleteConfigCodesDtl")]
        [ActionName("LoadNew")]
        public IHttpActionResult DeleteConfigCodesDtl()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var codePrime = int.Parse(queryString["codePrime"]);
            var codeSub = queryString["codeSub"];

            var status = true;
            var error_message = "";
            _CONFIG_CODES_DTL paramDtl = new _CONFIG_CODES_DTL(true);

            using (var context = new JobPortalContext())
            {
                using (var txn = context.Database.BeginTransaction())
                {
                    try
                    {
                        var dataTobeUpdated = context.CONFIG_CODES_DTL.SingleOrDefault(m => m.CODE_PRIME == codePrime && m.CODE_SUB == codeSub);
                        if (dataTobeUpdated != null)
                        {
                            context.CONFIG_CODES_DTL.Remove(dataTobeUpdated);
                            context.SaveChanges();
                        }
                        txn.Commit();
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Success Update Org", 1);
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Unsuccessful Update Org", 1);
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

        [HttpPost]
        [Route("api/GetDropDownItems")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDropDownItems()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            var codePrime = queryString["CODE_PRIME"];
            string[] splitCodePrime = codePrime.Split('|');

            var status = true;
            var error_message = "";
            //var json = "";
            List<string> s;
            List<codeInfo> dropDownList = new List<codeInfo>();
            List<_CONFIG_CODES_DTL> CodeList = new List<_CONFIG_CODES_DTL>();
            _CONFIG_CODES_DTL codeDetail = new _CONFIG_CODES_DTL(true);
            //var comma = "";
            using (var context = new JobPortalContext())
            {
                for (int i = 0; i < splitCodePrime.Length; i++)
                {
                    try
                    {
                        splitCodePrime[i] = splitCodePrime[i].Trim();
                        var codePrimes = Int32.Parse(splitCodePrime[i]);
                        codeDetail.CODE_PRIME = codePrimes;
                        codeDetail.CONFIG_STATUS1 = 1;
                        //CodeList = manager.GetConfigCodesDetail(1, codeDetail);
                        CodeList = context.CONFIG_CODES_DTL.Where(d => d.CODE_PRIME == codeDetail.CODE_PRIME && d.CONFIG_STATUS1 == codeDetail.CONFIG_STATUS1).ToList();

                        foreach (var CL in CodeList)
                        {
                            codeInfo codeInfo = new codeInfo()
                            {
                                CodePrime = CL.CODE_PRIME,
                                codeSub = CL.CODE_SUB,
                                infoDesc = CL.INFO_DESC,
                                dataValueI1 = CL.DATA_VALUEI1,
                                dataValueI2 = CL.DATA_VALUEI2,
                                configStatus1 = CL.CONFIG_STATUS1,
                            };
                            dropDownList.Add(codeInfo);
                            //var json2 = new object[] { CodeList };
                            //json += comma + new JavaScriptSerializer().Serialize(codeInfo);
                            //comma = ",";
                            //}
                            //json += new JavaScriptSerializer().Serialize(CodeList);

                            //    aaa += CodeList[z].INFO_DESC;
                            //}
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
                //string bbb = json.ToString();
                //bbb = bbb.Replace("},", "}|");
                // s = new List<string>(
                //    bbb.Split(new string[] { "|" }, StringSplitOptions.None));
                //string[] aaa = bbb.Split(", ");
                //json
            }
            if (status == true)
            {
                var obj = new codeInfo
                {
                };
                //json = new JavaScriptSerializer().Serialize(codeInfo);
                //var userAttrib = "[{\"value\": \"chocolate\", \"label\": \"Chocolate\" },{ \"value\": \"strawberry\", \"label\": \"Strawberry\" },{ \"value\": \"vanilla\", \"label\": \"Vanilla\" }]";

                return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                    //status =  new[] { new { value = "1", label = "Active"}, new { value = "0", label = "Inactive"} },
                    //test =  new[] { new { value = "1", label = "Active"}},
                    //test2 = new { value = "1", label = "Active" },
                    //userAttrib
                }});

                //return Ok(new
                //{
                //    codes = "[{ value: 'chocolate', label: 'Chocolate' }, { value: 'strawberry', label: 'Strawberry' },{ value: 'vanilla', label: 'Vanilla' },]"
                //    //codes = "{\"codes\":[" + userAttrib.ToString() + "]"
                //});
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

            var status = true;
            var error_message = "";
            Applicant applicantDtl = new Applicant();
            Attachment AttachmentDtl = new Attachment();
            //_PARAM_LICENSE paramLicenseDtl = new _PARAM_LICENSE(true);

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
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Success Add Org", 1);
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                        //manager.insertIntoAuditMaster(userid.ToUpper(), token, 1, "Failed Add Org", 1);
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

        public class codeInfo
        {
            public Int32 CodePrime { get; set; }
            public string codeSub { get; set; }
            public string infoDesc { get; set; }
            public Int32? dataValueI1 { get; set; }
            public Int32? dataValueI2 { get; set; }
            public Int32? configStatus1 { get; set; }
            public List<string> test { get; set; }
            public string wfName { get; set; }
            public Int32 wfId { get; set; }
            public Int32 wfModule { get; set; }
        }

        public class codeInfoScreening
        {
            public Int32 mapProduct { get; set; }
            public Int32 mapId { get; set; }
            public string mapTable { get; set; }
            public Int32 config_code { get; set; }
        }

        public class codeInfoFormula
        {
            public string columnName { get; set; }
            public string tableName { get; set; }
        }

        public class codeInfoParam
        {
            public Int32 mapProduct { get; set; }
            public Int32 mapIdHdr { get; set; }
            public string mapFieldDecs { get; set; }
            public string mapFieldName { get; set; }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}