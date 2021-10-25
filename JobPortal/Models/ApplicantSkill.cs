using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class ApplicantSkill
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 SkillSetID { get; set; }

        public Int32? ApplicantID { get; set; }
        public Int32? SkillID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
    }

    [Table("ApplicantSkill")]
    public class _ApplicantSkill
    {
        public _ApplicantSkill()
        {
        }

        public _ApplicantSkill(bool setDefaultValue)
        {
            SkillSetID = 0;
            ApplicantID = 0;
            SkillID = 0;
            CreatedBy = "";
            CreatedDt = DateTime.Now;
        }

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 SkillSetID { get; set; }

        public Int32? ApplicantID { get; set; }
        public Int32? SkillID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
    }
}