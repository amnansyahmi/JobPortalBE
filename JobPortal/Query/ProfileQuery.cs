using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMLP.Query
{
    public class ProfileQuery
    {

        public enum SqlCase
        {
            GetProfileLoad
                , GetProfileDetail
                , GetStaffDetail
                , GetParameterValue
               , GetAlertList
                , GetTranHit
                , GetProdTypeList
                , GetTranTypeList
                , GetGroupName

        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.GetProfileLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by CIF_ID asc) as Row, *  FROM ACCOUNT01";
                    break;

                case SqlCase.GetProfileDetail:
                    sqlStatement = "SELECT * FROM ACCOUNT01 WHERE  " +
                          " (CIF_ID =@CIF_ID)";
                    break;
                case SqlCase.GetStaffDetail:
                    sqlStatement = "SELECT * FROM COR_STAFF WHERE  " +
                          " (COR_USERID =@COR_USERID)";
                    break;
                case SqlCase.GetParameterValue:
                    sqlStatement = "SELECT * FROM COR_PARAMETER WHERE  " +
                          " (COR_COMP_CODE =@COR_COMP_CODE)";
                    break;
                case SqlCase.GetAlertList:
                    sqlStatement = "SELECT * FROM ALERTTRAN WHERE  " +
                          " (CIF_ID =@CIF_ID)";
                    //" (@ACCOUNT_NO = '' or ACCOUNT_NO =@ACCOUNT_NO)";
                    break;

                case SqlCase.GetTranHit:
                    sqlStatement = "SELECT * FROM BANKFINTRANHIT01 WHERE  " +
                          " (ALERT_ID =@ALERT_ID)";
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
                case SqlCase.GetGroupName:
                    sqlStatement = "SELECT * FROM GROUPMASTER WHERE  " +
                                   " (GRP_ID =@GRP_ID)";
                    break;


            }
            return sqlStatement;
        }


    }
}