using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class SETTING_RFLAGROUTE
    {
        public string masterRouteId { get; set; }
        public string rflagrouteName { get; set; }
        public string rflagrouteStatus { get; set; }
    }

    [Table("SETTING_RFLAGROUTE")]
    public class _SETTING_RFLAGROUTE
    {
        public _SETTING_RFLAGROUTE()
        {
        }

        public _SETTING_RFLAGROUTE(bool setDefaultValue)
        {
            masterRouteId = "";
            rflagrouteName = "";
            rflagrouteStatus = "";
        }

        [Key, Column(Order = 1)]
        public string masterRouteId { get; set; }

        public string rflagrouteName { get; set; }
        public string rflagrouteStatus { get; set; }
    }
}