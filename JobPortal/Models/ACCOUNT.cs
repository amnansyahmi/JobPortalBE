using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class ACCOUNT
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string NO_MASTER { get; set; }
        public string NO_CIF { get; set; }
        public string NO_ACC { get; set; }
        public string INFO_NAME { get; set; }
        public Int32 ACC_STATUS { get; set; }
        public string ACC_IPLACE { get; set; }
        public Int32 ACC_CDATE { get; set; }
        public Int32 ACC_JOINT { get; set; }
        public Int32 ACC_UDATE { get; set; }
        public string ACC_OTHER { get; set; }
        public double BAL1_VAL { get; set; }
        public double BAL2_VAL { get; set; }
        public double BAL1_AVG { get; set; }
        public double BAL2_AVG { get; set; }
        public double BAL1_OUT { get; set; }
        public double BAL2_OUT { get; set; }
        public Int32 ACC_TYPE { get; set; }
        public Int32 ACC_PROD { get; set; }
        public Int32 ACC_STYPE { get; set; }
        public Int32 ACC_SPROD { get; set; }
        public string TYPE_FACI { get; set; }
        public Int32 TYPE_CONS { get; set; }
        public Int32 PAY_DUR { get; set; }
        public Int32 PAY_FREQ { get; set; }
        public double PAY_IRATE { get; set; }
        public double PAY_LIMIT { get; set; }
        public Int32 TYPE_COVER { get; set; }
        public Int32 TYPE_PREM { get; set; }
        public Int32 DATE_INV { get; set; }
        public Int32 DATE_REDEM { get; set; }
        public Int32 DATE_RENEW { get; set; }
        public double PAY_DBURSE { get; set; }
        public Int32 DBURSE_DATE { get; set; }
        public double PAY_AMOUNT { get; set; }
        public Int32 PAY_DATE { get; set; }
        public double PAY_ADVANCE { get; set; }
        public Int32 PAY_DDATE { get; set; }
        public double PAY_SETTLE { get; set; }
        public Int32 PAY_SDATE { get; set; }
        public string AG_CAT { get; set; }
        public string AG_NO { get; set; }
        public string AG_NAME { get; set; }
        public string CTC_NO { get; set; }
        public string CTC_NAME { get; set; }
        public Int32 CTC_RDATE { get; set; }
        public double PREM_AMOUNT { get; set; }
        public string PREM_RLEN { get; set; }
        public Int32 PREM_PDATE { get; set; }
        public Int32 PREM_RDATE { get; set; }
        public Int32 PREM_DDATE { get; set; }
        public double PREM_ADV { get; set; }
        public Int32 PREM_NDATE { get; set; }
        public Int32 FLAG_FPOS { get; set; }
        public Int32 FPOS_DATE { get; set; }
        public string DATA_VALUE01 { get; set; }
        public string DATA_VALUE02 { get; set; }
        public string DATA_VALUE03 { get; set; }
        public string DATA_VALUE04 { get; set; }
        public string DATA_VALUE05 { get; set; }
        public string DATA_VALUE06 { get; set; }
        public string DATA_VALUE07 { get; set; }
        public string DATA_VALUE08 { get; set; }
        public string DATA_VALUE09 { get; set; }
        public string DATA_VALUE10 { get; set; }
        public string DATA_VALUE11 { get; set; }
        public string DATA_VALUE12 { get; set; }
        public string DATA_VALUE13 { get; set; }
        public string DATA_VALUE14 { get; set; }
        public string DATA_VALUE15 { get; set; }
        public string DATA_VALUE16 { get; set; }
        public string DATA_VALUE17 { get; set; }
        public string DATA_VALUE18 { get; set; }
        public string DATA_VALUE19 { get; set; }
        public string DATA_VALUE20 { get; set; }
        public string DATA_VALUE21 { get; set; }
        public string DATA_VALUE22 { get; set; }
        public string DATA_VALUE23 { get; set; }
        public string DATA_VALUE24 { get; set; }
        public string DATA_VALUE25 { get; set; }
        public string DATA_VALUE26 { get; set; }
        public string DATA_VALUE27 { get; set; }
        public string DATA_VALUE28 { get; set; }
        public string DATA_VALUE29 { get; set; }
        public string DATA_VALUE30 { get; set; }
        public string DATA_VALUE31 { get; set; }
        public string DATA_VALUE32 { get; set; }
        public string DATA_VALUE33 { get; set; }
        public string DATA_VALUE34 { get; set; }
        public string DATA_VALUE35 { get; set; }
        public string DATA_VALUE36 { get; set; }
        public string DATA_VALUE37 { get; set; }
        public string DATA_VALUE38 { get; set; }
        public string DATA_VALUE39 { get; set; }
        public string DATA_VALUE40 { get; set; }
        public string DATA_VALUE41 { get; set; }
        public string DATA_VALUE42 { get; set; }
        public string DATA_VALUE43 { get; set; }
        public string DATA_VALUE44 { get; set; }
        public string DATA_VALUE45 { get; set; }
        public string DATA_VALUE46 { get; set; }
        public string DATA_VALUE47 { get; set; }
        public string DATA_VALUE48 { get; set; }
        public string DATA_VALUE49 { get; set; }
        public string DATA_VALUE50 { get; set; }
        public string DATA_VALUE51 { get; set; }
        public string DATA_VALUE52 { get; set; }
        public string DATA_VALUE53 { get; set; }
        public string DATA_VALUE54 { get; set; }
        public string DATA_VALUE55 { get; set; }
        public Int32 BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("ACCOUNT")]
    public class _ACCOUNT
    {
        public _ACCOUNT()
        {
        }

        public _ACCOUNT(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            NO_MASTER = "";
            NO_CIF = "";
            NO_ACC = "";
            INFO_NAME = "";
            ACC_STATUS = 0;
            ACC_IPLACE = "";
            ACC_CDATE = 0;
            ACC_JOINT = 0;
            ACC_UDATE = 0;
            ACC_OTHER = "";
            BAL1_VAL = 0;
            BAL2_VAL = 0;
            BAL1_AVG = 0;
            BAL2_AVG = 0;
            BAL1_OUT = 0;
            BAL2_OUT = 0;
            ACC_TYPE = 0;
            ACC_PROD = 0;
            ACC_STYPE = 0;
            ACC_SPROD = 0;
            TYPE_FACI = "";
            TYPE_CONS = 0;
            PAY_DUR = 0;
            PAY_FREQ = 0;
            PAY_IRATE = 0;
            PAY_LIMIT = 0;
            TYPE_COVER = 0;
            TYPE_PREM = 0;
            DATE_INV = 0;
            DATE_REDEM = 0;
            DATE_RENEW = 0;
            PAY_DBURSE = 0;
            DBURSE_DATE = 0;
            PAY_AMOUNT = 0;
            PAY_DATE = 0;
            PAY_ADVANCE = 0;
            PAY_DDATE = 0;
            PAY_SETTLE = 0;
            PAY_SDATE = 0;
            AG_CAT = "";
            AG_NO = "";
            AG_NAME = "";
            CTC_NO = "";
            CTC_NAME = "";
            CTC_RDATE = 0;
            PREM_AMOUNT = 0;
            PREM_RLEN = "";
            PREM_PDATE = 0;
            PREM_RDATE = 0;
            PREM_DDATE = 0;
            PREM_ADV = 0;
            PREM_NDATE = 0;
            FLAG_FPOS = 0;
            FPOS_DATE = 0;
            DATA_VALUE01 = "";
            DATA_VALUE02 = "";
            DATA_VALUE03 = "";
            DATA_VALUE04 = "";
            DATA_VALUE05 = "";
            DATA_VALUE06 = "";
            DATA_VALUE07 = "";
            DATA_VALUE08 = "";
            DATA_VALUE09 = "";
            DATA_VALUE10 = "";
            DATA_VALUE11 = "";
            DATA_VALUE12 = "";
            DATA_VALUE13 = "";
            DATA_VALUE14 = "";
            DATA_VALUE15 = "";
            DATA_VALUE16 = "";
            DATA_VALUE17 = "";
            DATA_VALUE18 = "";
            DATA_VALUE19 = "";
            DATA_VALUE20 = "";
            DATA_VALUE21 = "";
            DATA_VALUE22 = "";
            DATA_VALUE23 = "";
            DATA_VALUE24 = "";
            DATA_VALUE25 = "";
            DATA_VALUE26 = "";
            DATA_VALUE27 = "";
            DATA_VALUE28 = "";
            DATA_VALUE29 = "";
            DATA_VALUE30 = "";
            DATA_VALUE31 = "";
            DATA_VALUE32 = "";
            DATA_VALUE33 = "";
            DATA_VALUE34 = "";
            DATA_VALUE35 = "";
            DATA_VALUE36 = "";
            DATA_VALUE37 = "";
            DATA_VALUE38 = "";
            DATA_VALUE39 = "";
            DATA_VALUE40 = "";
            DATA_VALUE41 = "";
            DATA_VALUE42 = "";
            DATA_VALUE43 = "";
            DATA_VALUE44 = "";
            DATA_VALUE45 = "";
            DATA_VALUE46 = "";
            DATA_VALUE47 = "";
            DATA_VALUE48 = "";
            DATA_VALUE49 = "";
            DATA_VALUE50 = "";
            DATA_VALUE51 = "";
            DATA_VALUE52 = "";
            DATA_VALUE53 = "";
            DATA_VALUE54 = "";
            DATA_VALUE55 = "";
            BATCH_DATE = 0;
            BATCH_NO = "";
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public string NO_MASTER { get; set; }

        [Key, Column(Order = 3)]
        public string NO_CIF { get; set; }

        [Key, Column(Order = 4)]
        public string NO_ACC { get; set; }

        public string INFO_NAME { get; set; }
        public Int32 ACC_STATUS { get; set; }
        public string ACC_IPLACE { get; set; }
        public Int32 ACC_CDATE { get; set; }
        public Int32 ACC_JOINT { get; set; }
        public Int32 ACC_UDATE { get; set; }
        public string ACC_OTHER { get; set; }
        public double BAL1_VAL { get; set; }
        public double BAL2_VAL { get; set; }
        public double BAL1_AVG { get; set; }
        public double BAL2_AVG { get; set; }
        public double BAL1_OUT { get; set; }
        public double BAL2_OUT { get; set; }
        public Int32 ACC_TYPE { get; set; }
        public Int32 ACC_PROD { get; set; }
        public Int32 ACC_STYPE { get; set; }
        public Int32 ACC_SPROD { get; set; }
        public string TYPE_FACI { get; set; }
        public Int32 TYPE_CONS { get; set; }
        public Int32 PAY_DUR { get; set; }
        public Int32 PAY_FREQ { get; set; }
        public double PAY_IRATE { get; set; }
        public double PAY_LIMIT { get; set; }
        public Int32 TYPE_COVER { get; set; }
        public Int32 TYPE_PREM { get; set; }
        public Int32 DATE_INV { get; set; }
        public Int32 DATE_REDEM { get; set; }
        public Int32 DATE_RENEW { get; set; }
        public double PAY_DBURSE { get; set; }
        public Int32 DBURSE_DATE { get; set; }
        public double PAY_AMOUNT { get; set; }
        public Int32 PAY_DATE { get; set; }
        public double PAY_ADVANCE { get; set; }
        public Int32 PAY_DDATE { get; set; }
        public double PAY_SETTLE { get; set; }
        public Int32 PAY_SDATE { get; set; }
        public string AG_CAT { get; set; }
        public string AG_NO { get; set; }
        public string AG_NAME { get; set; }
        public string CTC_NO { get; set; }
        public string CTC_NAME { get; set; }
        public Int32 CTC_RDATE { get; set; }
        public double PREM_AMOUNT { get; set; }
        public string PREM_RLEN { get; set; }
        public Int32 PREM_PDATE { get; set; }
        public Int32 PREM_RDATE { get; set; }
        public Int32 PREM_DDATE { get; set; }
        public double PREM_ADV { get; set; }
        public Int32 PREM_NDATE { get; set; }
        public Int32 FLAG_FPOS { get; set; }
        public Int32 FPOS_DATE { get; set; }
        public string DATA_VALUE01 { get; set; }
        public string DATA_VALUE02 { get; set; }
        public string DATA_VALUE03 { get; set; }
        public string DATA_VALUE04 { get; set; }
        public string DATA_VALUE05 { get; set; }
        public string DATA_VALUE06 { get; set; }
        public string DATA_VALUE07 { get; set; }
        public string DATA_VALUE08 { get; set; }
        public string DATA_VALUE09 { get; set; }
        public string DATA_VALUE10 { get; set; }
        public string DATA_VALUE11 { get; set; }
        public string DATA_VALUE12 { get; set; }
        public string DATA_VALUE13 { get; set; }
        public string DATA_VALUE14 { get; set; }
        public string DATA_VALUE15 { get; set; }
        public string DATA_VALUE16 { get; set; }
        public string DATA_VALUE17 { get; set; }
        public string DATA_VALUE18 { get; set; }
        public string DATA_VALUE19 { get; set; }
        public string DATA_VALUE20 { get; set; }
        public string DATA_VALUE21 { get; set; }
        public string DATA_VALUE22 { get; set; }
        public string DATA_VALUE23 { get; set; }
        public string DATA_VALUE24 { get; set; }
        public string DATA_VALUE25 { get; set; }
        public string DATA_VALUE26 { get; set; }
        public string DATA_VALUE27 { get; set; }
        public string DATA_VALUE28 { get; set; }
        public string DATA_VALUE29 { get; set; }
        public string DATA_VALUE30 { get; set; }
        public string DATA_VALUE31 { get; set; }
        public string DATA_VALUE32 { get; set; }
        public string DATA_VALUE33 { get; set; }
        public string DATA_VALUE34 { get; set; }
        public string DATA_VALUE35 { get; set; }
        public string DATA_VALUE36 { get; set; }
        public string DATA_VALUE37 { get; set; }
        public string DATA_VALUE38 { get; set; }
        public string DATA_VALUE39 { get; set; }
        public string DATA_VALUE40 { get; set; }
        public string DATA_VALUE41 { get; set; }
        public string DATA_VALUE42 { get; set; }
        public string DATA_VALUE43 { get; set; }
        public string DATA_VALUE44 { get; set; }
        public string DATA_VALUE45 { get; set; }
        public string DATA_VALUE46 { get; set; }
        public string DATA_VALUE47 { get; set; }
        public string DATA_VALUE48 { get; set; }
        public string DATA_VALUE49 { get; set; }
        public string DATA_VALUE50 { get; set; }
        public string DATA_VALUE51 { get; set; }
        public string DATA_VALUE52 { get; set; }
        public string DATA_VALUE53 { get; set; }
        public string DATA_VALUE54 { get; set; }
        public string DATA_VALUE55 { get; set; }
        public Int32 BATCH_DATE { get; set; }
        public string BATCH_NO { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}