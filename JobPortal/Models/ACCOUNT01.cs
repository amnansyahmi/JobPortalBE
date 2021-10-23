using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class ACCOUNT01
    {
        #region Properties

        public Int64 Row { get; set; }  // temp please change
        public Int16 COMP_CODE { get; set; }
        public String ACCOUNT_NO { get; set; }
        public String CIF_ID { get; set; }
        public String ACCOUNT_NAME { get; set; }
        public String ACCOUNT_TYPE { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public String BR_CODE { get; set; }
        public int DATE_OF_ACCT_OPENED { get; set; }
        public String ACCOUNT_STATUS { get; set; }
        public int DATE_OF_ACCT_CLOSED { get; set; }
        public String TYPE_OF_OWNERSHIP { get; set; }
        public double BALANCE_VALUE1 { get; set; }
        public double BALANCE_VALUE2 { get; set; }
        public int FALSE_POSITIVE_DT { get; set; }
        public Int16 FALSE_POSITIVE_IND { get; set; }
        public String RISK_LEVEL { get; set; }
        public String FieldA17 { get; set; }
        public String FieldA18 { get; set; }
        public String FieldA19 { get; set; }
        public String FieldA20 { get; set; }
        public String AField01 { get; set; }
        public String AField02 { get; set; }
        public String AField03 { get; set; }
        public String AField04 { get; set; }
        public String AField05 { get; set; }
        public String AField06 { get; set; }
        public String AField07 { get; set; }
        public String AField08 { get; set; }
        public String AField09 { get; set; }
        public String AField10 { get; set; }
        public String AField11 { get; set; }
        public String AField12 { get; set; }
        public String AField13 { get; set; }
        public String AField14 { get; set; }
        public String AField15 { get; set; }
        public String AField16 { get; set; }
        public String AField17 { get; set; }
        public String AField18 { get; set; }
        public String AField19 { get; set; }
        public String AField20 { get; set; }
        public String AField21 { get; set; }
        public String AField22 { get; set; }
        public String AField23 { get; set; }
        public String AField24 { get; set; }
        public String AField25 { get; set; }
        public String AField26 { get; set; }
        public String AField27 { get; set; }
        public String AField28 { get; set; }
        public String AField29 { get; set; }
        public String AField30 { get; set; }
        public Double AField131 { get; set; }
        public Double AField132 { get; set; }
        public Double AField133 { get; set; }
        public Double AField134 { get; set; }
        public Double AField135 { get; set; }
        public Double AField136 { get; set; }
        public Double AField137 { get; set; }
        public Double AField138 { get; set; }
        public Double AField139 { get; set; }
        public Double AField140 { get; set; }
        public Double AField141 { get; set; }
        public Double AField142 { get; set; }
        public Double AField143 { get; set; }
        public Double AField144 { get; set; }
        public Double AField145 { get; set; }
        public Double AField146 { get; set; }
        public Double AField147 { get; set; }
        public Double AField148 { get; set; }
        public Double AField149 { get; set; }
        public Double AField150 { get; set; }
        public int AField151 { get; set; }
        public int AField152 { get; set; }
        public int AField153 { get; set; }
        public int AField154 { get; set; }
        public int AField155 { get; set; }
        public int AField156 { get; set; }
        public int AField157 { get; set; }
        public int AField158 { get; set; }
        public int AField159 { get; set; }
        public int AField160 { get; set; }
        public int AField161 { get; set; }
        public int AField162 { get; set; }
        public int AField163 { get; set; }
        public int AField164 { get; set; }
        public int AField165 { get; set; }
        public int FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 FALSE_POSITIVE_IND_WL { get; set; }
        public int BATCH_DATE { get; set; }
        public String BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public String USER_ID { get; set; }
        public String MODE_MN { get; set; }

        #endregion Properties
    }

    [Table("ACCOUNT01")]
    public class _ACCOUNT01
    {
        public _ACCOUNT01()
        {
        }

        public _ACCOUNT01(bool setDefaultValue)
        {
            COMP_CODE = 0;
            ACCOUNT_NO = "";
            CIF_ID = "";
            ACCOUNT_NAME = "";
            ACCOUNT_TYPE = "";
            PRODUCT_TYPE = 0;
            BR_CODE = "";
            DATE_OF_ACCT_OPENED = 0;
            ACCOUNT_STATUS = "";
            DATE_OF_ACCT_CLOSED = 0;
            TYPE_OF_OWNERSHIP = "";
            BALANCE_VALUE1 = 0;
            BALANCE_VALUE2 = 0;
            FALSE_POSITIVE_DT = 0;
            FALSE_POSITIVE_IND = 0;
            RISK_LEVEL = "";
            FieldA17 = "";
            FieldA18 = "";
            FieldA19 = "";
            FieldA20 = "";
            AField01 = "";
            AField02 = "";
            AField03 = "";
            AField04 = "";
            AField05 = "";
            AField06 = "";
            AField07 = "";
            AField08 = "";
            AField09 = "";
            AField10 = "";
            AField11 = "";
            AField12 = "";
            AField13 = "";
            AField14 = "";
            AField15 = "";
            AField16 = "";
            AField17 = "";
            AField18 = "";
            AField19 = "";
            AField20 = "";
            AField21 = "";
            AField22 = "";
            AField23 = "";
            AField24 = "";
            AField25 = "";
            AField26 = "";
            AField27 = "";
            AField28 = "";
            AField29 = "";
            AField30 = "";
            AField131 = 0;
            AField132 = 0;
            AField133 = 0;
            AField134 = 0;
            AField135 = 0;
            AField136 = 0;
            AField137 = 0;
            AField138 = 0;
            AField139 = 0;
            AField140 = 0;
            AField141 = 0;
            AField142 = 0;
            AField143 = 0;
            AField144 = 0;
            AField145 = 0;
            AField146 = 0;
            AField147 = 0;
            AField148 = 0;
            AField149 = 0;
            AField150 = 0;
            AField151 = 0;
            AField152 = 0;
            AField153 = 0;
            AField154 = 0;
            AField155 = 0;
            AField156 = 0;
            AField157 = 0;
            AField158 = 0;
            AField159 = 0;
            AField160 = 0;
            AField161 = 0;
            AField162 = 0;
            AField163 = 0;
            AField164 = 0;
            AField165 = 0;
            FALSE_POSITIVE_DT_WL = 0;
            FALSE_POSITIVE_IND_WL = 0;
            BATCH_DATE = 0;
            BATCH_NO = "";
            STAMP_DTTM = null;
            USER_ID = "";
            MODE_MN = "";
        }

        #region Properties

        [Key, Column(Order = 1)]
        public Int16 COMP_CODE { get; set; }

        [Key, Column(Order = 2)]
        public String ACCOUNT_NO { get; set; }

        public String CIF_ID { get; set; }
        public String ACCOUNT_NAME { get; set; }
        public String ACCOUNT_TYPE { get; set; }
        public Int16 PRODUCT_TYPE { get; set; }
        public String BR_CODE { get; set; }
        public int DATE_OF_ACCT_OPENED { get; set; }
        public String ACCOUNT_STATUS { get; set; }
        public int DATE_OF_ACCT_CLOSED { get; set; }
        public String TYPE_OF_OWNERSHIP { get; set; }
        public double BALANCE_VALUE1 { get; set; }
        public double BALANCE_VALUE2 { get; set; }
        public int FALSE_POSITIVE_DT { get; set; }
        public Int16 FALSE_POSITIVE_IND { get; set; }
        public String RISK_LEVEL { get; set; }
        public String FieldA17 { get; set; }
        public String FieldA18 { get; set; }
        public String FieldA19 { get; set; }
        public String FieldA20 { get; set; }
        public String AField01 { get; set; }
        public String AField02 { get; set; }
        public String AField03 { get; set; }
        public String AField04 { get; set; }
        public String AField05 { get; set; }
        public String AField06 { get; set; }
        public String AField07 { get; set; }
        public String AField08 { get; set; }
        public String AField09 { get; set; }
        public String AField10 { get; set; }
        public String AField11 { get; set; }
        public String AField12 { get; set; }
        public String AField13 { get; set; }
        public String AField14 { get; set; }
        public String AField15 { get; set; }
        public String AField16 { get; set; }
        public String AField17 { get; set; }
        public String AField18 { get; set; }
        public String AField19 { get; set; }
        public String AField20 { get; set; }
        public String AField21 { get; set; }
        public String AField22 { get; set; }
        public String AField23 { get; set; }
        public String AField24 { get; set; }
        public String AField25 { get; set; }
        public String AField26 { get; set; }
        public String AField27 { get; set; }
        public String AField28 { get; set; }
        public String AField29 { get; set; }
        public String AField30 { get; set; }
        public Double AField131 { get; set; }
        public Double AField132 { get; set; }
        public Double AField133 { get; set; }
        public Double AField134 { get; set; }
        public Double AField135 { get; set; }
        public Double AField136 { get; set; }
        public Double AField137 { get; set; }
        public Double AField138 { get; set; }
        public Double AField139 { get; set; }
        public Double AField140 { get; set; }
        public Double AField141 { get; set; }
        public Double AField142 { get; set; }
        public Double AField143 { get; set; }
        public Double AField144 { get; set; }
        public Double AField145 { get; set; }
        public Double AField146 { get; set; }
        public Double AField147 { get; set; }
        public Double AField148 { get; set; }
        public Double AField149 { get; set; }
        public Double AField150 { get; set; }
        public int AField151 { get; set; }
        public int AField152 { get; set; }
        public int AField153 { get; set; }
        public int AField154 { get; set; }
        public int AField155 { get; set; }
        public int AField156 { get; set; }
        public int AField157 { get; set; }
        public int AField158 { get; set; }
        public int AField159 { get; set; }
        public int AField160 { get; set; }
        public int AField161 { get; set; }
        public int AField162 { get; set; }
        public int AField163 { get; set; }
        public int AField164 { get; set; }
        public int AField165 { get; set; }
        public int FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 FALSE_POSITIVE_IND_WL { get; set; }
        public int BATCH_DATE { get; set; }
        public String BATCH_NO { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public String USER_ID { get; set; }
        public String MODE_MN { get; set; }

        #endregion Properties
    }
}