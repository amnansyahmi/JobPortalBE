using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CONFIG_FILTER
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 WF_MODULE { get; set; }
        public Int32 WF_ID { get; set; }
        public Int32 WF_LEVEL { get; set; }
        public string FILTER_FD_NAME { get; set; }
        public string FILTER_DATA { get; set; }
        public string FILTER_TABLE { get; set; }
        public Int32 FILTER_TYPE { get; set; }
        public string RULE_ID { get; set; }
        public string FILTER_FORM { get; set; }
        public string FILTER_DATA_START { get; set; }
        public string FILTER_DATA_END { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("CONFIG_FILTER")]
    public class _CONFIG_FILTER
    {
        public _CONFIG_FILTER()
        {
        }

        public _CONFIG_FILTER(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            WF_MODULE = 0;
            WF_ID = 0;
            WF_LEVEL = 0;
            FILTER_FD_NAME = "";
            FILTER_DATA = "";
            FILTER_TABLE = "";
            FILTER_TYPE = 0;
            RULE_ID = "";
            FILTER_FORM = "";
            FILTER_DATA_START = "";
            FILTER_DATA_END = "";
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }
        public Int32 WF_MODULE { get; set; }
        public Int32 WF_ID { get; set; }
        public Int32 WF_LEVEL { get; set; }
        public string FILTER_FD_NAME { get; set; }
        public string FILTER_DATA { get; set; }
        public string FILTER_TABLE { get; set; }
        public Int32 FILTER_TYPE { get; set; }

        [Key, Column(Order = 1)]
        public string RULE_ID { get; set; }

        public string FILTER_FORM { get; set; }
        public string FILTER_DATA_START { get; set; }
        public string FILTER_DATA_END { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}