using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class CONFIG_CODES_DTL
    {
        public Int32? CODE_COMP { get; set; }
        public Int32? CODE_ORG { get; set; }
        public Int32 CODE_PRIME { get; set; }
        public string CODE_SUB { get; set; }
        public Int32? INFO_ORDER { get; set; }
        public string INFO_CATEGORY { get; set; }
        public string INFO_DESC { get; set; }
        public string INFO_DESC_OTHER { get; set; }
        public Int32? DATA_VALUEI1 { get; set; }
        public Int32? DATA_VALUEI2 { get; set; }
        public double? DATA_VALUEF1 { get; set; }
        public double? DATA_VALUEF2 { get; set; }
        public string DATA_VALUET1 { get; set; }
        public string DATA_VALUET2 { get; set; }
        public Decimal? DATA_VALUED1 { get; set; }
        public Decimal? DATA_VALUED2 { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public Int32? CONFIG_STATUS1 { get; set; }
        public Int32? CONFIG_STATUS2 { get; set; }

        //public string DATA_VALUEI1_DESC { get; set; }
        public string CONFIG_STATUS1_DESC { get; set; }

        public string MODULE_DESC { get; set; }
        public string WF_NAME { get; set; }
        public string ASSIGN_STATUS { get; set; }
        public string DATA_VALUEI1_DESC { get; set; }
    }

    [Table("CONFIG_CODES_DTL")]
    public class _CONFIG_CODES_DTL
    {
        public _CONFIG_CODES_DTL()
        {
        }

        public _CONFIG_CODES_DTL(bool setDefaultValue)
        {
            CODE_COMP = 1;
            CODE_ORG = 1;
            CODE_PRIME = 0;
            CODE_SUB = "";
            INFO_ORDER = 0;
            INFO_CATEGORY = "";
            INFO_DESC = "";
            INFO_DESC_OTHER = "";
            DATA_VALUEI1 = 0;
            DATA_VALUEI2 = 0;
            DATA_VALUEF1 = 0;
            DATA_VALUEF2 = 0;
            DATA_VALUET1 = "";
            DATA_VALUET2 = "";
            DATA_VALUED1 = 0;
            DATA_VALUED2 = 0;
            CONFIG_STATUS1 = 1;
            CONFIG_STATUS2 = 0;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_USER = "";
            AUDIT_CREATED_DATE = DateTime.Now;
            AUDIT_UPDATED_DATE = DateTime.Now;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0)]
        public Int32? CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32? CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 CODE_PRIME { get; set; }

        [Key, Column(Order = 3)]
        public string CODE_SUB { get; set; }

        public Int32? INFO_ORDER { get; set; }
        public string INFO_CATEGORY { get; set; }
        public string INFO_DESC { get; set; }
        public string INFO_DESC_OTHER { get; set; }
        public Int32? DATA_VALUEI1 { get; set; }
        public Int32? DATA_VALUEI2 { get; set; }
        public double? DATA_VALUEF1 { get; set; }
        public double? DATA_VALUEF2 { get; set; }
        public string DATA_VALUET1 { get; set; }
        public string DATA_VALUET2 { get; set; }
        public Decimal? DATA_VALUED1 { get; set; }
        public Decimal? DATA_VALUED2 { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public Int32? CONFIG_STATUS1 { get; set; }
        public Int32? CONFIG_STATUS2 { get; set; }
    }
}