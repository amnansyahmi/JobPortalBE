using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_ROUTE
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public string ROUTE_DESC { get; set; }
        public string ROUTE_LIST { get; set; }
        public Int16 CONFIG_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATE_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public String CONFIG_STATUS_DESC { get; set; }
    }

    [Table("PARAM_ROUTE")]
    public class _PARAM_ROUTE
    {
        public _PARAM_ROUTE()
        {
        }

        public _PARAM_ROUTE(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            ROUTE_CODE = "";
            ROUTE_NAME = "";
            ROUTE_DESC = "";
            ROUTE_LIST = "";
            CONFIG_STATUS = 0;
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATE_DATE = null;
            AUDIT_UPDATED_USER = "";
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public string ROUTE_CODE { get; set; }

        public string ROUTE_NAME { get; set; }
        public string ROUTE_DESC { get; set; }
        public string ROUTE_LIST { get; set; }
        public Int16 CONFIG_STATUS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATE_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        //public String CONFIG_STATUS_DESC { get; set; }
    }
}