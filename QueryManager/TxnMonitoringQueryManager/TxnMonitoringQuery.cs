//Author : AS 20200606

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxnMonitoringQueryManager
{
    public class TxnMonitoringQuery
    {
        //Dila 20200701
        public enum SqlCase
        {
            GetTxnMonitoringLoad
          , GetCaseDetail
          , GetTxnHistList
          , GetRedFlagList
          , GetRedFlagDetailList
          , GetTranHistory
          , GetTxncase
          , GetRedFlagSelectList
          , GetCaseSelect
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.GetTxnMonitoringLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by CASE_ID asc) as Row, *  FROM RF_CASE";
                    break;

                case SqlCase.GetCaseDetail:
                    sqlStatement = "SELECT * FROM RF_CASE WHERE  " +
                          " (CASE_ID =@CASE_ID)";
                    break;

                case SqlCase.GetTxnHistList:
                    sqlStatement = "SELECT * FROM TRANSACTIONS WHERE  " +
                          " (NO_CIF =@NO_CIF)";
                    break;

                case SqlCase.GetRedFlagList:
                    sqlStatement = "select ROW_NUMBER() over(order by RF_ID asc) as Row, OUTSTANDINGDAYS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), TRAN_DATE, 112),GETDATE()), * FROM RF_TM";
                    break;

                case SqlCase.GetRedFlagDetailList:
                    sqlStatement = "select ROW_NUMBER() over(order by RF_ID asc) as Row, * FROM RF_TMDTL";
                    break;

                case SqlCase.GetTranHistory:
                    sqlStatement = "select ROW_NUMBER() over(order by NO_CIF asc) as Row, * FROM TRANSACTIONS";
                    break;

                case SqlCase.GetTxncase:
                    sqlStatement = "select ROW_NUMBER() over(order by CASE_ID asc) as Row, * FROM RF_CASE";
                    break;

                case SqlCase.GetRedFlagSelectList:
                    sqlStatement = "select ROW_NUMBER() over(order by RF_ID asc) as Row, OUTSTANDINGDAYS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), TRAN_DATE, 112),GETDATE()),  * FROM RF_TM";
                    break;

                case SqlCase.GetCaseSelect:
                    sqlStatement = "select ROW_NUMBER() over(order by CASE_ID asc) as Row, * FROM RF_CASE";
                    break;
            }
            return sqlStatement;
        }
    }
}