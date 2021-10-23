using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class RPT_STR_DTL
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 STR_SEQ { get; set; }
        public Int32 STR_ID { get; set; }
        public Int32 STR_HIST_QUEST { get; set; }
        public Int32 STR_HDR_SEQ { get; set; }
        public Int32 STR_CATEGORY { get; set; }
        public string NO_CIF { get; set; }
        public string NO_MASTER { get; set; }
        public string TFIELD001 { get; set; }
        public string TFIELD002 { get; set; }
        public string TFIELD003 { get; set; }
        public string TFIELD004 { get; set; }
        public string TFIELD005 { get; set; }
        public string TFIELD006 { get; set; }
        public string TFIELD007 { get; set; }
        public string TFIELD008 { get; set; }
        public string TFIELD009 { get; set; }
        public string TFIELD010 { get; set; }
        public string TFIELD011 { get; set; }
        public string TFIELD012 { get; set; }
        public string TFIELD013 { get; set; }
        public string TFIELD014 { get; set; }
        public string TFIELD015 { get; set; }
        public string TFIELD016 { get; set; }
        public string TFIELD017 { get; set; }
        public string TFIELD018 { get; set; }
        public string TFIELD019 { get; set; }
        public string TFIELD020 { get; set; }
        public string TFIELD021 { get; set; }
        public string TFIELD022 { get; set; }
        public string TFIELD023 { get; set; }
        public string TFIELD024 { get; set; }
        public string TFIELD025 { get; set; }
        public string TFIELD026 { get; set; }
        public string TFIELD027 { get; set; }
        public string TFIELD028 { get; set; }
        public string TFIELD029 { get; set; }
        public string TFIELD030 { get; set; }
        public string TFIELD031 { get; set; }
        public string TFIELD032 { get; set; }
        public string TFIELD033 { get; set; }
        public string TFIELD034 { get; set; }
        public string TFIELD035 { get; set; }
        public string TFIELD036 { get; set; }
        public string TFIELD037 { get; set; }
        public string TFIELD038 { get; set; }
        public string TFIELD039 { get; set; }
        public string TFIELD040 { get; set; }
        public string TFIELD041 { get; set; }
        public string TFIELD042 { get; set; }
        public string TFIELD043 { get; set; }
        public string TFIELD044 { get; set; }
        public string TFIELD045 { get; set; }
        public string TFIELD046 { get; set; }
        public string TFIELD047 { get; set; }
        public string TFIELD048 { get; set; }
        public string TFIELD049 { get; set; }
        public string TFIELD050 { get; set; }
        public string TFIELD051 { get; set; }
        public string TFIELD052 { get; set; }
        public string TFIELD053 { get; set; }
        public string TFIELD054 { get; set; }
        public string TFIELD055 { get; set; }
        public string TFIELD056 { get; set; }
        public string TFIELD057 { get; set; }
        public string TFIELD058 { get; set; }
        public string TFIELD059 { get; set; }
        public string TFIELD060 { get; set; }
        public string TFIELD061 { get; set; }
        public string TFIELD062 { get; set; }
        public string TFIELD063 { get; set; }
        public string TFIELD064 { get; set; }
        public string TFIELD065 { get; set; }
        public string TFIELD066 { get; set; }
        public string TFIELD067 { get; set; }
        public string TFIELD068 { get; set; }
        public string TFIELD069 { get; set; }
        public string TFIELD070 { get; set; }
        public Int32? AUDIT_USER_LEVEL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }

    [Table("RPT_STR_DTL")]
    public class _RPT_STR_DTL
    {
        public _RPT_STR_DTL()
        {
        }

        public _RPT_STR_DTL(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            STR_SEQ = 0;
            STR_ID = 0;
            STR_HIST_QUEST = 0;
            STR_HDR_SEQ = 0;
            STR_CATEGORY = 0;
            NO_CIF = "";
            NO_MASTER = "";
            TFIELD001 = "";
            TFIELD002 = "";
            TFIELD003 = "";
            TFIELD004 = "";
            TFIELD005 = "";
            TFIELD006 = "";
            TFIELD007 = "";
            TFIELD008 = "";
            TFIELD009 = "";
            TFIELD010 = "";
            TFIELD011 = "";
            TFIELD012 = "";
            TFIELD013 = "";
            TFIELD014 = "";
            TFIELD015 = "";
            TFIELD016 = "";
            TFIELD017 = "";
            TFIELD018 = "";
            TFIELD019 = "";
            TFIELD020 = "";
            TFIELD021 = "";
            TFIELD022 = "";
            TFIELD023 = "";
            TFIELD024 = "";
            TFIELD025 = "";
            TFIELD026 = "";
            TFIELD027 = "";
            TFIELD028 = "";
            TFIELD029 = "";
            TFIELD030 = "";
            TFIELD031 = "";
            TFIELD032 = "";
            TFIELD033 = "";
            TFIELD034 = "";
            TFIELD035 = "";
            TFIELD036 = "";
            TFIELD037 = "";
            TFIELD038 = "";
            TFIELD039 = "";
            TFIELD040 = "";
            TFIELD041 = "";
            TFIELD042 = "";
            TFIELD043 = "";
            TFIELD044 = "";
            TFIELD045 = "";
            TFIELD046 = "";
            TFIELD047 = "";
            TFIELD048 = "";
            TFIELD049 = "";
            TFIELD050 = "";
            TFIELD051 = "";
            TFIELD052 = "";
            TFIELD053 = "";
            TFIELD054 = "";
            TFIELD055 = "";
            TFIELD056 = "";
            TFIELD057 = "";
            TFIELD058 = "";
            TFIELD059 = "";
            TFIELD060 = "";
            TFIELD061 = "";
            TFIELD062 = "";
            TFIELD063 = "";
            TFIELD064 = "";
            TFIELD065 = "";
            TFIELD066 = "";
            TFIELD067 = "";
            TFIELD068 = "";
            TFIELD069 = "";
            TFIELD070 = "";
            AUDIT_USER_LEVEL = 0;
            AUDIT_CREATED_DATE = DateTime.Now;
            AUDIT_CREATED_USER = "";
            AUDIT_UPDATED_DATE = DateTime.Now;
            AUDIT_UPDATED_USER = "";
        }

        [Key, Column(Order = 0)]
        public Int32 CODE_COMP { get; set; }

        [Key, Column(Order = 1)]
        public Int32 CODE_ORG { get; set; }

        [Key, Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 STR_SEQ { get; set; }

        public Int32 STR_ID { get; set; }
        public Int32 STR_HIST_QUEST { get; set; }
        public Int32 STR_HDR_SEQ { get; set; }
        public Int32 STR_CATEGORY { get; set; }
        public string NO_CIF { get; set; }
        public string NO_MASTER { get; set; }
        public string TFIELD001 { get; set; }
        public string TFIELD002 { get; set; }
        public string TFIELD003 { get; set; }
        public string TFIELD004 { get; set; }
        public string TFIELD005 { get; set; }
        public string TFIELD006 { get; set; }
        public string TFIELD007 { get; set; }
        public string TFIELD008 { get; set; }
        public string TFIELD009 { get; set; }
        public string TFIELD010 { get; set; }
        public string TFIELD011 { get; set; }
        public string TFIELD012 { get; set; }
        public string TFIELD013 { get; set; }
        public string TFIELD014 { get; set; }
        public string TFIELD015 { get; set; }
        public string TFIELD016 { get; set; }
        public string TFIELD017 { get; set; }
        public string TFIELD018 { get; set; }
        public string TFIELD019 { get; set; }
        public string TFIELD020 { get; set; }
        public string TFIELD021 { get; set; }
        public string TFIELD022 { get; set; }
        public string TFIELD023 { get; set; }
        public string TFIELD024 { get; set; }
        public string TFIELD025 { get; set; }
        public string TFIELD026 { get; set; }
        public string TFIELD027 { get; set; }
        public string TFIELD028 { get; set; }
        public string TFIELD029 { get; set; }
        public string TFIELD030 { get; set; }
        public string TFIELD031 { get; set; }
        public string TFIELD032 { get; set; }
        public string TFIELD033 { get; set; }
        public string TFIELD034 { get; set; }
        public string TFIELD035 { get; set; }
        public string TFIELD036 { get; set; }
        public string TFIELD037 { get; set; }
        public string TFIELD038 { get; set; }
        public string TFIELD039 { get; set; }
        public string TFIELD040 { get; set; }
        public string TFIELD041 { get; set; }
        public string TFIELD042 { get; set; }
        public string TFIELD043 { get; set; }
        public string TFIELD044 { get; set; }
        public string TFIELD045 { get; set; }
        public string TFIELD046 { get; set; }
        public string TFIELD047 { get; set; }
        public string TFIELD048 { get; set; }
        public string TFIELD049 { get; set; }
        public string TFIELD050 { get; set; }
        public string TFIELD051 { get; set; }
        public string TFIELD052 { get; set; }
        public string TFIELD053 { get; set; }
        public string TFIELD054 { get; set; }
        public string TFIELD055 { get; set; }
        public string TFIELD056 { get; set; }
        public string TFIELD057 { get; set; }
        public string TFIELD058 { get; set; }
        public string TFIELD059 { get; set; }
        public string TFIELD060 { get; set; }
        public string TFIELD061 { get; set; }
        public string TFIELD062 { get; set; }
        public string TFIELD063 { get; set; }
        public string TFIELD064 { get; set; }
        public string TFIELD065 { get; set; }
        public string TFIELD066 { get; set; }
        public string TFIELD067 { get; set; }
        public string TFIELD068 { get; set; }
        public string TFIELD069 { get; set; }
        public string TFIELD070 { get; set; }
        public Int32? AUDIT_USER_LEVEL { get; set; }
        public DateTime? AUDIT_CREATED_DATE { get; set; }
        public string AUDIT_CREATED_USER { get; set; }
        public DateTime? AUDIT_UPDATED_DATE { get; set; }
        public string AUDIT_UPDATED_USER { get; set; }
    }
}