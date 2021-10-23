using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class ES_ACCESS_TOKEN
    {
        public Int16? COMP_CODE { get; set; }
        public Int32 AUTO_SEQ_NO { get; set; }
        public string ACCESS_TOKEN { get; set; }
        public string EXPIRES_IN { get; set; }
        public string USERNAME { get; set; }
        public string CLIENT_ID { get; set; }
        public DateTime? ISSUED { get; set; }
        public DateTime? EXPIRES { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
    }

    [Table("ES_ACCESS_TOKEN")]
    public class _ES_ACCESS_TOKEN
    {
        public _ES_ACCESS_TOKEN()
        {
        }

        public _ES_ACCESS_TOKEN(bool setDefaultValue)
        {
            AUTO_SEQ_NO = 0;
            COMP_CODE = 0;
            ACCESS_TOKEN = "";
            EXPIRES_IN = "";
            USERNAME = "";
            CLIENT_ID = "";
        }

        [Key, Column(Order = 0)]
        public Int16? COMP_CODE { get; set; }

        [Key, Column(Order = 1)]
        public Int32 AUTO_SEQ_NO { get; set; }

        public string ACCESS_TOKEN { get; set; }
        public string EXPIRES_IN { get; set; }
        public string USERNAME { get; set; }
        public string CLIENT_ID { get; set; }
        public DateTime? ISSUED { get; set; }
        public DateTime? EXPIRES { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
    }
}