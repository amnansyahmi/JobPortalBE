using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RF_OMDTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int64 RF_ID { get; set; }
        public Int32 SYS_SEQ { get; set; }
        public string HIT_WL_ID { get; set; }
        public Int16 TYPE_HIT { get; set; }
        public string NO_ACCOUNT { get; set; }
        public string NO_CIF { get; set; }
        public string HIT_SOURCE { get; set; }
        public string TYPE_NAME { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string HIT_ID { get; set; }
        public string HIT_COUNTRY { get; set; }
        public string HIT_DOBS { get; set; }
        public string HIT_CATEGORY { get; set; }
        public string HIT_NAMESOURCE { get; set; }
        public Int16 HIT_STRONG { get; set; }
        public Int16 STATUS_INV { get; set; }
        public Int16 TYPE_EXPO { get; set; }
        public string REMARKS { get; set; }

        [NotMapped]
        public string EXPOSURE { get; set; }

        [NotMapped]
        public string FINDINGS { get; set; }

        public Int16 FLAG_FALSEPOS { get; set; }
        public string HIT_GENDER { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string TYPE_ENT { get; set; }

        [NotMapped]
        public string HIT_GENDER_DESC { get; set; }
    }

    [Table("RF_OMDTL")]
    public class _RF_OMDTL
    {
        public _RF_OMDTL()
        {
        }

        public _RF_OMDTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            RF_ID = 0;
            SYS_SEQ = 0;
            HIT_WL_ID = "";
            TYPE_HIT = 0;
            NO_ACCOUNT = "";
            NO_CIF = "";
            HIT_SOURCE = "";
            TYPE_NAME = "";
            SINGLE_STRING_NAME = "";
            HIT_ID = "";
            HIT_COUNTRY = "";
            HIT_DOBS = "";
            HIT_CATEGORY = "";
            HIT_NAMESOURCE = "";
            HIT_STRONG = 0;
            STATUS_INV = 0;
            TYPE_EXPO = 0;
            REMARKS = "";
            FLAG_FALSEPOS = 0;
            HIT_GENDER = "";
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_USER = "";
            TYPE_ENT = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int64 RF_ID { get; set; }

        [Key, Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 SYS_SEQ { get; set; }

        public string HIT_WL_ID { get; set; }
        public Int16 TYPE_HIT { get; set; }
        public string NO_ACCOUNT { get; set; }
        public string NO_CIF { get; set; }
        public string HIT_SOURCE { get; set; }
        public string TYPE_NAME { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string HIT_ID { get; set; }
        public string HIT_COUNTRY { get; set; }
        public string HIT_DOBS { get; set; }
        public string HIT_CATEGORY { get; set; }
        public string HIT_NAMESOURCE { get; set; }
        public Int16 HIT_STRONG { get; set; }
        public Int16 STATUS_INV { get; set; }
        public Int16 TYPE_EXPO { get; set; }
        public string REMARKS { get; set; }
        public Int16 FLAG_FALSEPOS { get; set; }
        public string HIT_GENDER { get; set; }

        [NotMapped]
        public string HIT_GENDER_DESC { get; set; }

        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public string TYPE_ENT { get; set; }
    }
}