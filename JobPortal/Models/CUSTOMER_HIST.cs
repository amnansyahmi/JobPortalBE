using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CUSTOMER_HIST
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string NO_MASTER { get; set; }
        public string NO_CIF { get; set; }
        public Int32 NO_SEQ { get; set; }
        public string INFO_NAME_FULL { get; set; }
        public string INFO_NAME_NATIVE { get; set; }
        public string INFO_NAME_FIRST { get; set; }
        public string INFO_NAME_MID { get; set; }
        public string INFO_NAME_LAST { get; set; }
        public Int32 CIF_STATUS { get; set; }
        public string CIF_IPLACE { get; set; }
        public Int32 CIF_JOINT { get; set; }
        public Int32 CIF_DATE_CREATE { get; set; }
        public Int32 CIF_DATE_UPDATE { get; set; }
        public Int32 RISK_NEW { get; set; }
        public Int32 RISK_PREV { get; set; }
        public Int32 RISK_MANUAL { get; set; }
        public Int32 RISK_HOST { get; set; }
        public Int32 RISK_SCORE { get; set; }
        public Int32 INFO_TYPE { get; set; }
        public Int32 ID1_TYPE { get; set; }
        public string ID1_NO { get; set; }
        public Int32 ID1_IDATE { get; set; }
        public Int32 ID1_VDATE { get; set; }
        public string ID1_IPLACE { get; set; }
        public Int32 ID1_EDATE { get; set; }
        public Int32 ID2_TYPE { get; set; }
        public string ID2_NO { get; set; }
        public Int32 ID2_IDATE { get; set; }
        public Int32 ID2_VDATE { get; set; }
        public string ID2_IPLACE { get; set; }
        public Int32 ID2_EDATE { get; set; }
        public string INFO_NAT { get; set; }
        public string INFO_RES { get; set; }
        public Int32 INFO_AGE { get; set; }
        public Int32 INDO_DOB { get; set; }
        public Int32 INFO_GEN { get; set; }
        public Int32 INFO_MARRY { get; set; }
        public Int32 CON_HOME { get; set; }
        public Int32 CON_MOBILE { get; set; }
        public Int32 CON_OFFICE { get; set; }
        public string EMAIL { get; set; }
        public string INFO_RACE { get; set; }
        public string INFO_RELI { get; set; }
        public string INFO_EDU { get; set; }
        public string INFO_LANG { get; set; }
        public string INFO_OCC { get; set; }
        public string INFO_OSECT { get; set; }
        public string INFO_OYEAR { get; set; }
        public string INFO_BLINE { get; set; }
        public string INFO_BSECT { get; set; }
        public string INFO_SOF { get; set; }
        public string INFO_ICOME { get; set; }
        public string INFO_AGENT { get; set; }
        public string INFO_DDATE { get; set; }
        public string ADD_L1 { get; set; }
        public string ADD_PCODE { get; set; }
        public string ADD_L2 { get; set; }
        public string ADD_CITY { get; set; }
        public string ADD_L3 { get; set; }
        public string ADD_STATE { get; set; }
        public string ADD_L4 { get; set; }
        public string ADD_COUNTRY { get; set; }
        public Int32 FLAG_STAFF { get; set; }
        public Int32 FLAG_EKYC { get; set; }
        public Int32 FLAG_STR { get; set; }
        public Int32 FLAG_WLIST { get; set; }
        public Int32 FLAT_HNW { get; set; }
        public Int32 FLAG_BLIST { get; set; }
        public Int32 FLAG_LEGAL { get; set; }
        public Int32 FLAG_PEP { get; set; }
        public Int32 FLAG_CRS { get; set; }
        public Int32 FLAG_SOC { get; set; }
        public Int32 FLAG_PDPA { get; set; }
        public Int32 FLAG_FI { get; set; }
        public Int32 FLAG_BUMI { get; set; }
        public Int32 FLAG_OTHER { get; set; }
        public Int32 FLAG_FPOS { get; set; }
        public Int32 FLAG_PRIME { get; set; }
        public Int32 FPOS_DATE { get; set; }
        public string EMP_NAME { get; set; }
        public Int32 EMP_YEAR { get; set; }
        public string EMP_ADD1 { get; set; }
        public string EMP_PCODE { get; set; }
        public string EMP_ADD2 { get; set; }
        public string EMP_CITY { get; set; }
        public string EMP_ADD3 { get; set; }
        public string EMP_STATE { get; set; }
        public string EMP_ADD4 { get; set; }
        public string EMP_COUNTRY { get; set; }
        public Int32 FLAG_FATCA { get; set; }
        public string FATCA_NO { get; set; }
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
        public string AUDIT_REMARKS { get; set; }
        public string AUDIT_NO_CIF_OLD { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("CUSTOMER_HIST")]
    public class _CUSTOMER_HIST
    {
        public _CUSTOMER_HIST()
        {
        }

        public _CUSTOMER_HIST(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            NO_MASTER = "";
            NO_CIF = "";
            NO_SEQ = 0;
            INFO_NAME_FULL = "";
            INFO_NAME_NATIVE = "";
            INFO_NAME_FIRST = "";
            INFO_NAME_MID = "";
            INFO_NAME_LAST = "";
            CIF_STATUS = 0;
            CIF_IPLACE = "";
            CIF_JOINT = 0;
            CIF_DATE_CREATE = 0;
            CIF_DATE_UPDATE = 0;
            RISK_NEW = 0;
            RISK_PREV = 0;
            RISK_MANUAL = 0;
            RISK_HOST = 0;
            RISK_SCORE = 0;
            INFO_TYPE = 0;
            ID1_TYPE = 0;
            ID1_NO = "";
            ID1_IDATE = 0;
            ID1_VDATE = 0;
            ID1_IPLACE = "";
            ID1_EDATE = 0;
            ID2_TYPE = 0;
            ID2_NO = "";
            ID2_IDATE = 0;
            ID2_VDATE = 0;
            ID2_IPLACE = "";
            ID2_EDATE = 0;
            INFO_NAT = "";
            INFO_RES = "";
            INFO_AGE = 0;
            INDO_DOB = 0;
            INFO_GEN = 0;
            INFO_MARRY = 0;
            CON_HOME = 0;
            CON_MOBILE = 0;
            CON_OFFICE = 0;
            EMAIL = "";
            INFO_RACE = "";
            INFO_RELI = "";
            INFO_EDU = "";
            INFO_LANG = "";
            INFO_OCC = "";
            INFO_OSECT = "";
            INFO_OYEAR = "";
            INFO_BLINE = "";
            INFO_BSECT = "";
            INFO_SOF = "";
            INFO_ICOME = "";
            INFO_AGENT = "";
            INFO_DDATE = "";
            ADD_L1 = "";
            ADD_PCODE = "";
            ADD_L2 = "";
            ADD_CITY = "";
            ADD_L3 = "";
            ADD_STATE = "";
            ADD_L4 = "";
            ADD_COUNTRY = "";
            FLAG_STAFF = 0;
            FLAG_EKYC = 0;
            FLAG_STR = 0;
            FLAG_WLIST = 0;
            FLAT_HNW = 0;
            FLAG_BLIST = 0;
            FLAG_LEGAL = 0;
            FLAG_PEP = 0;
            FLAG_CRS = 0;
            FLAG_SOC = 0;
            FLAG_PDPA = 0;
            FLAG_FI = 0;
            FLAG_BUMI = 0;
            FLAG_OTHER = 0;
            FLAG_FPOS = 0;
            FLAG_PRIME = 0;
            FPOS_DATE = 0;
            EMP_NAME = "";
            EMP_YEAR = 0;
            EMP_ADD1 = "";
            EMP_PCODE = "";
            EMP_ADD2 = "";
            EMP_CITY = "";
            EMP_ADD3 = "";
            EMP_STATE = "";
            EMP_ADD4 = "";
            EMP_COUNTRY = "";
            FLAG_FATCA = 0;
            FATCA_NO = "";
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
            AUDIT_REMARKS = "";
            AUDIT_NO_CIF_OLD = "";
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
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
        public Int32 NO_SEQ { get; set; }

        public string INFO_NAME_FULL { get; set; }
        public string INFO_NAME_NATIVE { get; set; }
        public string INFO_NAME_FIRST { get; set; }
        public string INFO_NAME_MID { get; set; }
        public string INFO_NAME_LAST { get; set; }
        public Int32 CIF_STATUS { get; set; }
        public string CIF_IPLACE { get; set; }
        public Int32 CIF_JOINT { get; set; }
        public Int32 CIF_DATE_CREATE { get; set; }
        public Int32 CIF_DATE_UPDATE { get; set; }
        public Int32 RISK_NEW { get; set; }
        public Int32 RISK_PREV { get; set; }
        public Int32 RISK_MANUAL { get; set; }
        public Int32 RISK_HOST { get; set; }
        public Int32 RISK_SCORE { get; set; }
        public Int32 INFO_TYPE { get; set; }
        public Int32 ID1_TYPE { get; set; }
        public string ID1_NO { get; set; }
        public Int32 ID1_IDATE { get; set; }
        public Int32 ID1_VDATE { get; set; }
        public string ID1_IPLACE { get; set; }
        public Int32 ID1_EDATE { get; set; }
        public Int32 ID2_TYPE { get; set; }
        public string ID2_NO { get; set; }
        public Int32 ID2_IDATE { get; set; }
        public Int32 ID2_VDATE { get; set; }
        public string ID2_IPLACE { get; set; }
        public Int32 ID2_EDATE { get; set; }
        public string INFO_NAT { get; set; }
        public string INFO_RES { get; set; }
        public Int32 INFO_AGE { get; set; }
        public Int32 INDO_DOB { get; set; }
        public Int32 INFO_GEN { get; set; }
        public Int32 INFO_MARRY { get; set; }
        public Int32 CON_HOME { get; set; }
        public Int32 CON_MOBILE { get; set; }
        public Int32 CON_OFFICE { get; set; }
        public string EMAIL { get; set; }
        public string INFO_RACE { get; set; }
        public string INFO_RELI { get; set; }
        public string INFO_EDU { get; set; }
        public string INFO_LANG { get; set; }
        public string INFO_OCC { get; set; }
        public string INFO_OSECT { get; set; }
        public string INFO_OYEAR { get; set; }
        public string INFO_BLINE { get; set; }
        public string INFO_BSECT { get; set; }
        public string INFO_SOF { get; set; }
        public string INFO_ICOME { get; set; }
        public string INFO_AGENT { get; set; }
        public string INFO_DDATE { get; set; }
        public string ADD_L1 { get; set; }
        public string ADD_PCODE { get; set; }
        public string ADD_L2 { get; set; }
        public string ADD_CITY { get; set; }
        public string ADD_L3 { get; set; }
        public string ADD_STATE { get; set; }
        public string ADD_L4 { get; set; }
        public string ADD_COUNTRY { get; set; }
        public Int32 FLAG_STAFF { get; set; }
        public Int32 FLAG_EKYC { get; set; }
        public Int32 FLAG_STR { get; set; }
        public Int32 FLAG_WLIST { get; set; }
        public Int32 FLAT_HNW { get; set; }
        public Int32 FLAG_BLIST { get; set; }
        public Int32 FLAG_LEGAL { get; set; }
        public Int32 FLAG_PEP { get; set; }
        public Int32 FLAG_CRS { get; set; }
        public Int32 FLAG_SOC { get; set; }
        public Int32 FLAG_PDPA { get; set; }
        public Int32 FLAG_FI { get; set; }
        public Int32 FLAG_BUMI { get; set; }
        public Int32 FLAG_OTHER { get; set; }
        public Int32 FLAG_FPOS { get; set; }
        public Int32 FLAG_PRIME { get; set; }
        public Int32 FPOS_DATE { get; set; }
        public string EMP_NAME { get; set; }
        public Int32 EMP_YEAR { get; set; }
        public string EMP_ADD1 { get; set; }
        public string EMP_PCODE { get; set; }
        public string EMP_ADD2 { get; set; }
        public string EMP_CITY { get; set; }
        public string EMP_ADD3 { get; set; }
        public string EMP_STATE { get; set; }
        public string EMP_ADD4 { get; set; }
        public string EMP_COUNTRY { get; set; }
        public Int32 FLAG_FATCA { get; set; }
        public string FATCA_NO { get; set; }
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
        public string AUDIT_REMARKS { get; set; }
        public string AUDIT_NO_CIF_OLD { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}