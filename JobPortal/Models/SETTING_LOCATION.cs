using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class SETTING_LOCATION
    {
        public string locationName { get; set; }
        public string locationStatus { get; set; }
    }

    [Table("SETTING_LOCATION")]
    public class _SETTING_LOCATION
    {
        public _SETTING_LOCATION()
        {
        }

        public _SETTING_LOCATION(bool setDefaultValue)
        {
            locationName = "";
            locationStatus = "";
        }

        [Key, Column(Order = 1)]
        public string locationName { get; set; }

        public string locationStatus { get; set; }
    }
}