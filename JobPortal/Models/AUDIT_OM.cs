using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class AUDIT_OM
    {
        public Int32 CODE_SEQ { get; set; }
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public DateTime? AUDIT_STAMPDT { get; set; }
        public string AUDIT_USER_ID { get; set; }
        public Int32 AUDIT_MODULE { get; set; }
        public Int32 AUDIT_PAGE { get; set; }
        public Int32 AUDIT_ACTIVITY { get; set; }
        public string AUDIT_ACTIVITY_DESC { get; set; }
    }

    [Table("AUDIT_OM")]
    public class _AUDIT_OM
    {
        public _AUDIT_OM()
        {
        }

        public _AUDIT_OM(bool setDefaultValue)
        {
            CODE_SEQ = 0;
            CODE_COMP = 0;
            CODE_ORG = 0;
            AUDIT_USER_ID = "";
            AUDIT_MODULE = 0;
            AUDIT_PAGE = 0;
            AUDIT_ACTIVITY = 0;
            AUDIT_ACTIVITY_DESC = "";
        }

        [Key, Column(Order = 1)]
        public Int32 CODE_SEQ { get; set; }

        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public DateTime? AUDIT_STAMPDT { get; set; }
        public string AUDIT_USER_ID { get; set; }
        public Int32 AUDIT_MODULE { get; set; }
        public Int32 AUDIT_PAGE { get; set; }
        public Int32 AUDIT_ACTIVITY { get; set; }
        public string AUDIT_ACTIVITY_DESC { get; set; }
    }
}