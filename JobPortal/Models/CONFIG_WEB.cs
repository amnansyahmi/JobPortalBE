using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class CONFIG_WEB
    {
        public Int32 CODE_COMP { get; set; }
        public Int32 CODE_ORG { get; set; }
        public Int32 AD_TYPE { get; set; }
        public string PATH_FILETEMP { get; set; }
        public string PATH_FILEACT { get; set; }
        public string PATH_FILEBATCH { get; set; }
        public string PATH_FILEOUTPUT { get; set; }
        public string PATH_WU { get; set; }
        public string PATH_FILESTR { get; set; }
        public string PATH_DNS { get; set; }
        public Int32 SIZE_UPFILE { get; set; }
        public Int32 SIZE_BATCHFILE { get; set; }
        public Int32 FLAG_OFFLINE { get; set; }
        public Int32 FLAG_WATCHLIST_LOG { get; set; }
        public string FLAG_WL_TYPE { get; set; }
        public Int32 FLAG_THEME { get; set; }
        public Int32 FLAG_LANGUAGE { get; set; }
        public Int32 TIME_FORMAT { get; set; }
        public Int32 DATE_FORMAT { get; set; }
        public Int32 EMAIL_EXCHANGE { get; set; }
        public string EMAIL_HOST { get; set; }
        public string EMAIL_USERID { get; set; }
        public string EMAIL_PASSWORD { get; set; }
        public Int32 EMAIL_PORT { get; set; }
        public Int32 EMAIL_SECURITY { get; set; }
        public Int32 FLAG_ANALYSIS { get; set; }
    }

    [Table("CONFIG_WEB")]
    public class _CONFIG_WEB
    {
        public _CONFIG_WEB()
        {
        }

        public _CONFIG_WEB(bool setDefaultValue)
        {
            CODE_COMP = 0;
            CODE_ORG = 0;
            AD_TYPE = 0;
            PATH_FILETEMP = "";
            PATH_FILEACT = "";
            PATH_FILEBATCH = "";
            PATH_FILEOUTPUT = "";
            PATH_WU = "";
            PATH_FILESTR = "";
            PATH_DNS = "";
            SIZE_UPFILE = 0;
            SIZE_BATCHFILE = 0;
            FLAG_OFFLINE = 0;
            FLAG_WATCHLIST_LOG = 0;
            FLAG_WL_TYPE = "";
            FLAG_THEME = 0;
            FLAG_LANGUAGE = 0;
            DATE_FORMAT = 0;
            TIME_FORMAT = 0;
            EMAIL_EXCHANGE = 0;
            EMAIL_HOST = "";
            EMAIL_USERID = "";
            EMAIL_PASSWORD = "";
            EMAIL_PORT = 0;
            EMAIL_SECURITY = 0;
            FLAG_ANALYSIS = 0;
        }

        [Key, Column(Order = 1)]
        public Int32 CODE_COMP { get; set; }

        public Int32 CODE_ORG { get; set; }
        public Int32 AD_TYPE { get; set; }
        public string PATH_FILETEMP { get; set; }
        public string PATH_FILEACT { get; set; }
        public string PATH_FILEBATCH { get; set; }
        public string PATH_FILEOUTPUT { get; set; }
        public string PATH_WU { get; set; }
        public string PATH_FILESTR { get; set; }
        public string PATH_DNS { get; set; }
        public Int32 SIZE_UPFILE { get; set; }
        public Int32 SIZE_BATCHFILE { get; set; }
        public Int32 FLAG_OFFLINE { get; set; }
        public Int32 FLAG_WATCHLIST_LOG { get; set; }
        public string FLAG_WL_TYPE { get; set; }
        public Int32 FLAG_THEME { get; set; }
        public Int32 FLAG_LANGUAGE { get; set; }
        public Int32 TIME_FORMAT { get; set; }
        public Int32 DATE_FORMAT { get; set; }
        public Int32 EMAIL_EXCHANGE { get; set; }
        public string EMAIL_HOST { get; set; }
        public string EMAIL_USERID { get; set; }
        public string EMAIL_PASSWORD { get; set; }
        public Int32 EMAIL_PORT { get; set; }
        public Int32 EMAIL_SECURITY { get; set; }
        public Int32 FLAG_ANALYSIS { get; set; }
    }
}