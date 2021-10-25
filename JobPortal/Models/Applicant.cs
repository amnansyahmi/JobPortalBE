using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class Applicant
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ApplicantID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Int32 JobID { get; set; }
        public Int32? YearsExp { get; set; }
        public string PrefLocation { get; set; }
        public string VacancyFoundIn { get; set; }
        public Int32? NoticePeriod { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedDt { get; set; }

        [NotMapped]
        public string JobTitle { get; set; }
    }

    [Table("Applicant")]
    public class _Applicant
    {
        public _Applicant()
        {
        }

        public _Applicant(bool setDefaultValue)
        {
            ApplicantID = 0;
            FirstName = "";
            LastName = "";
            JobID = 0;
            YearsExp = 0;
            PrefLocation = "";
            VacancyFoundIn = "";
            NoticePeriod = 0;
            ContactNo = "";
            Email = "";
            Address = "";
        }

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ApplicantID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Int32 JobID { get; set; }
        public Int32? YearsExp { get; set; }
        public string PrefLocation { get; set; }
        public string VacancyFoundIn { get; set; }
        public Int32? NoticePeriod { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedDt { get; set; }

        [NotMapped]
        public string JobTitle { get; set; }
    }
}