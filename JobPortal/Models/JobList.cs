using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class JobList
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 JobID { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string SalaryRange { get; set; }
        public DateTime? PostedDt { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }
    }

    [Table("JobList")]
    public class _JobList
    {
        public _JobList()
        {
        }

        public _JobList(bool setDefaultValue)
        {
            JobID = 0;
            JobTitle = "";
            JobDescription = "";
            SalaryRange = "";
            PostedDt = DateTime.Now;
            Remarks = "";
            CreatedDt = DateTime.Now;
            CreatedBy = "";
        }

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 JobID { get; set; }

        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string SalaryRange { get; set; }
        public DateTime? PostedDt { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }
    }
}