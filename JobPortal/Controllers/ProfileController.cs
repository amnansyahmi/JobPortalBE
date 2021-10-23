using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using Newtonsoft.Json;
using AMLP.Models;
using AMLP.Repositories;
using AMLP.Shares;
using System.Web.Http.Cors;


namespace AMLP.Controllers
{

    //tbml
    // implement secure connection !!

    //[RoutePrefix("api/AMLP")]
    public class PortfolioController : ApiController
    {
        [HttpGet]
        //[Route("{AuthUser:length(1,30}")]
        [Route("api/Profile")]
        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        [ActionName("LoadNew")]
        public List<ACCOUNT01> Get()
        {
            List<ACCOUNT01> ProfileList = new List<ACCOUNT01>();

            using (var context = new AMLPContext())
            {
                using (var manager = new AMLPManager(context))
                {

                    ProfileList = manager.ProfileLoad();
                }
            }

            return ProfileList;
        }

        [HttpGet]
        [Route("api/ProfileDetail")]
        [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
        [ActionName("LoadNew")]
        public ProfileDetail GetAccountDetail(String cifID)
        {
            List<ACCOUNT01> ProfileList = new List<ACCOUNT01>();
            List<ProfileDetail> ProfileDetailList = new List<ProfileDetail>();
            List<ALERTTRAN> AlertList = new List<ALERTTRAN>();
            ProfileDetail ProfileDetail = new ProfileDetail();

            using (var context = new AMLPContext())
            {
                using (var manager = new AMLPManager(context))
                {

                    ProfileList = manager.ProfileDetail(cifID);
                    AlertList = manager.AlertLoad(cifID);
                    ProfileDetail.Name = ProfileList[0].ACCOUNT_NAME;
                    ProfileDetail.Amount = ProfileList[0].BALANCE_VALUE1.ToString();
                    ProfileDetail.RedFlagCount = AlertList.Count.ToString();
                }
            }
            return ProfileDetail;
        }

       
        [HttpGet]
        [Route("api/Alert")]
        [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
        [ActionName("LoadNew")]
        public List<ALERTTRAN> GetAlert(String cifID)
        {
            List<ALERTTRAN> AlertList = new List<ALERTTRAN>();

            using (var context = new AMLPContext())
            {
                using (var manager = new AMLPManager(context))
                {


                    AlertList = manager.AlertLoad(cifID); 
                }
            }

            return AlertList;
        }


        [HttpGet]
        [Route("api/TranHit")]
        [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
        [ActionName("LoadNew")]
        public List<BANKFINTRANHIT01> GetTranDet(String alertID)
        {
            List<BANKFINTRANHIT01> TranHitList = new List<BANKFINTRANHIT01>();
            List<cor_code> ProductTypeList = new List<cor_code>();
            List<cor_code> TranTypeList = new List<cor_code>();
            cor_code TranType = new cor_code();

            using (var context = new AMLPContext())
            {
                using (var manager = new AMLPManager(context))
                {

                    ProductTypeList = manager.ProdType();
                    TranHitList = manager.TranHitLoad(alertID);

                    foreach (var hit in TranHitList)
                    {
                        foreach (var prod in ProductTypeList)
                        {
                            if (hit.UNLOAD_IND == prod.cor_CodeKey)
                            {
                                hit.UNLOAD_IND = prod.cor_Desc;
                            }
                        }

                        TranTypeList = manager.TranType(hit.TRAN_CODE);
                        hit.TRAN_CODE = TranTypeList[0].cor_Desc;
                    }
                }
            }

            return TranHitList;
        }
    }
}
