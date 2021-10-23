using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQueryManager
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
                    , GetMsgDetails
                    , GetLogList
                    , ReadCorCodeDropDown

                    //insert Statement
                    , insertIntoEventViewer

                    , insertIntoAuditMaster
                    //, GetDropDownItems1
                    //TESTPOWERQUERY

                    //Get Latest and Current Sequence
                    , RF_WM_ID

                    , HITLOGGER_SEQ_NO

                    , GetLatestSequence
                    , GetCurrentSequence
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.GetParameterValue:
                    sqlStatement = "SELECT * FROM PARAM_STAFF WHERE  " +
                          " (CODE_COMP =@CODE_comp)";
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

                case SqlCase.ReadCorCodeDropDown:
                    sqlStatement = "select * from cor_code where cor_CodeNo=@cor_CodeNo order by cor_Display_order, cor_Desc";
                    break;

                case SqlCase.GetCorCodeDetails:
                    sqlStatement = "SELECT * FROM PARAM_ERROR WHERE  " +
                                   " (MODULE_ID =@MODULE_ID) ";
                    //" (cor_CodeKey =@cor_CodeKey)";
                    break;

                case SqlCase.GetMsgDetails:
                    //sqlStatement = "SELECT INFO_DESCRIPTION FROM PARAM_ERROR WHERE  " +
                    //               " (INFO_CODE =@INFO_CODE) ";
                    sqlStatement = "select INFO_DESC from CONFIG_CODES_DTL where CODE_PRIME = 2011001 AND CODE_SUB = @CODE_SUB ";
                    break;

                //table GROUPMASTER not finalized yet
                case SqlCase.GetGroupName:
                    sqlStatement = "SELECT * FROM GROUPMASTER WHERE  " +
                                   " (GRP_ID =@GRP_ID)";
                    break;

                case SqlCase.GetLogList:
                    sqlStatement = "SELECT * FROM AUDIT_MASTER WHERE  " +
                                   " (AUDIT_USER_ID =@userID) ";
                    break;

                case SqlCase.GetLatestSequence:
                    sqlStatement = "SELECT NEXT VALUE FOR @name AS LATEST_VALUE ";
                    break;

                case SqlCase.GetCurrentSequence:
                    sqlStatement = "SELECT CURRENT_VALUE FROM SYS.SEQUENCES  " +
                                   " WHERE name = @name ";
                    break;
            }
            return sqlStatement;
        }

        public static string GetLatestSequence(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.RF_WM_ID:
                    sqlStatement = "SELECT CAST(NEXT VALUE FOR RF_WM_ID as varchar(30)) AS LATEST_VALUE ";
                    break;

                case SqlCase.HITLOGGER_SEQ_NO:
                    sqlStatement = "SELECT CAST(NEXT VALUE FOR HITLOGGER_SEQ_NO as varchar(30)) AS LATEST_VALUE ";
                    break;
            }
            return sqlStatement;
        }

        public static string GetCurrentSequence(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.RF_WM_ID:
                    sqlStatement = "SELECT CURRENT_VALUE FROM SYS.SEQUENCES  " +
                                   " WHERE name = 'RF_WM_ID' ";
                    break;

                case SqlCase.HITLOGGER_SEQ_NO:
                    sqlStatement = "SELECT CURRENT_VALUE FROM SYS.SEQUENCES  " +
                                   " WHERE name = 'HITLOGGER_SEQ_NO' ";
                    break;
            }
            return sqlStatement;
        }

        public static string insertIntoEventViewer()
        {
            string sqlStatement = "";

            sqlStatement = "INSERT INTO event_viewer " +
                            "(userid, comp_code, tran_date, action, access_date, room_name, menu_name) " +
                            "values " +
                            "(@userId, @Comp_Code, @tran_date, @Action, getdate(), @RoomName, @MenuName)";

            return sqlStatement;
        }

        public static string insertIntoAuditMaster()
        {
            string sqlStatement = "";

            sqlStatement = "INSERT INTO AUDIT_MASTER " +
                            "(CODE_COMP,CODE_ORG, AUDIT_MODULE, AUDIT_PAGE,AUDIT_USER_TYPE, AUDIT_USER_ID, AUDIT_TOKEN, AUDIT_ACTIVITY ,AUDIT_ACTIVITY_DESC,  AUDIT_STAMPDT) " +
                            "values " +
                            "(@CODE_COMP, @CODE_ORG, @AUDIT_MODULE, @AUDIT_PAGE,@AUDIT_USER_TYPE, @AUDIT_USER_ID, @AUDIT_TOKEN, @AUDIT_ACTIVITY, @AUDIT_ACTIVITY_DESC, getdate())";

            return sqlStatement;
        }

        public static string GetConfigCodesDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE CONFIG_STATUS1 = @CONFIG_STATUS1 AND  " +
                          " (CODE_PRIME =@CODE_PRIME)";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE  " +
                          " (CODE_PRIME =@CODE_PRIME) AND CODE_SUB=@CODE_SUB";
                    break;

                case 3:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE DATA_VALUEI2 = @DATA_VALUEI2 AND  " +
                          " (CODE_PRIME =@CODE_PRIME)";
                    break;

                case 4:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL WHERE  " +
                          " (CODE_PRIME =@CODE_PRIME)";
                    break;

                default:
                    sqlStatement = "SELECT * FROM CONFIG_CODES_DTL";
                    break;
            }
            return sqlStatement;
        }

        public static string GetDropDownItemsWfTemplate(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_HDR WHERE  " +
                          " (CODE_COMP =@CODE_COMP) AND (CODE_ORG=@CODE_ORG) AND (WF_MODULE=@WF_MODULE)";
                    break;

                default:
                    sqlStatement = "SELECT * FROM CONFIG_WF_HDR";
                    break;
            }
            return sqlStatement;
        }

        public static string GetDropDownItemsWorkflow()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT *  FROM CONFIG_WF_HDR WHERE WF_MODULE='7'";

            return sqlStatement;
        }

        public static string GetDropDownItemsWorkflow(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_HDR WHERE  " +
                          " (WF_MODULE =@WF_MODULE)";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM CONFIG_WF_HDR WHERE  " +
                          " (WF_ID =@WF_ID) AND WF_MODULE=@WF_MODULE";
                    break;

                default:
                    sqlStatement = "SELECT * FROM CONFIG_WF_HDR";
                    break;
            }
            return sqlStatement;
        }

        public static string GetDropDownScreeningTable(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_HDR WHERE  " +
                          " (MAP_PRODUCT =@MAP_PRODUCT)";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_HDR WHERE  " +
                          " (MAP_ID_HDR =@MAP_ID_HDR) AND MAP_PRODUCT=@MAP_PRODUCT";
                    break;

                default:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_HDR";
                    break;
            }
            return sqlStatement;
        }

        public static string GetDropDownScreeningField(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_DTL WHERE  " +
                          " (MAP_PRODUCT =@MAP_PRODUCT)";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_DTL WHERE  " +
                          " (MAP_ID_DTL =@MAP_ID_DTL) AND MAP_PRODUCT=@MAP_PRODUCT";
                    break;

                case 3:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_DTL WHERE  " +
                          " (MAP_TABLE_NAME =@MAP_TABLE_NAME) AND (MAP_PRODUCT=@MAP_PRODUCT) and config_code <> 0";
                    break;

                case 4:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_DTL WHERE  " +
                          " (MAP_TABLE_NAME =@MAP_TABLE_NAME) AND (MAP_PRODUCT=@MAP_PRODUCT)  and CONFIG_WATCHLIST = 1";
                    break;

                default:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_DTL";
                    break;
            }
            return sqlStatement;
        }

        public static string GetDropDownScreeningFormula(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, ISNULL(CHARACTER_MAXIMUM_LENGTH, 0) AS LENGTH, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE" +
                          " (TABLE_NAME =@TABLE_NAME) AND (COLUMN_NAME =@COLUMN_NAME)";
                    break;

                default:
                    sqlStatement = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS";
                    break;
            }
            return sqlStatement;
        }

        public static string GetHistoryLogLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 501 AND CODE_SUB = AUDIT_MASTER.AUDIT_MODULE) AS MODULE_DESC, *  FROM AUDIT_MASTER ORDER BY AUDIT_STAMPDT DESC";

            return sqlStatement;
        }


        public static string GetDDParamMapDtl(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_DTL WHERE  " +
                          " (MAP_ID_HDR =@MAP_ID_HDR) AND MAP_PRODUCT=@MAP_PRODUCT AND MAP_FIELD_NAME !=''";
                    break;

                default:
                    sqlStatement = "SELECT * FROM PARAM_MAPPING_DTL";
                    break;
            }
            return sqlStatement;
        }
    }
}