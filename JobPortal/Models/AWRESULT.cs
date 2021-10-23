using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class AWRESULT
    {
        //AW_MASTER
        public string ENTITY_ID { get; set; }

        public string INFO_SOURCE { get; set; }
        public string ENTITY_TYPE { get; set; }
        public string GENDER { get; set; }
        public string ACTIVE_STATUS { get; set; }
        public string DECEASED { get; set; }
        public string BIRTH_PLACE { get; set; }
        public string PROFILE_NOTES { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string DATE_OF_DEATH { get; set; }
        public string HIGH_RISK_COUNTRY { get; set; }
        public Int16 HIGH_RISK_COUNTRY_SCORE { get; set; }
        public Int16 COMP_CODE { get; set; }
        public Int16 FALSE_POSITIVE { get; set; }
        public Int32 FALSE_POSITIVE_EXPIRY_DT { get; set; }
        public string BATCH_NO { get; set; }
        public Int32 BATCH_DATE { get; set; }
        public string ACTION { get; set; }
        public DateTime? LAST_UPDATE_DATE { get; set; }
        public Int16 SUBSIDIARY_CODE { get; set; }
        public string SUBSIDIARY_DESC { get; set; }
        public string INDUSTRY_CODE { get; set; }
        public string INDUSTRY_DESC { get; set; }
        public string DATE_OF_NATIONAL { get; set; }
        public string DATE_OF_PRIVATE { get; set; }
        public string DATE_OF_CESSATION { get; set; }

        //AW_NAME
        public Int32 SYS_ID { get; set; }

        public Int64 ROWNO { get; set; }
        public string NAME_TYPE { get; set; }
        public string TITLE_HONORIFIC { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string SURNAME { get; set; }
        public string MAIDEN_NAME { get; set; }
        public string SUFFIX { get; set; }
        public string ENTITY_NAME { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string SINGLE_STRING_NAME2 { get; set; }
        public string SINGLE_STRING_NAME3 { get; set; }
        public string ORIGINAL_SCRIPT_NAME { get; set; }
        public Int16 APPROVAL_STATUS { get; set; }
        public string CATEGORY { get; set; }
        public string DOB { get; set; }
        public string COUNTRY { get; set; }
        public string ID_REF_NO { get; set; }
        public string SANCTION { get; set; }
        public string CATEGORYNUM { get; set; }
    }
}