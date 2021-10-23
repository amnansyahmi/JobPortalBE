using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class INFORMATION_SCHEMA_COLUMNS
    {
        public string TABLE_CATALOG { get; set; }
        public string TABLE_SCHEMA { get; set; }
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public Int32 ORDINAL_POSITION { get; set; }
        public string COLUMN_DEFAULT { get; set; }
        public string IS_NULLABLE { get; set; }
        public string DATA_TYPE { get; set; }
        public Int32 CHARACTER_MAXIMUM_LENGTH { get; set; }
        public Int32 CHARACTER_OCTET_LENGTH { get; set; }
        public byte NUMERIC_PRECISION { get; set; }
        public Int32 NUMERIC_PRECISION_RADIX { get; set; }
        public string NUMERIC_SCALE { get; set; }
        public Int16 DATETIME_PRECISION { get; set; }
        public string CHARACTER_SET_CATALOG { get; set; }
        public string CHARACTER_SET_SCHEMA { get; set; }
        public string CHARACTER_SET_NAME { get; set; }
        public string COLLATION_CATALOG { get; set; }
        public string COLLATION_SCHEMA { get; set; }
        public string COLLATION_NAME { get; set; }
        public string DOMAIN_CATALOG { get; set; }
        public string DOMAIN_SCHEMA { get; set; }
        public string DOMAIN_NAME { get; set; }
    }

    [Table("INFORMATION_SCHEMA_COLUMNS")]
    public class _INFORMATION_SCHEMA_COLUMNS
    {
        public _INFORMATION_SCHEMA_COLUMNS()
        {
        }

        public _INFORMATION_SCHEMA_COLUMNS(bool setDefaultValue)
        {
            TABLE_CATALOG = "";
            TABLE_SCHEMA = "";
            TABLE_NAME = "";
            COLUMN_NAME = "";
            ORDINAL_POSITION = 0;
            COLUMN_DEFAULT = "";
            IS_NULLABLE = "";
            DATA_TYPE = "";
            CHARACTER_MAXIMUM_LENGTH = 0;
            CHARACTER_OCTET_LENGTH = 0;
            NUMERIC_PRECISION = 0;
            NUMERIC_PRECISION_RADIX = 0;
            NUMERIC_SCALE = "";
            DATETIME_PRECISION = 0;
            CHARACTER_SET_CATALOG = "";
            CHARACTER_SET_SCHEMA = "";
            CHARACTER_SET_NAME = "";
            COLLATION_CATALOG = "";
            COLLATION_SCHEMA = "";
            COLLATION_NAME = "";
            DOMAIN_CATALOG = "";
            DOMAIN_SCHEMA = "";
            DOMAIN_NAME = "";
        }

        public string TABLE_CATALOG { get; set; }
        public string TABLE_SCHEMA { get; set; }
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public Int32 ORDINAL_POSITION { get; set; }
        public string COLUMN_DEFAULT { get; set; }
        public string IS_NULLABLE { get; set; }
        public string DATA_TYPE { get; set; }
        public Int32 CHARACTER_MAXIMUM_LENGTH { get; set; }
        public Int32 CHARACTER_OCTET_LENGTH { get; set; }
        public byte NUMERIC_PRECISION { get; set; }
        public Int32 NUMERIC_PRECISION_RADIX { get; set; }
        public string NUMERIC_SCALE { get; set; }
        public Int16 DATETIME_PRECISION { get; set; }
        public string CHARACTER_SET_CATALOG { get; set; }
        public string CHARACTER_SET_SCHEMA { get; set; }
        public string CHARACTER_SET_NAME { get; set; }
        public string COLLATION_CATALOG { get; set; }
        public string COLLATION_SCHEMA { get; set; }
        public string COLLATION_NAME { get; set; }
        public string DOMAIN_CATALOG { get; set; }
        public string DOMAIN_SCHEMA { get; set; }
        public string DOMAIN_NAME { get; set; }
    }
}