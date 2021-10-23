using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_TM
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public Int32? CASE_ID { get; set; }
        public string MODULE_ID { get; set; }
        public Int32? HIT_DATE { get; set; }
        public string HIT_RULEID { get; set; }
        public string HIT_RULENAME { get; set; }
        public string NO_ACCOUNT { get; set; }
        public string INFO_NAME { get; set; }
        public string NO_CIF { get; set; }
        public Int16? TRAN_TYPE { get; set; }
        public Int32? TRAN_DATE { get; set; }
        public Int32? TRAN_POST_DATE { get; set; }
        public Int32? TRAN_VAL_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string INFO_BRANCH { get; set; }
        public string HIT_BRANCH { get; set; }
        public string TRAN_LOCATION { get; set; }
        public Int32? TRAN_VOL { get; set; }
        public double? TRAN_AMOUNT { get; set; }
        public string TRAN_CUR { get; set; }
        public double? TRAN_CUR_AMOUNT { get; set; }
        public double? TRAN_RATE { get; set; }
        public Int16? TAG_REV { get; set; }
        public string INFO_PRODUCT { get; set; }
        public Int16? AUDIT_STATUS { get; set; }
        public Int32? AUDIT_STATUS_DATE { get; set; }
        public Int32? AUDIT_DATE_CREATED { get; set; }
        public Int32? AUDIT_TIME_CREATED { get; set; }
        public Int32? AUDIT_DATE_UPDATED { get; set; }
        public Int32? AUDIT_TIME_UPDATED { get; set; }
        public Int16? TAG_STAFF { get; set; }
        public string TAG_FRAUD { get; set; }
        public Int64? TAG_CASE_ASSIGN { get; set; }
        public Int16? TAG_CASE { get; set; }
        public Int32? AUDIT_BATCHDT { get; set; }
        public string AUDIT_BATCHNO { get; set; }
        public DateTime? AUDIT_TIMESTAMP { get; set; }
        public string AUDIT_USER { get; set; }
        public Int32? TRAN_HVOL { get; set; }
        public double? TRAN_HAMOUNT { get; set; }
        public double? TRAN_HCUR_AMOUNT { get; set; }
        public Int16? FLAG_FILTERSQL { get; set; }
        public string INFO_FILTERSQL { get; set; }
    }

    [Table("RF_TM")]
    public class _RF_TM
    {
        public _RF_TM()
        {
        }

        public _RF_TM(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            RF_ID = 0;
            CASE_ID = 0;
            MODULE_ID = "";
            HIT_DATE = 0;
            HIT_RULEID = "";
            HIT_RULENAME = "";
            NO_ACCOUNT = "";
            INFO_NAME = "";
            NO_CIF = "";
            TRAN_TYPE = 0;
            TRAN_DATE = 0;
            TRAN_POST_DATE = 0;
            TRAN_VAL_DATE = 0;
            TRAN_CODE = "";
            INFO_BRANCH = "";
            HIT_BRANCH = "";
            TRAN_LOCATION = "";
            TRAN_VOL = 0;
            TRAN_AMOUNT = 0;
            TRAN_CUR = "";
            TRAN_CUR_AMOUNT = 0;
            TRAN_RATE = 0;
            TAG_REV = 0;
            INFO_PRODUCT = "";
            AUDIT_STATUS = 0;
            AUDIT_STATUS_DATE = 0;
            AUDIT_DATE_CREATED = 0;
            AUDIT_TIME_CREATED = 0;
            AUDIT_DATE_UPDATED = 0;
            AUDIT_TIME_UPDATED = 0;
            TAG_STAFF = 0;
            TAG_FRAUD = "";
            TAG_CASE_ASSIGN = 0;
            TAG_CASE = 0;
            AUDIT_BATCHDT = 0;
            AUDIT_BATCHNO = "";
            AUDIT_TIMESTAMP = null;
            AUDIT_USER = "";
            TRAN_HVOL = 0;
            TRAN_HAMOUNT = 0;
            TRAN_HCUR_AMOUNT = 0;
            FLAG_FILTERSQL = 0;
            INFO_FILTERSQL = "";
        }

        [Key, Column(Order = 1)]
        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public Int32? CASE_ID { get; set; }
        public string MODULE_ID { get; set; }
        public Int32? HIT_DATE { get; set; }
        public string HIT_RULEID { get; set; }
        public string HIT_RULENAME { get; set; }
        public string NO_ACCOUNT { get; set; }
        public string INFO_NAME { get; set; }
        public string NO_CIF { get; set; }
        public Int16? TRAN_TYPE { get; set; }
        public Int32? TRAN_DATE { get; set; }
        public Int32? TRAN_POST_DATE { get; set; }
        public Int32? TRAN_VAL_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string INFO_BRANCH { get; set; }
        public string HIT_BRANCH { get; set; }
        public string TRAN_LOCATION { get; set; }
        public Int32? TRAN_VOL { get; set; }
        public double? TRAN_AMOUNT { get; set; }
        public string TRAN_CUR { get; set; }
        public double? TRAN_CUR_AMOUNT { get; set; }
        public double? TRAN_RATE { get; set; }
        public Int16? TAG_REV { get; set; }
        public string INFO_PRODUCT { get; set; }
        public Int16? AUDIT_STATUS { get; set; }
        public Int32? AUDIT_STATUS_DATE { get; set; }
        public Int32? AUDIT_DATE_CREATED { get; set; }
        public Int32? AUDIT_TIME_CREATED { get; set; }
        public Int32? AUDIT_DATE_UPDATED { get; set; }
        public Int32? AUDIT_TIME_UPDATED { get; set; }
        public Int16? TAG_STAFF { get; set; }
        public string TAG_FRAUD { get; set; }
        public Int64? TAG_CASE_ASSIGN { get; set; }
        public Int16? TAG_CASE { get; set; }
        public Int32? AUDIT_BATCHDT { get; set; }
        public string AUDIT_BATCHNO { get; set; }
        public DateTime? AUDIT_TIMESTAMP { get; set; }
        public string AUDIT_USER { get; set; }
        public Int32? TRAN_HVOL { get; set; }
        public double? TRAN_HAMOUNT { get; set; }
        public double? TRAN_HCUR_AMOUNT { get; set; }
        public Int16? FLAG_FILTERSQL { get; set; }
        public string INFO_FILTERSQL { get; set; }
    }
}