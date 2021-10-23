using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class CONFIG_WF_FILTER
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 WF_MODULE { get; set; }
        public Int32? WF_ID { get; set; }
        public Int32? WF_LEVEL { get; set; }
        public Int32? FILTER_NO { get; set; }
        public string FILTER_NAME { get; set; }
        public string FILTER_TABLE { get; set; }
        public string FILTER_FD_NAME { get; set; }
        public string FILTER_OPERATOR { get; set; }
        public string FILTER_DATA { get; set; }
        public Int32? FILTER_GROUP { get; set; }
        public Int32? FILTER_LOGIC { get; set; }
    }

    [Table("CONFIG_WF_FILTER")]
    public class _CONFIG_WF_FILTER
    {
        public _CONFIG_WF_FILTER()
        {
        }

        public _CONFIG_WF_FILTER(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            WF_MODULE = 0;
            WF_ID = 0;
            WF_LEVEL = 0;
            FILTER_NO = 0;
            FILTER_NAME = "";
            FILTER_TABLE = "";
            FILTER_FD_NAME = "";
            FILTER_OPERATOR = "";
            FILTER_DATA = "";
            FILTER_GROUP = 0;
            FILTER_LOGIC = 0;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }
        public Int32 WF_MODULE { get; set; }
        public Int32? WF_ID { get; set; }

        [Key, Column(Order = 0)]
        public Int32? WF_LEVEL { get; set; }

        [Key, Column(Order = 1)]
        public Int32? FILTER_NO { get; set; }

        public string FILTER_NAME { get; set; }
        public string FILTER_TABLE { get; set; }
        public string FILTER_FD_NAME { get; set; }
        public string FILTER_OPERATOR { get; set; }
        public string FILTER_DATA { get; set; }
        public Int32? FILTER_GROUP { get; set; }
        public Int32? FILTER_LOGIC { get; set; }
    }
}