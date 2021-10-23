using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_PORTFOLIO
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string NO_MASTER { get; set; }
        public string NO_CIF { get; set; }
        public Int32 RISK_PRIORITY { get; set; }
        public Int32 RISK_LEVEL { get; set; }
        public string INFO_NAME { get; set; }
        public Int32 RF_TM { get; set; }
        public Int32 RF_WL { get; set; }
        public Int32 RF_RP { get; set; }
        public Int32 RF_OB { get; set; }
        public Int32 RF_PM { get; set; }
        public Int32 RF_MODULE01 { get; set; }
        public Int32 RF_MODULE02 { get; set; }
        public Int32 RF_MODULE03 { get; set; }
        public Int32 RF_MODULE04 { get; set; }
        public Int32 RF_MODULE05 { get; set; }
        public Int64 ROW { get; set; }
        public Int32 TOTAL_NEW_REDFLAGS { get; set; }
        public Int32 TOTAL_ADDON_REDFLAGS { get; set; }
        public Int32 TOTAL_DROP_REDFLAGS { get; set; }
        public string STATUS_RF { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }

        // HAFIZUL SWITCHING PORTFOLIO > CUSTOMER
        public Int32 WM_CNT { get; set; }

        public string WM_LABEL { get; set; }
        public string INFO_NAME_FULL { get; set; }

        //OM CNT
        public Int32 OM_CNT { get; set; }

        public string OM_LABEL { get; set; }
    }

    [Table("RF_PORTFOLIO")]
    public class _RF_PORTFOLIO
    {
        public _RF_PORTFOLIO()
        {
        }

        public _RF_PORTFOLIO(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            NO_MASTER = "";
            NO_CIF = "";
            RISK_PRIORITY = 0;
            RISK_LEVEL = 0;
            INFO_NAME = "";
            RF_TM = 0;
            RF_WL = 0;
            RF_RP = 0;
            RF_OB = 0;
            RF_PM = 0;
            RF_MODULE01 = 0;
            RF_MODULE02 = 0;
            RF_MODULE03 = 0;
            RF_MODULE04 = 0;
            RF_MODULE05 = 0;
            STATUS_RF = "";
            TOTAL_NEW_REDFLAGS = 0;
            TOTAL_ADDON_REDFLAGS = 0;
            TOTAL_DROP_REDFLAGS = 0;
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 1)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 2)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 3)]
        public string NO_MASTER { get; set; }

        public string NO_CIF { get; set; }
        public Int32 RISK_PRIORITY { get; set; }
        public Int32 RISK_LEVEL { get; set; }
        public string INFO_NAME { get; set; }
        public Int32 RF_TM { get; set; }
        public Int32 RF_WL { get; set; }
        public Int32 RF_RP { get; set; }
        public Int32 RF_OB { get; set; }
        public Int32 RF_PM { get; set; }
        public Int32 RF_MODULE01 { get; set; }
        public Int32 RF_MODULE02 { get; set; }
        public Int32 RF_MODULE03 { get; set; }
        public Int32 RF_MODULE04 { get; set; }
        public Int32 RF_MODULE05 { get; set; }
        public string STATUS_RF { get; set; }

        [NotMapped]
        public Int32 TOTAL_NEW_REDFLAGS { get; set; }

        [NotMapped]
        public Int32 TOTAL_ADDON_REDFLAGS { get; set; }

        [NotMapped]
        public Int32 TOTAL_DROP_REDFLAGS { get; set; }

        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }

        [NotMapped]
        public Int32 WM_CNT { get; set; }

        [NotMapped]
        public string WM_LABEL { get; set; }

        [NotMapped]
        public string INFO_NAME_FULL { get; set; }

        //OM CNT
        [NotMapped]
        public Int32 OM_CNT { get; set; }

        [NotMapped]
        public string OM_LABEL { get; set; }
    }
}