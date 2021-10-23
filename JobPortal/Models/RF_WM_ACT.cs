using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_WM_ACT
    {
        public Int32 CODE_SEQ { get; set; }
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public Int32 CASE_ID { get; set; }
        public string AUDIT_REMARKS { get; set; }
        public string AUDIT_ACTION { get; set; }
        public Int32 AUDIT_STATUS { get; set; }
        public Int32 AUDIT_SUB_STATUS { get; set; }

        [NotMapped]
        public string SUB_STATUS_DESC { get; set; }

        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
    }

    [Table("RF_WM_ACT")]
    public class _RF_WM_ACT
    {
        public _RF_WM_ACT()
        {
        }

        public _RF_WM_ACT(bool setDefaultValue)
        {
            CODE_SEQ = 0;
            CODE_COMP = 0;
            CODE_ORG = 0;
            RF_ID = 0;
            CASE_ID = 0;
            AUDIT_REMARKS = "";
            AUDIT_ACTION = "";
            AUDIT_STATUS = 0;
            AUDIT_SUB_STATUS = 0;
            AUDIT_CREATED_USER = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_SEQ { get; set; }

        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public Int32 CASE_ID { get; set; }
        public string AUDIT_REMARKS { get; set; }
        public string AUDIT_ACTION { get; set; }
        public Int32 AUDIT_STATUS { get; set; }
        public Int32 AUDIT_SUB_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }

        [NotMapped]
        public string SUB_STATUS_DESC { get; set; }
    }
}