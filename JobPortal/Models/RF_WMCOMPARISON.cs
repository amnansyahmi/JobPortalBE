using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_WMCOMPARISON
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public string ENTITY_ID { get; set; }
        public string COMPARISON_DATA { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
    }

    [Table("RF_WMCOMPARISON")]
    public class _RF_WMCOMPARISON
    {
        public _RF_WMCOMPARISON()
        {
        }

        public _RF_WMCOMPARISON(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            RF_ID = 0;
            ENTITY_ID = "";
            COMPARISON_DATA = "";
            AUDIT_CREATED_USER = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int64 RF_ID { get; set; }

        public string ENTITY_ID { get; set; }
        public string COMPARISON_DATA { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
    }
}