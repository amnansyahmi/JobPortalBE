using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class SMSEMAILGROUP
    {
        #region Properties

        public Int16 COMP_CODE { get; set; }
        public String SMSEMAIL_KEY { get; set; }
        public String GROUP_DESCR { get; set; }
        public String CASE_APPR_TEMPLATE_NO { get; set; }
        public Int16 SEND_SMS { get; set; }
        public String SMS_SEND_TO { get; set; }
        public String SMS_CCCOPY { get; set; }
        public String SMS_MSG { get; set; }
        public Int16 SEND_EMAIL { get; set; }
        public String EMAIL_SUBJECT { get; set; }
        public String EMAIL_SEND_FROM { get; set; }
        public String EMAIL_SEND_TO { get; set; }
        public String EMAIL_CCCOPY { get; set; }
        public String EMAIL_ATTACTMENT { get; set; }
        public String EMAIL_MSG { get; set; }
        public String REMARKS { get; set; }
        public Int16 STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public String USER_ID { get; set; }
        public String MODE_MN { get; set; }

        #endregion Properties
    }

    [Table("SMSEMAILGROUP")]
    public class _SMSEMAILGROUP
    {
        public _SMSEMAILGROUP()
        {
        }

        public _SMSEMAILGROUP(bool setDefaultValue)
        {
            COMP_CODE = 0;
            SMSEMAIL_KEY = "";
            GROUP_DESCR = "";
            CASE_APPR_TEMPLATE_NO = "";
            SEND_SMS = 0;
            SMS_SEND_TO = "";
            SMS_CCCOPY = "";
            SMS_MSG = "";
            SEND_EMAIL = 0;
            EMAIL_SUBJECT = "";
            EMAIL_SEND_FROM = "";
            EMAIL_SEND_TO = "";
            EMAIL_CCCOPY = "";
            EMAIL_ATTACTMENT = "";
            EMAIL_MSG = "";
            REMARKS = "";
            STATUS = 0;
            //STAMP_DTTM = 0;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        public Int16 COMP_CODE { get; set; }
        public String SMSEMAIL_KEY { get; set; }
        public String GROUP_DESCR { get; set; }
        public String CASE_APPR_TEMPLATE_NO { get; set; }
        public Int16 SEND_SMS { get; set; }
        public String SMS_SEND_TO { get; set; }
        public String SMS_CCCOPY { get; set; }
        public String SMS_MSG { get; set; }
        public Int16 SEND_EMAIL { get; set; }
        public String EMAIL_SUBJECT { get; set; }
        public String EMAIL_SEND_FROM { get; set; }
        public String EMAIL_SEND_TO { get; set; }
        public String EMAIL_CCCOPY { get; set; }
        public String EMAIL_ATTACTMENT { get; set; }
        public String EMAIL_MSG { get; set; }
        public String REMARKS { get; set; }
        public Int16 STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public String USER_ID { get; set; }
        public String MODE_MN { get; set; }

        #endregion Properties
    }
}