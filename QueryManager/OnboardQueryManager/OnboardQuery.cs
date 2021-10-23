using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardQueryManager
{
    public class OnboardQuery
    {
        public enum SqlCase
        {
            //, GetSupportDocuments
            GetSupportDocuments_Invoice

                , GetSupportDocuments_Transport
                , GetSupportDocuments_TransportDetails
                , GetEventLog
                , GetAttachment
                , GetPortCities
                , GetWatchlist
                , GetDUG
                , GetKYC
                , GetKYCC
                , GetRelatedSwift
                , GetGTPriceDetails
                , DropDownTradePartner
                , GetGTPriceHeader
                , GetCurrencyRate
                , PreshipmentApproval_Approve
                , PreshipmentApproval_Reject
                , PreshipmentApproval_UpdateTBMLTradeTran
                , PreshipmentApproval_GetMessageDetails
                , PreshipmentApproval_SetUserAsCaseOwner
                , PreshipmentApproval_GetDropDown_BankPrice_HSCode6
                , PreshipmentApproval_GetDropDown_GlobalPrice_HSCode6
                , PreshipmentApproval_GetDropDown_BankPrice_TarifflineCode
                , PreshipmentApproval_GetDropDown_GlobalPrice_TarifflineCode
                , ReleaseCaseOwner
                , GetTNC
                , UpdateTNCStatus
                , GetTranHistory
                , UpdateFindings
                , GetWatchlistDetails_Master
                , GetWatchlistDetails_NameInfo
                , GetWatchlistDetails_DescriptionInfo
                , GetWatchlistDetails_RoleInfo
                , GetWatchlistDetails_SanctionInfo
                , GetWatchlistDetails_AddressInfo
                , GetWatchlistDetails_ResidentInfo
                , GetWatchlistDetails_IdInfo
                , GetWatchlistDetails_RelationInfo
                , GetWatchlistDetails_ImageInfo
                , GetWatchlistDetails_SourceInfo
                , GetWatchlistDetails_VesselInfo
                , GetDetails
                , GetGoodsLists
                , GetContLists
                , DropDownEntity
                , DropDownPEP
                , DropDownSIC
                , DropDownSanction
                , GetVesselNameInfoSource
                , SearchSNVessel
                , SearchSNVesselwName
                , SearchSNVesselwId
                , GetPositiveToleranceValue
                , GetNegativeToleranceValue
                , GetStandardCaseStatus
                , GetWeeklyStandardCaseStatus
                , GetDailyStandardCaseStatus
                , GetCustomCaseStatus
                , GetWeeklyCustomCaseStatus
                , GetDailyCustomCaseStatus
                , GetKYCScreening
                , GetWeeklyKYCScreening
                , GetDailyKYCScreening
        }

        public static string GetWLCaseWorkflow(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM RF_CASE WHERE MODULE_ID = @MODULE_ID ORDER BY CASE_ID DESC ";
                    break;

                default:
                    sqlStatement = "SELECT CASE CAST(CASE_STATUS AS NVARCHAR) WHEN '0' THEN 'Closed' WHEN '1' THEN 'Unassigned' ELSE 'In-Progress' END AS CASE_STATUS_DESC, *FROM RF_CASE";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRFOMAttachmentDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM RF_OM_ATTACH WHERE CASE_ID = @CASE_ID ORDER BY AUDIT_CREATED_DATE DESC ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM RF_OM_ATTACH";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRFOMActivityDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT *, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_SUB = RF_OM_ACT.AUDIT_SUB_STATUS AND CODE_PRIME = 7001) AS SUB_STATUS_DESC FROM RF_OM_ACT WHERE CASE_ID = @CASE_ID  ORDER BY AUDIT_CREATED_DATE DESC ";
                    break;

                default:
                    sqlStatement = "SELECT *, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_SUB = RF_OM_ACT.AUDIT_SUB_STATUS AND CODE_PRIME = 7001) AS SUB_STATUS_DESC FROM RF_OM_ACT";
                    break;
            }
            return sqlStatement;
        }

        public static string GetInternalUploadLoad()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT CASE CAST(STATUS AS NVARCHAR) WHEN '0' THEN 'Pending' WHEN '1' THEN 'In Progress' WHEN '2' THEN 'Completed' END AS STATUS_DESC, *  FROM WL_BATCHLOG WHERE (UPLOAD_TYPE=1) AND (ACTIVE=1) ";

            return sqlStatement;
        }

        public static string GetWLCaseDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT DATEDIFF(DAY, AUDIT_DATE_CREATED, GETDATE()) AS CASE_OS, (SELECT INFO_NAME_FULL FROM CUSTOMER WHERE CUSTOMER.NO_CIF = RF_CASE.NO_CIF) AS USER_NAME, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = '507' AND CODE_SUB = CASE_STATUS) AS STATUS_DESC, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = '7001' AND CODE_SUB = CASE_SUB_STATUS) AS SUB_STATUS_DESC,  * FROM RF_CASE WHERE MODULE_ID = @MODULE_ID ORDER BY CASE_ID DESC ";
                    break;

                case 2:
                    sqlStatement = "SELECT DATEDIFF(DAY, AUDIT_DATE_CREATED, GETDATE()) AS CASE_OS, (SELECT INFO_NAME_FULL FROM CUSTOMER WHERE CUSTOMER.NO_CIF = RF_CASE.NO_CIF) AS USER_NAME, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = '507' AND CODE_SUB = CASE_STATUS) AS STATUS_DESC, " +
                        " (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = '7001' AND CODE_SUB = CASE_SUB_STATUS) AS SUB_STATUS_DESC, * FROM RF_CASE WHERE  " +
                          " (CASE_ID =@CASE_ID)";
                    break;

                case 3:
                    sqlStatement = "SELECT  CASE_ID FROM RF_CASE WHERE NO_CIF = @NO_CIF and CASE_STATUS <> 300 and MODULE_ID = @MODULE_ID ORDER BY CASE_ID DESC";
                    break;

                default:
                    sqlStatement = "SELECT * FROM RF_CASE";
                    break;
            }
            return sqlStatement;
        }

        public static string GetConfigMiscTableDatalist(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIGMISCTABLEDATALIST WHERE TEMPLATE_CODE = @TEMPLATE_CODE";
                    break;

                default:
                    sqlStatement = "SELECT * FROM RF_CASE";
                    break;
            }
            return sqlStatement;
        }

        public static string GetParamSTRDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM PARAM_STR_DTL WHERE STR_ID = @STR_ID";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM PARAM_STR_DTL WHERE STR_ID = @STR_ID AND QUEST_CATEGORY = @QUEST_CATEGORY";
                    break;

                default:
                    sqlStatement = "SELECT * FROM PARAM_STR_DTL";
                    break;
            }
            return sqlStatement;
        }

        public static string GetTxnReportMisc(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM TXNREPORTMISC WHERE ALERT_ID = @ALERT_ID";
                    break;

                default:
                    sqlStatement = "SELECT * FROM TXNREPORTMISC";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRPTSTRHDR(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM RPT_STR_HDR WHERE NO_CIF = @NO_CIF";
                    break;

                default:
                    sqlStatement = "SELECT * FROM RPT_STR_HDR";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRPTSTR(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM RPT_STR_DTL WHERE NO_CIF = @NO_CIF";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM RPT_STR_DTL WHERE STR_SEQ = @STR_SEQ AND STR_CATEGORY = @STR_CATEGORY";
                    break;

                case 3:
                    sqlStatement = "SELECT * FROM RPT_STR_DTL WHERE NO_CIF = @NO_CIF AND STR_CATEGORY = @STR_CATEGORY";
                    break;

                case 4:
                    sqlStatement = "SELECT * FROM RPT_STR_DTL WHERE STR_HDR_SEQ = @STR_HDR_SEQ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM RPT_STR_DTL";
                    break;
            }
            return sqlStatement;
        }

        public static string GetBlacklistDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT A.ENTITY_ID, B.SINGLE_STRING_NAME, B.SINGLE_STRING_NAME2, B.SINGLE_STRING_NAME3, A.DATE_OF_BIRTH, A.BIRTH_PLACE, B.NAME_TYPE, A.ENTITY_TYPE, B.CATEGORY, B.COUNTRY, A.GENDER, A.INFO_SOURCE, B.ID_REF_NO " +
                                   " FROM AW_MASTER A INNER JOIN AW_NAME B ON B.ENTITY_ID = A.ENTITY_ID WHERE A.INFO_SOURCE <> 'DJ' " +
                                   " AND (@INFO_SOURCE = '' OR A.INFO_SOURCE = @INFO_SOURCE)  " +
                                   " AND (@SINGLE_STRING_NAME3='' or SINGLE_STRING_NAME3 like '%'+@SINGLE_STRING_NAME3+'%') " +
                                   " AND (@ENTITY_ID = '' OR A.ENTITY_ID = @ENTITY_ID)" +
                                   " AND (@ID_REF_NO = '' or B.ID_REF_NO = @ID_REF_NO) ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM RF_CASE";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLName(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM AW_NAME WHERE ENTITY_ID = @ENTITY_ID ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_NAME";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLSanction(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT CAST(SINCE_DAY as nvarchar) + '/' + CAST(SINCE_MONTH as nvarchar) + '/' + CAST(SINCE_YEAR as nvarchar) as SANCTION_FROM, " +
                        "CAST(TO_DAY as nvarchar) + '/' + CAST(TO_MONTH as nvarchar) + '/' + CAST(TO_YEAR as nvarchar) as SANCTION_TO, * FROM AW_SANCTION WHERE ENTITY_ID = @ENTITY_ID ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_SANCTION";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLRelationship(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT A.*, B.SINGLE_STRING_NAME3 from AW_ASSOCIATION A LEFT JOIN AW_NAME B ON B.ENTITY_ID = 'DJ' + A.ASSOCIATE_ENTITY where A.ENTITY_ID = @ENTITY_ID  AND B.NAME_TYPE  = 'Primary Name' ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_ASSOCIATION";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLMaster(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM AW_MASTER WHERE ENTITY_ID = @ENTITY_ID ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_MASTER";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLSource(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM AW_SOURCE WHERE ENTITY_ID = @ENTITY_ID ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_SOURCE";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLReference(Int32 sqlCase, string searchCriteria)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM AW_REFERENCE WHERE REF_NO = @REF_NO ";
                    if (searchCriteria != "")
                    {
                        sqlStatement += searchCriteria;
                    }
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM AW_REFERENCE WHERE REF_NO = @REF_NO ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_REFERENCE";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLAddress(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM AW_ADDRESS WHERE ENTITY_ID = @ENTITY_ID ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_ADDRESS";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLIDNumber(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM AW_IDNUMBER WHERE ENTITY_ID = @ENTITY_ID ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_IDNUMBER";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLCountry(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM AW_COUNTRY WHERE ENTITY_ID = @ENTITY_ID ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM AW_COUNTRY";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWLCountryRisk(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM WATCHLISTCOUNTRYRISK WHERE HIGH_RISK_KEY = @HIGH_RISK_KEY ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM WATCHLISTCOUNTRYRISK";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWatchlistAlgorithm(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                default:
                    sqlStatement = "SELECT *, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 500 AND CODE_SUB = ENABLED) AS STATUS_DESC FROM WATCHLISTALGORITHM";
                    break;
            }
            return sqlStatement;
        }

        public static string GetWatchlistAlgorithmDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM WATCHLISTALGORITHMDTL WHERE WL_ALGO = @WL_ALGO ";
                    break;

                default:
                    sqlStatement = "SELECT * FROM WATCHLISTALGORITHMDTL";
                    break;
            }
            return sqlStatement;
        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case SqlCase.DropDownSanction:
                    sqlStatement = "select concat('|',REF_KEY1,'|') as value, concat(REF_DESC,' (',REF_VALUET1,')') as description from AW_REFERENCE where REF_NO = 4 order by REF_DESC asc ";
                    break;

                case SqlCase.DropDownSIC:
                    sqlStatement = "select concat('|',REF_KEY1,'|') as value,REF_DESC as description from AW_REFERENCE where REF_NO = 6 and (REF_KEY2 = N'3') union " + Environment.NewLine +
                        "select concat('|',REF_KEY1,'|') as value,REF_DESC as description from AW_REFERENCE where REF_NO = 6 and REF_KEY2 = N'4' order by REF_DESC asc";
                    break;

                case SqlCase.DropDownPEP:
                    sqlStatement = "select concat('|',REF_KEY1,'|') as value,REF_DESC as description from AW_REFERENCE where REF_NO = 2 union " + Environment.NewLine +
                        "select concat('|',REF_KEY1,'|') as value,REF_DESC as description from AW_REFERENCE where REF_NO = 5 and REF_KEY1 = '2' order by REF_DESC asc";
                    break;

                case SqlCase.DropDownEntity:
                    sqlStatement = "select cor_CodeKey as value,cor_Desc as description from cor_code where cor_CodeNo = @cor_CodeNo ";
                    break;

                case SqlCase.GetDetails:
                    sqlStatement = "Select * From TBMLTradeInvoice where DOC_REF=@DOC_REF ";
                    break;

                case SqlCase.GetGoodsLists:
                    sqlStatement = "Select * From TBMLTRADEGOODS where DOC_NO=@DOC_NO ";
                    break;

                case SqlCase.GetContLists:
                    sqlStatement = "Select * From TBMLTRADEBLDOCONT where BLDO_NO=@BLDO_NO ";
                    break;

                case SqlCase.GetWatchlistDetails_Master:
                    sqlStatement = "Select * From AW_MASTER where ENTITY_ID=@ENTITY_ID ";
                    break;

                case SqlCase.GetWatchlistDetails_NameInfo:
                    sqlStatement = "Select * From AW_NAME  where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_DescriptionInfo:
                    sqlStatement = "Select * From AW_DESC  where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_RoleInfo:
                    sqlStatement = "Select *" + Environment.NewLine +
                                    ",CAST(SINCE_DAY AS VARCHAR(4)) + '-' + IIF(SINCE_MONTH = 0, '0', FORMAT(CAST('2000-' + CAST(SINCE_MONTH AS VARCHAR(4)) + '-01' AS DATETIME), 'MMM')) + '-' + CAST(SINCE_YEAR AS VARCHAR(4)) as SinceDate" + Environment.NewLine +
                                    ",CAST(TO_DAY AS VARCHAR(4)) + '-' + IIF(TO_MONTH = 0, '0', FORMAT(CAST('2000-' + CAST(TO_MONTH AS VARCHAR(4)) + '-01' AS DATETIME), 'MMM')) + '-' + CAST(TO_YEAR AS VARCHAR(4)) as ToDate" + Environment.NewLine +
                                    "from AW_ROLE" + Environment.NewLine +
                                    "where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_SanctionInfo:
                    sqlStatement = "Select *" + Environment.NewLine +
                                    ",CAST(SINCE_DAY AS VARCHAR(4)) + '-' + IIF(SINCE_MONTH = 0, '0', FORMAT(CAST('2000-' + CAST(SINCE_MONTH AS VARCHAR(4)) + '-01' AS DATETIME), 'MMM')) + '-' + CAST(SINCE_YEAR AS VARCHAR(4)) as SinceDate" + Environment.NewLine +
                                    ",CAST(TO_DAY AS VARCHAR(4)) + '-' + IIF(TO_MONTH = 0, '0', FORMAT(CAST('2000-' + CAST(TO_MONTH AS VARCHAR(4)) + '-01' AS DATETIME), 'MMM')) + '-' + CAST(TO_YEAR AS VARCHAR(4)) as ToDate" + Environment.NewLine +
                                    "from AW_SANCTION" + Environment.NewLine +
                                    "where ENTITY_ID = @ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_AddressInfo:
                    sqlStatement = "Select * From AW_ADDRESS  where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_ResidentInfo:
                    sqlStatement = "Select * From AW_COUNTRY  where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_IdInfo:
                    sqlStatement = "Select * From AW_IDNUMBER  where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_RelationInfo:
                    sqlStatement = "Select a.*, c.SINGLE_STRING_NAME, c.SINGLE_STRING_NAME2, c.SINGLE_STRING_NAME3, b.ENTITY_TYPE as EntityType, c.ENTITY_NAME as EntityName, c.FIRST_NAME as FirstName, MIDDLE_NAME as MiddleName, SURNAME as SurName" + Environment.NewLine +
                                    "From AW_ASSOCIATION as a" + Environment.NewLine +
                                    "left join AW_MASTER as b on b.ENTITY_ID = 'DJ' + a.ASSOCIATE_ENTITY" + Environment.NewLine +
                                    "left join AW_NAME as c on c.ENTITY_ID = 'DJ' + a.ASSOCIATE_ENTITY and c.NAME_TYPE = 'Primary Name'" + Environment.NewLine +
                                    "where a.ENTITY_ID = @ENTITY_ID" + Environment.NewLine +
                                    "order by a.SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_ImageInfo:
                    sqlStatement = "Select * From AW_IMAGE  where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_SourceInfo:
                    sqlStatement = "Select * From AW_SOURCE  where ENTITY_ID=@ENTITY_ID order by SYS_ID";
                    break;

                case SqlCase.GetWatchlistDetails_VesselInfo:
                    sqlStatement = "Select a.*, cor_desc as VESSEL_FLAG_DESC" + Environment.NewLine +
                                    "From AW_VESSEL as a" + Environment.NewLine +
                                    "left join cor_code as b on b.cor_CodeNo = 2709 and b.cor_CodeKey = a.VESSEL_FLAG" + Environment.NewLine +
                                    "where ENTITY_ID = @ENTITY_ID  order by SYS_ID";
                    break;

                case SqlCase.UpdateFindings:
                    sqlStatement = "UPDATE {0}" + Environment.NewLine +
                                    "Set INVESTIGATE_STATUS=@INVESTIGATE_STATUS, TYPE_OF_EXPOSITION=@TYPE_OF_EXPOSITION, REMARKS=@REMARKS, " + Environment.NewLine +
                                    "LAST_UPT_DATE=@LAST_UPT_DATE, LAST_UPT_TIME=@LAST_UPT_TIME, USER_ID=@USER_ID, MODE_MN = N'M' " + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                                    "and MSG_PYMT_ID=@MSG_PYMT_ID" + Environment.NewLine +
                                    "and ENTITY_ID=@ENTITY_ID" + Environment.NewLine +
                                    "and SYS_ID=@SYS_ID" + Environment.NewLine +
                                    "and AUTO_SEQ_NO=@AUTO_SEQ_NO";

                    break;

                #region Approval

                case SqlCase.GetTranHistory:
                    sqlStatement = "Select replace(convert(varchar, convert(datetime, rtrim(TRX_DATE), 112), 106), ' ', '-') as TRX_DATE" + Environment.NewLine +
                                    ", TRX_DATE as TRX_DATE2, DOC_CURRENCY, COUNT(1) as TRAN_COUNT, Round(SUM(DOC_AMOUNT)/1000, 3) as TRAN_AMOUNT" + Environment.NewLine +
                                    "FROM TBMLTRADETRAN " + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode And ACCOUNT_NO=@ACCOUNT_NO" + Environment.NewLine +
                                    "And TRX_DATE between @dateFrom And @dateTo" + Environment.NewLine +
                                    "GROUP BY TRX_DATE, DOC_CURRENCY" + Environment.NewLine +
                                    "ORDER BY TRX_DATE2";
                    break;

                case SqlCase.ReleaseCaseOwner:
                    sqlStatement = "UPDATE MsgPaymentTrade " + Environment.NewLine +
                                    "Set USER_ID{0} = N'None' " + Environment.NewLine +
                                    "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO";
                    break;

                case SqlCase.PreshipmentApproval_GetDropDown_BankPrice_HSCode6:
                    sqlStatement = "select HS_CODE as value, HS_CODE + ' - ' + HS_DESCRIPTION as description" + Environment.NewLine +
                                    "from IHM_HSCODE as a" + Environment.NewLine +
                                    //"where exists (select 1 from TBMLBANKTRADEPRICE where HS6_CODE=a.HS_CODE)" + Environment.NewLine +
                                    "order by 2";
                    //sqlStatement = "select HS6_CODE as value, HS6_CODE + ' - ' + HS6_DESC as description" + Environment.NewLine +
                    //                "from TBMLBANKTRADEPRICE" + Environment.NewLine +
                    //                "group by HS6_CODE, HS6_DESC" + Environment.NewLine +
                    //                "order by 2";
                    break;

                case SqlCase.PreshipmentApproval_GetDropDown_GlobalPrice_HSCode6:
                    sqlStatement = "select HS_CODE as value, HS_CODE + ' - ' + HS_DESCRIPTION as description" + Environment.NewLine +
                                    "from IHM_HSCODE as a" + Environment.NewLine +
                                    //"where exists (select 1 from IHM_GLOBALTRADEALTAS where HS6_CODE=a.HS_CODE)" + Environment.NewLine +
                                    "order by 2";
                    //sqlStatement = "select HS6_CODE as value, HS6_CODE + ' - ' + HS6_DESC as description" + Environment.NewLine +
                    //                "from IHM_GLOBALTRADEALTAS" + Environment.NewLine +
                    //                "group by HS6_CODE, HS6_DESC" + Environment.NewLine +
                    //                "order by 2";
                    break;

                case SqlCase.PreshipmentApproval_GetDropDown_BankPrice_TarifflineCode:
                    sqlStatement = "select distinct TARIFFLINE_CODE as value, TARIFFLINE_CODE + ' - ' + TARIFFLINE_DESC  as description" + Environment.NewLine +
                                    "from TBMLBANKTRADEPRICE" + Environment.NewLine +
                                    "where HS6_CODE=@HS6_CODE" + Environment.NewLine +
                                    "order by 2";
                    break;

                case SqlCase.PreshipmentApproval_GetDropDown_GlobalPrice_TarifflineCode:
                    sqlStatement = "select distinct TARIFFLINE_CODE as value, TARIFFLINE_CODE + ' - ' + TARIFFLINE_DESC as description" + Environment.NewLine +
                                    "from IHM_GLOBALTRADEALTAS" + Environment.NewLine +
                                    "where HS6_CODE=@HS6_CODE" + Environment.NewLine +
                                    "order by 2";
                    break;

                case SqlCase.PreshipmentApproval_GetMessageDetails:
                    sqlStatement = "select * from MsgPaymentTrade" + Environment.NewLine +
                                "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO";
                    break;

                case SqlCase.PreshipmentApproval_SetUserAsCaseOwner:
                    sqlStatement = "update MsgPaymentTrade" + Environment.NewLine +
                                    "set USER_ID{0}=@USER_ID_N" + Environment.NewLine +
                                    "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO";
                    break;

                case SqlCase.PreshipmentApproval_UpdateTBMLTradeTran:
                    sqlStatement = "update TBMLTradeTran" + Environment.NewLine +
                                    "set SCAN_STATUS=@SCAN_STATUS" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode and DOC_REF=@DOC_REF";
                    break;

                case SqlCase.PreshipmentApproval_Approve:
                    ////select MSG_PYMT_ID, MSG_SEQ_NO, ALERT_NO, APPROVAL_STATUS, NO_OF_APPROVAL_DONE, REMARKS, ACTION_STATUS, SCAN_STATUS
                    ////, APPROVAL_STATUS1, APPROVED_BY1, APPROVED_DT1, APPROVED_TM1
                    ////, APPROVAL_STATUS2, APPROVED_BY2, APPROVED_DT1, APPROVED_TM2
                    ////, APPROVAL_STATUS3, APPROVED_BY3, APPROVED_DT1, APPROVED_TM3
                    ////from MsgPaymentTrade
                    sqlStatement = "update MsgPaymentTrade" + Environment.NewLine +
                                "set ALERT_NO=@ALERT_NO, NO_OF_APPROVAL_DONE=NO_OF_APPROVAL_DONE+1" + Environment.NewLine +
                                ", APPROVAL_STATUS{0}=@APPROVAL_STATUS_N, APPROVED_BY=@APPROVED_BY_N, APPROVED_BY{1}=@APPROVED_BY_N" + Environment.NewLine +
                                ", APPROVED_DT{2}=@APPROVED_DT_N, APPROVED_TM{3}=@APPROVED_TM_N" + Environment.NewLine +
                                ", REMARKS=@REMARKS, ACTION_STATUS=@ACTION_STATUS, SCAN_STATUS=@SCAN_STATUS" + Environment.NewLine +
                                ", APPROVAL_STATUS=IIF(APPROVAL_STATUS1='2' OR APPROVAL_STATUS2='2' OR APPROVAL_STATUS3='2', '2', @APPROVAL_STATUS)" + Environment.NewLine +
                                "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO";
                    break;

                case SqlCase.PreshipmentApproval_Reject:
                    sqlStatement = "update MsgPaymentTrade" + Environment.NewLine +
                                "set ALERT_NO=@ALERT_NO, APPROVAL_STATUS=@APPROVAL_STATUS, NO_OF_APPROVAL_DONE=NO_OF_APPROVAL_DONE+1, NO_OF_REJECTED_DONE=NO_OF_REJECTED_DONE+1" + Environment.NewLine +
                                ", APPROVAL_STATUS{0}=@APPROVAL_STATUS_N, APPROVED_BY=@APPROVED_BY_N, APPROVED_BY{1}=@APPROVED_BY_N" + Environment.NewLine +
                                ", APPROVED_DT{2}=@APPROVED_DT_N, APPROVED_TM{3}=@APPROVED_TM_N" + Environment.NewLine +
                                "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO";
                    break;

                case SqlCase.GetTNC:
                    sqlStatement = "Select * from TBMLTRADETNC" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                                    "and exists (select 1 from TBMLTRADETRAN where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO and DOC_REF=TBMLTRADETNC.DOC_REF)" + Environment.NewLine +
                                    "order by AUTO_SEQ_NO";
                    break;

                case SqlCase.UpdateTNCStatus:
                    sqlStatement = "update TBMLTRADETNC" + Environment.NewLine +
                                    "set status=@status" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                                    "and AUTO_SEQ_NO=@AUTO_SEQ_NO" + Environment.NewLine +
                                    "and DOC_REF=@DOC_REF";
                    break;

                case SqlCase.GetGTPriceHeader:
                    sqlStatement = "Select top 1 * from {0}" + Environment.NewLine +
                                    "where HS6_CODE=@HS6_CODE" + Environment.NewLine +
                                    "and (@TARIFFLINE_CODE='' or TARIFFLINE_CODE=@TARIFFLINE_CODE)" + Environment.NewLine +
                                    "and DIRECTION=@DIRECTION";
                    break;

                case SqlCase.GetGTPriceDetails:

                    sqlStatement = "Select * into #period From (" + Environment.NewLine +
                                    "{0}" + Environment.NewLine +
                                    ") As t" + Environment.NewLine + Environment.NewLine;

                    sqlStatement += "Select PARTNER_COUNTRY_ISO, PARTNER_COUNTRY, {1} as HS_CODE, DIRECTION" + Environment.NewLine +
                                    ", ROUND(SUM(isnull(PRICE, 0)) / SUM(isnull(QUANTITY1, 0)), 0) As totalAvgPrice" + Environment.NewLine +
                                    "into #summary" + Environment.NewLine +
                                    "from {2}" + Environment.NewLine +
                                    "where HS6_CODE=@HS6_CODE" + Environment.NewLine +
                                    "And DIRECTION=@DIRECTION" + Environment.NewLine +
                                    "And {3} between @periodfrom And @periodto" + Environment.NewLine +
                                    "And (@TARIFFLINE_CODE='' Or TARIFFLINE_CODE=@TARIFFLINE_CODE)" + Environment.NewLine +
                                    "And (@PARTNER_COUNTRY_ISO='' Or PARTNER_COUNTRY_ISO=@PARTNER_COUNTRY_ISO)" + Environment.NewLine +
                                    "And (@REPORTING_COUNTRY_ISO='' Or REPORTING_COUNTRY_ISO=@REPORTING_COUNTRY_ISO)" + Environment.NewLine +
                                    "group by PARTNER_COUNTRY_ISO, PARTNER_COUNTRY, {4}, DIRECTION" + Environment.NewLine + Environment.NewLine;

                    sqlStatement += "Select pivotPrice.*" + Environment.NewLine +
                                    "from (" + Environment.NewLine +
                                    "	Select a.period, b.PARTNER_COUNTRY_ISO, b.PARTNER_COUNTRY, b.totalAvgPrice" + Environment.NewLine +
                                    "	, IIF(SUM(isnull(c.QUANTITY1, 0)) > 0, ROUND(SUM(isnull(c.PRICE, 0)) / SUM(isnull(c.QUANTITY1, 0)), 0), 0) As avgPrice" + Environment.NewLine +
                                    "	from #period As a" + Environment.NewLine +
                                    "	cross join #summary As b" + Environment.NewLine +
                                    "	left join {5} As c On c.PARTNER_COUNTRY_ISO=b.PARTNER_COUNTRY_ISO And c.PARTNER_COUNTRY=b.PARTNER_COUNTRY" + Environment.NewLine +
                                    "							And c.{6}=a.period And c.{7}=b.HS_CODE And c.DIRECTION=b.DIRECTION" + Environment.NewLine +
                                    "	group by a.period, b.PARTNER_COUNTRY_ISO, b.PARTNER_COUNTRY, b.totalAvgPrice" + Environment.NewLine +
                                    ") As srcTable" + Environment.NewLine +
                                    "PIVOT" + Environment.NewLine +
                                    "(" + Environment.NewLine +
                                    "SUM(avgPrice)" + Environment.NewLine +
                                    "For period In ({8})" + Environment.NewLine +
                                    ") As pivotPrice" + Environment.NewLine +
                                    "order by 2" + Environment.NewLine + Environment.NewLine;

                    sqlStatement += "drop table #period" + Environment.NewLine +
                                    "drop table #summary";

                    break;

                case SqlCase.GetCurrencyRate:
                    sqlStatement = "select * from TBMLCURRENCYRATE where COMP_CODE=@COMP_CODE order by CURR_CODE";
                    break;

                //hazim add on 161219
                case SqlCase.GetRelatedSwift:
                    sqlStatement = "Select * from MSGPAYMENTTRADE where MSG_REF_KEY = (Select distinct MSG_REF_KEY from MSGPAYMENTTRADE where MSG_PYMT_ID = @MSG_PYMT_ID) " + Environment.NewLine +
                                    "and MSG_REF_KEY2 > 700 and MSG_PYMT_ID != @MSG_PYMT_ID";
                    break;

                case SqlCase.GetSupportDocuments_Invoice:
                    sqlStatement = "select a.*, prodType.cor_Desc as productType, fraud.cor_Desc as fraudInd" + Environment.NewLine +
                                    "from TBMLTradeInvoice as a" + Environment.NewLine +
                                    "left join cor_code as prodType on prodType.cor_CodeNo=3204 and prodType.cor_CodeKey=a.INVOICE_PRODUCT_TYPE" + Environment.NewLine +
                                    "left join cor_code as fraud on fraud.cor_CodeNo=3206 and fraud.cor_CodeKey=a.FRAUD_IND" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                                    "and exists (select 1 from TBMLTradeTran where COMP_CODE=a.COMP_CODE and DOC_REF=a.DOC_REF and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO)" + Environment.NewLine +
                                    "order by a.AUTO_SEQ_NO";

                    break;

                case SqlCase.GetSupportDocuments_TransportDetails:
                    sqlStatement = "select * from TBMLTradeBLDO" + Environment.NewLine +
                                    "where COMP_CODE = @CompanyCode" + Environment.NewLine +
                                    "and DOC_REF = @DOC_REF" + Environment.NewLine +
                                    "and AUTO_SEQ_NO = @AUTO_SEQ_NO";

                    break;

                case SqlCase.GetSupportDocuments_Transport:
                    sqlStatement = "select a.*, scanStatus.cor_Desc as scanStatus, prodType.cor_Desc as productType, fraud.cor_Desc as fraudInd, BLDOType.cor_Desc as BLDOType" + Environment.NewLine +
                                    "from TBMLTradeBLDO as a" + Environment.NewLine +
                                    "left join cor_code as prodType on prodType.cor_CodeNo=3204 and prodType.cor_CodeKey=a.BLDO_PRODUCT_TYPE" + Environment.NewLine +
                                    "left join cor_code as BLDOType on BLDOType.cor_CodeNo=3207 and BLDOType.cor_CodeKey=a.BLDO_TYPE" + Environment.NewLine +
                                    "left join cor_code as scanStatus on scanStatus.cor_CodeNo=3223 and scanStatus.cor_CodeKey=a.BLDO_SCAN_STATUS" + Environment.NewLine +
                                    "left join cor_code as fraud on fraud.cor_CodeNo=3206 and fraud.cor_CodeKey=a.BLDO_FRAUD_IND" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                                    "and exists (select 1 from TBMLTradeTran where COMP_CODE=a.COMP_CODE and DOC_REF=a.DOC_REF and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO)" + Environment.NewLine +
                                    "order by a.AUTO_SEQ_NO";
                    break;

                //case SqlCase.GetSupportDocuments:
                //    sqlStatement = "select 'Invoice' as DOC_TYPE, COMP_CODE, DOC_REF, AUTO_SEQ_NO, INVOICE_PRODUCT_TYPE as PRODUCT_TYPE, INVOICE_NO as DOC_NO, INVOICE_DATE as DOC_DATE, INVOICE_IMAGE_NAME as IMAGE_NAME" + Environment.NewLine +
                //                    ", INVOICE_REF as DOC_REF, STATUS, USER_ID, prodType.cor_Desc as productType, fraud.cor_Desc as fraudInd, '' as BLDOType" + Environment.NewLine +
                //                    "--, TOTAL_AMOUNT, FX_RATE, INVOICE_CURRENCY, QTY, UNIT_PRICE, AMOUNT, DESCR1" + Environment.NewLine +
                //                    "--, FX_AMOUNT, CONSIGNEE_NAME, CONTRACT_NO, CUSTOMER_PO_NO, CUSTOMER_PO_DATE, SALLING_ON_DATE, SELLER, MARK_NOS" + Environment.NewLine +
                //                    "from TBMLTradeInvoice as a" + Environment.NewLine +
                //                    "left join cor_code as prodType on prodType.cor_CodeNo=3204 and prodType.cor_CodeKey=a.INVOICE_PRODUCT_TYPE" + Environment.NewLine +
                //                    "left join cor_code as fraud on fraud.cor_CodeNo=3206 and fraud.cor_CodeKey=a.FRAUD_IND" + Environment.NewLine +
                //                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                //                    "and exists (select 1 from TBMLTradeTran where COMP_CODE=a.COMP_CODE and DOC_REF=a.DOC_REF and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO)" + Environment.NewLine +
                //                    "union all" + Environment.NewLine +
                //                    "select 'BLDO' as DOC_TYPE, COMP_CODE, DOC_REF, AUTO_SEQ_NO, BLDO_PRODUCT_TYPE, BLDO_NO, BLDO_DATE, BLDO_IMAGE_NAME" + Environment.NewLine +
                //                    ", BLDO_REF, STATUS, USER_ID, prodType.cor_Desc as productType, fraud.cor_Desc as fraudInd, BLDOType.cor_Desc as BLDOType" + Environment.NewLine +
                //                    "--, BLDO_TYPE, BLDO_FRAUD_IND, BLDO_SCAN_STATUS, LAST_SCAN_DATE, LAST_MATCH_DATE, REMARKS, RJ_REMARKS, USER_ID1" + Environment.NewLine +
                //                    "--, BLDO_CONTAINER, BLDO_TRX_DATE, BLDO_TRX_TIME, BLDO_FIELD1, BLDO_FIELD2, BLDO_FIELD3, BLDO_FIELD4, BLDO_FIELD5" + Environment.NewLine +
                //                    "from TBMLTradeBLDO as a" + Environment.NewLine +
                //                    "left join cor_code as prodType on prodType.cor_CodeNo=3204 and prodType.cor_CodeKey=a.BLDO_PRODUCT_TYPE" + Environment.NewLine +
                //                    "left join cor_code as BLDOType on BLDOType.cor_CodeNo=3207 and BLDOType.cor_CodeKey=a.BLDO_TYPE" + Environment.NewLine +
                //                    "left join cor_code as fraud on fraud.cor_CodeNo=3206 and fraud.cor_CodeKey=a.BLDO_FRAUD_IND" + Environment.NewLine +
                //                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                //                    "and exists (select 1 from TBMLTradeTran where COMP_CODE=a.COMP_CODE and DOC_REF=a.DOC_REF and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO)";
                //    break;

                case SqlCase.GetEventLog:

                    sqlStatement = "select *, Convert(VARCHAR(10), createdt, 103) As tranDateDesc,convert(VARCHAR(8), createdt, 14) As tranTimeDesc" + Environment.NewLine +
                                    "from MsgPayEventLog" + Environment.NewLine +
                                    "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO" + Environment.NewLine +
                                    "order by tranDateDesc, tranTimeDesc";
                    break;

                //'sqlStatement = "select AUTO_SYS_ID, TRAN_DATE, TRAN_TIME, APPROVAL_TYPE, PAYMENT_STATUS, REMARKS, DONE_BY" + Environment.NewLine +
                //'                "from (" + Environment.NewLine +
                //'                "select cast(APPROVAL_DATE as varchar(8)) as sortDate" + Environment.NewLine +
                //'                ", AUTO_SYS_ID, dbo.fnConvertIntDate(APPROVAL_DATE, 103) as TRAN_DATE, convert(VARCHAR(8), createdt, 14) as TRAN_TIME" + Environment.NewLine +
                //'                ", APPROVAL_TYPE, '' as PAYMENT_STATUS, remark as REMARKS, APPROVED_BY as DONE_BY" + Environment.NewLine +
                //'                "from MsgPayApprovalLog" + Environment.NewLine +
                //'                "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO" + Environment.NewLine +
                //'                "union" + Environment.NewLine +
                //'                "select convert(varchar(8), createdt, 112) as sortDate" + Environment.NewLine +
                //'                ", 0 as AUTO_SYS_ID, CONVERT(VARCHAR(10), createdt, 103) as TRAN_DATE, convert(VARCHAR(8), createdt, 14) as TRAN_TIME" + Environment.NewLine +
                //'                ", '' as APPROVAL_TYPE, Status as PAYMENT_STATUS, remarks as REMARKS, USER_ID as DONE_BY" + Environment.NewLine +
                //'                "from MsgPayEventLog" + Environment.NewLine +
                //'                "where MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO" + Environment.NewLine +
                //'                ") as t" + Environment.NewLine +
                //'                "order by sortDate, TRAN_TIME"

                case SqlCase.GetAttachment:
                    sqlStatement = "Select *, dbo.fnConvertIntDate(DOC_DATE, 103) as docDateDesc" + Environment.NewLine +
                                    "From MsgPayAttachment" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO" + Environment.NewLine +
                                    "order by MSG_SEQ_NO";
                    break;

                //case SqlCase.RemoveAttachment:
                //    sqlStatement = "update MsgPayAttachment" + Environment.NewLine +
                //                    "set isactive=0" + Environment.NewLine +
                //                    "where COMP_CODE=@CompanyCode and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO and isactive=1" + Environment.NewLine +
                //                    "order by MSG_SEQ_NO";
                //break;

                case SqlCase.GetWatchlist:
                    sqlStatement = "select IIF(master.ENTITY_ID IS NULL, 0, 1) as isMasterExists, scanFor.cor_Desc as scanFor, invstStatus.cor_Desc as investigateStatus, expoType.cor_Desc as expositionType, a.*" + Environment.NewLine +
                                    "From MsgPayWListDtl as a" + Environment.NewLine +
                                    "left join cor_code as scanFor on scanFor.cor_CodeNo=2537 and scanFor.cor_CodeKey=a.SCAN_FOR" + Environment.NewLine +
                                    "left join cor_code as invstStatus on invstStatus.cor_CodeNo=2621 and invstStatus.cor_CodeKey=a.INVESTIGATE_STATUS" + Environment.NewLine +
                                    "left join cor_code as expoType on expoType.cor_CodeNo=2622 and expoType.cor_CodeKey=a.TYPE_OF_EXPOSITION" + Environment.NewLine +
                                    "left join AW_MASTER as master on master.ENTITY_ID=a.ENTITY_ID" + Environment.NewLine +
                                    "where a.COMP_CODE=@CompanyCode and a.MSG_PYMT_ID=@MSG_PYMT_ID and a.MSG_SEQ_NO=@MSG_SEQ_NO" + Environment.NewLine +
                                    "order by a.SEARCH_INPUT_REF, a.MATCH_PERCENT, a.ENTITY_ID, a.SYS_ID";
                    break;

                case SqlCase.GetPortCities:
                    sqlStatement = "select scanFor.cor_Desc as scanFor, invstStatus.cor_Desc as investigateStatus, expoType.cor_Desc as expositionType, a.*" + Environment.NewLine +
                                    "from MsgPayPortSnName as a" + Environment.NewLine +
                                    "left join cor_code as scanFor on scanFor.cor_CodeNo=2537 and scanFor.cor_CodeKey=a.SCAN_FOR" + Environment.NewLine +
                                    "left join cor_code as invstStatus on invstStatus.cor_CodeNo=3231 and invstStatus.cor_CodeKey=a.INVESTIGATE_STATUS" + Environment.NewLine +
                                    "left join cor_code as expoType on expoType.cor_CodeNo=3232 and expoType.cor_CodeKey=a.TYPE_OF_EXPOSITION" + Environment.NewLine +
                                    "where a.COMP_CODE=@CompanyCode and a.MSG_PYMT_ID=@MSG_PYMT_ID and a.MSG_SEQ_NO=@MSG_SEQ_NO" + Environment.NewLine +
                                    "order by a.AUTO_SEQ_NO, a.ENTITY_ID, a.SYS_ID";
                    break;

                case SqlCase.GetDUG:
                    sqlStatement = "select scanFor.cor_Desc as scanFor, invstStatus.cor_Desc as investigateStatus, expoType.cor_Desc as expositionType, a.*" + Environment.NewLine +
                                    "from MsgPayDugListDtl as a" + Environment.NewLine +
                                    "left join cor_code as scanFor on scanFor.cor_CodeNo=2537 and scanFor.cor_CodeKey=a.SCAN_FOR" + Environment.NewLine +
                                    "left join cor_code as invstStatus on invstStatus.cor_CodeNo=3213 and invstStatus.cor_CodeKey=a.INVESTIGATE_STATUS" + Environment.NewLine +
                                    "left join cor_code as expoType on expoType.cor_CodeNo=3214 and expoType.cor_CodeKey=a.TYPE_OF_EXPOSITION" + Environment.NewLine +
                                    "where a.COMP_CODE=@CompanyCode and a.MSG_PYMT_ID=@MSG_PYMT_ID and a.MSG_SEQ_NO=@MSG_SEQ_NO" + Environment.NewLine +
                                    "order by a.AUTO_SEQ_NO, a.ENTITY_ID, a.SYS_ID";
                    break;

                case SqlCase.GetKYC:
                    sqlStatement = "select a.*, prodType.cor_desc as productTypeDesc, faciType.cor_desc as facilityTypeDesc, riskRate.cor_desc as riskRatingDesc" + Environment.NewLine +
                                    ", IIF(a.ACCOUNT_STATUS=0, 'Active', 'Inactive') as accountStatusDesc, dbo.fnConvertIntDate(DATE_OF_ACCT_OPENED, 103) as acctOpenedDateDesc" + Environment.NewLine +
                                    "from TBMLTradeAcc01 as a" + Environment.NewLine +
                                    "left join cor_code as prodType on prodType.cor_CodeNo=3204 and prodType.cor_CodeKey=a.PRODUCT_TYPE" + Environment.NewLine +
                                    "left join cor_code as faciType on faciType.cor_CodeNo=3216 and faciType.cor_CodeKey=a.ACCOUNT_TYPE" + Environment.NewLine +
                                    "left join cor_code as riskRate on riskRate.cor_CodeNo=3215 and riskRate.cor_CodeKey=a.RISK_LEVEL" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                                    "and exists (select 1 from TBMLTradeTran" + Environment.NewLine +
                                    "			where COMP_CODE=a.COMP_CODE and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO and ACCOUNT_NO=a.TRADE_ACC_NO)";
                    break;

                case SqlCase.GetKYCC:
                    sqlStatement = "select a.*, suppType.cor_Desc as supplierTypeDesc, country.cor_Desc as countryDesc, riskLvl.cor_Desc as riskLevelDesc" + Environment.NewLine +
                                    ", IIF(a.WATCHLIST_STATUS=0, 'Not Hit', 'Hit') as watchlistStatusDesc, IIF(a.SUPPLIER_STATUS=0, 'Active', 'Inactive') as supplierStatusDesc, dbo.fnConvertIntDate(DATE_ESTABLISHED, 103) as establishedDateDesc" + Environment.NewLine +
                                    "from TBMLSUPPLIER01 as a" + Environment.NewLine +
                                    "left join cor_code as suppType on suppType.cor_CodeNo=3230 and suppType.cor_CodeKey=a.SUPPLIER_TYPE" + Environment.NewLine +
                                    "left join cor_code as country on country.cor_CodeNo=2709 and country.cor_CodeKey=a.COUNTRY" + Environment.NewLine +
                                    "left join cor_code as riskLvl on riskLvl.cor_CodeNo=3215 and riskLvl.cor_CodeKey=a.RISK_LEVEL" + Environment.NewLine +
                                    "where COMP_CODE=@CompanyCode" + Environment.NewLine +
                                    "and exists (select 1 from TBMLTradeTran" + Environment.NewLine +
                                    "			where COMP_CODE=a.COMP_CODE and MSG_PYMT_ID=@MSG_PYMT_ID and MSG_SEQ_NO=@MSG_SEQ_NO and SUPPLIER_NO=a.SUPPLIER_NO)";
                    break;

                case SqlCase.DropDownTradePartner:

                    sqlStatement = "Select distinct CATEGORY as value, HIGH_RISK_KEY as description" + Environment.NewLine +
                                    "From WatchlistCountryRisk" + Environment.NewLine +
                                    "Where COMP_CODE =@CompanyCode And RISK_TYPE=1 And STATUS=0 And CATEGORY>''" + Environment.NewLine +
                                    "order by 2";
                    break;

                #endregion Approval

                case SqlCase.GetVesselNameInfoSource:
                    sqlStatement = "select INFO_SOURCE as value, INFO_SOURCE as description from AW_VESSELNAME group by INFO_SOURCE ";
                    break;

                case SqlCase.GetPositiveToleranceValue:
                    sqlStatement = "select INT_VALUE1" + Environment.NewLine +
                                    "from cor_code_cust" + Environment.NewLine +
                                    "where CODENO = @CODENO" + Environment.NewLine +
                                    "and CODE_VALUE = @CODE_VALUE" + Environment.NewLine +
                                    "";
                    break;

                case SqlCase.GetNegativeToleranceValue:
                    sqlStatement = "select INT_VALUE1" + Environment.NewLine +
                                    "from cor_code_cust" + Environment.NewLine +
                                    "where CODENO = @CODENO" + Environment.NewLine +
                                    "and CODE_VALUE = @CODE_VALUE" + Environment.NewLine +
                                    "";
                    break;

                #region dashboard standard case status

                case SqlCase.GetStandardCaseStatus:
                    sqlStatement = "SELECT CAST(CONVERT(VARCHAR, MONTH(AUDIT_DATE_CREATED), 23) AS NVARCHAR) AS DATE_FILTER, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 0 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS NONE, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 100 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS UNASSIGN," +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 200 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS INPROGRESS, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 300 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS CLOSED" +
                        " FROM RF_CASE A WHERE YEAR(A.AUDIT_DATE_CREATED) = YEAR(GETDATE()) AND MONTH(A.AUDIT_DATE_CREATED) <= MONTH(GETDATE())  GROUP BY MONTH(AUDIT_DATE_CREATED) ";
                    break;

                case SqlCase.GetWeeklyStandardCaseStatus:
                    sqlStatement = "SELECT CAST(CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23) AS NVARCHAR) AS DATE_FILTER, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 0 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS NONE," +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 100 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS UNASSIGN, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 200 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS INPROGRESS, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 300 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS CLOSED" +
                        " FROM RF_CASE A WHERE AUDIT_DATE_CREATED BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE()  GROUP BY AUDIT_DATE_CREATED";
                    break;

                case SqlCase.GetDailyStandardCaseStatus:
                    sqlStatement = "SELECT CAST(CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23) AS NVARCHAR) AS DATE_FILTER, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 0 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS NONE, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 100 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS UNASSIGN, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 200 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS INPROGRESS, " +
                        " (SELECT COUNT(CASE_STATUS) FROM RF_CASE WHERE CASE_STATUS = 300 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS CLOSED " +
                        " FROM RF_CASE A WHERE CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, GETDATE(), 23)  GROUP BY CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)";
                    break;

                #endregion dashboard standard case status

                #region dashboard custom case status

                case SqlCase.GetCustomCaseStatus:
                    sqlStatement = "SELECT CAST(CONVERT(VARCHAR, MONTH(AUDIT_DATE_CREATED), 23) AS NVARCHAR) AS DATE_FILTER, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 100 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS UNASSIGN," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 101 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS PICKUP," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 110 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS INPROGRESS," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 210 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS DROPCASE, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 211 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS APPROVEDROPCASE, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 212 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS DRAFTEDCASE, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 213 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS REVIEWEDCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 214 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS APPROVEDCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 215 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS REJECTCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 216 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS REWORKCASE, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 217 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS REASSIGNCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 218 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS REOPENCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 219 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS WAITINGINFO, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 220 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS REVIEWCASE, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 300 AND MONTH(A.AUDIT_DATE_CREATED) = MONTH(AUDIT_DATE_CREATED)) AS CLOSED" +
                        " FROM RF_CASE A WHERE YEAR(A.AUDIT_DATE_CREATED) = YEAR(GETDATE()) AND MONTH(A.AUDIT_DATE_CREATED) <= MONTH(GETDATE())  GROUP BY MONTH(AUDIT_DATE_CREATED)";
                    break;

                case SqlCase.GetWeeklyCustomCaseStatus:
                    sqlStatement = "SELECT CAST(CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23) AS NVARCHAR) AS DATE_FILTER, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 100 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS UNASSIGN, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 101 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS PICKUP, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 110 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS INPROGRESS," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 210 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS DROPCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 211 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS APPROVEDROPCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 212 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS DRAFTEDCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 213 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS REVIEWEDCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 214 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS APPROVEDCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 215 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS REJECTCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 216 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS REWORKCASE, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 217 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS REASSIGNCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 218 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS REOPENCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 219 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS WAITINGINFO, " +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 220 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS REVIEWCASE," +
                        " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 300 AND A.AUDIT_DATE_CREATED = AUDIT_DATE_CREATED) AS CLOSED" +
                        " FROM RF_CASE A WHERE AUDIT_DATE_CREATED BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE()  GROUP BY AUDIT_DATE_CREATED";
                    break;

                case SqlCase.GetDailyCustomCaseStatus:
                    sqlStatement = "SELECT CAST(CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23) AS NVARCHAR) AS DATE_FILTER, " +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 100 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS UNASSIGN," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 101 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS PICKUP," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 110 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS INPROGRESS," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 210 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS DROPCASE, " +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 211 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS APPROVEDROPCASE, " +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 212 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS DRAFTEDCASE, " +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 213 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS REVIEWEDCASE," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 214 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS APPROVEDCASE," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 215 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS REJECTCASE," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 216 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS REWORKCASE, " +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 217 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS REASSIGNCASE," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 218 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS REOPENCASE," +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 219 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS WAITINGINFO, " +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 220 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS REVIEWCASE, " +
                       " (SELECT COUNT(CASE_SUB_STATUS) FROM RF_CASE WHERE CASE_SUB_STATUS = 300 AND CONVERT(VARCHAR, A.AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)) AS CLOSED" +
                       " FROM RF_CASE A WHERE CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23) = CONVERT(VARCHAR, GETDATE(), 23)  GROUP BY CONVERT(VARCHAR, AUDIT_DATE_CREATED, 23)";
                    break;

                #endregion dashboard custom case status

                #region dashboard KYC Screening

                case SqlCase.GetKYCScreening:
                    sqlStatement = "SELECT DISTINCT CAST(MONTH(CONVERT(DATE,CONVERT(VARCHAR(10),HIT_DATE,120))) AS NVARCHAR) AS DATE_FILTER, " +
                        " COUNT(SEQ_NO) AS HIT_COUNT FROM AW_HITLOGGER WHERE YEAR(CONVERT(DATE, CONVERT(VARCHAR(10),HIT_DATE,120))) = YEAR(GETDATE()) AND MONTH(CONVERT(DATE, CONVERT(VARCHAR(10),HIT_DATE,120))) <= MONTH(GETDATE())" +
                        " GROUP BY MONTH(CONVERT(DATE, CONVERT(VARCHAR(10), HIT_DATE, 120))) ORDER BY CAST(MONTH(CONVERT(DATE, CONVERT(VARCHAR(10), HIT_DATE, 120))) AS NVARCHAR)";
                    break;

                case SqlCase.GetWeeklyKYCScreening:
                    sqlStatement = "SELECT DISTINCT CAST(CONVERT(DATE,CONVERT(VARCHAR(10),HIT_DATE,120)) AS NVARCHAR) AS DATE_FILTER, " +
                        " COUNT(SEQ_NO) AS HIT_COUNT FROM AW_HITLOGGER WHERE CONVERT(DATE, CONVERT(VARCHAR(10),HIT_DATE,120)) BETWEEN DATEADD(DAY,-7, GETDATE()) AND GETDATE()" +
                        " GROUP BY CONVERT(DATE, CONVERT(VARCHAR(10), HIT_DATE, 120)) ORDER BY CAST(CONVERT(DATE, CONVERT(VARCHAR(10), HIT_DATE, 120)) AS NVARCHAR)";
                    break;

                case SqlCase.GetDailyKYCScreening:
                    sqlStatement = "SELECT DISTINCT CAST(CONVERT(DATE,CONVERT(VARCHAR(10),HIT_DATE,120)) AS NVARCHAR) AS DATE_FILTER," +
                        " COUNT(SEQ_NO) AS HIT_COUNT FROM AW_HITLOGGER WHERE CONVERT(DATE, CONVERT(VARCHAR(10),HIT_DATE,120)) = CONVERT(VARCHAR, GETDATE(), 23)" +
                        " GROUP BY CONVERT(DATE, CONVERT(VARCHAR(10), HIT_DATE, 120)) ORDER BY CAST(CONVERT(DATE, CONVERT(VARCHAR(10), HIT_DATE, 120)) AS NVARCHAR)";
                    break;

                    #endregion dashboard KYC Screening
            }

            return sqlStatement;
        }

        public static string GetTxnHistLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM TRANSACTIONS WHERE  " +
                          " (NO_CIF =@NO_CIF)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetCaseHistLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = '507' AND CODE_SUB = CASE_STATUS) AS STATUS_DESC, * FROM RF_CASE WHERE  " +
                          " (NO_CIF =@NO_CIF)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetConfigWFDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL WHERE  " +
                          " WF_LEVEL = @WF_LEVEL AND WF_MODULE = @WF_MODULE AND WF_STATUS = 1";
                    break;

                default:
                    sqlStatement = "SELECT * FROM CONFIG_WF_DTL";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRFOMLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT DATEDIFF(DAY, CONVERT(datetime, CONVERT(VARCHAR(10), HIT_DATE)), GETDATE()) AS CASE_OS, * FROM RF_OM WHERE " +
                    //sqlStatement = "SELECT A.*, B.* FROM RF_OM A INNER JOIN RF_OMDTL B on B.RF_ID = A.RF_ID WHERE  " +
                          " (CASE_ID =@CASE_ID)";
                    break;

                case 2:
                    sqlStatement = "SELECT * FROM RF_OM WHERE  " +
                          " (NO_CIF =@NO_CIF)";
                    break;

                case 3:
                    sqlStatement = "SELECT * FROM RF_OM " +
                                   " WHERE (@CASE_ID=0 OR CASE_ID = @CASE_ID) " +
                                   " AND (@INFO_NAME='' OR INFO_NAME like '%'+@INFO_NAME+'%') " +
                                   " AND (@RF_ID = 0 OR RF_ID = @RF_ID) ";
                    break;

                case 4:
                    sqlStatement = "SELECT A.*, (SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 501002 AND CODE_SUB = B.STATUS_INV) AS FINDINGS, " +
                                   "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 501003 AND CODE_SUB = B.TYPE_EXPO) AS EXPOSURE, " +
                                   "B.REMARKS from RF_OM A INNER JOIN RF_OMDTL B ON B.RF_ID = A.RF_ID " +
                                   //" WHERE (@CASE_ID=0 OR A.CASE_ID = @CASE_ID) " +
                                   //" AND (@INFO_NAME='' OR A.INFO_NAME like '%'+@INFO_NAME+'%') " +
                                   " WHERE (@RF_ID = 0 or A.RF_ID = @RF_ID) ";
                    break;

                default:
                    sqlStatement = "SELECT DATEDIFF(DAY, CONVERT(datetime, CONVERT(VARCHAR(10), HIT_DATE)), GETDATE()) AS CASE_OS, * FROM RF_OM";
                    break;
            }
            return sqlStatement;
        }

        public static string GetRFOMDetailLoad(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT CASE CAST(HIT_GENDER AS NVARCHAR) WHEN '0' THEN 'Male' WHEN '1' THEN 'Famale' ELSE 'Unknown' END AS HIT_GENDER_DESC, " +
                        "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 501002 AND CODE_SUB = RF_OMDTL.STATUS_INV) AS FINDINGS, " +
                        "(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 501003 AND CODE_SUB = RF_OMDTL.TYPE_EXPO) AS EXPOSURE, * FROM RF_OMDTL WHERE " +
                          " (RF_ID =@RF_ID)";

                    break;
            }
            return sqlStatement;
        }

        public static string GetHistoryLoad()
        {
            string sqlStatement = "";

            //sqlStatement = "SELECT CASE CAST(UPLOAD_TYPE AS NVARCHAR) WHEN '1' THEN 'Watchlist' WHEN '2' THEN 'Screening' END AS UPLOAD_TYPE_DESC, *  FROM WL_BATCHLOG WHERE (UPLOAD_TYPE=1) AND (ACTIVE=0) ";
            sqlStatement = "SELECT(SELECT INFO_DESC FROM CONFIG_CODES_DTL WHERE CODE_PRIME = 509 AND CODE_SUB = WL_BATCHLOG.UPLOAD_TYPE) AS UPLOAD_TYPE_DESC,*FROM WL_BATCHLOG WHERE(UPLOAD_TYPE= 1) AND(ACTIVE = 0)";

            return sqlStatement;
        }

        public static string GetResultDetail(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM WL_BATCHLOG WHERE  " +
                          " (JOB_ID =@JOB_ID)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetResultInfo(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM WL_BATCHDTL WHERE  " +
                          " (JOB_ID =@JOB_ID)";
                    break;
            }
            return sqlStatement;
        }

        public static string GetInputInfo(Int32 sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {
                case 1:
                    sqlStatement = "SELECT * FROM WL_BATCHDTL WHERE  " +
                          " (INPUT_ID =@INPUT_ID) AND (JOB_ID =@JOB_ID) ";
                    break;
            }
            return sqlStatement;
        }
    }
}