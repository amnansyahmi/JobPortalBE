using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class WATCHLISTALGORITHMCAT
    {
        public Int16 COMP_CODE { get; set; }
        public Int16 CATEGORY_TYPE { get; set; }
        public string CAT_DESC { get; set; }
        public string CAT1 { get; set; }
        public string CAT2 { get; set; }
        public string CAT3 { get; set; }
        public string CAT4 { get; set; }
        public string CAT5 { get; set; }
        public Int16? EXCLUDED_CAT1 { get; set; }
        public Int16? EXCLUDED_CAT2 { get; set; }
        public Int16? EXCLUDED_CAT3 { get; set; }
        public Int16? EXCLUDED_CAT4 { get; set; }
        public Int16? EXCLUDED_CAT5 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }

    [Table("WATCHLISTALGORITHMCAT")]
    public class _WATCHLISTALGORITHMCAT
    {
        public _WATCHLISTALGORITHMCAT()
        {
        }

        public _WATCHLISTALGORITHMCAT(bool setDefaultValue)
        {
            COMP_CODE = 0;
            CATEGORY_TYPE = 0;
            CAT_DESC = "";
            CAT1 = "";
            CAT2 = "";
            CAT3 = "";
            CAT4 = "";
            CAT5 = "";
            EXCLUDED_CAT1 = 0;
            EXCLUDED_CAT2 = 0;
            EXCLUDED_CAT3 = 0;
            EXCLUDED_CAT4 = 0;
            EXCLUDED_CAT5 = 0;
            USER_ID = "";
            MODE_MN = "";
        }

        [Key, Column(Order = 0)]
        public Int16 COMP_CODE { get; set; }

        [Key, Column(Order = 1)]
        public Int16 CATEGORY_TYPE { get; set; }

        public string CAT_DESC { get; set; }
        public string CAT1 { get; set; }
        public string CAT2 { get; set; }
        public string CAT3 { get; set; }
        public string CAT4 { get; set; }
        public string CAT5 { get; set; }
        public Int16? EXCLUDED_CAT1 { get; set; }
        public Int16? EXCLUDED_CAT2 { get; set; }
        public Int16? EXCLUDED_CAT3 { get; set; }
        public Int16? EXCLUDED_CAT4 { get; set; }
        public Int16? EXCLUDED_CAT5 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }
}