using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_LOCATION
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string LOC_CODE { get; set; }
        public string LOC_SHORT { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_DESC { get; set; }
        public string MAIL_GROUP { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("PARAM_LOCATION")]
    public class _PARAM_LOCATION
    {
        public _PARAM_LOCATION()
        {
        }

        public _PARAM_LOCATION(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            LOC_CODE = "";
            LOC_SHORT = "";
            LOC_NAME = "";
            LOC_DESC = "";
            MAIL_GROUP = "";
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 1)]
        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }
        public string LOC_CODE { get; set; }
        public string LOC_SHORT { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_DESC { get; set; }
        public string MAIL_GROUP { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}