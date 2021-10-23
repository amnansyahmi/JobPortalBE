using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMLP.Query
{
    public class PeopleQuery
    {

        public enum SqlCase
        {       
                //Get Statement
                GetPeopleLoad
                , GetPeopleDetail

                //Update Statement
                , UpdatePeopleDetail

        }

        public static string GetStatementPeople(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {

                //siti added 17062020
                case SqlCase.GetPeopleLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by userId asc) as Row, *  FROM PEOPLE_DETAIL";
                    break;

                case SqlCase.GetPeopleDetail:
                    sqlStatement = "SELECT * FROM STAFF WHERE  " +
                          " (USER_ID =@USER_ID)";
                    break;
            }
            return sqlStatement;
        }


        public static string UpdateStatementPeople(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {

                //siti added 17062020
                //case SqlCase.UpdatePeopleDetail:
                //    sqlStatement = "INSERT ";
                //    break;

            }
            return sqlStatement;
        }

    }
}