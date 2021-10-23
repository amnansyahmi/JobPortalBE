using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_ERROR
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int16 MODULE_ID { get; set; }
        public string INFO_CODE { get; set; }
        public string INFO_DESCRIPTION { get; set; }
        public Int16 CONFIG_STATUS { get; set; }
        public Int16 CONFIG_SEQ { get; set; }
        public Int16 CONFIG_LANGUAGE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public String CONFIG_STATUS_DESC { get; set; }
    }

    [Table("PARAM_ERROR")]
    public class _PARAM_ERROR
    {
        public _PARAM_ERROR()
        {
        }

        public _PARAM_ERROR(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            MODULE_ID = 0;
            INFO_CODE = "";
            INFO_DESCRIPTION = "";
            CONFIG_STATUS = 0;
            CONFIG_SEQ = 0;
            CONFIG_LANGUAGE = 0;
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
        public Int16 MODULE_ID { get; set; }

        [Key, Column(Order = 3)]
        public string INFO_CODE { get; set; }

        public string INFO_DESCRIPTION { get; set; }
        public Int16 CONFIG_STATUS { get; set; }
        public Int16 CONFIG_SEQ { get; set; }
        public Int16 CONFIG_LANGUAGE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public String CONFIG_STATUS_DESC { get; set; }
    }
}