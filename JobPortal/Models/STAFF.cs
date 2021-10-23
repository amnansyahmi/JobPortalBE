using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class STAFF
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string USER_ID { get; set; }
        public Int16? USER_TYPE { get; set; }
        public string USER_OFFICE { get; set; }
        public string USER_ROUTING { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_MENU { get; set; }
        public string USER_MODULE { get; set; }
        public string USER_DASBOARD { get; set; }
        public string INFO_NAME_FULL { get; set; }
        public string INFO_NAME_FIRST { get; set; }
        public string INFO_NAME_MIDDLE { get; set; }
        public string INFO_NAME_LAST { get; set; }
        public Int32 AUDIT_FIRST_LOGINDATE { get; set; }
        public Int32? AUDIT_FIRST_LOGINTIME { get; set; }
        public Int32? AUDIT_LAST_LOGINTIME { get; set; }
        public Int32? AUDIT_LAST_LOGINDATE { get; set; }
        public Int32 AUDIT_RETRY { get; set; }
        public Int16? CONFIG_STATUS { get; set; }
        public string CONFIG_PASSWORD { get; set; }
        public string FLAG_PASSWORD_RESET { get; set; }
        public Int16? CONFIG_AD { get; set; }
        public Int32? CONFIG_EXPIRY_DATE { get; set; }
        public Int32? CONFIG_EXPIRY_DAY { get; set; }
        public Int32? CONFIG_MAX_RETRY { get; set; }
        public Int32? CONFIG_ACCESS_DATE_FROM { get; set; }
        public Int32? CONFIG_ACCESS_DATE_TO { get; set; }
        public Int32? CONFIG_ACCESS_TIME_FROM { get; set; }
        public Int32? CONFIG_ACCESS_TIME_TO { get; set; }
        public Int32? WF_TM_TEMPLATE { get; set; }
        public Int32? WF_TM_LEVEL { get; set; }
        public Int32? WF_WM_TEMPLATE { get; set; }
        public Int32? WF_WM_LEVEL { get; set; }
        public Int32? WF_RP_TEMPLATE { get; set; }
        public Int32? WF_RP_LEVEL { get; set; }
        public Int32? WF_PM_TEMPLATE { get; set; }
        public Int32? WF_OM_TEMPLATE { get; set; }
        public Int32? WF_PM_LEVEL { get; set; }
        public Int32? WF_OM_LEVEL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string USER_OFFICE_DESC { get; set; }
    }

    [Table("STAFF")]
    public class _STAFF
    {
        public _STAFF()
        {
        }

        public _STAFF(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            USER_ID = "";
            USER_TYPE = 1;
            USER_OFFICE = "";
            USER_ROUTING = "";
            USER_EMAIL = "";
            USER_MENU = "";
            USER_MODULE = "";
            USER_DASBOARD = "";
            INFO_NAME_FULL = "";
            INFO_NAME_FIRST = "";
            INFO_NAME_MIDDLE = "";
            INFO_NAME_LAST = "";
            AUDIT_FIRST_LOGINDATE = 0;
            AUDIT_FIRST_LOGINTIME = 0;
            AUDIT_LAST_LOGINTIME = 0;
            AUDIT_LAST_LOGINDATE = 0;
            AUDIT_RETRY = 0;
            CONFIG_STATUS = 0;
            CONFIG_PASSWORD = "";
            FLAG_PASSWORD_RESET = "";
            CONFIG_AD = 0;
            CONFIG_EXPIRY_DATE = 0;
            CONFIG_EXPIRY_DAY = 0;
            CONFIG_MAX_RETRY = 5;
            CONFIG_ACCESS_DATE_FROM = 0;
            CONFIG_ACCESS_DATE_TO = 0;
            CONFIG_ACCESS_TIME_FROM = 0;
            CONFIG_ACCESS_TIME_TO = 0;
            WF_TM_TEMPLATE = 0;
            WF_TM_LEVEL = 0;
            WF_WM_TEMPLATE = 0;
            WF_WM_LEVEL = 0;
            WF_RP_TEMPLATE = 0;
            WF_RP_LEVEL = 0;
            WF_PM_TEMPLATE = 0;
            WF_OM_TEMPLATE = 0;
            WF_PM_LEVEL = 0;
            WF_OM_LEVEL = 0;
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public string USER_ID { get; set; }

        public Int16? USER_TYPE { get; set; }
        public string USER_OFFICE { get; set; }
        public string USER_ROUTING { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_MENU { get; set; }
        public string USER_MODULE { get; set; }
        public string USER_DASBOARD { get; set; }
        public string INFO_NAME_FULL { get; set; }
        public string INFO_NAME_FIRST { get; set; }
        public string INFO_NAME_MIDDLE { get; set; }
        public string INFO_NAME_LAST { get; set; }
        public Int32 AUDIT_FIRST_LOGINDATE { get; set; }
        public Int32? AUDIT_FIRST_LOGINTIME { get; set; }
        public Int32? AUDIT_LAST_LOGINTIME { get; set; }
        public Int32? AUDIT_LAST_LOGINDATE { get; set; }
        public Int32 AUDIT_RETRY { get; set; }
        public Int16 CONFIG_STATUS { get; set; }
        public string CONFIG_PASSWORD { get; set; }
        public string FLAG_PASSWORD_RESET { get; set; }
        public Int16? CONFIG_AD { get; set; }
        public Int32? CONFIG_EXPIRY_DATE { get; set; }
        public Int32? CONFIG_EXPIRY_DAY { get; set; }
        public Int32? CONFIG_MAX_RETRY { get; set; }
        public Int32? CONFIG_ACCESS_DATE_FROM { get; set; }
        public Int32? CONFIG_ACCESS_DATE_TO { get; set; }
        public Int32? CONFIG_ACCESS_TIME_FROM { get; set; }
        public Int32? CONFIG_ACCESS_TIME_TO { get; set; }
        public Int32? WF_TM_TEMPLATE { get; set; }
        public Int32? WF_TM_LEVEL { get; set; }
        public Int32? WF_WM_TEMPLATE { get; set; }
        public Int32? WF_WM_LEVEL { get; set; }
        public Int32? WF_RP_TEMPLATE { get; set; }
        public Int32? WF_RP_LEVEL { get; set; }
        public Int32? WF_PM_TEMPLATE { get; set; }
        public Int32? WF_OM_TEMPLATE { get; set; }
        public Int32? WF_PM_LEVEL { get; set; }
        public Int32? WF_OM_LEVEL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}