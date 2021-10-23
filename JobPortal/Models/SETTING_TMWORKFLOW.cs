using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class SETTING_TMWORKFLOW
    {
        public Int32 MasterTemplateNo { get; set; }
        public string MasterTemplateName { get; set; }
        public Int32 WorkflowStatus { get; set; }
    }

    [Table("SETTING_TMWORKFLOW")]
    public class _SETTING_TMWORKFLOW
    {
        public _SETTING_TMWORKFLOW()
        {
        }

        public _SETTING_TMWORKFLOW(bool setDefaultValue)
        {
            MasterTemplateNo = 0;
            MasterTemplateName = "";
            WorkflowStatus = 0;
        }

        [Key, Column(Order = 1)]
        public Int32 MasterTemplateNo { get; set; }

        public string MasterTemplateName { get; set; }
        public Int32 WorkflowStatus { get; set; }
    }
}