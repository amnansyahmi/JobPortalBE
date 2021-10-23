using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class SETTING_CANNED_RESPONSE
    {
        public string CRName { get; set; }
        public string CRTemplate { get; set; }
        public string CRModule { get; set; }
        public Int32 CRStatus { get; set; }
    }

    [Table("SETTING_CANNED_RESPONSE")]
    public class _SETTING_CANNED_RESPONSE
    {
        public _SETTING_CANNED_RESPONSE()
        {
        }

        public _SETTING_CANNED_RESPONSE(bool setDefaultValue)
        {
            CRName = "";
            CRTemplate = "";
            CRModule = "";
            CRStatus = 0;
        }

        [Key, Column(Order = 1)]
        public string CRName { get; set; }

        public string CRTemplate { get; set; }
        public string CRModule { get; set; }
        public Int32 CRStatus { get; set; }
    }
}