using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_STAFF
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 FLAG_JobPortal { get; set; }
        public Int32 FLAG_BI { get; set; }
        public Int32 USER_MINLENGTH { get; set; }
        public Int32 USER_MAXLENGTH { get; set; }
        public Int32 USER_AUTOID { get; set; }
        public Int32 USER_AUTH { get; set; }
        public Int32 USER_AUTH_SAME_LEVEL { get; set; }
        public Int32 PW_CHANGE_FREQ { get; set; }
        public Int32 PW_CHANGE_FORCE { get; set; }
        public Int32 PW_MINLENGTH { get; set; }
        public Int32 PW_MAXLENGTH { get; set; }
        public Int32 PW_CONSECUTIVE { get; set; }
        public Int32 PW_BLANKCHAR { get; set; }
        public Int32 PW_SPECIALCHAR { get; set; }
        public Int32 PW_DEFAULT_TYPE { get; set; }
        public Int32 PW_DEAULT_VAL { get; set; }
        public string PW_RESTRICTED { get; set; }
        public Int32 LOGIN_TRY_ALLOW { get; set; }
        public DateTime? LOGIN_START_DATE { get; set; }
        public DateTime? LOGIN_END_DATE { get; set; }
        public double LOGIN_START_TIME { get; set; }
        public double LOGIN_END_TIME { get; set; }
        public string LOGIN_LANGUAGE_REC { get; set; }
        public Int32 LOGIN_THEME { get; set; }
        public string LOGIN_LANGUAGE { get; set; }
        public Int32 LOGIN_SSO { get; set; }
        public DateTime? LIC_EXPIRY_DATE { get; set; }
        public Int32 LIC_GRACE_PERIOD { get; set; }
        public Int32 LIC_VERIFIED_LICENSEDT { get; set; }
        public string LIC_COMP_NAME { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("PARAM_STAFF")]
    public class _PARAM_STAFF
    {
        public _PARAM_STAFF()
        {
        }

        public _PARAM_STAFF(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            FLAG_JobPortal = 0;
            FLAG_BI = 0;
            USER_MINLENGTH = 0;
            USER_MAXLENGTH = 0;
            USER_AUTOID = 0;
            USER_AUTH = 0;
            USER_AUTH_SAME_LEVEL = 0;
            PW_CHANGE_FREQ = 0;
            PW_CHANGE_FORCE = 0;
            PW_MINLENGTH = 0;
            PW_MAXLENGTH = 0;
            PW_CONSECUTIVE = 0;
            PW_BLANKCHAR = 0;
            PW_SPECIALCHAR = 0;
            PW_DEFAULT_TYPE = 0;
            PW_DEAULT_VAL = 0;
            PW_RESTRICTED = "";
            LOGIN_TRY_ALLOW = 0;
            LOGIN_START_DATE = null;
            LOGIN_END_DATE = null;
            LOGIN_START_TIME = 0;
            LOGIN_END_TIME = 0;
            LOGIN_LANGUAGE_REC = "";
            LOGIN_THEME = 0;
            LOGIN_LANGUAGE = "";
            LOGIN_SSO = 0;
            LIC_EXPIRY_DATE = null;
            LIC_GRACE_PERIOD = 0;
            LIC_VERIFIED_LICENSEDT = 0;
            LIC_COMP_NAME = "";
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 1)]
        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }
        public Int32 FLAG_JobPortal { get; set; }
        public Int32 FLAG_BI { get; set; }
        public Int32 USER_MINLENGTH { get; set; }
        public Int32 USER_MAXLENGTH { get; set; }
        public Int32 USER_AUTOID { get; set; }
        public Int32 USER_AUTH { get; set; }
        public Int32 USER_AUTH_SAME_LEVEL { get; set; }
        public Int32 PW_CHANGE_FREQ { get; set; }
        public Int32 PW_CHANGE_FORCE { get; set; }
        public Int32 PW_MINLENGTH { get; set; }
        public Int32 PW_MAXLENGTH { get; set; }
        public Int32 PW_CONSECUTIVE { get; set; }
        public Int32 PW_BLANKCHAR { get; set; }
        public Int32 PW_SPECIALCHAR { get; set; }
        public Int32 PW_DEFAULT_TYPE { get; set; }
        public Int32 PW_DEAULT_VAL { get; set; }
        public string PW_RESTRICTED { get; set; }
        public Int32 LOGIN_TRY_ALLOW { get; set; }
        public DateTime? LOGIN_START_DATE { get; set; }
        public DateTime? LOGIN_END_DATE { get; set; }
        public double LOGIN_START_TIME { get; set; }
        public double LOGIN_END_TIME { get; set; }
        public string LOGIN_LANGUAGE_REC { get; set; }
        public Int32 LOGIN_THEME { get; set; }
        public string LOGIN_LANGUAGE { get; set; }
        public Int32 LOGIN_SSO { get; set; }
        public DateTime? LIC_EXPIRY_DATE { get; set; }
        public Int32 LIC_GRACE_PERIOD { get; set; }
        public Int32 LIC_VERIFIED_LICENSEDT { get; set; }
        public string LIC_COMP_NAME { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}