using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class COR_MENU
    {
        public Int32 ID_MODULE { get; set; }
        public Int32 ID_MENU { get; set; }
        public String INFO_NAME { get; set; }
        public String INFO_LINK { get; set; }
        public Int32 FLAG_ENABLE { get; set; }
        public String INFO_VERSION { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public String AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_MODIFIED_DATE { get; set; }
        public String AUDIT_MODIFIED_USER { get; set; }
    }

    [Table("COR_MENU")]
    public class _COR_MENU
    {
        public _COR_MENU()
        {
        }

        public _COR_MENU(bool setDefaultValue)
        {
            ID_MODULE = 0;
            ID_MENU = 0;
            INFO_NAME = "";
            INFO_LINK = "";
            FLAG_ENABLE = 0;
            INFO_VERSION = "";
            AUDIT_CREATED_USER = "";
            AUDIT_MODIFIED_USER = "";
        }

        [Key, Column(Order = 1)]
        public Int32 ID_MODULE { get; set; }

        public Int32 ID_MENU { get; set; }
        public String INFO_NAME { get; set; }
        public String INFO_LINK { get; set; }
        public Int32 FLAG_ENABLE { get; set; }
        public String INFO_VERSION { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public String AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_MODIFIED_DATE { get; set; }
        public String AUDIT_MODIFIED_USER { get; set; }
    }
}