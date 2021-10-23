using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shares
{
    public static class SqlHelper
    {
        public static string AddSortingType(string sqlStatement, string sortType)
        {
            if (sortType.ToLower().Trim() == "asc" || sortType.ToLower().Trim() == "desc")
                return sqlStatement + " " + sortType.ToLower().Trim();
            else
                return sqlStatement + " " + "asc";
        }

        public static DbParameter CreateDbParameter(string paramName, object paramValue)
        {
            if (GlobalVariables.ConnectionProvider == ConnectionProviders.Sql)
                return new SqlParameter(paramName, paramValue);
            else if (GlobalVariables.ConnectionProvider == ConnectionProviders.OleDb)
                return new OleDbParameter(paramName, paramValue);
            else
                return null;
        }

        public static DbParameter[] CreateDbParameters(params KeyValuePair<String, Object>[] keyvalue)
        {
            if (GlobalVariables.ConnectionProvider == ConnectionProviders.Sql)
            {
                var parJobPortalist = new List<SqlParameter>();

                foreach (var v in keyvalue)
                    parJobPortalist.Add(new SqlParameter(v.Key, v.Value));

                return parJobPortalist.ToArray();
            }
            else if (GlobalVariables.ConnectionProvider == ConnectionProviders.Sql)
            {
                var parJobPortalist = new List<OleDbParameter>();

                foreach (var v in keyvalue)
                    parJobPortalist.Add(new OleDbParameter(v.Key, v.Value));

                return parJobPortalist.ToArray();
            }

            return null;
        }
    }
}