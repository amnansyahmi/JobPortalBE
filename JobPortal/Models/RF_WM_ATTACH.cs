using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_WM_ATTACH
    {
        public Int32 CODE_SEQ { get; set; }
        public Int32? CODE_COMP { get; set; }
        public Int32? CODE_ORG { get; set; }
        public Int64? RF_ID { get; set; }
        public Int32? CASE_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public string FILE_ENCODE { get; set; }
    }

    [Table("RF_WM_ATTACH")]
    public class _RF_WM_ATTACH
    {
        public _RF_WM_ATTACH()
        {
        }

        public _RF_WM_ATTACH(bool setDefaultValue)
        {
            CODE_SEQ = 0;
            CODE_COMP = 0;
            CODE_ORG = 0;
            RF_ID = 0;
            CASE_ID = 0;
            FILE_NAME = "";
            FILE_PATH = "";
            AUDIT_CREATED_DATE = DateTime.Now;
            AUDIT_CREATED_USER = "";
            FILE_ENCODE = "";
        }

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 CODE_SEQ { get; set; }

        public Int32? CODE_COMP { get; set; }
        public Int32? CODE_ORG { get; set; }
        public Int64? RF_ID { get; set; }
        public Int32? CASE_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public string FILE_ENCODE { get; set; }
    }
}