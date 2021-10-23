using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CONFIG_WF_HDR
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 WF_MODULE { get; set; }
        public Int32 WF_ID { get; set; }
        public string WF_NAME { get; set; }
        public Int32 WF_LEVEL_MAX { get; set; }
        public Int32 WF_STATUS { get; set; }
        public Int32 WF_FILTER_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }

        [NotMapped]
        public string WF_STATUS_DESC { get; set; }
    }

    [Table("CONFIG_WF_HDR")]
    public class _CONFIG_WF_HDR
    {
        public _CONFIG_WF_HDR()
        {
        }

        public _CONFIG_WF_HDR(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            WF_MODULE = 0;
            WF_ID = 0;
            WF_NAME = "";
            WF_LEVEL_MAX = 0;
            WF_STATUS = 0;
            WF_FILTER_STATUS = 0;
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
        public Int32 WF_MODULE { get; set; }

        [Key, Column(Order = 3)]
        public Int32 WF_ID { get; set; }

        public string WF_NAME { get; set; }
        public Int32 WF_LEVEL_MAX { get; set; }
        public Int32 WF_STATUS { get; set; }
        public Int32 WF_FILTER_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }

        [NotMapped]
        public string WF_STATUS_DESC { get; set; }
    }
}