using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class CONFIGMISCTABLEDATALIST
    {
        public Int16 COMP_CODE { get; set; }
        public string TEMPLATE_CODE { get; set; }
        public Int16 QUEST_ITEM_NO { get; set; }
        public Int16 DISPLAY_ORDER { get; set; }
        public string FIELD_ID { get; set; }
        public Int16 FIELD_MAX_LEN { get; set; }
        public string SHORT_FD_DESC { get; set; }
        public string QUEST_TEXT { get; set; }
        public Int16 DISP_QUESTTEXT_IND { get; set; }
        public Int16 DISP_SCORING_IND { get; set; }
        public Int16 ANS_TYPE { get; set; }
        public Int32 DDL_TABLENO { get; set; }
        public Int32 MIN_SCORING_REQ { get; set; }
        public Int32 MAX_SCORING_REQ { get; set; }
        public Int32 SCORING_TEXT { get; set; }
        public Int32 SCORING_YES { get; set; }
        public Int32 SCORING_NO { get; set; }
        public string OPTION_A { get; set; }
        public Int32 SCORING_A { get; set; }
        public string OPTION_B { get; set; }
        public Int32 SCORING_B { get; set; }
        public string OPTION_C { get; set; }
        public Int32 SCORING_C { get; set; }
        public string OPTION_D { get; set; }
        public Int32 SCORING_D { get; set; }
        public string OPTION_E { get; set; }
        public Int32 SCORING_E { get; set; }
        public Int16 IMPORT_FIELDSEQ { get; set; }
        public Int16 OPERATOR_VALUE { get; set; }
        public Int16 EDITABLE_IND { get; set; }
        public Int16 EDITABLE_IND1 { get; set; }
        public Int16 EDITABLE_IND2 { get; set; }
        public Int16 EDITABLE_IND3 { get; set; }
        public Int16 EDITABLE_IND4 { get; set; }
        public string DEFAULT_VALUE { get; set; }
        public Int16 COMPULSARY_IND { get; set; }
        public Int16 MULTIPLELINE_HEIGHT { get; set; }
        public Int16 STATUS { get; set; }
        public string XML_LEVEL1 { get; set; }
        public string XML_LEVEL2 { get; set; }
        public string XML_LEVEL3 { get; set; }
        public string XML_LEVEL4 { get; set; }
        public string XML_LEVEL5 { get; set; }
        public string XML_LEVEL6 { get; set; }
        public Int16 XML_SECTION_NO { get; set; }
        public Int16 XML_SEQ_NO { get; set; }
        public Int16 XML_SUB_SEQ { get; set; }
        public Int16 XML_ACTION1 { get; set; }
        public Int16 XML_ACTION2 { get; set; }
        public Int16 XML_ACTION3 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
        public List<CONFIG_CODES_DTL> DropDownDetails { get; set; }
        public string TFIELD_ANS { get; set; }
    }

    [Table("CONFIGMISCTABLEDATALIST")]
    public class _CONFIGMISCTABLEDATALIST
    {
        public _CONFIGMISCTABLEDATALIST()
        {
        }

        public _CONFIGMISCTABLEDATALIST(bool setDefaultValue)
        {
            COMP_CODE = 0;
            TEMPLATE_CODE = "";
            QUEST_ITEM_NO = 0;
            DISPLAY_ORDER = 0;
            FIELD_ID = "";
            FIELD_MAX_LEN = 0;
            SHORT_FD_DESC = "";
            QUEST_TEXT = "";
            DISP_QUESTTEXT_IND = 0;
            DISP_SCORING_IND = 0;
            ANS_TYPE = 0;
            DDL_TABLENO = 0;
            MIN_SCORING_REQ = 0;
            MAX_SCORING_REQ = 0;
            SCORING_TEXT = 0;
            SCORING_YES = 0;
            SCORING_NO = 0;
            OPTION_A = "";
            SCORING_A = 0;
            OPTION_B = "";
            SCORING_B = 0;
            OPTION_C = "";
            SCORING_C = 0;
            OPTION_D = "";
            SCORING_D = 0;
            OPTION_E = "";
            SCORING_E = 0;
            IMPORT_FIELDSEQ = 0;
            OPERATOR_VALUE = 0;
            EDITABLE_IND = 0;
            EDITABLE_IND1 = 0;
            EDITABLE_IND2 = 0;
            EDITABLE_IND3 = 0;
            EDITABLE_IND4 = 0;
            DEFAULT_VALUE = "";
            COMPULSARY_IND = 0;
            MULTIPLELINE_HEIGHT = 0;
            STATUS = 0;
            XML_LEVEL1 = "";
            XML_LEVEL2 = "";
            XML_LEVEL3 = "";
            XML_LEVEL4 = "";
            XML_LEVEL5 = "";
            XML_LEVEL6 = "";
            XML_SECTION_NO = 0;
            XML_SEQ_NO = 0;
            XML_SUB_SEQ = 0;
            XML_ACTION1 = 0;
            XML_ACTION2 = 0;
            XML_ACTION3 = 0;
            USER_ID = "";
            MODE_MN = "";
        }

        [Key, Column(Order = 0)]
        public Int16 COMP_CODE { get; set; }

        [Key, Column(Order = 1)]
        public string TEMPLATE_CODE { get; set; }

        [Key, Column(Order = 2)]
        public Int16 QUEST_ITEM_NO { get; set; }

        public Int16 DISPLAY_ORDER { get; set; }
        public string FIELD_ID { get; set; }
        public Int16 FIELD_MAX_LEN { get; set; }
        public string SHORT_FD_DESC { get; set; }
        public string QUEST_TEXT { get; set; }
        public Int16 DISP_QUESTTEXT_IND { get; set; }
        public Int16 DISP_SCORING_IND { get; set; }
        public Int16 ANS_TYPE { get; set; }
        public Int32 DDL_TABLENO { get; set; }
        public Int32 MIN_SCORING_REQ { get; set; }
        public Int32 MAX_SCORING_REQ { get; set; }
        public Int32 SCORING_TEXT { get; set; }
        public Int32 SCORING_YES { get; set; }
        public Int32 SCORING_NO { get; set; }
        public string OPTION_A { get; set; }
        public Int32 SCORING_A { get; set; }
        public string OPTION_B { get; set; }
        public Int32 SCORING_B { get; set; }
        public string OPTION_C { get; set; }
        public Int32 SCORING_C { get; set; }
        public string OPTION_D { get; set; }
        public Int32 SCORING_D { get; set; }
        public string OPTION_E { get; set; }
        public Int32 SCORING_E { get; set; }
        public Int16 IMPORT_FIELDSEQ { get; set; }
        public Int16 OPERATOR_VALUE { get; set; }
        public Int16 EDITABLE_IND { get; set; }
        public Int16 EDITABLE_IND1 { get; set; }
        public Int16 EDITABLE_IND2 { get; set; }
        public Int16 EDITABLE_IND3 { get; set; }
        public Int16 EDITABLE_IND4 { get; set; }
        public string DEFAULT_VALUE { get; set; }
        public Int16 COMPULSARY_IND { get; set; }
        public Int16 MULTIPLELINE_HEIGHT { get; set; }
        public Int16 STATUS { get; set; }
        public string XML_LEVEL1 { get; set; }
        public string XML_LEVEL2 { get; set; }
        public string XML_LEVEL3 { get; set; }
        public string XML_LEVEL4 { get; set; }
        public string XML_LEVEL5 { get; set; }
        public string XML_LEVEL6 { get; set; }
        public Int16 XML_SECTION_NO { get; set; }
        public Int16 XML_SEQ_NO { get; set; }
        public Int16 XML_SUB_SEQ { get; set; }
        public Int16 XML_ACTION1 { get; set; }
        public Int16 XML_ACTION2 { get; set; }
        public Int16 XML_ACTION3 { get; set; }
        public DateTime? STAMP_DTTM { get; set; }
        public string USER_ID { get; set; }
        public string MODE_MN { get; set; }
    }
}