using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class CONFIG_WF_TMDTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 WF_ID { get; set; }
        public Int32? WF_LEVEL { get; set; }
        public Int32? WF_SOURCE { get; set; }
        public string WF_DESCRIPTION { get; set; }
        public Int32? WF_FILTER_STATUS { get; set; }
        public Int32? WF_STATUS { get; set; }
        public Int32? WF_BYPASS { get; set; }
        public Int32? WF_SKIP_LEVEL { get; set; }
        public Int32? WF_RPT_DRAFT { get; set; }
        public Int32? WF_RPT_MANDATORY { get; set; }
        public string BTN1_NAME { get; set; }
        public Int32? BTN1_STATUS { get; set; }
        public Int32? BTN1_ALLOW_MONITORING { get; set; }
        public Int32? BTN1_ALLOW_REASSIGN { get; set; }
        public Int32? BTN1_ALLOW_SKIP { get; set; }
        public Int32? BTN1_ALLOW_REWORK { get; set; }
        public Int32? BTN1_REWORK_STATUS { get; set; }
        public Int32? BTN1_ALLOW_REVIEW { get; set; }
        public Int32? BTN1_REVIEW_STATUS { get; set; }
        public Int32? BTN1_ALLOW_REOPEN { get; set; }
        public Int32? BTN1_REOPEN_STATUS { get; set; }
        public Int32? BTN1_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN1_ALLOW_STR { get; set; }
        public Int32? BTN1_STR_REPORT { get; set; }
        public Int32? BTN1_STR_FIELD1 { get; set; }
        public Int32? BTN1_STR_FIELD2 { get; set; }
        public Int32? BTN1_ALLOW_PEP { get; set; }
        public Int32? BTN1_PEP_FIELD1 { get; set; }
        public Int32? BTN1_PEP_FIELD2 { get; set; }
        public Int32? BTN1_EMAIL_TYPE { get; set; }
        public Int32? BTN1_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN1_ALLOW_JobPortalC { get; set; }
        public Int32? BTN1_JobPortalC_STATUS { get; set; }
        public Int32? BTN1_JobPortalC_APPOVAL { get; set; }
        public string BTN2_NAME { get; set; }
        public Int32? BTN2_STATUS { get; set; }
        public Int32? BTN2_ALLOW_MONITORING { get; set; }
        public Int32? BTN2_ALLOW_REASSIGN { get; set; }
        public Int32? BTN2_ALLOW_SKIP { get; set; }
        public Int32? BTN2_ALLOW_REWORK { get; set; }
        public Int32? BTN2_REWORK_STATUS { get; set; }
        public Int32? BTN2_ALLOW_REVIEW { get; set; }
        public Int32? BTN2_REVIEW_STATUS { get; set; }
        public Int32? BTN2_ALLOW_REOPEN { get; set; }
        public Int32? BTN2_REOPEN_STATUS { get; set; }
        public Int32? BTN2_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN2_ALLOW_STR { get; set; }
        public Int32? BTN2_STR_REPORT { get; set; }
        public Int32? BTN2_STR_FIELD1 { get; set; }
        public Int32? BTN2_STR_FIELD2 { get; set; }
        public Int32? BTN2_ALLOW_PEP { get; set; }
        public Int32? BTN2_PEP_FIELD1 { get; set; }
        public Int32? BTN2_PEP_FIELD2 { get; set; }
        public Int32? BTN2_EMAIL_TYPE { get; set; }
        public Int32? BTN2_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN2_ALLOW_JobPortalC { get; set; }
        public Int32? BTN2_JobPortalC_STATUS { get; set; }
        public Int32? BTN2_JobPortalC_APPOVAL { get; set; }
        public string BTN3_NAME { get; set; }
        public Int32? BTN3_STATUS { get; set; }
        public Int32? BTN3_ALLOW_MONITORING { get; set; }
        public Int32? BTN3_ALLOW_REASSIGN { get; set; }
        public Int32? BTN3_ALLOW_SKIP { get; set; }
        public Int32? BTN3_ALLOW_REWORK { get; set; }
        public Int32? BTN3_REWORK_STATUS { get; set; }
        public Int32? BTN3_ALLOW_REVIEW { get; set; }
        public Int32? BTN3_REVIEW_STATUS { get; set; }
        public Int32? BTN3_ALLOW_REOPEN { get; set; }
        public Int32? BTN3_REOPEN_STATUS { get; set; }
        public Int32? BTN3_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN3_ALLOW_STR { get; set; }
        public Int32? BTN3_STR_REPORT { get; set; }
        public Int32? BTN3_STR_FIELD1 { get; set; }
        public Int32? BTN3_STR_FIELD2 { get; set; }
        public Int32? BTN3_ALLOW_PEP { get; set; }
        public Int32? BTN3_PEP_FIELD1 { get; set; }
        public Int32? BTN3_PEP_FIELD2 { get; set; }
        public Int32? BTN3_EMAIL_TYPE { get; set; }
        public Int32? BTN3_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN3_ALLOW_JobPortalC { get; set; }
        public Int32? BTN3_JobPortalC_STATUS { get; set; }
        public Int32? BTN3_JobPortalC_APPOVAL { get; set; }
        public string BTN4_NAME { get; set; }
        public Int32? BTN4_STATUS { get; set; }
        public Int32? BTN4_ALLOW_MONITORING { get; set; }
        public Int32? BTN4_ALLOW_REASSIGN { get; set; }
        public Int32? BTN4_ALLOW_SKIP { get; set; }
        public Int32? BTN4_ALLOW_REWORK { get; set; }
        public Int32? BTN4_REWORK_STATUS { get; set; }
        public Int32? BTN4_ALLOW_REVIEW { get; set; }
        public Int32? BTN4_REVIEW_STATUS { get; set; }
        public Int32? BTN4_ALLOW_REOPEN { get; set; }
        public Int32? BTN4_REOPEN_STATUS { get; set; }
        public Int32? BTN4_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN4_ALLOW_STR { get; set; }
        public Int32? BTN4_STR_REPORT { get; set; }
        public Int32? BTN4_STR_FIELD1 { get; set; }
        public Int32? BTN4_STR_FIELD2 { get; set; }
        public Int32? BTN4_ALLOW_PEP { get; set; }
        public Int32? BTN4_PEP_FIELD1 { get; set; }
        public Int32? BTN4_PEP_FIELD2 { get; set; }
        public Int32? BTN4_EMAIL_TYPE { get; set; }
        public Int32? BTN4_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN4_ALLOW_JobPortalC { get; set; }
        public Int32? BTN4_JobPortalC_STATUS { get; set; }
        public Int32? BTN4_JobPortalC_APPOVAL { get; set; }
        public string BTN5_NAME { get; set; }
        public Int32? BTN5_STATUS { get; set; }
        public Int32? BTN5_ALLOW_MONITORING { get; set; }
        public Int32? BTN5_ALLOW_REASSIGN { get; set; }
        public Int32? BTN5_ALLOW_SKIP { get; set; }
        public Int32? BTN5_ALLOW_REWORK { get; set; }
        public Int32? BTN5_REWORK_STATUS { get; set; }
        public Int32? BTN5_ALLOW_REVIEW { get; set; }
        public Int32? BTN5_REVIEW_STATUS { get; set; }
        public Int32? BTN5_ALLOW_REOPEN { get; set; }
        public Int32? BTN5_REOPEN_STATUS { get; set; }
        public Int32? BTN5_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN5_ALLOW_STR { get; set; }
        public Int32? BTN5_STR_REPORT { get; set; }
        public Int32? BTN5_STR_FIELD1 { get; set; }
        public Int32? BTN5_STR_FIELD2 { get; set; }
        public Int32? BTN5_ALLOW_PEP { get; set; }
        public Int32? BTN5_PEP_FIELD1 { get; set; }
        public Int32? BTN5_PEP_FIELD2 { get; set; }
        public Int32? BTN5_EMAIL_TYPE { get; set; }
        public Int32? BTN5_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN5_ALLOW_JobPortalC { get; set; }
        public Int32? BTN5_JobPortalC_STATUS { get; set; }
        public Int32? BTN5_JobPortalC_APPOVAL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("CONFIG_WF_TMDTL")]
    public class _CONFIG_WF_TMDTL
    {
        public _CONFIG_WF_TMDTL()
        {
        }

        public _CONFIG_WF_TMDTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            WF_ID = 0;
            WF_LEVEL = 0;
            WF_SOURCE = 0;
            WF_DESCRIPTION = "";
            WF_FILTER_STATUS = 0;
            WF_STATUS = 0;
            WF_BYPASS = 0;
            WF_SKIP_LEVEL = 0;
            WF_RPT_DRAFT = 0;
            WF_RPT_MANDATORY = 0;
            BTN1_NAME = "";
            BTN1_STATUS = 0;
            BTN1_ALLOW_MONITORING = 0;
            BTN1_ALLOW_REASSIGN = 0;
            BTN1_ALLOW_SKIP = 0;
            BTN1_ALLOW_REWORK = 0;
            BTN1_REWORK_STATUS = 0;
            BTN1_ALLOW_REVIEW = 0;
            BTN1_REVIEW_STATUS = 0;
            BTN1_ALLOW_REOPEN = 0;
            BTN1_REOPEN_STATUS = 0;
            BTN1_REOPEN_TEMPLATE = 0;
            BTN1_ALLOW_STR = 0;
            BTN1_STR_REPORT = 0;
            BTN1_STR_FIELD1 = 0;
            BTN1_STR_FIELD2 = 0;
            BTN1_ALLOW_PEP = 0;
            BTN1_PEP_FIELD1 = 0;
            BTN1_PEP_FIELD2 = 0;
            BTN1_EMAIL_TYPE = 0;
            BTN1_EMAIL_TEMPLATE = 0;
            BTN1_ALLOW_JobPortalC = 0;
            BTN1_JobPortalC_STATUS = 0;
            BTN1_JobPortalC_APPOVAL = 0;
            BTN2_NAME = "";
            BTN2_STATUS = 0;
            BTN2_ALLOW_MONITORING = 0;
            BTN2_ALLOW_REASSIGN = 0;
            BTN2_ALLOW_SKIP = 0;
            BTN2_ALLOW_REWORK = 0;
            BTN2_REWORK_STATUS = 0;
            BTN2_ALLOW_REVIEW = 0;
            BTN2_REVIEW_STATUS = 0;
            BTN2_ALLOW_REOPEN = 0;
            BTN2_REOPEN_STATUS = 0;
            BTN2_REOPEN_TEMPLATE = 0;
            BTN2_ALLOW_STR = 0;
            BTN2_STR_REPORT = 0;
            BTN2_STR_FIELD1 = 0;
            BTN2_STR_FIELD2 = 0;
            BTN2_ALLOW_PEP = 0;
            BTN2_PEP_FIELD1 = 0;
            BTN2_PEP_FIELD2 = 0;
            BTN2_EMAIL_TYPE = 0;
            BTN2_EMAIL_TEMPLATE = 0;
            BTN2_ALLOW_JobPortalC = 0;
            BTN2_JobPortalC_STATUS = 0;
            BTN2_JobPortalC_APPOVAL = 0;
            BTN3_NAME = "";
            BTN3_STATUS = 0;
            BTN3_ALLOW_MONITORING = 0;
            BTN3_ALLOW_REASSIGN = 0;
            BTN3_ALLOW_SKIP = 0;
            BTN3_ALLOW_REWORK = 0;
            BTN3_REWORK_STATUS = 0;
            BTN3_ALLOW_REVIEW = 0;
            BTN3_REVIEW_STATUS = 0;
            BTN3_ALLOW_REOPEN = 0;
            BTN3_REOPEN_STATUS = 0;
            BTN3_REOPEN_TEMPLATE = 0;
            BTN3_ALLOW_STR = 0;
            BTN3_STR_REPORT = 0;
            BTN3_STR_FIELD1 = 0;
            BTN3_STR_FIELD2 = 0;
            BTN3_ALLOW_PEP = 0;
            BTN3_PEP_FIELD1 = 0;
            BTN3_PEP_FIELD2 = 0;
            BTN3_EMAIL_TYPE = 0;
            BTN3_EMAIL_TEMPLATE = 0;
            BTN3_ALLOW_JobPortalC = 0;
            BTN3_JobPortalC_STATUS = 0;
            BTN3_JobPortalC_APPOVAL = 0;
            BTN4_NAME = "";
            BTN4_STATUS = 0;
            BTN4_ALLOW_MONITORING = 0;
            BTN4_ALLOW_REASSIGN = 0;
            BTN4_ALLOW_SKIP = 0;
            BTN4_ALLOW_REWORK = 0;
            BTN4_REWORK_STATUS = 0;
            BTN4_ALLOW_REVIEW = 0;
            BTN4_REVIEW_STATUS = 0;
            BTN4_ALLOW_REOPEN = 0;
            BTN4_REOPEN_STATUS = 0;
            BTN4_REOPEN_TEMPLATE = 0;
            BTN4_ALLOW_STR = 0;
            BTN4_STR_REPORT = 0;
            BTN4_STR_FIELD1 = 0;
            BTN4_STR_FIELD2 = 0;
            BTN4_ALLOW_PEP = 0;
            BTN4_PEP_FIELD1 = 0;
            BTN4_PEP_FIELD2 = 0;
            BTN4_EMAIL_TYPE = 0;
            BTN4_EMAIL_TEMPLATE = 0;
            BTN4_ALLOW_JobPortalC = 0;
            BTN4_JobPortalC_STATUS = 0;
            BTN4_JobPortalC_APPOVAL = 0;
            BTN5_NAME = "";
            BTN5_STATUS = 0;
            BTN5_ALLOW_MONITORING = 0;
            BTN5_ALLOW_REASSIGN = 0;
            BTN5_ALLOW_SKIP = 0;
            BTN5_ALLOW_REWORK = 0;
            BTN5_REWORK_STATUS = 0;
            BTN5_ALLOW_REVIEW = 0;
            BTN5_REVIEW_STATUS = 0;
            BTN5_ALLOW_REOPEN = 0;
            BTN5_REOPEN_STATUS = 0;
            BTN5_REOPEN_TEMPLATE = 0;
            BTN5_ALLOW_STR = 0;
            BTN5_STR_REPORT = 0;
            BTN5_STR_FIELD1 = 0;
            BTN5_STR_FIELD2 = 0;
            BTN5_ALLOW_PEP = 0;
            BTN5_PEP_FIELD1 = 0;
            BTN5_PEP_FIELD2 = 0;
            BTN5_EMAIL_TYPE = 0;
            BTN5_EMAIL_TEMPLATE = 0;
            BTN5_ALLOW_JobPortalC = 0;
            BTN5_JobPortalC_STATUS = 0;
            BTN5_JobPortalC_APPOVAL = 0;
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 0)]
        public Int32 WF_ID { get; set; }

        [Key, Column(Order = 1)]
        public Int32? WF_LEVEL { get; set; }

        public Int32? WF_SOURCE { get; set; }
        public string WF_DESCRIPTION { get; set; }
        public Int32? WF_FILTER_STATUS { get; set; }
        public Int32? WF_STATUS { get; set; }
        public Int32? WF_BYPASS { get; set; }
        public Int32? WF_SKIP_LEVEL { get; set; }
        public Int32? WF_RPT_DRAFT { get; set; }
        public Int32? WF_RPT_MANDATORY { get; set; }
        public string BTN1_NAME { get; set; }
        public Int32? BTN1_STATUS { get; set; }
        public Int32? BTN1_ALLOW_MONITORING { get; set; }
        public Int32? BTN1_ALLOW_REASSIGN { get; set; }
        public Int32? BTN1_ALLOW_SKIP { get; set; }
        public Int32? BTN1_ALLOW_REWORK { get; set; }
        public Int32? BTN1_REWORK_STATUS { get; set; }
        public Int32? BTN1_ALLOW_REVIEW { get; set; }
        public Int32? BTN1_REVIEW_STATUS { get; set; }
        public Int32? BTN1_ALLOW_REOPEN { get; set; }
        public Int32? BTN1_REOPEN_STATUS { get; set; }
        public Int32? BTN1_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN1_ALLOW_STR { get; set; }
        public Int32? BTN1_STR_REPORT { get; set; }
        public Int32? BTN1_STR_FIELD1 { get; set; }
        public Int32? BTN1_STR_FIELD2 { get; set; }
        public Int32? BTN1_ALLOW_PEP { get; set; }
        public Int32? BTN1_PEP_FIELD1 { get; set; }
        public Int32? BTN1_PEP_FIELD2 { get; set; }
        public Int32? BTN1_EMAIL_TYPE { get; set; }
        public Int32? BTN1_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN1_ALLOW_JobPortalC { get; set; }
        public Int32? BTN1_JobPortalC_STATUS { get; set; }
        public Int32? BTN1_JobPortalC_APPOVAL { get; set; }
        public string BTN2_NAME { get; set; }
        public Int32? BTN2_STATUS { get; set; }
        public Int32? BTN2_ALLOW_MONITORING { get; set; }
        public Int32? BTN2_ALLOW_REASSIGN { get; set; }
        public Int32? BTN2_ALLOW_SKIP { get; set; }
        public Int32? BTN2_ALLOW_REWORK { get; set; }
        public Int32? BTN2_REWORK_STATUS { get; set; }
        public Int32? BTN2_ALLOW_REVIEW { get; set; }
        public Int32? BTN2_REVIEW_STATUS { get; set; }
        public Int32? BTN2_ALLOW_REOPEN { get; set; }
        public Int32? BTN2_REOPEN_STATUS { get; set; }
        public Int32? BTN2_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN2_ALLOW_STR { get; set; }
        public Int32? BTN2_STR_REPORT { get; set; }
        public Int32? BTN2_STR_FIELD1 { get; set; }
        public Int32? BTN2_STR_FIELD2 { get; set; }
        public Int32? BTN2_ALLOW_PEP { get; set; }
        public Int32? BTN2_PEP_FIELD1 { get; set; }
        public Int32? BTN2_PEP_FIELD2 { get; set; }
        public Int32? BTN2_EMAIL_TYPE { get; set; }
        public Int32? BTN2_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN2_ALLOW_JobPortalC { get; set; }
        public Int32? BTN2_JobPortalC_STATUS { get; set; }
        public Int32? BTN2_JobPortalC_APPOVAL { get; set; }
        public string BTN3_NAME { get; set; }
        public Int32? BTN3_STATUS { get; set; }
        public Int32? BTN3_ALLOW_MONITORING { get; set; }
        public Int32? BTN3_ALLOW_REASSIGN { get; set; }
        public Int32? BTN3_ALLOW_SKIP { get; set; }
        public Int32? BTN3_ALLOW_REWORK { get; set; }
        public Int32? BTN3_REWORK_STATUS { get; set; }
        public Int32? BTN3_ALLOW_REVIEW { get; set; }
        public Int32? BTN3_REVIEW_STATUS { get; set; }
        public Int32? BTN3_ALLOW_REOPEN { get; set; }
        public Int32? BTN3_REOPEN_STATUS { get; set; }
        public Int32? BTN3_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN3_ALLOW_STR { get; set; }
        public Int32? BTN3_STR_REPORT { get; set; }
        public Int32? BTN3_STR_FIELD1 { get; set; }
        public Int32? BTN3_STR_FIELD2 { get; set; }
        public Int32? BTN3_ALLOW_PEP { get; set; }
        public Int32? BTN3_PEP_FIELD1 { get; set; }
        public Int32? BTN3_PEP_FIELD2 { get; set; }
        public Int32? BTN3_EMAIL_TYPE { get; set; }
        public Int32? BTN3_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN3_ALLOW_JobPortalC { get; set; }
        public Int32? BTN3_JobPortalC_STATUS { get; set; }
        public Int32? BTN3_JobPortalC_APPOVAL { get; set; }
        public string BTN4_NAME { get; set; }
        public Int32? BTN4_STATUS { get; set; }
        public Int32? BTN4_ALLOW_MONITORING { get; set; }
        public Int32? BTN4_ALLOW_REASSIGN { get; set; }
        public Int32? BTN4_ALLOW_SKIP { get; set; }
        public Int32? BTN4_ALLOW_REWORK { get; set; }
        public Int32? BTN4_REWORK_STATUS { get; set; }
        public Int32? BTN4_ALLOW_REVIEW { get; set; }
        public Int32? BTN4_REVIEW_STATUS { get; set; }
        public Int32? BTN4_ALLOW_REOPEN { get; set; }
        public Int32? BTN4_REOPEN_STATUS { get; set; }
        public Int32? BTN4_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN4_ALLOW_STR { get; set; }
        public Int32? BTN4_STR_REPORT { get; set; }
        public Int32? BTN4_STR_FIELD1 { get; set; }
        public Int32? BTN4_STR_FIELD2 { get; set; }
        public Int32? BTN4_ALLOW_PEP { get; set; }
        public Int32? BTN4_PEP_FIELD1 { get; set; }
        public Int32? BTN4_PEP_FIELD2 { get; set; }
        public Int32? BTN4_EMAIL_TYPE { get; set; }
        public Int32? BTN4_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN4_ALLOW_JobPortalC { get; set; }
        public Int32? BTN4_JobPortalC_STATUS { get; set; }
        public Int32? BTN4_JobPortalC_APPOVAL { get; set; }
        public string BTN5_NAME { get; set; }
        public Int32? BTN5_STATUS { get; set; }
        public Int32? BTN5_ALLOW_MONITORING { get; set; }
        public Int32? BTN5_ALLOW_REASSIGN { get; set; }
        public Int32? BTN5_ALLOW_SKIP { get; set; }
        public Int32? BTN5_ALLOW_REWORK { get; set; }
        public Int32? BTN5_REWORK_STATUS { get; set; }
        public Int32? BTN5_ALLOW_REVIEW { get; set; }
        public Int32? BTN5_REVIEW_STATUS { get; set; }
        public Int32? BTN5_ALLOW_REOPEN { get; set; }
        public Int32? BTN5_REOPEN_STATUS { get; set; }
        public Int32? BTN5_REOPEN_TEMPLATE { get; set; }
        public Int32? BTN5_ALLOW_STR { get; set; }
        public Int32? BTN5_STR_REPORT { get; set; }
        public Int32? BTN5_STR_FIELD1 { get; set; }
        public Int32? BTN5_STR_FIELD2 { get; set; }
        public Int32? BTN5_ALLOW_PEP { get; set; }
        public Int32? BTN5_PEP_FIELD1 { get; set; }
        public Int32? BTN5_PEP_FIELD2 { get; set; }
        public Int32? BTN5_EMAIL_TYPE { get; set; }
        public Int32? BTN5_EMAIL_TEMPLATE { get; set; }
        public Int32? BTN5_ALLOW_JobPortalC { get; set; }
        public Int32? BTN5_JobPortalC_STATUS { get; set; }
        public Int32? BTN5_JobPortalC_APPOVAL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}