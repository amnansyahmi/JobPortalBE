using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class Attachment
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 AttachmentID { get; set; }

        public Int32 ApplicantID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileEncode { get; set; }
        public DateTime? UploadedDt { get; set; }
        public string UploadedBy { get; set; }
    }

    [Table("Attachment")]
    public class _Attachment
    {
        public _Attachment()
        {
        }

        public _Attachment(bool setDefaultValue)
        {
            AttachmentID = 0;
            ApplicantID = 0;
            FileName = "";
            FilePath = "";
            FileEncode = "";
            UploadedDt = DateTime.Now;
            UploadedBy = "";
        }

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 AttachmentID { get; set; }

        public Int32 ApplicantID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileEncode { get; set; }
        public DateTime? UploadedDt { get; set; }
        public string UploadedBy { get; set; }
    }
}