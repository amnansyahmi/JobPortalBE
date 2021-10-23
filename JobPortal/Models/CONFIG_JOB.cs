using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CONFIG_JOB
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string JOB_ID { get; set; }
        public Int32 JOB_SEQ { get; set; }
        public string JOB_NAME { get; set; }
        public Int32 JOB_GROUP { get; set; }
        public Int32 JOB_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("CONFIG_JOB")]
    public class _CONFIG_JOB
    {
        public _CONFIG_JOB()
        {
        }

        public _CONFIG_JOB(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            JOB_ID = "";
            JOB_SEQ = 0;
            JOB_NAME = "";
            JOB_GROUP = 0;
            JOB_STATUS = 0;
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
        public string JOB_ID { get; set; }

        [Key, Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 JOB_SEQ { get; set; }

        public string JOB_NAME { get; set; }
        public Int32 JOB_GROUP { get; set; }
        public Int32 JOB_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}