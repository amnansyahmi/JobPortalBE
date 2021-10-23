using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RPT_STR_HDR
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string NO_MASTER { get; set; }
        public string NO_CIF { get; set; }

        public int CASE_ID { get; set; }
        public Int32 STR_HDR_SEQ { get; set; }
        public Int32 STR_ID { get; set; }
        public string AUDIT_USER_LEVEL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("RPT_STR_HDR")]
    public class _RPT_STR_HDR
    {
        public _RPT_STR_HDR()
        {
        }

        public _RPT_STR_HDR(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            NO_MASTER = "";
            NO_CIF = "";
            STR_HDR_SEQ = 0;
            STR_ID = 0;
            AUDIT_USER_LEVEL = "";
            AUDIT_CREATED_DATE = DateTime.Now;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = DateTime.Now;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 STR_HDR_SEQ { get; set; }

        [Key, Column(Order = 5)]
        public int CASE_ID { get; set; }

        public Int32 STR_ID { get; set; }
        public string AUDIT_USER_LEVEL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}