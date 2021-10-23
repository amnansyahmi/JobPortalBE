using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_MAPPING_HDR
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 MAP_ID_HDR { get; set; }
        public string MAP_DESC { get; set; }
        public string MAP_TABLE { get; set; }
        public Int32 MAP_PRODUCT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public Int32 CONFIG_STATUS { get; set; }
        public String CONFIG_STATUS_DESC { get; set; }
    }

    [Table("PARAM_MAPPING_HDR")]
    public class _PARAM_MAPPING_HDR
    {
        public _PARAM_MAPPING_HDR()
        {
        }

        public _PARAM_MAPPING_HDR(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            MAP_ID_HDR = 0;
            MAP_DESC = "";
            MAP_TABLE = "";
            MAP_PRODUCT = 0;
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
        public Int32 MAP_ID_HDR { get; set; }

        public string MAP_DESC { get; set; }
        public string MAP_TABLE { get; set; }
        public Int32 MAP_PRODUCT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public Int32 CONFIG_STATUS { get; set; }
    }
}