using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class SETTING_DATA_MAPPING
    {
        public string mappingType { get; set; }
        public string dMappingName { get; set; }
        public string tableType { get; set; }
        public string dMappingProduct { get; set; }
        public Int32 dMappingStatus { get; set; }
    }

    [Table("SETTING_DATA_MAPPING")]
    public class _SETTING_DATA_MAPPING
    {
        public _SETTING_DATA_MAPPING()
        {
        }

        public _SETTING_DATA_MAPPING(bool setDefaultValue)
        {
            mappingType = "";
            dMappingName = "";
            tableType = "";
            dMappingProduct = "";
            dMappingStatus = 0;
        }

        [Key, Column(Order = 1)]
        public string mappingType { get; set; }

        public string dMappingName { get; set; }
        public string tableType { get; set; }
        public string dMappingProduct { get; set; }
        public Int32 dMappingStatus { get; set; }
    }
}