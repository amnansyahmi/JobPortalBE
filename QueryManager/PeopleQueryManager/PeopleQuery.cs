using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleQueryManager
{
    public class PeopleQuery
    {
        public enum SqlCase
        {       
                  GetPeopleLoad
                , GetPeopleDetail
                , GetRFTemplate
        }

        public static string GetPeopleLoad()
        {
            string sqlStatement = "";

                    sqlStatement = "select * , CASE CAST(USER_OFFICE AS NVARCHAR) WHEN '1' THEN 'Kuala lumpur' WHEN '2' THEN 'Wangsa maju' WHEN '3' THEN 'Cheras' WHEN '4' THEN 'Setapak' WHEN '5' THEN 'SS2, Petaling Jaya' WHEN '6' THEN 'Petaling jaya' END AS USER_OFFICE_DESC FROM STAFF";
            //        sqlStatement = "SELECT B.*, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 507 AND CODE_SUB = B.DATA_VALUEI1) AS ASSIGN_STATUS, " +
            //"CASE CAST(USER_OFFICE AS NVARCHAR) WHEN '1' THEN 'Kuala lumpur' WHEN '2' THEN 'Wangsa maju' WHEN '3' THEN 'Cheras' WHEN '4' THEN 'Setapak' WHEN '5' THEN 'SS2, Petaling Jaya' WHEN '6' THEN 'Petaling jaya'" +
            //" END AS USER_OFFICE_DESC FROM STAFF B";



            return sqlStatement;
        }

        public static string GetRFTemplate()
        {
            string sqlStatement = "";

                    sqlStatement = "select *  FROM PARAM_ROUTE";

            return sqlStatement;
        }

        public static string GetPeopleDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM STAFF WHERE  " +
                          " (USER_ID =@USER_ID)";
                    break;

            }
            return sqlStatement;

        }


    }
}