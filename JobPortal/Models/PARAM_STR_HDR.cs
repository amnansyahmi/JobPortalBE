using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_STR_HDR
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 STR_ID { get; set; }
        public string STR_NAME { get; set; }
        public Int32 STR_COUNTRY { get; set; }
        public Int32 STR_TYPE { get; set; }
        public Int32 STR_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string STR_STATUS_DESC { get; set; }
        public string STR_COUNTRY_DESC { get; set; }
        public string STR_TYPE_DESC { get; set; }
    }

    [Table("PARAM_STR_HDR")]
    public class _PARAM_STR_HDR
    {
        public _PARAM_STR_HDR()
        {
        }

        public _PARAM_STR_HDR(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            STR_ID = 0;
            STR_NAME = "";
            STR_COUNTRY = 0;
            STR_TYPE = 0;
            STR_STATUS = 0;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 STR_ID { get; set; }

        public string STR_NAME { get; set; }
        public Int32 STR_COUNTRY { get; set; }
        public Int32 STR_TYPE { get; set; }
        public Int32 STR_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}