using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class BANKFINTRANHIT01
    {
        #region Properties

        public Int64 HIT_TRAN_AUTO_ID { get; set; }
        public Int64 ALERT_ID { get; set; }
        public Int64 TRAN_ID { get; set; }
        public Int16 COMP_CODE { get; set; }
        public String REC_TYPE { get; set; }
        public String UNLOAD_IND { get; set; }
        public String REC_IDENTITY_NO { get; set; }
        public String INWARD_OUTWARD_CODE { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public int POSTING_DATE { get; set; }
        public int VALUE_DATE { get; set; }
        public String TRAN_CODE { get; set; }
        public String ACCOUNT_NO { get; set; }
        public String CIF_ID { get; set; }
        public String BR_CODE { get; set; }
        public Double LOCAL_AMOUNT { get; set; }
        public String LOCAL_CURRENCY { get; set; }
        public Double FOREIGN_AMOUNT { get; set; }
        public Double FX_RATE { get; set; }
        public Int16 TRAN_REVERSAL_IND { get; set; }
        public String REFERANCE_NO { get; set; }
        public String REFERANCE_DT { get; set; }
        public String TRAN_LOCATION { get; set; }
        public String Field1 { get; set; }
        public String Field2 { get; set; }
        public String Field3 { get; set; }
        public String Field4 { get; set; }
        public String Field5 { get; set; }
        public String Field6 { get; set; }
        public String Field7 { get; set; }
        public String Field8 { get; set; }
        public String Field9 { get; set; }
        public String Field10 { get; set; }
        public String Field11 { get; set; }
        public String Field12 { get; set; }
        public String Field13 { get; set; }
        public String Field14 { get; set; }
        public String Field15 { get; set; }
        public Double FIELD21 { get; set; }
        public Double FIELD22 { get; set; }
        public Double FIELD23 { get; set; }
        public Double FIELD24 { get; set; }
        public Double FIELD25 { get; set; }
        public Double FIELD26 { get; set; }
        public Double FIELD27 { get; set; }
        public Double FIELD28 { get; set; }
        public Double FIELD29 { get; set; }
        public Double FIELD30 { get; set; }
        public int FIELD31 { get; set; }
        public int FIELD32 { get; set; }
        public int FIELD33 { get; set; }
        public int FIELD34 { get; set; }
        public int FIELD35 { get; set; }
        public int FIELD36 { get; set; }
        public int FIELD37 { get; set; }
        public int FIELD38 { get; set; }
        public int FIELD39 { get; set; }
        public int FIELD40 { get; set; }
        public String FIELD50 { get; set; }
        public String FIELD51 { get; set; }
        public String FIELD52 { get; set; }
        public String FIELD53 { get; set; }
        public String FIELD54 { get; set; }
        public String FIELD55 { get; set; }
        public int BATCH_DATE { get; set; }
        public String BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public String USER_ID { get; set; }
        public String MODE_MN { get; set; }

        #endregion Properties
    }

    [Table("BANKFINTRANHIT01")]
    public class _BANKFINTRANHIT01
    {
        public _BANKFINTRANHIT01()
        {
        }

        public _BANKFINTRANHIT01(bool setDefaultValue)
        {
            HIT_TRAN_AUTO_ID = 0;
            ALERT_ID = 0;
            TRAN_ID = 0;
            COMP_CODE = 0;
            REC_TYPE = "";
            UNLOAD_IND = "";
            REC_IDENTITY_NO = "";
            INWARD_OUTWARD_CODE = "";
            CREDIT_DEBIT = 0;
            TRAN_DATE = 0;
            POSTING_DATE = 0;
            VALUE_DATE = 0;
            TRAN_CODE = "";
            ACCOUNT_NO = "";
            CIF_ID = "";
            BR_CODE = "";
            LOCAL_AMOUNT = 0;
            LOCAL_CURRENCY = "";
            FOREIGN_AMOUNT = 0;
            FX_RATE = 0;
            TRAN_REVERSAL_IND = 0;
            REFERANCE_NO = "";
            REFERANCE_DT = "";
            TRAN_LOCATION = "";
            Field1 = "";
            Field2 = "";
            Field3 = "";
            Field4 = "";
            Field5 = "";
            Field6 = "";
            Field7 = "";
            Field8 = "";
            Field9 = "";
            Field10 = "";
            Field11 = "";
            Field12 = "";
            Field13 = "";
            Field14 = "";
            Field15 = "";
            FIELD21 = 0;
            FIELD22 = 0;
            FIELD23 = 0;
            FIELD24 = 0;
            FIELD25 = 0;
            FIELD26 = 0;
            FIELD27 = 0;
            FIELD28 = 0;
            FIELD29 = 0;
            FIELD30 = 0;
            FIELD31 = 0;
            FIELD32 = 0;
            FIELD33 = 0;
            FIELD34 = 0;
            FIELD35 = 0;
            FIELD36 = 0;
            FIELD37 = 0;
            FIELD38 = 0;
            FIELD39 = 0;
            FIELD40 = 0;
            FIELD50 = "";
            FIELD51 = "";
            FIELD52 = "";
            FIELD53 = "";
            FIELD54 = "";
            FIELD55 = "";
            BATCH_DATE = 0;
            BATCH_NO = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int64 HIT_TRAN_AUTO_ID { get; set; }

        public Int64 ALERT_ID { get; set; }
        public Int64 TRAN_ID { get; set; }
        public Int16 COMP_CODE { get; set; }
        public String REC_TYPE { get; set; }
        public String UNLOAD_IND { get; set; }
        public String REC_IDENTITY_NO { get; set; }
        public String INWARD_OUTWARD_CODE { get; set; }
        public Int16 CREDIT_DEBIT { get; set; }
        public int TRAN_DATE { get; set; }
        public int POSTING_DATE { get; set; }
        public int VALUE_DATE { get; set; }
        public String TRAN_CODE { get; set; }
        public String ACCOUNT_NO { get; set; }
        public String CIF_ID { get; set; }
        public String BR_CODE { get; set; }
        public Double LOCAL_AMOUNT { get; set; }
        public String LOCAL_CURRENCY { get; set; }
        public Double FOREIGN_AMOUNT { get; set; }
        public Double FX_RATE { get; set; }
        public Int16 TRAN_REVERSAL_IND { get; set; }
        public String REFERANCE_NO { get; set; }
        public String REFERANCE_DT { get; set; }
        public String TRAN_LOCATION { get; set; }
        public String Field1 { get; set; }
        public String Field2 { get; set; }
        public String Field3 { get; set; }
        public String Field4 { get; set; }
        public String Field5 { get; set; }
        public String Field6 { get; set; }
        public String Field7 { get; set; }
        public String Field8 { get; set; }
        public String Field9 { get; set; }
        public String Field10 { get; set; }
        public String Field11 { get; set; }
        public String Field12 { get; set; }
        public String Field13 { get; set; }
        public String Field14 { get; set; }
        public String Field15 { get; set; }
        public Double FIELD21 { get; set; }
        public Double FIELD22 { get; set; }
        public Double FIELD23 { get; set; }
        public Double FIELD24 { get; set; }
        public Double FIELD25 { get; set; }
        public Double FIELD26 { get; set; }
        public Double FIELD27 { get; set; }
        public Double FIELD28 { get; set; }
        public Double FIELD29 { get; set; }
        public Double FIELD30 { get; set; }
        public int FIELD31 { get; set; }
        public int FIELD32 { get; set; }
        public int FIELD33 { get; set; }
        public int FIELD34 { get; set; }
        public int FIELD35 { get; set; }
        public int FIELD36 { get; set; }
        public int FIELD37 { get; set; }
        public int FIELD38 { get; set; }
        public int FIELD39 { get; set; }
        public int FIELD40 { get; set; }
        public String FIELD50 { get; set; }
        public String FIELD51 { get; set; }
        public String FIELD52 { get; set; }
        public String FIELD53 { get; set; }
        public String FIELD54 { get; set; }
        public String FIELD55 { get; set; }
        public int BATCH_DATE { get; set; }
        public String BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public String USER_ID { get; set; }
        public String MODE_MN { get; set; }

        #endregion Properties
    }
}