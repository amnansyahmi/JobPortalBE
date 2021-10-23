using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RULE_WM_DTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string RULE_ID { get; set; }
        public Int32 RULE_CON_ID { get; set; }
        public string RULE_CON_DESC { get; set; }
        public string RULE_WL_FD { get; set; }
        public string RULE_CUST_TABLE { get; set; }
        public string RULE_CUST_FD { get; set; }
        public Int32 RULE_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string RULE_STATUS_DESC { get; set; }
    }

    [Table("RULE_WM_DTL")]
    public class _RULE_WM_DTL
    {
        public _RULE_WM_DTL()
        {
        }

        public _RULE_WM_DTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            RULE_ID = "";
            RULE_CON_ID = 0;
            RULE_CON_DESC = "";
            RULE_WL_FD = "";
            RULE_CUST_TABLE = "";
            RULE_CUST_FD = "";
            RULE_STATUS = 0;
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

        [Key, Column(Order = 3)]
        public Int32 RULE_CON_ID { get; set; }

        public string RULE_CON_DESC { get; set; }
        public string RULE_WL_FD { get; set; }
        public string RULE_CUST_TABLE { get; set; }
        public string RULE_CUST_FD { get; set; }
        public Int32 RULE_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }

        [NotMapped]
        public string RULE_STATUS_DESC { get; set; }
    }
}