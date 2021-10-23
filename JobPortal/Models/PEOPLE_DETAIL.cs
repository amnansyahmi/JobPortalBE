using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PEOPLE_DETAIL
    {
        public string userId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Int16 userType { get; set; }
        public string location { get; set; }
        public Int16 userStatus { get; set; }
        public DateTime? lastActive { get; set; }
        public string authorize { get; set; }
    }

    [Table("PEOPLE_DETAIL")]
    public class _PEOPLE_DETAIL
    {
        public _PEOPLE_DETAIL()
        {
        }

        public _PEOPLE_DETAIL(bool setDefaultValue)
        {
            userId = "";
            name = "";
            email = "";
            userType = 0;
            location = "";
            userStatus = 0;
            DateTime lastActive = new DateTime();
            authorize = "";
        }

        [Key, Column(Order = 1)]
        public string userId { get; set; }

        public string name { get; set; }
        public string email { get; set; }
        public Int16 userType { get; set; }
        public string location { get; set; }
        public Int16 userStatus { get; set; }
        public DateTime? lastActive { get; set; }
        public string authorize { get; set; }
    }
}