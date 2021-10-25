using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class Skills
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 SkillID { get; set; }

        public string JobType { get; set; }
        public string SkillType { get; set; }
        public string SkillDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
    }

    [Table("Skills")]
    public class _Skills
    {
        public _Skills()
        {
        }

        public _Skills(bool setDefaultValue)
        {
            SkillID = 0;
            JobType = "";
            SkillType = "";
            SkillDesc = "";
            CreatedBy = "";
            CreatedDt = DateTime.Now;
        }

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 SkillID { get; set; }

        public string JobType { get; set; }
        public string SkillType { get; set; }
        public string SkillDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
    }
}