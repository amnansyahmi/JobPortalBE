using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class SETTING_ORG
    {
        public string orgId { get; set; }
        public string orgName { get; set; }
        public DateTime? createdDt { get; set; }
        public DateTime? licenseExpDt { get; set; }
    }

    [Table("SETTING_ORG")]
    public class _SETTING_ORG
    {
        public _SETTING_ORG()
        {
        }

        public _SETTING_ORG(bool setDefaultValue)
        {
            orgId = "";
            orgName = "";
            DateTime createdDt = new DateTime();
            DateTime licenseExpDt = new DateTime();
        }

        [Key, Column(Order = 1)]
        public string orgId { get; set; }

        public string orgName { get; set; }
        public DateTime? createdDt { get; set; }
        public DateTime? licenseExpDt { get; set; }
    }
}