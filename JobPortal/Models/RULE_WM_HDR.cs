using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RULE_WM_HDR
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string RULE_ID { get; set; }
        public string RULE_DESC { get; set; }
        public Int32 RULE_STATUS { get; set; }
        public Int32 RULE_REPORT { get; set; }
        public string WL_TYPE { get; set; }
        public Int32 WL_SCENARIO { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string RULE_STATUS_DESC { get; set; }
        public string WL_SCENARIO_DESC { get; set; }
        public string WL_TYPE_DESC { get; set; }
    }

    [Table("RULE_WM_HDR")]
    public class _RULE_WM_HDR
    {
        public _RULE_WM_HDR()
        {
        }

        public _RULE_WM_HDR(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            RULE_ID = "";
            RULE_DESC = "";
            RULE_STATUS = 0;
            RULE_REPORT = 0;
            WL_TYPE = "";
            WL_SCENARIO = 0;
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
        public string RULE_ID { get; set; }

        public string RULE_DESC { get; set; }
        public Int32 RULE_STATUS { get; set; }
        public Int32 RULE_REPORT { get; set; }
        public string WL_TYPE { get; set; }
        public Int32 WL_SCENARIO { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}