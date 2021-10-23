using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class AUDIT_MASTER
    {
        public Int32? CODE_SEQ { get; set; }
        public Int32? CODE_COMP { get; set; }
        public Int32? CODE_ORG { get; set; }
        public Int32? AUDIT_DATE { get; set; }
        public DateTime? AUDIT_STAMPDT { get; set; }
        public string AUDIT_USER_ID { get; set; }
        public string AUDIT_TOKEN { get; set; }
        public Int32? AUDIT_MODULE { get; set; }
        public Int32? AUDIT_PAGE { get; set; }
        public Int32? AUDIT_ACTIVITY { get; set; }
        public string AUDIT_ACTIVITY_DESC { get; set; }
        public Int32? AUDIT_USER_TYPE { get; set; }
        public string MODULE_DESC { get; set; }
    }

    [Table("AUDIT_MASTER")]
    public class _AUDIT_MASTER
    {
        public _AUDIT_MASTER()
        {
        }

        public _AUDIT_MASTER(bool setDefaultValue)
        {
            CODE_SEQ = 0;
            CODE_COMP = 1;
            CODE_ORG = 1;
            AUDIT_DATE = 0;
            AUDIT_STAMPDT = DateTime.Now;
            //AUDIT_STAMPDT = null;
            AUDIT_USER_ID = "";
            AUDIT_TOKEN = "";
            AUDIT_MODULE = 0;
            AUDIT_PAGE = 0;
            AUDIT_ACTIVITY = 0;
            AUDIT_ACTIVITY_DESC = "";
            AUDIT_USER_TYPE = 1;
        }

        [Key, Column(Order = 0)]
        public Int32? CODE_SEQ { get; set; }

        public Int32? CODE_COMP { get; set; }
        public Int32? CODE_ORG { get; set; }
        public Int32? AUDIT_DATE { get; set; }
        public DateTime? AUDIT_STAMPDT { get; set; }
        public string AUDIT_USER_ID { get; set; }
        public string AUDIT_TOKEN { get; set; }
        public Int32? AUDIT_MODULE { get; set; }
        public Int32? AUDIT_PAGE { get; set; }
        public Int32? AUDIT_ACTIVITY { get; set; }
        public string AUDIT_ACTIVITY_DESC { get; set; }
        public Int32? AUDIT_USER_TYPE { get; set; }
    }
}