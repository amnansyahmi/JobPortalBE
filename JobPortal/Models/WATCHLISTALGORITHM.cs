using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class WATCHLISTALGORITHM
    {
        public Int16 COMP_CODE { get; set; }
        public Int16 WL_ALGO { get; set; }
        public string WL_DESC { get; set; }
        public string WL_RMK { get; set; }
        public Int16 ENABLED { get; set; }
        public Int16? LINK_TABLE_NO { get; set; }
        public string LINK_TABLE_TYPE { get; set; }
        public string LINK_PAGE_ID { get; set; }
        public Int16? LINK_TABLE_FMT { get; set; }
        public string NUMERIC_FIELD_DESC { get; set; }
        public string TEXT_FIELD_DESC { get; set; }
        public string BOOLEAN_FIELD_DESC { get; set; }
        public string DISP_ICON_CONTROL { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public string VALUE { get; set; }
        public string STATUS_DESC { get; set; }
    }

    [Table("WATCHLISTALGORITHM")]
    public class _WATCHLISTALGORITHM
    {
        public _WATCHLISTALGORITHM()
        {
        }

        public _WATCHLISTALGORITHM(bool setDefaultValue)
        {
            COMP_CODE = 0;
            WL_ALGO = 0;
            WL_DESC = "";
            WL_RMK = "";
            ENABLED = 0;
            LINK_TABLE_NO = 0;
            LINK_TABLE_TYPE = "";
            LINK_PAGE_ID = "";
            LINK_TABLE_FMT = 0;
            NUMERIC_FIELD_DESC = "";
            TEXT_FIELD_DESC = "";
            BOOLEAN_FIELD_DESC = "";
            DISP_ICON_CONTROL = "";
            USER_ID = "";
            MODE_MN = "";
        }

        [Key, Column(Order = 0)]
        public Int16 COMP_CODE { get; set; }

        [Key, Column(Order = 1)]
        public Int16 WL_ALGO { get; set; }

        public string WL_DESC { get; set; }
        public string WL_RMK { get; set; }
        public Int16 ENABLED { get; set; }
        public Int16? LINK_TABLE_NO { get; set; }
        public string LINK_TABLE_TYPE { get; set; }
        public string LINK_PAGE_ID { get; set; }
        public Int16? LINK_TABLE_FMT { get; set; }
        public string NUMERIC_FIELD_DESC { get; set; }
        public string TEXT_FIELD_DESC { get; set; }
        public string BOOLEAN_FIELD_DESC { get; set; }
        public string DISP_ICON_CONTROL { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }
}