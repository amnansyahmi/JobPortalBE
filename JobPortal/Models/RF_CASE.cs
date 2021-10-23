using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_CASE
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 CASE_ID { get; set; }
        public String NO_MASTER { get; set; }
        public String NO_CIF { get; set; }
        public Int32? CASE_STATUS { get; set; }
        public Int32? CASE_SUB_STATUS { get; set; }

        [NotMapped]
        public Int32? CASE_OS { get; set; }

        [NotMapped]
        public String STATUS_DESC { get; set; }

        [NotMapped]
        public String SUB_STATUS_DESC { get; set; }

        public String AUDIT_USER { get; set; }

        [NotMapped]
        public String USER_NAME { get; set; }

        public Int32? AUDIT_USER_LEVEL { get; set; }
        public Int32? CASE_LEVEL { get; set; }
        public Int32? MODULE_ID { get; set; }
        public DateTime? AUDIT_DATE_UPDATED { get; set; }
        public DateTime? AUDIT_DATE_CREATED { get; set; }

        //from getrfcaseselect
        public string WF_DESCRIPTION { get; set; }

        //FOR DASHBOARD
        [NotMapped]
        public Int32? NONE { get; set; }

        [NotMapped]
        public Int32? UNASSIGN { get; set; }

        [NotMapped]
        public Int32? INPROGRESS { get; set; }

        [NotMapped]
        public Int32? CLOSED { get; set; }

        [NotMapped]
        public Int32? PICKUP { get; set; }

        [NotMapped]
        public Int32? DROPCASE { get; set; }

        [NotMapped]
        public Int32? APPROVEDROPCASE { get; set; }

        [NotMapped]
        public Int32? DRAFTEDCASE { get; set; }

        [NotMapped]
        public Int32? REVIEWEDCASE { get; set; }

        [NotMapped]
        public Int32? APPROVEDCASE { get; set; }

        [NotMapped]
        public Int32? REJECTCASE { get; set; }

        [NotMapped]
        public Int32? REWORKCASE { get; set; }

        [NotMapped]
        public Int32? REASSIGNCASE { get; set; }

        [NotMapped]
        public Int32? REOPENCASE { get; set; }

        [NotMapped]
        public Int32? WAITINGINFO { get; set; }

        [NotMapped]
        public Int32? REVIEWCASE { get; set; }

        [NotMapped]
        public string DATE_FILTER { get; set; }
    }

    [Table("RF_CASE")]
    public class _RF_CASE
    {
        public _RF_CASE()
        {
        }

        public _RF_CASE(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            CASE_ID = 0;
            NO_MASTER = "";
            NO_CIF = "";
            CASE_STATUS = 0;
            CASE_SUB_STATUS = 0;
            //STATUS_DESC = "" ;
            //CASE_OS = 0 ;
            AUDIT_USER = "";
            //USER_NAME = "" ;
            AUDIT_USER_LEVEL = 0;
            CASE_LEVEL = 0;
            MODULE_ID = 0;
            AUDIT_DATE_UPDATED = null;
            AUDIT_DATE_CREATED = null;
        }

        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 0)]
        public Int32 CASE_ID { get; set; }

        public String NO_MASTER { get; set; }
        public String NO_CIF { get; set; }
        public Int32? CASE_STATUS { get; set; }
        public Int32? CASE_SUB_STATUS { get; set; }

        //public String STATUS_DESC { get; set; }
        //public Int32? CASE_OS { get; set; }
        public String AUDIT_USER { get; set; }

        //public String USER_NAME { get; set; }
        public Int32? AUDIT_USER_LEVEL { get; set; }

        public Int32? CASE_LEVEL { get; set; }

        public Int32? MODULE_ID { get; set; }
        public DateTime? AUDIT_DATE_UPDATED { get; set; }
        public DateTime? AUDIT_DATE_CREATED { get; set; }

        [NotMapped]
        public Int32? CASE_OS { get; set; }

        [NotMapped]
        public String STATUS_DESC { get; set; }

        [NotMapped]
        public String SUB_STATUS_DESC { get; set; }
    }
}