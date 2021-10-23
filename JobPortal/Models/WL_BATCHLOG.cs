using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class WL_BATCHLOG
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 JOB_ID { get; set; }
        public Int16 UPLOAD_TYPE { get; set; }
        public string UPLOAD_SOURCE { get; set; }
        public string UPLOAD_FILE_NAME { get; set; }
        public Int32 UPLOAD_FILE_SIZE { get; set; }
        public string RESULT_FILE_NAME { get; set; }
        public Int32 RESULT_FILE_SIZE { get; set; }
        public Int32 TOTAL_PROCESSED { get; set; }
        public Int32 TOTAL_RECORD { get; set; }
        public Int32 TOTAL_HIT { get; set; }
        public Int16 STATUS { get; set; }
        public string MESSAGE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string STATUS_DESC { get; set; }
        public Int32 ACTIVE { get; set; }
        public string UPLOAD_TYPE_DESC { get; set; }
    }

    [Table("WL_BATCHLOG")]
    public class _WL_BATCHLOG
    {
        public _WL_BATCHLOG()
        {
        }

        public _WL_BATCHLOG(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            JOB_ID = 0;
            UPLOAD_TYPE = 0;
            UPLOAD_SOURCE = "";
            UPLOAD_FILE_NAME = "";
            UPLOAD_FILE_SIZE = 0;
            RESULT_FILE_NAME = "";
            RESULT_FILE_SIZE = 0;
            TOTAL_PROCESSED = 0;
            TOTAL_RECORD = 0;
            TOTAL_HIT = 0;
            STATUS = 0;
            MESSAGE = "";
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_USER = "";
            ACTIVE = 1;
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 JOB_ID { get; set; }

        public Int16 UPLOAD_TYPE { get; set; }
        public string UPLOAD_SOURCE { get; set; }
        public string UPLOAD_FILE_NAME { get; set; }
        public Int32 UPLOAD_FILE_SIZE { get; set; }
        public string RESULT_FILE_NAME { get; set; }
        public Int32 RESULT_FILE_SIZE { get; set; }
        public Int32 TOTAL_PROCESSED { get; set; }
        public Int32 TOTAL_RECORD { get; set; }
        public Int32 TOTAL_HIT { get; set; }
        public Int16 STATUS { get; set; }
        public string MESSAGE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public Int32 ACTIVE { get; set; }
    }
}