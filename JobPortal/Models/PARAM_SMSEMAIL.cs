using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_SMSEMAIL
    {
        public Int32 COMP_CODE { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 GRP_KEY { get; set; }
        public Int32 GRP_MODULE { get; set; }
        public string GRP_DESC { get; set; }
        public string GRP_TEMPLATE_NO { get; set; }
        public Int16 FLAG_TYPE { get; set; }
        public string SMS_SEND_TO { get; set; }
        public string SMS_CC { get; set; }
        public string SMS_MSG { get; set; }
        public string EMAIL_SUBJECT { get; set; }
        public string EMAIL_SENDFROM { get; set; }
        public string EMAIL_SENDTO { get; set; }
        public string EMAIL_CC { get; set; }
        public string EMAIL_ATTACHMENT { get; set; }
        public string EMAIL_MSG { get; set; }
        public string INFO_REMARKS { get; set; }
        public Int16 INFO_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public String INFO_STATUS_DESC { get; set; }
        public String MODULE_DESC { get; set; }
    }

    [Table("PARAM_SMSEMAIL")]
    public class _PARAM_SMSEMAIL
    {
        public _PARAM_SMSEMAIL()
        {
        }

        public _PARAM_SMSEMAIL(bool setDefaultValue)
        {
            COMP_CODE = 0;
            CODE_ORG = 0;
            GRP_KEY = 0;
            GRP_MODULE = 0;
            GRP_DESC = "";
            GRP_TEMPLATE_NO = "";
            FLAG_TYPE = 0;
            SMS_SEND_TO = "";
            SMS_CC = "";
            SMS_MSG = "";
            EMAIL_SUBJECT = "";
            EMAIL_SENDFROM = "";
            EMAIL_SENDTO = "";
            EMAIL_CC = "";
            EMAIL_ATTACHMENT = "";
            EMAIL_MSG = "";
            INFO_REMARKS = "";
            INFO_STATUS = 0;
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 0)]
        public Int32 COMP_CODE { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 GRP_KEY { get; set; }

        public Int32 GRP_MODULE { get; set; }
        public string GRP_DESC { get; set; }
        public string GRP_TEMPLATE_NO { get; set; }
        public Int16 FLAG_TYPE { get; set; }
        public string SMS_SEND_TO { get; set; }
        public string SMS_CC { get; set; }
        public string SMS_MSG { get; set; }
        public string EMAIL_SUBJECT { get; set; }
        public string EMAIL_SENDFROM { get; set; }
        public string EMAIL_SENDTO { get; set; }
        public string EMAIL_CC { get; set; }
        public string EMAIL_ATTACHMENT { get; set; }
        public string EMAIL_MSG { get; set; }
        public string INFO_REMARKS { get; set; }
        public Int16 INFO_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}