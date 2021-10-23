using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CONFIG_JOB_STEP
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string JOB_ID { get; set; }
        public Int32 STEP_ID { get; set; }
        public string STEP_NAME { get; set; }
        public Int32 STEP_ORDER { get; set; }
        public string PROG_ARGUMENT { get; set; }
        public string PROG_NAME { get; set; }
        public Int32 PROCESS_STATUS { get; set; }
        public Int32 STEP_STATUS { get; set; }
        public Int32 PROCESS_PERCENT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("CONFIG_JOB_STEP")]
    public class _CONFIG_JOB_STEP
    {
        public _CONFIG_JOB_STEP()
        {
        }

        public _CONFIG_JOB_STEP(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            JOB_ID = "";
            STEP_ID = 0;
            STEP_NAME = "";
            STEP_ORDER = 0;
            PROG_ARGUMENT = "";
            PROG_NAME = "";
            PROCESS_STATUS = 0;
            STEP_STATUS = 0;
            PROCESS_PERCENT = 0;
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
        public Int32 STEP_ID { get; set; }

        public string STEP_NAME { get; set; }
        public Int32 STEP_ORDER { get; set; }
        public string PROG_ARGUMENT { get; set; }
        public string PROG_NAME { get; set; }
        public Int32 PROCESS_STATUS { get; set; }
        public Int32 STEP_STATUS { get; set; }
        public Int32 PROCESS_PERCENT { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}