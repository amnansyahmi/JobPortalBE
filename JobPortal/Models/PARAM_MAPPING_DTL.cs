using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_MAPPING_DTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 MAP_ID_HDR { get; set; }
        public Int32 MAP_PRODUCT { get; set; }
        public Int32 MAP_ID_DTL { get; set; }
        public string MAP_TABLE_NAME { get; set; }
        public string MAP_FIELD_NAME { get; set; }
        public string MAP_FIELD_DESC { get; set; }
        public Int32? CONFIG_KYC { get; set; }
        public Int32? CONFIG_WATCHLIST { get; set; }
        public Int32 CONFIG_CODE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("PARAM_MAPPING_DTL")]
    public class _PARAM_MAPPING_DTL
    {
        public _PARAM_MAPPING_DTL()
        {
        }

        public _PARAM_MAPPING_DTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            MAP_ID_HDR = 0;
            MAP_PRODUCT = 0;
            MAP_ID_DTL = 0;
            MAP_TABLE_NAME = "";
            MAP_FIELD_NAME = "";
            MAP_FIELD_DESC = "";
            CONFIG_KYC = 0;
            CONFIG_WATCHLIST = 0;
            CONFIG_CODE = 0;
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
        public Int32 MAP_ID_HDR { get; set; }

        [Key, Column(Order = 3)]
        public Int32 MAP_PRODUCT { get; set; }

        [Key, Column(Order = 4)]
        public Int32 MAP_ID_DTL { get; set; }

        public string MAP_TABLE_NAME { get; set; }
        public string MAP_FIELD_NAME { get; set; }
        public string MAP_FIELD_DESC { get; set; }
        public Int32? CONFIG_KYC { get; set; }
        public Int32? CONFIG_WATCHLIST { get; set; }
        public Int32 CONFIG_CODE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}