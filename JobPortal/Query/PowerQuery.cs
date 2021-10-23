using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMLP.Query
{
    public class PowerQuery
    {

        public enum SqlCase
        {
            //Get Statement
            GetParameterValue
                , GetProdTypeList
                , GetTranTypeList
                , GetGroupName
                , GetCorCodeDetails

                //insert Statement
                , insertIntoEventViewer
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.GetParameterValue:
                    sqlStatement = "SELECT * FROM COR_PARAMETER WHERE  " +
                          " (COR_COMP_CODE =@COR_COMP_CODE)";
                    break;
                // please revisit to optimize. doing this to avoid sql join.
                case SqlCase.GetProdTypeList:
                    sqlStatement = "SELECT * FROM cor_code WHERE  " +
                          " (cor_codeno = '121')";
                    break;
                case SqlCase.GetTranTypeList:
                    sqlStatement = "SELECT * FROM cor_code WHERE  " +
                                   " (cor_CodeKey =@cor_CodeKey)";
                    break;
                case SqlCase.GetCorCodeDetails:
                    sqlStatement = "SELECT * FROM cor_code WHERE  " +
                                   " (cor_CodeNo =@cor_CodeNo) ";
                    //" (cor_CodeKey =@cor_CodeKey)";
                    break;
                case SqlCase.GetGroupName:
                    sqlStatement = "SELECT * FROM GROUPMASTER WHERE  " +
                                   " (GRP_ID =@GRP_ID)";
                    break;


            }
            return sqlStatement;
        }

        public static string insertIntoEventViewer()
        {
            string sqlStatement = "";

            sqlStatement = "INSERT INTO event_viewer " +
                            "(userid, comp_code, tran_date, action, access_date, page_name, room_name, menu_name) " +
                            "values " +
                            "(@userId, @Comp_Code, @tran_date, @Action, getdate(), @URL, @RoomName, @MenuName)";

            return sqlStatement;
        }
    }
}