using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class PARAM_STR_DTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 STR_ID { get; set; }
        public Int32 STR_HIST { get; set; }
        public Int32 STR_STATUS { get; set; }
        public Int32 QUEST_CATEGORY { get; set; }
        public Int32 QUEST_NO { get; set; }
        public string QUEST_FIELD { get; set; }
        public string QUEST_TEXT { get; set; }
        public string QUEST_REMARKS { get; set; }
        public string ANS_FIELD { get; set; }
        public Int32 ANS_TYPE { get; set; }
        public Int32 ANS_CODE { get; set; }
        public string ANS_DEFAULT { get; set; }
        public Int32 ANS_COMPULSORY { get; set; }
        public Int32 DISP_TEXT { get; set; }
        public Int32 DISP_REMARKS { get; set; }
        public Int32 DISP_ANS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public Int32 DISP_HDR { get; set; }

        [NotMapped]
        public string STR_STATUS_DESC { get; set; }

        [NotMapped]
        public string ANS_TYPE_DESC { get; set; }

        [NotMapped]
        public List<_CONFIG_CODES_DTL> DropDownDetails { get; set; }

        [NotMapped]
        public string TFIELD_ANS { get; set; }
    }

    [Table("PARAM_STR_DTL")]
    public class _PARAM_STR_DTL
    {
        public _PARAM_STR_DTL()
        {
        }

        public _PARAM_STR_DTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            STR_ID = 0;
            STR_HIST = 0;
            STR_STATUS = 0;
            QUEST_CATEGORY = 0;
            QUEST_NO = 0;
            QUEST_FIELD = "";
            QUEST_TEXT = "";
            QUEST_REMARKS = "";
            ANS_FIELD = "";
            ANS_TYPE = 0;
            ANS_CODE = 0;
            ANS_DEFAULT = "";
            ANS_COMPULSORY = 0;
            DISP_TEXT = 0;
            DISP_REMARKS = 0;
            DISP_ANS = 0;
            AUDIT_CREATED_DATE = DateTime.Now;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = DateTime.Now;
            AUDIT_UPDATED_USER = "";
            DISP_HDR = 0;
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        public Int32 STR_ID { get; set; }

        public Int32 STR_HIST { get; set; }
        public Int32 STR_STATUS { get; set; }

        [Key, Column(Order = 3)]
        public Int32 QUEST_CATEGORY { get; set; }

        [Key, Column(Order = 4)]
        public Int32 QUEST_NO { get; set; }

        public string QUEST_FIELD { get; set; }
        public string QUEST_TEXT { get; set; }
        public string QUEST_REMARKS { get; set; }
        public string ANS_FIELD { get; set; }
        public Int32 ANS_TYPE { get; set; }
        public Int32 ANS_CODE { get; set; }
        public string ANS_DEFAULT { get; set; }
        public Int32 ANS_COMPULSORY { get; set; }
        public Int32 DISP_TEXT { get; set; }
        public Int32 DISP_REMARKS { get; set; }
        public Int32 DISP_ANS { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
        public Int32 DISP_HDR { get; set; }

        [NotMapped]
        public string STR_STATUS_DESC { get; set; }

        [NotMapped]
        public string ANS_TYPE_DESC { get; set; }

        //public List<_CONFIG_CODES_DTL> DropDownDetails { get; set; }
        [NotMapped]
        public string TFIELD_ANS { get; set; }
    }
}