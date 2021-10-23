using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public class ReturnResult
    {
        public string ScanStatus { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> RtnHit { get; set; }
        public List<string> RtnScanID { get; set; }
        public string RtnEnCryptScanID { get; set; }

        public ReturnResult()
        {
            RtnHit = new List<string>();
            RtnScanID = new List<string>();
        }
    }

    public class ESResult
    {
        public result results { get; set; }
    }

    public class result
    {
        public SearchResult[] hit { get; set; }
        public SearchResult[] pos { get; set; }
    }

    public class SearchResult
    {
        #region Properties

        public string ENTITY_ID { get; set; }
        public string ENTITY_TYPE { get; set; }
        public int SYS_ID { get; set; }
        public string INFO_SOURCE { get; set; }
        public string NAME_TYPE { get; set; }
        public string NAME_SOURCE { get; set; }
        public string SINGLE_STRING_NAME { get; set; }
        public string SINGLE_STRING_NAME2 { get; set; }
        public string SINGLE_STRING_NAME3 { get; set; }
        public string ORIGINAL_SCRIPT_NAME { get; set; }
        public string CATEGORY { get; set; }
        public string CATEGORY1 { get; set; }
        public string CATEGORY2 { get; set; }
        public string DOB { get; set; }
        public string COUNTRY { get; set; }
        public string SANCTION { get; set; }

        ////ID Result
        public string ID_VALUE { get; set; }

        public string GENDER { get; set; }
        public string MAIDEN_NAME { get; set; }
        public string ENTITY_NAME { get; set; }

        public string MATCH { get; set; }
        public int ID_HIT { get; set; }
        public int NAME_HIT { get; set; }
        public int RANK { get; set; }

        #endregion Properties
    }
}