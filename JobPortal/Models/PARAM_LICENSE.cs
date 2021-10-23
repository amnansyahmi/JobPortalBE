using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_LICENSE
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string NAME_COMP { get; set; }
        public string NAME_ORG { get; set; }
        public Int32 DATE_VALID_TO { get; set; }
        public Int32 DATE_VALID_FROM { get; set; }
        public Int16 DATE_GRACE { get; set; }
        public string KEY_LICENSE { get; set; }
        public string KEY_VALIDATOR { get; set; }
        public string KEY_DB_NAME { get; set; }
        public string INFO_REG_NO { get; set; }
        public string INFO_MODULES { get; set; }
        public Int32 KEY_TYPE { get; set; }
        public Int32 KEY_USERS { get; set; }
        public Int32 STATUS_LICENSE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("PARAM_LICENSE")]
    public class _PARAM_LICENSE
    {
        public _PARAM_LICENSE()
        {
        }

        public _PARAM_LICENSE(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            NAME_COMP = "";
            NAME_ORG = "";
            DATE_VALID_TO = 0;
            DATE_VALID_FROM = 0;
            DATE_GRACE = 0;
            KEY_LICENSE = "";
            KEY_VALIDATOR = "";
            KEY_DB_NAME = "";
            INFO_REG_NO = "";
            INFO_MODULES = "";
            KEY_TYPE = 0;
            KEY_USERS = 0;
            STATUS_LICENSE = 0;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_USER = "";
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        public string NAME_COMP { get; set; }
        public string NAME_ORG { get; set; }
        public Int32 DATE_VALID_TO { get; set; }
        public Int32 DATE_VALID_FROM { get; set; }
        public Int16 DATE_GRACE { get; set; }
        public string KEY_LICENSE { get; set; }
        public string KEY_VALIDATOR { get; set; }
        public string KEY_DB_NAME { get; set; }
        public string INFO_REG_NO { get; set; }
        public string INFO_MODULES { get; set; }
        public Int32 KEY_TYPE { get; set; }
        public Int32 KEY_USERS { get; set; }
        public Int32 STATUS_LICENSE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}