using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_WM
    {
        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 MODULE_ID { get; set; }

        //[Key, Column(Order = 3)]
        public Int32? CASE_ID { get; set; }

        [Key, Column(Order = 3)]
        public Int64 RF_ID { get; set; }

        public string NO_CIF { get; set; }
        public Int32 HIT_DATE { get; set; }
        public string HIT_RULEID { get; set; }
        public string HIT_RULENAME { get; set; }
        public string INFO_NAME { get; set; }
        public string INFO_BRANCH { get; set; }
        public string TYPE_PRODUCT { get; set; }
        public Int16 AUDIT_STATUS { get; set; }
        public Int16 TAG_STAFF { get; set; }
        public string TAG_FRAUD { get; set; }
        public Int64 TAG_CASE_ASSIGN { get; set; }
        public string TYPE_SEARCH { get; set; }
        public string HIT_SEARCH { get; set; }
        public Int32 HIT_VOL { get; set; }
        public Int32 HIT_VOL_NAME { get; set; }
        public Int32 HIT_VOL_ID { get; set; }
        public string CONFIG_TABLE { get; set; }
        public string CONFIG_SQLFD { get; set; }
        public string CONFIG_DETECT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }

        //Combine with RF_WMDTL
        public Int32 SYS_SEQ { get; set; }

        public string HIT_WL_ID { get; set; }
        public Int16 TYPE_HIT { get; set; }
        public string HIT_SOURCE { get; set; }
        public string TYPE_NAME { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string HIT_ID { get; set; }
        public string HIT_COUNTRY { get; set; }
        public string HIT_DOBS { get; set; }
        public string HIT_CATEGORY { get; set; }
        public string HIT_NAMESOURCE { get; set; }
        public Int16 HIT_STRONG { get; set; }
        public Int16 STATUS_INV { get; set; }
        public Int16 TYPE_EXPO { get; set; }

        [NotMapped]
        public Int32? CASE_OS { get; set; }

        public string REMARKS { get; set; }

        public Int16 FLAG_FALSEPOS { get; set; }
        public string HIT_GENDER { get; set; }

        //FOR DASHBOARD
        [NotMapped]
        public Int32? TOTAL_NEW { get; set; }

        [NotMapped]
        public Int32? TOTAL_ADDON { get; set; }

        [NotMapped]
        public Int32? TOTAL_DROP { get; set; }

        [NotMapped]
        public string DATE_FILTER { get; set; }
    }

    [Table("RF_WM")]
    public class _RF_WM
    {
        public _RF_WM()
        {
        }

        public _RF_WM(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            MODULE_ID = 0;
            CASE_ID = 0;
            RF_ID = 0;
            NO_CIF = "";
            HIT_DATE = 0;
            HIT_RULEID = "";
            HIT_RULENAME = "";
            INFO_NAME = "";
            INFO_BRANCH = "";
            TYPE_PRODUCT = "";
            AUDIT_STATUS = 0;
            TAG_STAFF = 0;
            TAG_FRAUD = "";
            TAG_CASE_ASSIGN = 0;
            TYPE_SEARCH = "";
            HIT_SEARCH = "";
            HIT_VOL = 0;
            HIT_VOL_NAME = 0;
            HIT_VOL_ID = 0;
            CONFIG_TABLE = "";
            CONFIG_SQLFD = "";
            CONFIG_DETECT = "";
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 MODULE_ID { get; set; }

        //[Key, Column(Order = 3)]
        public Int32? CASE_ID { get; set; }

        [Key, Column(Order = 3)]
        public Int64 RF_ID { get; set; }

        public string NO_CIF { get; set; }
        public Int32 HIT_DATE { get; set; }
        public string HIT_RULEID { get; set; }
        public string HIT_RULENAME { get; set; }
        public string INFO_NAME { get; set; }
        public string INFO_BRANCH { get; set; }
        public string TYPE_PRODUCT { get; set; }
        public Int16 AUDIT_STATUS { get; set; }
        public Int16 TAG_STAFF { get; set; }
        public string TAG_FRAUD { get; set; }
        public Int64 TAG_CASE_ASSIGN { get; set; }
        public string TYPE_SEARCH { get; set; }
        public string HIT_SEARCH { get; set; }
        public Int32 HIT_VOL { get; set; }
        public Int32 HIT_VOL_NAME { get; set; }
        public Int32 HIT_VOL_ID { get; set; }
        public string CONFIG_TABLE { get; set; }
        public string CONFIG_SQLFD { get; set; }
        public string CONFIG_DETECT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }

        [NotMapped]
        public Int32? CASE_OS { get; set; }
    }
}