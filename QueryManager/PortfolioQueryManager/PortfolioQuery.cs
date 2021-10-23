//Author : AS 20200606

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioQueryManager
{
    public class PortfolioQuery
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
                , GetPortfolioAlert
                , GetTranHistory
                , GetPortfolioRfDetail
                , GetPortfolioGeneralInfo
                , GetAccountDetail
                , GetPortfolioRFWMDetailLoad
                , GetPortfolioRFSelectList
                , GetPortfolioCaseSelect
                , GetWatchlistRedFlag
                , GetWeeklyWatchlistRedFlag
                , GetDailyWatchlistRedFlag
                , GetActivePortfolio
                , GetRegulatorSubmission
                , GetRFOMDetails
                , GetPortfolioRFOMDetailLoad
                , GetOMRFSelectList
                , GetOMCaseSelect
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.GetProfileLoad:

                    sqlStatement = " SELECT CASE WHEN ((RISK_NEW*0.8) + (RISK_WM*0.2)) <=1.6  THEN 1  ";
                    sqlStatement += " WHEN ((RISK_NEW*0.8) + (RISK_WM*0.2)) BETWEEN 1.61 AND 2.3  THEN 2  ";
                    sqlStatement += " WHEN ((RISK_NEW*0.8) + (RISK_WM*0.2)) > 2.3  ";
                    sqlStatement += " THEN 3  ";
                    sqlStatement += " END AS 'PRIORITY'  ";
                    sqlStatement += " ,NO_CIF  ";
                    sqlStatement += " , CASE WHEN CNT_ADDON > 0 THEN CNT_ADDON  "; // Start WM_CNT
                    sqlStatement += " WHEN CNT_NEW > 0 THEN CNT_NEW  ";
                    sqlStatement += " ELSE 0  ";
                    sqlStatement += " END AS 'WM_CNT'  ";
                    sqlStatement += " ,CASE WHEN CNT_ADDON > 0 THEN 'ADDON'  ";
                    sqlStatement += " WHEN CNT_NEW > 0 THEN 'NEW'  ";
                    sqlStatement += " ELSE 'NONE'  ";
                    sqlStatement += " END AS 'WM_LABEL'  "; // End WM_CNT
                    sqlStatement += " , CASE WHEN CNT_ADDON_OM > 0 THEN CNT_ADDON_OM  "; // Start OM_CNT
                    sqlStatement += " WHEN CNT_NEW_OM > 0 THEN CNT_NEW_OM  ";
                    sqlStatement += " ELSE 0 ";
                    sqlStatement += " END AS 'OM_CNT'  ";
                    sqlStatement += " ,CASE WHEN CNT_ADDON_OM > 0 THEN 'ADDON_OM'  ";
                    sqlStatement += " WHEN CNT_NEW_OM > 0 THEN 'NEW_OM'  ";
                    sqlStatement += " ELSE 'NONE_OM'  ";
                    sqlStatement += " END AS 'OM_LABEL'  "; // End OM_CNT
                    sqlStatement += " ,INFO_NAME_FULL  ";
                    sqlStatement += " FROM (SELECT NO_CIF  ";
                    sqlStatement += " ,NO_MASTER  ";
                    sqlStatement += " ,INFO_NAME_FULL  ";
                    sqlStatement += " ,RISK_NEW  ";
                    sqlStatement += " ,CASE	WHEN (SELECT COUNT(RF_ID) FROM RF_WM WHERE AUDIT_STATUS = 0 AND RF_WM.NO_CIF = CUSTOMER.NO_CIF) <= 10 THEN 1  ";
                    sqlStatement += " WHEN (SELECT COUNT(RF_ID) FROM RF_WM WHERE AUDIT_STATUS = 0 AND RF_WM.NO_CIF = CUSTOMER.NO_CIF) BETWEEN 11 AND 30 THEN 2  ";
                    sqlStatement += " WHEN (SELECT COUNT(RF_ID) FROM RF_WM WHERE AUDIT_STATUS = 0 AND RF_WM.NO_CIF = CUSTOMER.NO_CIF) >= 31 THEN 3  ";
                    sqlStatement += " END AS 'RISK_WM'  ";
                    sqlStatement += " ,(SELECT COUNT(RF_ID) FROM RF_WM WHERE AUDIT_STATUS = 0 AND RF_WM.NO_CIF = CUSTOMER.NO_CIF) AS 'RF_WL'  "; // Start WM_CNT
                    sqlStatement += " ,(SELECT COUNT(RF_ID) FROM RF_WM WHERE AUDIT_STATUS <> 300 AND MODULE_ID = 7 AND RF_WM.NO_CIF = CUSTOMER.NO_CIF AND CASE_ID <> 0) AS 'CNT_ADDON'  ";
                    sqlStatement += " ,(SELECT COUNT(RF_ID) FROM RF_WM WHERE AUDIT_STATUS = 100 AND MODULE_ID = 7 AND RF_WM.NO_CIF = CUSTOMER.NO_CIF AND CASE_ID = 0) AS 'CNT_NEW'  "; // End WM_CNT
                    sqlStatement += " ,(SELECT COUNT(RF_ID) FROM RF_OM WHERE AUDIT_STATUS = 0 AND RF_OM.NO_CIF = CUSTOMER.NO_CIF) AS 'RF_OB'  "; // Start OM_CNT
                    sqlStatement += " ,(SELECT COUNT(RF_ID) FROM RF_OM WHERE AUDIT_STATUS <> 300 AND MODULE_ID = 7 AND RF_OM.NO_CIF = CUSTOMER.NO_CIF AND CASE_ID <> 0) AS 'CNT_ADDON_OM'  ";
                    sqlStatement += " ,(SELECT COUNT(RF_ID) FROM RF_OM WHERE AUDIT_STATUS = 100 AND MODULE_ID = 7 AND RF_OM.NO_CIF = CUSTOMER.NO_CIF AND CASE_ID = 0) AS 'CNT_NEW_OM'  "; // End OM_CNT
                    sqlStatement += " FROM CUSTOMER  ";
                    sqlStatement += " ) CUSTOMER  ";
                    break;

                case SqlCase.GetProfileDetail:
                    sqlStatement = "SELECT * FROM ACCOUNT WHERE  " +
                          " (NO_CIF =@CIF_ID)";
                    break;

                case SqlCase.GetStaffDetail:
                    sqlStatement = "SELECT * FROM STAFF WHERE  " +
                          " (USER_ID =@USER_ID)";
                    break;

                case SqlCase.GetParameterValue:
                    sqlStatement = "SELECT * FROM PARAM_STAFF WHERE  " +
                          " (CODE_COMP =@CODE_COMP)";
                    break;

                case SqlCase.GetAlertList:
                    sqlStatement = "SELECT OUTSTANDINGDAYS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), TRAN_DATE, 112),GETDATE()), * FROM RF_TM WHERE  " +
                          " (NO_CIF =@NO_CIF)";
                    //" (@ACCOUNT_NO = '' or ACCOUNT_NO =@ACCOUNT_NO)";
                    break;

                case SqlCase.GetTranHit:
                    sqlStatement = "SELECT * FROM RF_TMDTL WHERE  " +
                          " (ALERT_ID =@ALERT_ID)";
                    break;

                // please revisit to optimize. doing this to avoid sql join.
                case SqlCase.GetProdTypeList:
                    sqlStatement = "SELECT * FROM PARAM_ERROR WHERE  " +
                          " (MODULE_ID = '121')";
                    break;

                case SqlCase.GetTranTypeList:
                    sqlStatement = "SELECT * FROM PARAM_ERROR WHERE  " +
                                   " (INFO_CODE =@INFO_CODE)";
                    break;

                case SqlCase.GetGroupName:
                    sqlStatement = "SELECT * FROM GROUPMASTER WHERE  " +
                                   " (GRP_ID =@GRP_ID)";
                    break;

                //dila added
                case SqlCase.GetPortfolioAlert:
                    sqlStatement = "SELECT * FROM RF_CASE WHERE  " +
                                   " (NO_CIF =@NO_CIF)";
                    break;

                //dila added
                case SqlCase.GetTranHistory:
                    sqlStatement = "SELECT * FROM TRANSACTIONS WHERE  " +
                                   " (NO_CIF =@NO_CIF)";

                    break;

                //dila added
                case SqlCase.GetPortfolioRfDetail:
                    sqlStatement = "SELECT * FROM RF_TMDTL WHERE  " +
                                   " (RF_ID =@RF_ID)";
                    break;

                //dila added
                case SqlCase.GetPortfolioGeneralInfo:
                    sqlStatement = "SELECT * FROM RF_PORTFOLIO WHERE  " +
                                   " (NO_CIF =@NO_CIF)";
                    break;

                //case SqlCase.GetPortfolioRFSelectList:
                //    sqlStatement = "SELECT ROW_NUMBER() over(order by RF_ID asc) as Row, CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_WM WHERE" +
                //                   "(NO_CIF = @NO_CIF)";
                //    break;

                case SqlCase.GetPortfolioCaseSelect:
                    sqlStatement = "SELECT B.WF_DESCRIPTION, * FROM RF_CASE A LEFT JOIN CONFIG_WF_DTL B ON A.MODULE_ID = B.WF_MODULE AND A.AUDIT_USER_LEVEL = B.WF_LEVEL";
                    break;

                case SqlCase.GetOMCaseSelect:
                    sqlStatement = "SELECT B.WF_DESCRIPTION, * FROM RF_CASE A LEFT JOIN CONFIG_WF_DTL B ON A.MODULE_ID = B.WF_MODULE AND A.AUDIT_USER_LEVEL = B.WF_LEVEL";
                    break;

                case SqlCase.GetWatchlistRedFlag:
                    sqlStatement = "SELECT DATENAME(MONTH, DATEADD(MONTH, CAST(MONTH(AUDIT_CREATED_DATE) AS int), -1)) AS DATE_FILTER, " +
                        " (SELECT COUNT(RF_ID) AS TOTAL_NEW FROM RF_WM WHERE AUDIT_STATUS = 100 AND MONTH(A.AUDIT_CREATED_DATE) = MONTH(AUDIT_CREATED_DATE)) AS TOTAL_NEW, " +
                        " (SELECT COUNT(RF_ID) AS TOTAL_ADDON FROM RF_WM WHERE MONTH(A.AUDIT_CREATED_DATE) = MONTH(AUDIT_CREATED_DATE)) as TOTAL_ADDON," +
                        " (SELECT COUNT(RF_ID) AS TOTAL_DROP FROM RF_WM WHERE AUDIT_STATUS = 300 AND MONTH(A.AUDIT_CREATED_DATE) = MONTH(AUDIT_CREATED_DATE)) as TOTAL_DROP " +
                        " FROM RF_WM A WHERE YEAR(A.AUDIT_CREATED_DATE) = YEAR(GETDATE()) AND MONTH(A.AUDIT_CREATED_DATE) <= MONTH(GETDATE())  GROUP BY MONTH(AUDIT_CREATED_DATE)";
                    break;

                case SqlCase.GetWeeklyWatchlistRedFlag:
                    sqlStatement = "SELECT CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23) AS DATE_FILTER,  " +
                        "(SELECT COUNT(RF_ID) AS TOTAL_NEW " +
                        "FROM RF_WM WHERE AUDIT_STATUS = 100 AND CONVERT(VARCHAR, A.AUDIT_CREATED_DATE, 23) = CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)) AS TOTAL_NEW, " +
                        "(SELECT COUNT(RF_ID) AS TOTAL_ADDON " +
                        "FROM RF_WM WHERE CONVERT(VARCHAR, A.AUDIT_CREATED_DATE, 23) = CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)) as TOTAL_ADDON, " +
                        "(SELECT COUNT(RF_ID) AS TOTAL_DROP " +
                        "FROM RF_WM WHERE AUDIT_STATUS = 300 AND CONVERT(VARCHAR, A.AUDIT_CREATED_DATE, 23) = CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)) as TOTAL_DROP " +
                        "FROM RF_WM A WHERE AUDIT_CREATED_DATE BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE()  GROUP BY CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)";
                    break;

                case SqlCase.GetDailyWatchlistRedFlag:
                    sqlStatement = "SELECT CAST(CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23) AS NVARCHAR) AS DATE_FILTER,  " +
                        "(SELECT COUNT(RF_ID) AS TOTAL_NEW " +
                        "FROM RF_WM WHERE AUDIT_STATUS = 100 AND CONVERT(VARCHAR, A.AUDIT_CREATED_DATE, 23) = CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)) AS TOTAL_NEW, " +
                        "(SELECT COUNT(RF_ID) AS TOTAL_ADDON " +
                        "FROM RF_WM WHERE CONVERT(VARCHAR, A.AUDIT_CREATED_DATE, 23) = CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)) as TOTAL_ADDON, " +
                        "(SELECT COUNT(RF_ID) AS TOTAL_DROP " +
                        "FROM RF_WM WHERE AUDIT_STATUS = 300 AND CONVERT(VARCHAR, A.AUDIT_CREATED_DATE, 23) = CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)) as TOTAL_DROP " +
                        "FROM RF_WM A WHERE CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23) = CONVERT(VARCHAR, GETDATE(), 23)  GROUP BY CONVERT(VARCHAR, AUDIT_CREATED_DATE, 23)";
                    break;

                case SqlCase.GetActivePortfolio:
                    sqlStatement = "SELECT * FROM RF_CASE";

                    break;

                case SqlCase.GetRegulatorSubmission:
                    sqlStatement = "SELECT * FROM RPT_STR_HDR";

                    break;
            }
            return sqlStatement;
        }

        public static string GetAccountDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                //Get RF Details by CIF No.
                case 1:
                    sqlStatement = "SELECT * FROM ACCOUNT WHERE  " +
                          " (NO_CIF =@NO_CIF)";
                    break;
                //Get RF Details by RF ID
                case 2:
                    sqlStatement = "SELECT * FROM ACCOUNT WHERE  " +
                          " (NO_ACC =@NO_ACC)";
                    break;

                default:
                    sqlStatement = "SELECT * FROM ACCOUNT";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRFWMDetails(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                //Get RF Details by CIF No.
                case 1:
                    sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_WM WHERE" +
                                   "(NO_CIF = @NO_CIF)";
                    break;

                case 2:
                    sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_WM WHERE" +
                                   "(RF_ID = @RF_ID)";
                    break;
            }
            return sqlStatement;
        }

        //OM
        public static string GetRFOMDetails(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                //Get RF Details by CIF No.
                case 1:
                    sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_OM WHERE" +
                                   "(NO_CIF = @NO_CIF)";
                    break;

                case 2:
                    sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_OM WHERE" +
                                   "(RF_ID = @RF_ID)";
                    break;
            }
            return sqlStatement;
        }

        //public static string GetPortfolioRFSelectList(Int32 SQLCase)
        //{
        //    string sqlStatement = "";

        //    switch (SQLCase)
        //    {
        //        //Get RF Details by CIF No.
        //        case 1:
        //            sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_WM WHERE  " +
        //                  " (NO_CIF =@NO_CIF)";
        //            break;
        //        //Get RF Details by RF ID
        //        case 2:
        //            sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_WM WHERE  " +
        //                 " (RF_ID =@RF_ID)";
        //            break;
        //    }
        //    return sqlStatement;
        //}

        //OM Select
        public static string GetOMRFSelectList(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                //Get RF Details by CIF No.
                case 1:
                    sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_OM WHERE  " +
                          " (NO_CIF =@NO_CIF)";
                    break;
                //Get RF Details by RF ID
                case 2:
                    sqlStatement = "SELECT CASE_OS=DATEDIFF(DAY, CONVERT(NVARCHAR(8), HIT_DATE, 112),GETDATE()), * FROM RF_OM WHERE  " +
                         " (RF_ID =@RF_ID)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetPortfolioRFWMDetailLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT CASE CAST(HIT_GENDER AS NVARCHAR) WHEN '0' THEN 'Male' WHEN '1' THEN 'Female' ELSE 'Unknown' END AS HIT_GENDER_DESC, " +
                        "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 701003 AND CODE_SUB = RF_WMDTL.STATUS_INV) AS FINDINGS, " +
                        "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 701004 AND CODE_SUB = RF_WMDTL.TYPE_EXPO) AS EXPOSURE, * FROM RF_WMDTL WHERE " +
                          " (RF_ID =@RF_ID)";

                    break;
            }
            return sqlStatement;
        }

        //OM
        public static string GetPortfolioRFOMDetailLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT CASE CAST(HIT_GENDER AS NVARCHAR) WHEN '1' THEN 'Male' WHEN '2' THEN 'Famale' ELSE 'None' END AS HIT_GENDER_DESC, * FROM RF_OMDTL WHERE " +
                        " (RF_ID =@RF_ID)";
                    //sqlStatement = "SELECT CASE CAST(HIT_GENDER AS NVARCHAR) WHEN '0' THEN 'Male' WHEN '1' THEN 'Famale' ELSE 'Unknown' END AS HIT_GENDER_DESC, " +
                    //    "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 200002 AND CODE_SUB = RF_WMDTL.STATUS_INV) AS FINDINGS, " +
                    //    "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 200001 AND CODE_SUB = RF_WMDTL.TYPE_EXPO) AS EXPOSURE, * FROM RF_OMDTL WHERE " +
                    //      " (RF_ID =@RF_ID)";

                    break;
            }
            return sqlStatement;
        }

        public static string RF_TM(String sqlSelect, String sqlJoin, String sqlWhere, string sqlOrder)
        {
            string sqlStatement = "SELECT " + sqlSelect + " FROM RF_TM " + sqlJoin + sqlWhere + sqlOrder;

            return sqlStatement;
        }

        public static string GetRFCase(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                //Get RF Details by CIF No.
                case 1:
                    sqlStatement = "SELECT (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = '507' AND CODE_SUB = CASE_STATUS) AS STATUS_DESC, * FROM RF_CASE WHERE  " +
                                    " (NO_CIF =@NO_CIF)";

                    break;
                //Get RF Details by RF ID
                case 2:
                    sqlStatement = "SELECT B.* FROM RF_TM A   " +
                                   " INNER JOIN RF_CASE B ON B.CASE_ID = A.CASE_ID " +
                                   " WHERE A.NO_MASTER = @NO_MASTER AND B.CASE_STATUS = 0";
                    break;
            }
            return sqlStatement;
        }

        public static string GetCustomerDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                //Get Customer Details via CIF No.
                case 1:
                    sqlStatement = "SELECT * FROM CUSTOMER WHERE  " +
                                   " (NO_CIF =@NO_CIF)";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM CUSTOMER WHERE  " +
                                    " (@INFO_NAME_FULL='' or INFO_NAME_FULL like '%'+@INFO_NAME_FULL+'%') " +
                                   " AND ((@ID1_NO = '' OR ID1_NO = @ID1_NO)" +
                                   " OR (@ID2_NO = '' OR ID2_NO = @ID2_NO)) " +
                                   " AND (@NO_CIF = '' OR NO_CIF = @NO_CIF)";
                    break;
            }
            return sqlStatement;
        }
    }
}