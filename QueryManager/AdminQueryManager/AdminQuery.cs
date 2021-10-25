using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminQueryManager
{
    public class AdminQuery
    {
        public static string GetMenuDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                case 1:
                    sqlStatement = "SELECT * " +
                          " FROM MENU " +
                          " WHERE FLAG_ENABLE = 1";
                    break;

                    // please revisit to optimize. doing this to avoid sql join.
            }
            return sqlStatement;
        }

        //public static string GetStaffDetail(SqlCase sqlCase)
        public static string GetStaffDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM STAFF ";
                    break;

                    // please revisit to optimize. doing this to avoid sql join.
            }
            return sqlStatement;
        }
    }
}