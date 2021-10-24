using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CodeConfig
    {
        [Key, Column(Order = 0)]
        public Int32 PrimeCode { get; set; }

        [Key, Column(Order = 1)]
        public string SubCode { get; set; }

        public Int32? CodeOrder { get; set; }
        public string CodeCategory { get; set; }
        public string CodeDescription { get; set; }
        public Int32? CodeStatus { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }
    }

    [Table("CodeConfig")]
    public class _CodeConfig
    {
        public _CodeConfig()
        {
        }

        public _CodeConfig(bool setDefaultValue)
        {
            PrimeCode = 0;
            SubCode = "";
            CodeOrder = 0;
            CodeCategory = "";
            CodeDescription = "";
            CodeStatus = 0;
            CreatedDt = DateTime.Now;
            CreatedBy = "";
        }

        [Key, Column(Order = 0)]
        public Int32 PrimeCode { get; set; }

        [Key, Column(Order = 1)]
        public string SubCode { get; set; }

        public Int32? CodeOrder { get; set; }
        public string CodeCategory { get; set; }
        public string CodeDescription { get; set; }
        public Int32? CodeStatus { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }
    }
}