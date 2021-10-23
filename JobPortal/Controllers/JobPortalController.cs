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

        // GET: api/JobPortal
        public IQueryable<cor_code> Getcor_code()
        {
            return db.cor_code;
        }

        // GET: api/JobPortal/5
        [ResponseType(typeof(cor_code))]
        public IHttpActionResult Getcor_code(int id)
        {
            cor_code cor_code = db.cor_code.Find(id);
            if (cor_code == null)
            {
                return NotFound();
            }

            return Ok(cor_code);
        }

        // PUT: api/JobPortal/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcor_code(int id, cor_code cor_code)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cor_code.cor_CodeNo)
            {
                return BadRequest();
            }

            db.Entry(cor_code).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cor_codeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

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

        [HttpPost]
        [Route("api/GetDropDownItemsWfTemplate")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDropDownItemsWfTemplate()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            var code_comp = int.Parse(queryString["code_comp"]);
            var wf_module = int.Parse(queryString["wf_module"]);

            //var codePrime = queryString["CODE_PRIME"];
            //string[] splitCodePrime = codePrime.Split('|');

            var status = true;
            var error_message = "";
            //var json = "";
            List<string> s;
            List<codeInfo> dropDownList = new List<codeInfo>();
            List<_CONFIG_WF_HDR> CodeList = new List<_CONFIG_WF_HDR>();
            _CONFIG_WF_HDR codeDetail = new _CONFIG_WF_HDR(true);
            //var comma = "";
            using (var context = new JobPortalContext())
            {
                try
                {
                    //splitCodePrime[i] = splitCodePrime[i].Trim();
                    //var codePrimes = Int32.Parse(splitCodePrime[i]);
                    codeDetail.CODE_COMP = code_comp;
                    codeDetail.CODE_ORG = code_comp;
                    codeDetail.WF_MODULE = wf_module;

                    //CodeList = manager.GetDropDownItemsWfTemplate(1, codeDetail);
                    CodeList = context.CONFIG_WF_HDR.Where(d => d.CODE_COMP == codeDetail.CODE_COMP && d.CODE_ORG == codeDetail.CODE_ORG && d.WF_MODULE == codeDetail.WF_MODULE).ToList();

                    foreach (var CL in CodeList)
                    {
                        codeInfo codeInfo = new codeInfo()
                        {
                            //CodePrime = CL.CODE_PRIME,
                            wfId = CL.WF_ID,
                            wfName = CL.WF_NAME,
                            wfModule = CL.WF_MODULE
                        };
                        dropDownList.Add(codeInfo);
                    }
                }
                catch (Exception ex)
                {
                    status = false;
                    error_message = ex.InnerException.InnerException.Message;
                    Console.WriteLine(ex.InnerException.InnerException.Message);
                }
            }
            if (status == true)
            {
                var obj = new codeInfo
                {
                };
                return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                }});
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
        [Route("api/GetDropDownItemsWorkflow")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDropDownItemsWorkflow()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            var wfModule = queryString["WF_MODULE"];
            string[] splitwfModule = wfModule.Split('|');

            //var codePrime = queryString["CODE_PRIME"];
            //string[] splitCodePrime = codePrime.Split('|');

            var status = true;
            var error_message = "";
            //var json = "";
            List<string> s;
            List<codeInfo> dropDownList = new List<codeInfo>();
            List<_CONFIG_WF_HDR> CodeList = new List<_CONFIG_WF_HDR>();
            _CONFIG_WF_HDR codeDetail = new _CONFIG_WF_HDR(true);
            //var comma = "";
            using (var context = new JobPortalContext())
            {
                for (int i = 0; i < splitwfModule.Length; i++)
                {
                    try
                    {
                        splitwfModule[i] = splitwfModule[i].Trim();
                        var wfModules = Int32.Parse(splitwfModule[i]);
                        codeDetail.WF_MODULE = wfModules;

                        //splitCodePrime[i] = splitCodePrime[i].Trim();
                        //var codePrimes = Int32.Parse(splitCodePrime[i]);
                        //codeDetail.CODE_PRIME = codePrimes;
                        //CodeList = manager.GetDropDownItemsWorkflow(1, codeDetail);
                        CodeList = context.CONFIG_WF_HDR.Where(d => d.WF_MODULE == codeDetail.WF_MODULE).ToList();

                        foreach (var CL in CodeList)
                        {
                            codeInfo codeInfo = new codeInfo()
                            {
                                wfModule = CL.WF_MODULE,
                                wfId = CL.WF_ID,
                                wfName = CL.WF_NAME
                            };
                            dropDownList.Add(codeInfo);
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
                if (status == true)
                {
                    var obj = new codeInfo
                    {
                    };
                    return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                }});
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
        }

        [HttpPost]
        [Route("api/GetDropDownScreeningTable")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDropDownScreeningTable()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            var mapProduct = queryString["MAP_PRODUCT"];
            string[] splitmapProduct = mapProduct.Split('|');

            var status = true;
            var error_message = "";
            //var json = "";
            List<string> s;
            List<codeInfoScreening> dropDownList = new List<codeInfoScreening>();
            List<_PARAM_MAPPING_HDR> CodeList = new List<_PARAM_MAPPING_HDR>();
            _PARAM_MAPPING_HDR codeDetail = new _PARAM_MAPPING_HDR(true);
            //var comma = "";
            using (var context = new JobPortalContext())
            {
                for (int i = 0; i < splitmapProduct.Length; i++)
                {
                    try
                    {
                        splitmapProduct[i] = splitmapProduct[i].Trim();
                        var mapProducts = Int32.Parse(splitmapProduct[i]);
                        codeDetail.MAP_PRODUCT = mapProducts;

                        //splitCodePrime[i] = splitCodePrime[i].Trim();
                        //var codePrimes = Int32.Parse(splitCodePrime[i]);
                        //codeDetail.CODE_PRIME = codePrimes;
                        //CodeList = manager.GetDropDownScreeningTable(1, codeDetail);
                        CodeList = context.PARAM_MAPPING_HDR.Where(d => d.MAP_PRODUCT == codeDetail.MAP_PRODUCT).ToList();

                        foreach (var CL in CodeList)
                        {
                            codeInfoScreening codeInfoScreening = new codeInfoScreening()
                            {
                                mapProduct = CL.MAP_PRODUCT,
                                mapId = CL.MAP_ID_HDR,
                                mapTable = CL.MAP_TABLE
                            };
                            dropDownList.Add(codeInfoScreening);
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
                if (status == true)
                {
                    var obj = new codeInfo
                    {
                    };
                    return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                }});
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
        }

        [HttpPost]
        [Route("api/GetDropDownScreeningField")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDropDownScreeningField()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            var mapProduct = queryString["MAP_PRODUCT"];
            var mapField = queryString["MAP_TABLE_NAME"];

            string[] splitmapProduct = mapProduct.Split('|');

            var status = true;
            var error_message = "";
            //var json = "";
            List<string> s;
            List<codeInfoScreening> dropDownList = new List<codeInfoScreening>();
            List<_PARAM_MAPPING_DTL> CodeList = new List<_PARAM_MAPPING_DTL>();
            _PARAM_MAPPING_DTL codeDetail = new _PARAM_MAPPING_DTL(true);
            //var comma = "";
            using (var context = new JobPortalContext())
            {
                for (int i = 0; i < splitmapProduct.Length; i++)
                {
                    try
                    {
                        splitmapProduct[i] = splitmapProduct[i].Trim();
                        var mapProducts = Int32.Parse(splitmapProduct[i]);
                        codeDetail.MAP_PRODUCT = mapProducts;
                        codeDetail.MAP_TABLE_NAME = mapField;

                        //splitCodePrime[i] = splitCodePrime[i].Trim();
                        //var codePrimes = Int32.Parse(splitCodePrime[i]);
                        //codeDetail.CODE_PRIME = codePrimes;

                        //CodeList = manager.GetDropDownScreeningField(3, codeDetail);
                        CodeList = context.PARAM_MAPPING_DTL.Where(d => d.MAP_PRODUCT == codeDetail.MAP_PRODUCT && d.MAP_TABLE_NAME == codeDetail.MAP_TABLE_NAME && d.CONFIG_CODE != 0).ToList();

                        foreach (var CL in CodeList)
                        {
                            codeInfoScreening codeInfoScreening = new codeInfoScreening()
                            {
                                mapProduct = CL.MAP_PRODUCT,
                                config_code = CL.CONFIG_CODE,
                                mapTable = CL.MAP_FIELD_NAME
                            };
                            dropDownList.Add(codeInfoScreening);
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
                if (status == true)
                {
                    var obj = new codeInfo
                    {
                    };
                    return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                }});
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
        }

        [HttpPost]
        [Route("api/GetDropDownScreeningFieldTarget")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDropDownScreeningFieldTarget()

        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            var mapProduct = queryString["MAP_PRODUCT"];
            var mapField = queryString["MAP_TABLE_NAME"];

            string[] splitmapProduct = mapProduct.Split('|');

            var status = true;
            var error_message = "";
            //var json = "";
            List<string> s;
            List<codeInfoScreening> dropDownList = new List<codeInfoScreening>();
            List<_PARAM_MAPPING_DTL> CodeList = new List<_PARAM_MAPPING_DTL>();
            _PARAM_MAPPING_DTL codeDetail = new _PARAM_MAPPING_DTL(true);
            //var comma = "";
            using (var context = new JobPortalContext())
            {
                for (int i = 0; i < splitmapProduct.Length; i++)
                {
                    try
                    {
                        splitmapProduct[i] = splitmapProduct[i].Trim();
                        var mapProducts = Int32.Parse(splitmapProduct[i]);
                        codeDetail.MAP_PRODUCT = mapProducts;
                        codeDetail.MAP_TABLE_NAME = mapField;

                        //splitCodePrime[i] = splitCodePrime[i].Trim();
                        //var codePrimes = Int32.Parse(splitCodePrime[i]);
                        //codeDetail.CODE_PRIME = codePrimes;

                        //CodeList = manager.GetDropDownScreeningField(4, codeDetail);
                        CodeList = context.PARAM_MAPPING_DTL.Where(d => d.MAP_PRODUCT == codeDetail.MAP_PRODUCT && d.MAP_TABLE_NAME == codeDetail.MAP_TABLE_NAME && d.CONFIG_WATCHLIST == 1).ToList();

                        foreach (var CL in CodeList)
                        {
                            codeInfoScreening codeInfoScreening = new codeInfoScreening()
                            {
                                mapProduct = CL.MAP_PRODUCT,
                                mapId = CL.MAP_ID_DTL,
                                mapTable = CL.MAP_FIELD_NAME
                            };
                            dropDownList.Add(codeInfoScreening);
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
                if (status == true)
                {
                    var obj = new codeInfoScreening
                    {
                    };
                    return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                }});
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
        }

        [HttpPost]
        [Route("api/GetDropDownScreeningFormula")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDropDownScreeningFormula()

        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            //var mapProduct = queryString["MAP_PRODUCT"];
            var mapTable = queryString["MAP_TABLE_NAME"];
            var mapField = queryString["MAP_FIELD_NAME"];

            //string[] splitmapProduct = mapProduct.Split('|');

            var status = true;
            var error_message = "";
            //var json = "";
            List<string> s;
            List<codeInfoFormula> dropDownList = new List<codeInfoFormula>();
            List<INFORMATION_SCHEMA_COLUMNS> CodeList = new List<INFORMATION_SCHEMA_COLUMNS>();
            _INFORMATION_SCHEMA_COLUMNS codeDetail = new _INFORMATION_SCHEMA_COLUMNS(true);
            //var comma = "";
            using (var context = new JobPortalContext())
            {
                try
                {
                    //splitmapProduct[i] = splitmapProduct[i].Trim();
                    //var mapProducts = Int32.Parse(splitmapProduct[i]);
                    codeDetail.COLUMN_NAME = mapField;
                    codeDetail.TABLE_NAME = mapTable;

                    //splitCodePrime[i] = splitCodePrime[i].Trim();
                    //var codePrimes = Int32.Parse(splitCodePrime[i]);
                    //codeDetail.CODE_PRIME = codePrimes;

                    //CodeList = manager.GetDropDownScreeningFormula(1, codeDetail);
                    //CodeList = context.PARAM_MAPPING_DTL.Where(d => d.MAP_PRODUCT == codeDetail.MAP_PRODUCT && d.MAP_TABLE_NAME == codeDetail.MAP_TABLE_NAME && d.CONFIG_WATCHLIST == 1).ToList();

                    foreach (var CL in CodeList)
                    {
                        codeInfoFormula codeInfoFormula = new codeInfoFormula()
                        {
                            //mapProduct = CL.MAP_PRODUCT,
                            columnName = CL.COLUMN_NAME,
                            tableName = CL.TABLE_NAME
                        };
                        dropDownList.Add(codeInfoFormula);
                    }
                }
                catch (Exception ex)
                {
                    status = false;
                    error_message = ex.InnerException.InnerException.Message;
                    Console.WriteLine(ex.InnerException.InnerException.Message);
                }
                if (status == true)
                {
                    var obj = new codeInfoScreening
                    {
                    };
                    return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                }});
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
        }

        [HttpPost]
        [Route("api/GetDDParamMapDtl")]
        [ActionName("LoadNew")]
        public IHttpActionResult GetDDParamMapDtl()
        {
            string formData;
            using (var reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                formData = reader.ReadToEnd();
            }

            var queryString = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(formData));
            var code_org = int.Parse(queryString["code_org"]);
            var mapProduct = queryString["MAP_PRODUCT"];
            var mapIdHdr = int.Parse(queryString["MAP_ID_HDR"]);

            string[] splitmapProduct = mapProduct.Split('|');

            var status = true;
            var error_message = "";
            List<string> s;
            List<codeInfoParam> dropDownList = new List<codeInfoParam>();
            List<_PARAM_MAPPING_DTL> CodeList = new List<_PARAM_MAPPING_DTL>();
            _PARAM_MAPPING_DTL codeDetail = new _PARAM_MAPPING_DTL();

            using (var context = new JobPortalContext())
            {
                for (int i = 0; i < splitmapProduct.Length; i++)
                {
                    try
                    {
                        codeDetail.MAP_PRODUCT = int.Parse(mapProduct);
                        codeDetail.MAP_ID_HDR = mapIdHdr;

                        splitmapProduct[i] = splitmapProduct[i].Trim();
                        var mapProducts = Int32.Parse(splitmapProduct[i]);
                        codeDetail.MAP_PRODUCT = mapProducts;

                        //CodeList = manager.GetDDParamMapDtl(1, codeDetail);
                        CodeList = context.PARAM_MAPPING_DTL.Where(d => d.MAP_PRODUCT == codeDetail.MAP_PRODUCT && d.MAP_ID_HDR == codeDetail.MAP_ID_HDR && d.MAP_FIELD_NAME != "").ToList();

                        foreach (var CL in CodeList)
                        {
                            codeInfoParam codeInfoParam = new codeInfoParam()
                            {
                                mapProduct = CL.MAP_PRODUCT,
                                mapIdHdr = CL.MAP_ID_HDR,
                                mapFieldDecs = CL.MAP_FIELD_DESC,
                                mapFieldName = CL.MAP_FIELD_NAME
                            };
                            dropDownList.Add(codeInfoParam);
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.InnerException.InnerException.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
                if (status == true)
                {
                    var obj = new codeInfoScreening
                    {
                    };
                    return Json(new[] { new
                {
                    dropDownItems = dropDownList,
                }});
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

        // POST: api/JobPortal
        [ResponseType(typeof(cor_code))]
        public IHttpActionResult Postcor_code(cor_code cor_code)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.cor_code.Add(cor_code);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (cor_codeExists(cor_code.cor_CodeNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cor_code.cor_CodeNo }, cor_code);
        }

        #region "Insert into Audit Master"

        public static bool AddAuditMaster(string auditUserId, string auditToken, int auditActivity, string auditActivityDesc, int compCode, int codeOrg)
        {
            var status = true;
            var error_message = "";
            _AUDIT_MASTER auditMasterDtl = new _AUDIT_MASTER(true);

            using (var context = new JobPortalContext())
            {
                using (var txn = context.Database.BeginTransaction())
                {
                    try
                    {
                        //Insert Data
                        auditMasterDtl.CODE_ORG = codeOrg;
                        auditMasterDtl.AUDIT_USER_ID = auditUserId;
                        auditMasterDtl.AUDIT_TOKEN = auditToken;
                        auditMasterDtl.AUDIT_ACTIVITY = auditActivity;
                        auditMasterDtl.AUDIT_ACTIVITY_DESC = auditActivityDesc;
                        auditMasterDtl.CODE_COMP = compCode;
                        context.AUDIT_MASTER.Add(auditMasterDtl);
                        context.SaveChanges();

                        txn.Commit();
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        error_message = ex.Message;
                        Console.WriteLine(ex.InnerException.InnerException.Message);
                    }
                }
            }

            return status;
        }

        #endregion "Insert into Audit Master"

        // DELETE: api/JobPortal/5
        [ResponseType(typeof(cor_code))]
        public IHttpActionResult Deletecor_code(int id)
        {
            cor_code cor_code = db.cor_code.Find(id);
            if (cor_code == null)
            {
                return NotFound();
            }

            db.cor_code.Remove(cor_code);
            db.SaveChanges();

            return Ok(cor_code);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool cor_codeExists(int id)
        {
            return db.cor_code.Count(e => e.cor_CodeNo == id) > 0;
        }
    }
}