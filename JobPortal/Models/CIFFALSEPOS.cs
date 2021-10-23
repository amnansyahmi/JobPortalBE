using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CIFFALSEPOS
    {
        public Int16 CODE_COMP { get; set; }
        public string NO_CIF { get; set; }
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

    [Table("CIFFALSEPOS")]
    public class _CIFFALSEPOS
    {
        public _CIFFALSEPOS()
        {
        }

        public _CIFFALSEPOS(bool setDefaultValue)
        {
            CODE_COMP = 0;
            NO_CIF = "";
            FIRST_NAME = "";
            CIF_FALSE_POSITIVE_DT = 0;
            CIF_FALSE_POSITIVE_IND = 0;
            CIF_FALSE_POSITIVE_DT_WL = 0;
            CIF_FALSE_POSITIVE_IND_WL = 0;
            CIF_TABLE_NAME = "";
            REMARKS = "";
            STAMP_DTTM = DateTime.Now;
            USER_ID = "";
            MODE_MN = "";
        }

        [Key, Column(Order = 0)]
        public Int16 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public string NO_CIF { get; set; }

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