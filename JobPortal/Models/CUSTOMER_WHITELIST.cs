using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CUSTOMER_WHITELIST
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public string NO_MASTER { get; set; }
        public string NO_CIF { get; set; }
        public string NO_ACC { get; set; }
        public string FIRST_NAME { get; set; }
        public Int32 CIF_FALSE_POSITIVE_DT { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND { get; set; }
        public Int32 CIF_FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND_WL { get; set; }
        public string CIF_TABLE_NAME { get; set; }
        public string REMARKS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }

    [Table("CUSTOMER_WHITELIST")]
    public class _CUSTOMER_WHITELIST
    {
        public _CUSTOMER_WHITELIST()
        {
        }

        public _CUSTOMER_WHITELIST(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            NO_MASTER = "";
            NO_CIF = "";
            NO_ACC = "";
            FIRST_NAME = "";
            CIF_FALSE_POSITIVE_DT = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            CIF_FALSE_POSITIVE_IND = 1;
            CIF_FALSE_POSITIVE_DT_WL = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            CIF_FALSE_POSITIVE_IND_WL = 1;
            CIF_TABLE_NAME = "CUSTOMER";
            REMARKS = "";
            STAMP_DTTM = DateTime.Now;
            USER_ID = "";
            MODE_MN = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public string NO_MASTER { get; set; }

        [Key, Column(Order = 3)]
        public string NO_CIF { get; set; }

        [Key, Column(Order = 4)]
        public string NO_ACC { get; set; }

        public string FIRST_NAME { get; set; }
        public Int32 CIF_FALSE_POSITIVE_DT { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND { get; set; }
        public Int32 CIF_FALSE_POSITIVE_DT_WL { get; set; }
        public Int16 CIF_FALSE_POSITIVE_IND_WL { get; set; }
        public string CIF_TABLE_NAME { get; set; }
        public string REMARKS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }
}