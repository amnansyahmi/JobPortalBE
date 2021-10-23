using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_TMDTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public Int64 TRAN_ID { get; set; }
        public Int64 TRAN_SEQ { get; set; }
        public string MODULE_ID { get; set; }
        public string TYPE_PRODUCT { get; set; }
        public Int16 TRAN_TYPE { get; set; }
        public Int32 TRAN_DATE { get; set; }
        public Int32 TRAN_POST_DATE { get; set; }
        public Int32 TRAN_VAL_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string NO_ACC { get; set; }
        public string NO_CIF { get; set; }
        public string INFO_BRANCH { get; set; }
        public double TRAN_AMOUNT { get; set; }
        public string TRAN_CUR { get; set; }
        public double TRAN_CUR_AMOUNT { get; set; }
        public double TRAN_RATE { get; set; }
        public Int16 TRAN_REV { get; set; }
        public string TRAN_LOCATION { get; set; }
        public string RES_CHAR01 { get; set; }
        public string RES_CHAR02 { get; set; }
        public string RES_CHAR03 { get; set; }
        public string RES_CHAR04 { get; set; }
        public string RES_CHAR05 { get; set; }
        public string RES_CHAR06 { get; set; }
        public string RES_CHAR07 { get; set; }
        public string RES_CHAR08 { get; set; }
        public string RES_CHAR09 { get; set; }
        public string RES_CHAR10 { get; set; }
        public double RES_FLT01 { get; set; }
        public double RES_FLT02 { get; set; }
        public double RES_FLT03 { get; set; }
        public double RES_FLT04 { get; set; }
        public double RES_FLT05 { get; set; }
        public Int32 RES_INT01 { get; set; }
        public Int32 RES_INT02 { get; set; }
        public Int32 RES_INT03 { get; set; }
        public Int32 RES_INT04 { get; set; }
        public Int32 RES_INT05 { get; set; }
        public Int32 AUDIT_BATCHDT { get; set; }
        public string AUDIT_BATCHNO { get; set; }
        public DateTime? AUDIT_TIMESTAMP { get; set; }
        public string AUDIT_USER { get; set; }
        public string TYPE_DATA { get; set; }
    }

    [Table("RF_TMDTL")]
    public class _RF_TMDTL
    {
        public _RF_TMDTL()
        {
        }

        public _RF_TMDTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            RF_ID = 0;
            TRAN_ID = 0;
            TRAN_SEQ = 0;
            MODULE_ID = "";
            TYPE_PRODUCT = "";
            TRAN_TYPE = 0;
            TRAN_DATE = 0;
            TRAN_POST_DATE = 0;
            TRAN_VAL_DATE = 0;
            TRAN_CODE = "";
            NO_ACC = "";
            NO_CIF = "";
            INFO_BRANCH = "";
            TRAN_AMOUNT = 0;
            TRAN_CUR = "";
            TRAN_CUR_AMOUNT = 0;
            TRAN_RATE = 0;
            TRAN_REV = 0;
            TRAN_LOCATION = "";
            RES_CHAR01 = "";
            RES_CHAR02 = "";
            RES_CHAR03 = "";
            RES_CHAR04 = "";
            RES_CHAR05 = "";
            RES_CHAR06 = "";
            RES_CHAR07 = "";
            RES_CHAR08 = "";
            RES_CHAR09 = "";
            RES_CHAR10 = "";
            RES_FLT01 = 0;
            RES_FLT02 = 0;
            RES_FLT03 = 0;
            RES_FLT04 = 0;
            RES_FLT05 = 0;
            RES_INT01 = 0;
            RES_INT02 = 0;
            RES_INT03 = 0;
            RES_INT04 = 0;
            RES_INT05 = 0;
            AUDIT_BATCHDT = 0;
            AUDIT_BATCHNO = "";
            AUDIT_TIMESTAMP = null;
            AUDIT_USER = "";
            TYPE_DATA = "";
        }

        [Key, Column(Order = 1)]
        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public Int64 TRAN_ID { get; set; }
        public Int64 TRAN_SEQ { get; set; }
        public string MODULE_ID { get; set; }
        public string TYPE_PRODUCT { get; set; }
        public Int16 TRAN_TYPE { get; set; }
        public Int32 TRAN_DATE { get; set; }
        public Int32 TRAN_POST_DATE { get; set; }
        public Int32 TRAN_VAL_DATE { get; set; }
        public string TRAN_CODE { get; set; }
        public string NO_ACC { get; set; }
        public string NO_CIF { get; set; }
        public string INFO_BRANCH { get; set; }
        public double TRAN_AMOUNT { get; set; }
        public string TRAN_CUR { get; set; }
        public double TRAN_CUR_AMOUNT { get; set; }
        public double TRAN_RATE { get; set; }
        public Int16 TRAN_REV { get; set; }
        public string TRAN_LOCATION { get; set; }
        public string RES_CHAR01 { get; set; }
        public string RES_CHAR02 { get; set; }
        public string RES_CHAR03 { get; set; }
        public string RES_CHAR04 { get; set; }
        public string RES_CHAR05 { get; set; }
        public string RES_CHAR06 { get; set; }
        public string RES_CHAR07 { get; set; }
        public string RES_CHAR08 { get; set; }
        public string RES_CHAR09 { get; set; }
        public string RES_CHAR10 { get; set; }
        public double RES_FLT01 { get; set; }
        public double RES_FLT02 { get; set; }
        public double RES_FLT03 { get; set; }
        public double RES_FLT04 { get; set; }
        public double RES_FLT05 { get; set; }
        public Int32 RES_INT01 { get; set; }
        public Int32 RES_INT02 { get; set; }
        public Int32 RES_INT03 { get; set; }
        public Int32 RES_INT04 { get; set; }
        public Int32 RES_INT05 { get; set; }
        public Int32 AUDIT_BATCHDT { get; set; }
        public string AUDIT_BATCHNO { get; set; }
        public DateTime? AUDIT_TIMESTAMP { get; set; }
        public string AUDIT_USER { get; set; }
        public string TYPE_DATA { get; set; }
    }
}