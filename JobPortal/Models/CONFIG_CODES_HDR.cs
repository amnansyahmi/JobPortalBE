using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class CONFIG_CODES_HDR
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 CODE_PRIME { get; set; }
        public string INFO_CATEGORY { get; set; }
        public string I1_TITLE { get; set; }
        public string I1_DESC { get; set; }
        public Int16 I1_VISIBLE { get; set; }
        public string I2_TITLE { get; set; }
        public string I2_DESC { get; set; }
        public Int16 I2_VISIBLE { get; set; }
        public string F1_TITLE { get; set; }
        public string F1_DESC { get; set; }
        public Int16 F1_VISIBLE { get; set; }
        public string F2_TITLE { get; set; }
        public string F2_DESC { get; set; }
        public Int16 F2_VISIBLE { get; set; }
        public string T1_TITLE { get; set; }
        public string T1_DESC { get; set; }
        public Int16 T1_VISIBLE { get; set; }
        public string T2_TITLE { get; set; }
        public string T2_DESC { get; set; }
        public Int16 T2_VISIBLE { get; set; }
        public string D1_TITLE { get; set; }
        public string D1_DESC { get; set; }
        public Int16 D1_VISIBLE { get; set; }
        public string D2_TITLE { get; set; }
        public string D2_DESC { get; set; }
        public Int16 D2_VISIBLE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATE_DATE { get; set; }
        public string AUDIT_UPDATE_USER { get; set; }
        public Int16 CONFIG_STATUS { get; set; }
        public String CONFIG_STATUS_DESC { get; set; }
    }

    [Table("CONFIG_CODES_HDR")]
    public class _CONFIG_CODES_HDR
    {
        public _CONFIG_CODES_HDR()
        {
        }

        public _CONFIG_CODES_HDR(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            CODE_PRIME = 0;
            INFO_CATEGORY = "";
            I1_TITLE = "";
            I1_DESC = "";
            I1_VISIBLE = 0;
            I2_TITLE = "";
            I2_DESC = "";
            I2_VISIBLE = 0;
            F1_TITLE = "";
            F1_DESC = "";
            F1_VISIBLE = 0;
            F2_TITLE = "";
            F2_DESC = "";
            F2_VISIBLE = 0;
            T1_TITLE = "";
            T1_DESC = "";
            T1_VISIBLE = 0;
            T2_TITLE = "";
            T2_DESC = "";
            T2_VISIBLE = 0;
            D1_TITLE = "";
            D1_DESC = "";
            D1_VISIBLE = 0;
            D2_TITLE = "";
            D2_DESC = "";
            D2_VISIBLE = 0;
            AUDIT_CREATED_DATE = null;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATE_DATE = null;
            AUDIT_UPDATE_USER = "";
            CONFIG_STATUS = 0;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 CODE_PRIME { get; set; }

        public string INFO_CATEGORY { get; set; }
        public string I1_TITLE { get; set; }
        public string I1_DESC { get; set; }
        public Int16 I1_VISIBLE { get; set; }
        public string I2_TITLE { get; set; }
        public string I2_DESC { get; set; }
        public Int16 I2_VISIBLE { get; set; }
        public string F1_TITLE { get; set; }
        public string F1_DESC { get; set; }
        public Int16 F1_VISIBLE { get; set; }
        public string F2_TITLE { get; set; }
        public string F2_DESC { get; set; }
        public Int16 F2_VISIBLE { get; set; }
        public string T1_TITLE { get; set; }
        public string T1_DESC { get; set; }
        public Int16 T1_VISIBLE { get; set; }
        public string T2_TITLE { get; set; }
        public string T2_DESC { get; set; }
        public Int16 T2_VISIBLE { get; set; }
        public string D1_TITLE { get; set; }
        public string D1_DESC { get; set; }
        public Int16 D1_VISIBLE { get; set; }
        public string D2_TITLE { get; set; }
        public string D2_DESC { get; set; }
        public Int16 D2_VISIBLE { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATE_DATE { get; set; }
        public string AUDIT_UPDATE_USER { get; set; }
        public Int16 CONFIG_STATUS { get; set; }
    }
}