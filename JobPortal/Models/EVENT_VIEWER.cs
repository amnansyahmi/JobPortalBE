using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class EVENT_VIEWER
    {
        public Int32 id { get; set; }
        public Int16 comp_code { get; set; }
        public Int32 tran_date { get; set; }
        public string userid { get; set; }
        public string action { get; set; }
        public DateTime? access_date { get; set; }
        public string page_name { get; set; }
        public string room_name { get; set; }
        public string menu_name { get; set; }
    }

    [Table("EVENT_VIEWER")]
    public class _EVENT_VIEWER
    {
        public _EVENT_VIEWER()
        {
        }

        public _EVENT_VIEWER(bool setDefaultValue)
        {
            id = 0;
            comp_code = 0;
            tran_date = 0;
            userid = "";
            action = "";
            page_name = "";
            room_name = "";
            menu_name = "";
        }

        [Key, Column(Order = 1)]
        public Int32 id { get; set; }

        public Int16 comp_code { get; set; }
        public Int32 tran_date { get; set; }
        public string userid { get; set; }
        public string action { get; set; }
        public DateTime? access_date { get; set; }
        public string page_name { get; set; }
        public string room_name { get; set; }
        public string menu_name { get; set; }
    }
}