using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingQueryManager
{
    public class SettingQuery
    {
        public enum SqlCase
        {
            GetOrgDetail
                , GetOrgIDDetailDelete
                , GetOrgLoad
                , GetOrgCodeDetail
                , GetRouteLoad
                , GetRouteDetail
                , GetWorkflowLoad
                , GetIdDetail
                , GetWfLvelDetail
                , GetBtnSetupDetail
                , GetBtnDetail
                , GetfilterDetail
                , GetFilterInfo
                , GetParameterLoad
                , GetMasterNoDetail
                , GetParameterListLoad
                , GetErrorCodeload
                , GetCodeNoDetail
                , GetAppSiteLoad
                , GetParamNoDetail
                , GetMappingLoad
                , GetMappingDetail
                , GetCustomStatusLoad
                , GetLicenseLoadDetail
                , GetClientLoad
                , GetClientDetail
                , GetClientHistLoad
                , GetEODJobLoad
                , GetEODJobDetail
                , GetJobStepLoad
                , GetJobStepDetail
                , GetTemplateLoad
                , GetOBIdDetail
                , GetOBLoad
                , GetOBLvelDetail
                , GetOBfilterDetail
                , GetOBBtnSetupDetail
                , GetOBBtnDetail
                , GetOBCustomStatusLoad
        }

        public static string InsertIntoParamLicense(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                case 1:
                    sqlStatement = " SET IDENTITY_INSERT PARAM_LICENSE ON INSERT INTO PARAM_LICENSE " +
                            "(CODE_COMP,CODE_ORG,NAME_COMP,NAME_ORG,DATE_VALID_TO,DATE_VALID_FROM,DATE_GRACE,KEY_LICENSE,KEY_VALIDATOR,KEY_DB_NAME,INFO_REG_NO, " +
                            "INFO_MODULES,KEY_TYPE,KEY_USERS,STATUS_LICENSE,AUDIT_CREATED_DATE,AUDIT_CREATED_USER,AUDIT_UPDATED_DATE,AUDIT_UPDATED_USER) " +
                            "VALUES " +
                            "(1, @CODE_ORG, @CODE_ORG, @NAME_ORG, @DATE_VALID_TO, FORMAT(getdate(), 'yyyyMMdd'), '', " +
                            "'', '', '', '', '', '', '',  @STATUS_LICENSE, GETDATE(),'','','')";

                    break;
            }
            return sqlStatement;
        }

        public static string GetOrgLoad()
        {
            string sqlStatement = "";

            sqlStatement = "select *  FROM PARAM_LICENSE";

            return sqlStatement;
        }

        public static string GetOrgCodeDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_LICENSE WHERE  " +
                          " (CODE_ORG =@CODE_ORG)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRouteLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = PARAM_ROUTE.CONFIG_STATUS) AS CONFIG_STATUS_DESC, *  FROM PARAM_ROUTE";

            return sqlStatement;
        }

        public static string GetRouteDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_ROUTE WHERE  " +
                          " (ROUTE_CODE =@ROUTE_CODE)";
                    break;
            }
            return sqlStatement;
        }

        //Onboard
        public static string GetTemplateLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = CONFIG_WF_HDR.WF_STATUS) AS WF_STATUS_DESC, *  FROM CONFIG_WF_HDR WHERE" +
                " (WF_MODULE ='9')";

            return sqlStatement;
        }

        public static string GetOBIdDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_HDR WHERE  " +
                          " (WF_ID =@WF_ID AND WF_MODULE = @WF_MODULE)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetOBLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = CONFIG_WF_DTL.WF_STATUS) AS WF_STATUS_DESC, * FROM CONFIG_WF_DTL WHERE  " +
                          " WF_ID =@WF_ID AND WF_MODULE = @WF_MODULE ";

                    break;
            }
            return sqlStatement;
        }

        public static string GetOBLvelDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetOBfilterDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";

                    break;
            }
            return sqlStatement;
        }

        public static string GetOBBtnSetupDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";

                    break;
            }
            return sqlStatement;
        }

        public static string GetOBBtnDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetOBCustomStatusLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT B.*, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 107 AND CODE_SUB = B.DATA_VALUEI1) AS ASSIGN_STATUS, " +
                "CASE CAST(CONFIG_STATUS1 AS NVARCHAR) WHEN '0' THEN 'INACTIVE' ELSE 'ACTIVE' END AS CONFIG_STATUS1_DESC FROM CONFIG_CODES_DTL B where CODE_PRIME = 108";

            return sqlStatement;
        }

        //Watchlist
        public static string GetWorkflowLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = CONFIG_WF_HDR.WF_STATUS) AS WF_STATUS_DESC, *  FROM CONFIG_WF_HDR WHERE" +
                " (WF_MODULE ='7')";

            return sqlStatement;
        }

        public static string GetIdDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_HDR WHERE  " +
                          " (WF_ID =@WF_ID)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWfLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = CONFIG_WF_DTL.WF_STATUS) AS WF_STATUS_DESC, * FROM CONFIG_WF_DTL WHERE  " +
                          " WF_ID =@WF_ID AND WF_MODULE = @WF_MODULE ";

                    break;
            }
            return sqlStatement;
        }

        public static string GetWfLvelDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetBtnSetupDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";

                    break;
            }
            return sqlStatement;
        }

        public static string GetBtnDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetfilterDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    //sqlStatement = "SELECT WF_FILTER_STATUS FROM CONFIG_WF_TMDTL WHERE  " +
                    //      " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL) AND (WF_MODULE = @WF_MODULE)";

                    break;
            }
            return sqlStatement;
        }

        public static string GetFilterInfo(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT FILTER_NO, FILTER_NAME FROM CONFIG_WF_FILTER WHERE  " +
                          " (WF_ID =@WF_ID) AND (WF_LEVEL = @WF_LEVEL)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetParameterLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = CONFIG_CODES_HDR.CONFIG_STATUS) AS CONFIG_STATUS_DESC, *  FROM CONFIG_CODES_HDR";

            return sqlStatement;
        }

        public static string GetMasterNoDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_HDR WHERE  " +
                          " (CODE_PRIME =@CODE_PRIME)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetParameterListLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE  " +
                          " (CODE_PRIME =@CODE_PRIME)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetErrorCodeload()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT CASE CAST(CONFIG_STATUS1 AS NVARCHAR) WHEN '2' THEN 'INACTIVE' ELSE 'ACTIVE' END AS CONFIG_STATUS1_DESC, *  FROM CONFIG_CODES_DTL WHERE" +
                          " (CODE_PRIME ='1452')";

            return sqlStatement;
        }

        public static string GetCodeNoDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE" + "(CODE_SUB =@CODE_SUB)" + "AND (CODE_PRIME = 1452 )";
                    //sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE" + "CODE_SUB =@CODE_SUB AND CODE_ORG = @CODE_ORG AND CODE_COMP = @CODE_COMP AND CODE_PRIME ='2011001'";

                    break;
            }
            return sqlStatement;
        }

        public static string GetAppSiteLoad()
        {
            string sqlStatement = "";

            sqlStatement = "select *  FROM CONFIG_WEB";

            return sqlStatement;
        }

        public static string GetParamNoDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE  " +
                          " (CODE_SUB =@CODE_SUB)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetMappingLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT CASE CAST(CONFIG_STATUS AS NVARCHAR) WHEN '0' THEN 'INACTIVE' ELSE 'ACTIVE' END AS CONFIG_STATUS_DESC, *  FROM PARAM_MAPPING_HDR";

            return sqlStatement;
        }

        public static string GetMappingDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_HDR WHERE  " +
                          " (MAP_ID_HDR =@MAP_ID_HDR)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetEmailLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = PARAM_SMSEMAIL.INFO_STATUS) AS INFO_STATUS_DESC," +
                            "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 501 AND CODE_SUB = PARAM_SMSEMAIL.GRP_MODULE) AS MODULE_DESC," +
                            " *  FROM PARAM_SMSEMAIL";

            return sqlStatement;
        }

        public static string GetEmailDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_SMSEMAIL WHERE  " +
                          " (GRP_KEY =@GRP_KEY)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetAuthLoad()
        {
            string sqlStatement = "";

            sqlStatement = "select *  FROM PARAM_STAFF";

            return sqlStatement;
        }

        public static string GetDomainLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT CASE CAST(DATA_VALUEI1 AS NVARCHAR) WHEN '0' THEN 'INACTIVE' ELSE 'ACTIVE' END AS DATA_VALUEI1_DESC, *FROM CONFIG_CODES_DTL WHERE" +
                          " (CODE_PRIME ='203002')";

            return sqlStatement;
        }

        public static string GetDomainDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE" + "(CODE_SUB =@CODE_SUB)" + "AND (CODE_PRIME = 203002)";

                    break;
            }
            return sqlStatement;
        }

        public static string GetCannedLoad()
        {
            string sqlStatement = "";

            //sqlStatement = "SELECT CASE CAST(CONFIG_STATUS1 AS NVARCHAR) WHEN '0' THEN 'INACTIVE' ELSE 'ACTIVE' END AS CONFIG_STATUS1_DESC, *  FROM CONFIG_CODES_DTL";
            sqlStatement = "SELECT " +
                "(SELECT INFO_DESC FROM CONFIG_CODES_DTL A WHERE A.CODE_SUB = B.DATA_VALUEI1 AND A.CODE_PRIME = 501) AS MODULE_DESC, " +
                "(SELECT INFO_DESC FROM CONFIG_CODES_DTL A WHERE A.CODE_PRIME = 500 AND A.CODE_SUB = B.CONFIG_STATUS1) AS CONFIG_STATUS1_DESC, " +
                "(SELECT WF_NAME FROM CONFIG_WF_HDR WHERE WF_ID = DATA_VALUEI2 AND WF_MODULE = B.DATA_VALUEI1) AS WF_NAME, " +
                " * FROM CONFIG_CODES_DTL B WHERE " +
                "CODE_COMP = 1 " +
                "AND CODE_ORG = 1 " +
                "AND CODE_PRIME = '2012001'";

            //sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 110 AND CODE_SUB = CONFIG_CODES_DTL.CONFIG_STATUS1) AS CONFIG_STATUS1_DESC, *  FROM PARAM_SMSEMAIL";

            return sqlStatement;
        }

        public static string GetCannedDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE  " +
                          " (CODE_SUB =@CODE_SUB) AND (CODE_PRIME=@CODE_PRIME)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetLocationLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT CASE CAST(CONFIG_STATUS1 AS NVARCHAR) WHEN '0' THEN 'INACTIVE' ELSE 'ACTIVE' END AS CONFIG_STATUS1_DESC, *  FROM CONFIG_CODES_DTL WHERE" +
                            " (CODE_PRIME ='105')";
            ;

            return sqlStatement;
        }

        public static string GetLocationDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE  " +
                          " (CODE_SUB =@CODE_SUB)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRuleload()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = RULE_WM_HDR.RULE_STATUS) AS RULE_STATUS_DESC," +
                "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 7101 AND CODE_SUB = RULE_WM_HDR.WL_SCENARIO) AS WL_SCENARIO_DESC," +
                "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 508 AND CODE_SUB = RULE_WM_HDR.WL_TYPE) AS WL_TYPE_DESC," +
                " *  FROM RULE_WM_HDR";

            return sqlStatement;
            //SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 115 AND CODE_SUB = RULE_WM_HDR.WL_TYPE) AS WL_TYPE_DESC
        }

        public static string GetRuleDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM RULE_WM_HDR WHERE " +
                          " (RULE_ID =@RULE_ID)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetScreeningLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = RULE_WM_DTL.RULE_STATUS) AS RULE_STATUS_DESC, * FROM RULE_WM_DTL WHERE  " +
                          " (RULE_ID =@RULE_ID)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetLicenseLoadDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            sqlStatement = "select *  FROM PARAM_LICENSE where CODE_ORG=@CODE_ORG";

            return sqlStatement;
        }

        public static string GetMaxValue()
        {
            string sqlStatement = "";

            sqlStatement = "select max(code_sub) +1 from config_codes_dtl " +
                        "where CODE_COMP='1' AND CODE_ORG='1' AND CODE_PRIME='2012001'";

            return sqlStatement;
        }

        public static string GetMaxValueParamSMS()
        {
            string sqlStatement = "";

            sqlStatement = "select max(GRP_KEY) +1 from PARAM_SMSEMAIL ";

            return sqlStatement;
        }

        public static string GetMaxValueWfModule()
        {
            string sqlStatement = "";

            sqlStatement = "select max(WF_MODULE) +1 from CONFIG_WF_HDR ";

            return sqlStatement;
        }

        public static string GetMaxValueconId()
        {
            string sqlStatement = "";

            sqlStatement = "select max(RULE_CON_ID) from RULE_WM_DTL ";

            return sqlStatement;
        }

        public static string GetCustomStatusLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT B.*, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 507 AND CODE_SUB = B.DATA_VALUEI1) AS ASSIGN_STATUS, " +
                "CASE CAST(CONFIG_STATUS1 AS NVARCHAR) WHEN '2' THEN 'INACTIVE' ELSE 'ACTIVE' END AS CONFIG_STATUS1_DESC FROM CONFIG_CODES_DTL B where CODE_PRIME = 7001";

            return sqlStatement;
        }

        public static string GetScreeningDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM RULE_WM_DTL WHERE " +
                          " (RULE_ID =@RULE_ID) AND (RULE_CON_ID=@RULE_CON_ID) ";

                    break;
            }
            return sqlStatement;
        }

        public static string GetClientLoad()
        {
            string sqlStatement = "";

            //sqlStatement = "select ROW_NUMBER() over(order by NO_CIF asc) as Row, *  FROM CUSTOMER";
            sqlStatement = "SELECT CASE CAST(FLAG_PRIME AS NVARCHAR) WHEN '0' THEN 'Secondary' ELSE 'Primary' END AS DATA_VALUE01, *  FROM CUSTOMER";

            return sqlStatement;
        }

        public static string GetClientDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CUSTOMER WHERE  " +
                          "(NO_CIF =@NO_CIF) AND (CODE_COMP =@CODE_COMP) AND (CODE_ORG =@CODE_ORG)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetClientHistLoad()
        {
            string sqlStatement = "";

            //sqlStatement = "select ROW_NUMBER() over(order by NO_CIF asc) as Row, *  FROM CUSTOMER_HIST";
            sqlStatement = "SELECT CASE CAST(FLAG_PRIME AS NVARCHAR) WHEN '0' THEN 'Secondary' ELSE 'Primary' END AS DATA_VALUE01, *  FROM CUSTOMER_HIST";

            return sqlStatement;
        }

        public static string GetRegulatorMapLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = PARAM_STR_HDR.STR_STATUS) AS STR_STATUS_DESC," +
                            "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 7004001 AND CODE_SUB = PARAM_STR_HDR.STR_COUNTRY) AS STR_COUNTRY_DESC," +
                            "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 503 AND CODE_SUB = PARAM_STR_HDR.STR_TYPE) AS STR_TYPE_DESC, *  FROM PARAM_STR_HDR ORDER BY AUDIT_CREATED_DATE DESC";

            return sqlStatement;
        }

        public static string GetParamStrDtlLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = PARAM_STR_DTL.STR_STATUS) AS STR_STATUS_DESC," +
                                    "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 7004003 AND CODE_SUB = PARAM_STR_DTL.ANS_TYPE) AS ANS_TYPE_DESC, *  FROM PARAM_STR_DTL WHERE" +
                                    "(STR_ID =@STR_ID) AND (QUEST_CATEGORY=@QUEST_CATEGORY)";
                    break;
            }

            return sqlStatement;
        }

        public static string GetParamStrDtl(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_STR_DTL WHERE  " +
                          " (STR_ID =@STR_ID) AND (QUEST_NO =@QUEST_NO) AND (QUEST_CATEGORY =@QUEST_CATEGORY)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetParamListLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT * FROM CONFIG_CODES_HDR WHERE CONFIG_STATUS = 1";

            return sqlStatement;
        }

        //EOD JOB
        public static string GetEODJobLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT * FROM CONFIG_JOB";

            return sqlStatement;
        }

        public static string GetEODJobDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_JOB WHERE (JOB_ID =@JOB_ID)";

                    break;
            }
            return sqlStatement;
        }

        //JOB STEP
        public static string GetJobStepLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            sqlStatement = "SELECT * FROM CONFIG_JOB_STEP WHERE (JOB_ID =@JOB_ID)";

            return sqlStatement;
        }

        public static string GetJobStepDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_JOB_STEP WHERE (JOB_ID =@JOB_ID) AND (STEP_ID =@STEP_ID)";


                    break;
            }
            return sqlStatement;
        }

        //lama
        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.GetOrgDetail:
                    sqlStatement = "SELECT * FROM PARAM_LICENSE WHERE  " +
                          " (CODE_ORG =@CODE_ORG)";
                    break;

                case SqlCase.GetOrgIDDetailDelete:
                    sqlStatement = "SELECT * FROM PARAM_LICENSE WHERE  " +
                          " (CODE_ORG =@CODE_ORG)";
                    break;
            }
            return sqlStatement;
        }

        //public DataSet ExecuteSQLQuery_ReturnDS(ref string ReturnErrorMsg, string sqlStatement, string DBConnString, Int16 DBType)
        //{
        //    ReturnErrorMsg = "";
        //    DataSet DS = new DataSet();

        //    if (DBType == 1)
        //    {
        //        try
        //        {
        //            OpenConnection(DBConnString, DBType);
        //            SqlCommand sqlCmd = new SqlCommand(SqlString, sqlConn);
        //            sqlCmd.CommandTimeout = 0;
        //            SqlDataAdapter sqlDaAdp = new SqlDataAdapter(sqlCmd);
        //            sqlDaAdp.Fill(DS);
        //            sqlCmd = null/* TODO Change to default(_) if this is not a reference type */;
        //            sqlDaAdp = null/* TODO Change to default(_) if this is not a reference type */;
        //            CloseConnection(DBType);
        //            return DS;
        //        }
        //        catch (SqlException ex)
        //        {
        //            if (ex.Number == 18456 | ex.Number == 4060)
        //                ReturnErrorMsg = "Database Connection Error >> Error No : " + ex.Number;
        //            else
        //                ReturnErrorMsg = "SQL Statement Error >> Error No : " + ex.Number;
        //            CloseConnection(DBType);
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        }
        //    }
        //    else if (DBType == 3)
        //    {
        //        try
        //        {
        //            OpenConnection(DBConnString, DBType);
        //            OleDbCommand oledbCmd = new OleDbCommand(SqlString, oleDbconn);
        //            OleDbDataAdapter oledbDaAdp = new OleDbDataAdapter(oledbCmd);
        //            oledbDaAdp.Fill(DS);
        //            oledbDaAdp = null/* TODO Change to default(_) if this is not a reference type */;
        //            oledbDaAdp = null/* TODO Change to default(_) if this is not a reference type */;
        //            CloseConnection(DBType);
        //            return DS;
        //        }
        //        catch (OleDbException ex)
        //        {
        //            if (ex.ErrorCode == -2147217887)
        //                ReturnErrorMsg = "Database Connection Error >> Error Code : " + ex.ErrorCode;
        //            else
        //                ReturnErrorMsg = "SQL Statement Error >> Error Code : " + ex.ErrorCode;
        //            CloseConnection(DBType);
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        }
        //    }
        //    //
        //    return null/* TODO Change to default(_) if this is not a reference type */;
        //}

        //public void OpenConnection(string DBStrConn, Int16 DBType)
        //{
        //    try
        //    {
        //        if (DBType == 1)
        //        {
        //            sqlConn = new SqlConnection(DBStrConn);
        //            if (sqlConn.State == ConnectionState.Closed)
        //                sqlConn.Open();
        //            else
        //            {
        //                sqlConn.Close();
        //                sqlConn.Open();
        //            }
        //        }
        //        else if (DBType == 3)
        //        {
        //            oleDbconn = new OleDbConnection(DBStrConn);
        //            if (oleDbconn.State == ConnectionState.Closed)
        //                oleDbconn.Open();
        //            else
        //            {
        //                oleDbconn.Close();
        //                oleDbconn.Open();
        //            }
        //        }
        //    }
        //    //
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}