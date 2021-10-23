using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class WATCHLISTCOUNTRYRISK
    {
        public Int16 COMP_CODE { get; set; }
        public Int16 RISK_TYPE { get; set; }
        public string HIGH_RISK_KEY { get; set; }
        public Int16 DISPLAY_OREDER { get; set; }
        public string RISK_DESCRIPTION { get; set; }
        public string CATEGORY { get; set; }
        public string ISO_ALPHA_3 { get; set; }
        public string ISO_NUMERIC_CODE { get; set; }
        public string CURRENCY_DESCR { get; set; }
        public string ISO_CURR_CODE { get; set; }
        public Int16? HIGH_RISK_SCORE1 { get; set; }
        public Int16? HIGH_RISK_SCORE2 { get; set; }
        public Int16? HIGH_RISK_SCORE3 { get; set; }
        public Int16? HIGH_RISK_SCORE4 { get; set; }
        public Int16? HIGH_RISK_SCORE5 { get; set; }
        public Int16? STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }

    [Table("WATCHLISTCOUNTRYRISK")]
    public class _WATCHLISTCOUNTRYRISK
    {
        public _WATCHLISTCOUNTRYRISK()
        {
        }

        public _WATCHLISTCOUNTRYRISK(bool setDefaultValue)
        {
            COMP_CODE = 0;
            RISK_TYPE = 0;
            HIGH_RISK_KEY = "";
            DISPLAY_OREDER = 0;
            RISK_DESCRIPTION = "";
            CATEGORY = "";
            ISO_ALPHA_3 = "";
            ISO_NUMERIC_CODE = "";
            CURRENCY_DESCR = "";
            ISO_CURR_CODE = "";
            HIGH_RISK_SCORE1 = 0;
            HIGH_RISK_SCORE2 = 0;
            HIGH_RISK_SCORE3 = 0;
            HIGH_RISK_SCORE4 = 0;
            HIGH_RISK_SCORE5 = 0;
            STATUS = 0;
            USER_ID = "";
            MODE_MN = "";
        }

        [Key, Column(Order = 0)]
        public Int16 COMP_CODE { get; set; }

        [Key, Column(Order = 1)]
        public Int16 RISK_TYPE { get; set; }

        [Key, Column(Order = 2)]
        public string HIGH_RISK_KEY { get; set; }

        public Int16 DISPLAY_OREDER { get; set; }
        public string RISK_DESCRIPTION { get; set; }
        public string CATEGORY { get; set; }
        public string ISO_ALPHA_3 { get; set; }
        public string ISO_NUMERIC_CODE { get; set; }
        public string CURRENCY_DESCR { get; set; }
        public string ISO_CURR_CODE { get; set; }
        public Int16? HIGH_RISK_SCORE1 { get; set; }
        public Int16? HIGH_RISK_SCORE2 { get; set; }
        public Int16? HIGH_RISK_SCORE3 { get; set; }
        public Int16? HIGH_RISK_SCORE4 { get; set; }
        public Int16? HIGH_RISK_SCORE5 { get; set; }
        public Int16? STATUS { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }
}