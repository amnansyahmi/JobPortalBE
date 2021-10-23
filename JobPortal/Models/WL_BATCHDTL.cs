using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class WL_BATCHDTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 JOB_ID { get; set; }
        public string INPUT_ID { get; set; }
        public string INFO_NAME { get; set; }
        public string INFO_ID { get; set; }
        public string INFO_NATIONALITY { get; set; }
        public string INFO_GENDER { get; set; }
        public string INFO_DOB { get; set; }
        public string INFO_NATIVE { get; set; }
        public string INFO_ENT_TYPE { get; set; }
        public string INFO_SOURCE { get; set; }
        public string INFO_CATEGORY { get; set; }
        public Int32 INFO_PASSPORT { get; set; }
        public string INFO_SEC { get; set; }
        public string INFO_DATE_EXP { get; set; }
        public string INFO_SEC_EXP { get; set; }
        public Int32 INFO_COUNTRY { get; set; }
        public Int32 INFO_PURPOSE { get; set; }
        public Int32 RESULT_HIT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string RESULT_HIT_DESC { get; set; }
    }

    [Table("WL_BATCHDTL")]
    public class _WL_BATCHDTL
    {
        public _WL_BATCHDTL()
        {
        }

        public _WL_BATCHDTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            JOB_ID = 0;
            INPUT_ID = "";
            INFO_NAME = "";
            INFO_ID = "";
            INFO_NATIONALITY = "";
            INFO_GENDER = "";
            INFO_DOB = "";
            INFO_NATIVE = "";
            INFO_ENT_TYPE = "";
            INFO_SOURCE = "";
            INFO_CATEGORY = "";
            INFO_PASSPORT = 0;
            INFO_SEC = "";
            INFO_DATE_EXP = "";
            INFO_SEC_EXP = "";
            INFO_COUNTRY = 0;
            INFO_PURPOSE = 0;
            RESULT_HIT = 0;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 JOB_ID { get; set; }

        [Key, Column(Order = 3)]
        public string INPUT_ID { get; set; }

        public string INFO_NAME { get; set; }
        public string INFO_ID { get; set; }
        public string INFO_NATIONALITY { get; set; }
        public string INFO_GENDER { get; set; }
        public string INFO_DOB { get; set; }
        public string INFO_NATIVE { get; set; }
        public string INFO_ENT_TYPE { get; set; }
        public string INFO_SOURCE { get; set; }
        public string INFO_CATEGORY { get; set; }
        public Int32 INFO_PASSPORT { get; set; }
        public string INFO_SEC { get; set; }
        public string INFO_DATE_EXP { get; set; }
        public string INFO_SEC_EXP { get; set; }
        public Int32 INFO_COUNTRY { get; set; }
        public Int32 INFO_PURPOSE { get; set; }
        public Int32 RESULT_HIT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}