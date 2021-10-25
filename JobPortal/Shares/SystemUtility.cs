using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Models;
using AdminQueryManager;
using PeopleQueryManager;
using JobPortal.Shares;

namespace JobPortal.Shares
{
    public static class SystemUtility
    {
        public enum CustomFieldType
        {
            DropDownListField = 5
            , TextField = 6
            , TextFieldReadOnly = 7
            , IntegerField = 8
            , DecimalField = 9
            , DateField = 10
            , LabelField = 1
        }

        public static string clsEmbeddedRQuoteToLQuote(string strText)
        {
            var clsEmbeddedRQuoteToLQuote = strText.Replace("'", "`");
            if (string.IsNullOrEmpty(clsEmbeddedRQuoteToLQuote) == true)
                clsEmbeddedRQuoteToLQuote = "";
            return clsEmbeddedRQuoteToLQuote;
        }

        public static string clsEmbeddedQuote(string strText)
        {
            var clsEmbeddedQuote = strText.Replace("'", "''");
            if (string.IsNullOrEmpty(clsEmbeddedQuote) == true)
                clsEmbeddedQuote = "";
            return clsEmbeddedQuote;
        }

        public static void RegisterAlertMessage_Ajax(string errorDesc, string errorDesc2 = "")
        {
            string strMsg = errorDesc;
            if (errorDesc2.Trim().Length > 0)
                strMsg += " (" + errorDesc2 + ")";
            //
            string script = "alert('" + strMsg + "');";
        }

        public static dynamic ConvertToInt<t>(string val)
        {
            string str = (val == "") ? "0" : val;
            return Convert.ChangeType(str, typeof(t));
        }

        public static int ConvertToInt(string val)
        {
            string str = (val == "") ? "0" : val;
            return int.Parse(str);
        }

        public static DateTime ConvertInt2DateTime(int date, int time = 0)
        {
            if (date.ToString().Length != 8)
                return new DateTime();

            string dt = date.ToString().Insert(4, "-").Insert(7, "-");
            string tm = time.ToString("D6").Insert(2, ":").Insert(5, ":");

            return DateTime.Parse(dt + " " + tm);
        }

        public static DateTime ConvertInt2DateTime(string date, string time = "0")
        {
            int dateVal = 0;
            int timeVal = 0;

            if (!int.TryParse(date, out dateVal))
                return new DateTime();
            if (!int.TryParse(time, out timeVal))
                return new DateTime();

            if (dateVal.ToString().Length != 8)
                return new DateTime();

            string dt = dateVal.ToString().Insert(4, "-").Insert(7, "-");
            string tm = timeVal.ToString("D6").Insert(2, ":").Insert(5, ":");

            return DateTime.Parse(dt + " " + tm);
        }
    }
}