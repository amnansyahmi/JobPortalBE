using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class SETTING_AUTH_DOMAIN
    {
        public string domainName { get; set; }
        public string domainServerName { get; set; }
        public Int16 domainStatus { get; set; }
    }

    [Table("SETTING_AUTH_DOMAIN")]
    public class _SETTING_AUTH_DOMAIN
    {
        public _SETTING_AUTH_DOMAIN()
        {
        }

        public _SETTING_AUTH_DOMAIN(bool setDefaultValue)
        {
            domainName = "";
            domainServerName = "";
            domainStatus = 0;
        }

        [Key, Column(Order = 1)]
        public string domainName { get; set; }

        public string domainServerName { get; set; }
        public Int16 domainStatus { get; set; }
    }
}