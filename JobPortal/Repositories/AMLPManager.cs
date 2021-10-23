using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using JobPortal.Shares;
using JobPortal.Models;

//using JobPortal.Query;
//using AdminQueryManager;
using AdminQueryManager;
using PowerQueryManager;
using PeopleQueryManager;
using PortfolioQueryManager;
using SettingQueryManager;

namespace JobPortal.Repositories
{
    public class JobPortalManager : Manager
    {
        public JobPortalManager(JobPortalContext context) : base(context)
        {
            //enf
        }

        //TESTCOMMENT

        public JobPortalManager() : base()
        {
        }

        //public List<ACCOUNT01> ProfileLoad()
        //{
        //    return _context.Database.SqlQuery<ACCOUNT01>(PortfolioQuery.GetStatement(PortfolioQuery.SqlCase.GetProfileLoad),
        //                                                                            new SqlParameter("s", "s")).ToList();

        //}

        //public List<ACCOUNT01> ProfileDetail(string CIFid)
        //{
        //    if (string.IsNullOrEmpty(CIFid))
        //    {
        //        CIFid = "";
        //    }
        //    return _context.Database.SqlQuery<ACCOUNT01>(PortfolioQuery.GetStatement(PortfolioQuery.SqlCase.GetProfileDetail),
        //                                                                            new SqlParameter("CIF_ID", CIFid)).ToList();
        //}

        ////siti added 24062020
        //public List<PEOPLE_DETAIL> PeopleLoad()
        //{
        //    return _context.Database.SqlQuery<PEOPLE_DETAIL>(PeopleQuery.GetStatementPeople(PeopleQuery.SqlCase.GetPeopleLoad),
        //                                                                             new SqlParameter("s", "s")).ToList();
        //}

        //public List<PEOPLE_DETAIL> UpdatePeople(Int32 SQLCase, string[] arrParameter)
        //{
        //    return _context.Database.SqlQuery<PEOPLE_DETAIL>(PeopleQuery.GetStatementPeople(PeopleQuery.SqlCase.UpdatePeopleDetail),
        //                                                                             new SqlParameter("s", "s")).ToList();
        //}

        ////siti added 24062020
        //public List<PEOPLE_DETAIL> PeopleDetail(string USER_ID)
        //{
        //    if (string.IsNullOrEmpty(USER_ID))
        //    {
        //        USER_ID = "";
        //    }
        //    return _context.Database.SqlQuery<PEOPLE_DETAIL>(PeopleQuery.GetStatementPeople(PeopleQuery.SqlCase.GetPeopleDetail),
        //                                                                            new SqlParameter("userId", USER_ID)).ToList();

        //}

        public List<CONFIG_CODES_DTL> GetConfigCodesDetail(Int32 sqlCase, _CONFIG_CODES_DTL CONFIG_CODES_DTL)
        {
            switch (sqlCase)
            {
                case 1:
                    return _context.Database.SqlQuery<CONFIG_CODES_DTL>(PowerQuery.GetConfigCodesDetail(sqlCase),
                                                                        new SqlParameter("CONFIG_STATUS1", CONFIG_CODES_DTL.CONFIG_STATUS1),
                                                                        new SqlParameter("CODE_PRIME", CONFIG_CODES_DTL.CODE_PRIME)).ToList();

                case 2:
                    return _context.Database.SqlQuery<CONFIG_CODES_DTL>(PowerQuery.GetConfigCodesDetail(sqlCase),
                                                                        new SqlParameter("CODE_SUB", CONFIG_CODES_DTL.CODE_SUB),
                                                                        new SqlParameter("CODE_PRIME", CONFIG_CODES_DTL.CODE_PRIME)).ToList();

                case 3:
                    return _context.Database.SqlQuery<CONFIG_CODES_DTL>(PowerQuery.GetConfigCodesDetail(sqlCase),
                                                                        new SqlParameter("CODE_PRIME", CONFIG_CODES_DTL.CODE_PRIME),
                                                                        new SqlParameter("DATA_VALUEI2", CONFIG_CODES_DTL.DATA_VALUEI2)).ToList();

                case 4:
                    return _context.Database.SqlQuery<CONFIG_CODES_DTL>(PowerQuery.GetConfigCodesDetail(sqlCase),
                                                                        new SqlParameter("CODE_PRIME", CONFIG_CODES_DTL.CODE_PRIME)).ToList();

                default:
                    return _context.Database.SqlQuery<CONFIG_CODES_DTL>(PowerQuery.GetConfigCodesDetail(sqlCase),
                                                                         new SqlParameter("s", "s")).ToList();
            }
        }

        //siti added 25062020
        public List<PARAM_LICENSE> OrgLoad()
        {
            return _context.Database.SqlQuery<PARAM_LICENSE>(SettingQuery.GetStatement(SettingQuery.SqlCase.GetOrgLoad),
                                                                                     new SqlParameter("s", "s")).ToList();
        }

        //siti added 06072020
        public List<PARAM_LICENSE> OrgDetail(string CODE_ORG)
        {
            if (string.IsNullOrEmpty(CODE_ORG))
            {
                CODE_ORG = "";
            }
            return _context.Database.SqlQuery<PARAM_LICENSE>(SettingQuery.GetStatement(SettingQuery.SqlCase.GetOrgDetail),
                                                                                    new SqlParameter("CODE_ORG", CODE_ORG)).ToList();
        }

        public List<STAFF> staffDetail(string USER_ID)
        {
            if (string.IsNullOrEmpty(USER_ID))
            {
                USER_ID = "";
            }
            return _context.Database.SqlQuery<STAFF>(PortfolioQuery.GetStatement(PortfolioQuery.SqlCase.GetStaffDetail),
                                                                                    new SqlParameter("USER_ID", USER_ID)).ToList();
        }

        //public List<STAFF> UpdateStaffDetail(Int32 SQLCase, string cor_userId, Int32 cor_pwsd_retry)
        public List<STAFF> UpdateStaffDetail(Int32 SQLCase, string[] arrParameter)
        {
            switch (SQLCase)
            {
                case 1:
                    return _context.Database.SqlQuery<STAFF>(AdminQuery.UpdateStaffDetail(SQLCase),
                                                                                    new SqlParameter("USER_ID", arrParameter[0]),
                                                                                    new SqlParameter("AUDIT_RETRY", arrParameter[1])).ToList();

                case 2:
                    return _context.Database.SqlQuery<STAFF>(AdminQuery.UpdateStaffDetail(SQLCase),
                                                                                    new SqlParameter("USER_ID", arrParameter[0]),
                                                                                    new SqlParameter("CONFIG_PASSWORD", arrParameter[1])).ToList();

                default:
                    return _context.Database.SqlQuery<STAFF>(AdminQuery.UpdateStaffDetail(SQLCase),
                                                                                    new SqlParameter("USER_ID", arrParameter[0])).ToList();
            }
        }

        //public List<STAFF> GetStaffDetail(Int32 SQLCase, string cor_userid)
        //{
        //    if (string.IsNullOrEmpty(cor_userid))
        //    {
        //        cor_userid = "";
        //    }
        //    return _context.Database.SqlQuery<STAFF>(AdminQuery.GetStaffDetail(SQLCase),
        //                                                                            new SqlParameter("cor_userid", cor_userid)).ToList();
        //}

        public List<COR_MENU> GetMenuDetail(Int32 SQLCase, string[] arrParameter)
        {
            switch (SQLCase)
            {
                case 1:
                    return _context.Database.SqlQuery<COR_MENU>(AdminQuery.GetMenuDetail(SQLCase),
                                                                                    new SqlParameter("cor_userid", arrParameter[0])).ToList();

                case 2:
                    return _context.Database.SqlQuery<COR_MENU>(AdminQuery.GetMenuDetail(SQLCase),
                                                                                    new SqlParameter("cor_userid", arrParameter[0]),
                                                                                    new SqlParameter("cor_emailId", arrParameter[1])).ToList();

                default:
                    return _context.Database.SqlQuery<COR_MENU>(AdminQuery.GetMenuDetail(SQLCase),
                                                                                    new SqlParameter("cor_userid", arrParameter[0])).ToList();
            }
        }

        public List<STAFF> GetStaffDetail(Int32 SQLCase, _STAFF staffDetail)
        {
            switch (SQLCase)
            {
                case 1:
                    return _context.Database.SqlQuery<STAFF>(AdminQuery.GetStaffDetail(SQLCase),
                                                                                    new SqlParameter("USER_ID", staffDetail.USER_ID)).ToList();

                case 2:
                    return _context.Database.SqlQuery<STAFF>(AdminQuery.GetStaffDetail(SQLCase),
                                                                                    new SqlParameter("USER_ID", staffDetail.USER_ID),
                                                                                    new SqlParameter("USER_EMAIL", staffDetail.USER_EMAIL)).ToList();

                default:
                    return _context.Database.SqlQuery<STAFF>(AdminQuery.GetStaffDetail(SQLCase),
                                                                                    new SqlParameter("USER_ID", staffDetail.USER_ID)).ToList();
            }
        }

        public List<PARAM_ERROR> corCodeDetail(Int32 MODULE_ID)
        {
            return _context.Database.SqlQuery<PARAM_ERROR>(PowerQuery.GetStatement(PowerQuery.SqlCase.GetCorCodeDetails),
                                                                                    new SqlParameter("MODULE_ID", MODULE_ID)).ToList();
        }

        public string getErrorDetail(string INFO_CODE)
        {
            return _context.Database.SqlQuery<string>(PowerQuery.GetStatement(PowerQuery.SqlCase.GetMsgDetails),
                                                                                    new SqlParameter("INFO_CODE", INFO_CODE)).FirstOrDefault();
        }

        public List<PARAM_LICENSE> InsertIntoParJobPortalicense(Int32 SQLCase, _PARAM_LICENSE PARAM_LICENSE)
        {
            return _context.Database.SqlQuery<PARAM_LICENSE>(SettingQuery.InsertIntoParJobPortalicense(SQLCase),
                                                                                new SqlParameter("CODE_ORG", PARAM_LICENSE.CODE_ORG),
                                                                                new SqlParameter("NAME_ORG", PARAM_LICENSE.NAME_ORG),
                                                                                new SqlParameter("DATE_VALID_TO", PARAM_LICENSE.DATE_VALID_TO),
                                                                                new SqlParameter("STATUS_LICENSE", PARAM_LICENSE.STATUS_LICENSE)
                                                                                ).ToList();
        }

        public List<EVENT_VIEWER> insertIntoEventViewer(string userId, string Action, string URL, string RoomName, string MenuName, Int16 compCode = 1)
        {
            return _context.Database.SqlQuery<EVENT_VIEWER>(PowerQuery.insertIntoEventViewer(),
                                                                                    new SqlParameter("userId", userId),
                                                                                    new SqlParameter("Action", Action),
                                                                                    new SqlParameter("URL", URL),
                                                                                    new SqlParameter("RoomName", RoomName),
                                                                                    new SqlParameter("MenuName", MenuName),
                                                                                    new SqlParameter("Comp_Code", compCode),
                                                                                    new SqlParameter("tran_date", DateTime.Now.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture))
                                                                                    ).ToList();
        }

        public List<PARAM_STAFF> getParameterDetail(int CODE_COMP)
        {
            return _context.Database.SqlQuery<PARAM_STAFF>(AdminQuery.getParameterDetail(),
                                                                                    new SqlParameter("CODE_COMP", CODE_COMP)).ToList();
        }

        public List<PARAM_SMSEMAIL> getSMSEmailDetail(int CODE_COMP, String GRP_KEY)
        {
            return _context.Database.SqlQuery<PARAM_SMSEMAIL>(AdminQuery.getSMSEmailDetail(),
                                                                                    new SqlParameter("GRP_KEY", GRP_KEY),
                                                                                    new SqlParameter("CODE_COMP", CODE_COMP)).ToList();
        }

        public List<RF_TM> AlertLoad(string NO_CIF)
        {
            if (string.IsNullOrEmpty(NO_CIF))
            {
                NO_CIF = "";
            }
            return _context.Database.SqlQuery<RF_TM>(PortfolioQuery.GetStatement(PortfolioQuery.SqlCase.GetAlertList),
                                                                                    new SqlParameter("NO_CIF", NO_CIF)).ToList();
        }

        public List<RF_TMDTL> TranHitLoad(string RF_ID)
        {
            if (string.IsNullOrEmpty(RF_ID))
            {
                RF_ID = "";
            }
            return _context.Database.SqlQuery<RF_TMDTL>(PortfolioQuery.GetStatement(PortfolioQuery.SqlCase.GetTranHit),
                                                                                    new SqlParameter("RF_ID", RF_ID)).ToList();
        }

        public List<PARAM_ERROR> ProdType()
        {
            return _context.Database.SqlQuery<PARAM_ERROR>(PortfolioQuery.GetStatement(PortfolioQuery.SqlCase.GetProdTypeList),
                                                                                    new SqlParameter("s", "s")).ToList();
        }

        public List<PARAM_ERROR> TranType(string INFO_CODE)
        {
            return _context.Database.SqlQuery<PARAM_ERROR>(PortfolioQuery.GetStatement(PortfolioQuery.SqlCase.GetTranTypeList),
                                                                                    new SqlParameter("INFO_CODE", INFO_CODE)).ToList();
        }

        public List<sequence> GetLatestSequence(sequence sequence)
        {
            switch (sequence.name)
            {
                case "RF_WM_ID":
                    return _context.Database.SqlQuery<sequence>(PowerQuery.GetLatestSequence(PowerQuery.SqlCase.RF_WM_ID)).ToList();

                case "HITLOGGER_SEQ_NO":
                    return _context.Database.SqlQuery<sequence>(PowerQuery.GetLatestSequence(PowerQuery.SqlCase.HITLOGGER_SEQ_NO)).ToList();

                default:
                    return _context.Database.SqlQuery<sequence>(PowerQuery.GetLatestSequence(PowerQuery.SqlCase.HITLOGGER_SEQ_NO)).ToList();
            }
        }

        public List<sequence> GetLatestSequence2(sequence sequence)
        {
            return _context.Database.SqlQuery<sequence>(PowerQuery.GetStatement(PowerQuery.SqlCase.GetLatestSequence),
                                                                                    new SqlParameter("name", sequence.name)).ToList();
        }

        public List<sequence> GetCurrentSequence(sequence sequence)
        {
            switch (sequence.name)
            {
                case "RF_WM_ID":
                    return _context.Database.SqlQuery<sequence>(PowerQuery.GetCurrentSequence(PowerQuery.SqlCase.RF_WM_ID)).ToList();

                case "HITLOGGER_SEQ_NO":
                    return _context.Database.SqlQuery<sequence>(PowerQuery.GetCurrentSequence(PowerQuery.SqlCase.HITLOGGER_SEQ_NO)).ToList();

                default:
                    return _context.Database.SqlQuery<sequence>(PowerQuery.GetCurrentSequence(PowerQuery.SqlCase.HITLOGGER_SEQ_NO)).ToList();
            }
        }

        public static string checkSQLSelect(String sqlSelect)
        {
            String result = "";

            if (sqlSelect == "")
            {
                result = "*";
            }
            else
            {
                result = sqlSelect;
            }

            return result;
        }

        public static string checkSQLWhere(String sqlWhere)
        {
            String result = "WHERE CODE_ORG";

            if (sqlWhere == "")
            {
                result = "*";
            }
            else
            {
                result = sqlWhere;
            }

            return result;
        }

        public List<CONFIG_WF_HDR> GetDropDownItemsWfTemplate(Int32 sqlCase, _CONFIG_WF_HDR CONFIG_WF_HDR)
        {
            switch (sqlCase)
            {
                case 1:
                    return _context.Database.SqlQuery<CONFIG_WF_HDR>(PowerQuery.GetDropDownItemsWfTemplate(sqlCase),
                                                                        new SqlParameter("WF_MODULE", CONFIG_WF_HDR.WF_MODULE),
                                                                        new SqlParameter("CODE_COMP", CONFIG_WF_HDR.CODE_COMP),
                                                                        new SqlParameter("CODE_ORG", CONFIG_WF_HDR.CODE_ORG)).ToList();

                default:
                    return _context.Database.SqlQuery<CONFIG_WF_HDR>(PowerQuery.GetDropDownItemsWfTemplate(sqlCase),
                                                                         new SqlParameter("s", "s")).ToList();
            }
        }

        //public List<CONFIG_WF_HDR> GetDropDownItemsWorkflow()
        //{
        //    return _context.Database.SqlQuery<CONFIG_WF_HDR>(PowerQuery.GetDropDownItemsWorkflow(),
        //                                             new SqlParameter("s", "s")).ToList();
        //}

        public List<CONFIG_WF_HDR> GetDropDownItemsWorkflow(Int32 sqlCase, _CONFIG_WF_HDR CONFIG_WF_HDR)
        {
            switch (sqlCase)
            {
                case 1:
                    return _context.Database.SqlQuery<CONFIG_WF_HDR>(PowerQuery.GetDropDownItemsWorkflow(sqlCase),
                                                                        new SqlParameter("WF_MODULE", CONFIG_WF_HDR.WF_MODULE)).ToList();

                case 2:
                    return _context.Database.SqlQuery<CONFIG_WF_HDR>(PowerQuery.GetDropDownItemsWorkflow(sqlCase),
                                                                        new SqlParameter("WF_ID", CONFIG_WF_HDR.WF_ID),
                                                                        new SqlParameter("WF_MODULE", CONFIG_WF_HDR.WF_MODULE)).ToList();

                default:
                    return _context.Database.SqlQuery<CONFIG_WF_HDR>(PowerQuery.GetDropDownItemsWorkflow(sqlCase),
                                                                         new SqlParameter("s", "s")).ToList();
            }
        }

        public List<PARAM_MAPPING_HDR> GetDropDownScreeningTable(Int32 sqlCase, _PARAM_MAPPING_HDR PARAM_MAPPING_HDR)
        {
            switch (sqlCase)
            {
                case 1:
                    return _context.Database.SqlQuery<PARAM_MAPPING_HDR>(PowerQuery.GetDropDownScreeningTable(sqlCase),
                                                                        new SqlParameter("MAP_PRODUCT", PARAM_MAPPING_HDR.MAP_PRODUCT)).ToList();

                case 2:
                    return _context.Database.SqlQuery<PARAM_MAPPING_HDR>(PowerQuery.GetDropDownScreeningTable(sqlCase),
                                                                        new SqlParameter("MAP_ID_HDR", PARAM_MAPPING_HDR.MAP_ID_HDR),
                                                                        new SqlParameter("MAP_PRODUCT", PARAM_MAPPING_HDR.MAP_PRODUCT)).ToList();

                default:
                    return _context.Database.SqlQuery<PARAM_MAPPING_HDR>(PowerQuery.GetDropDownScreeningTable(sqlCase),
                                                                         new SqlParameter("s", "s")).ToList();
            }
        }

        public List<PARAM_MAPPING_DTL> GetDropDownScreeningField(Int32 sqlCase, _PARAM_MAPPING_DTL PARAM_MAPPING_DTL)
        {
            switch (sqlCase)
            {
                case 1:
                    return _context.Database.SqlQuery<PARAM_MAPPING_DTL>(PowerQuery.GetDropDownScreeningField(sqlCase),
                                                                        new SqlParameter("MAP_PRODUCT", PARAM_MAPPING_DTL.MAP_PRODUCT)).ToList();

                case 2:
                    return _context.Database.SqlQuery<PARAM_MAPPING_DTL>(PowerQuery.GetDropDownScreeningField(sqlCase),
                                                                        new SqlParameter("MAP_ID_DTL", PARAM_MAPPING_DTL.MAP_ID_DTL),
                                                                        new SqlParameter("MAP_PRODUCT", PARAM_MAPPING_DTL.MAP_PRODUCT)).ToList();

                case 3:
                    return _context.Database.SqlQuery<PARAM_MAPPING_DTL>(PowerQuery.GetDropDownScreeningField(sqlCase),
                                                                        new SqlParameter("MAP_TABLE_NAME", PARAM_MAPPING_DTL.MAP_TABLE_NAME),
                                                                        new SqlParameter("MAP_PRODUCT", PARAM_MAPPING_DTL.MAP_PRODUCT)).ToList();

                case 4:
                    return _context.Database.SqlQuery<PARAM_MAPPING_DTL>(PowerQuery.GetDropDownScreeningField(sqlCase),
                                                                        new SqlParameter("MAP_TABLE_NAME", PARAM_MAPPING_DTL.MAP_TABLE_NAME),
                                                                        new SqlParameter("MAP_PRODUCT", PARAM_MAPPING_DTL.MAP_PRODUCT)).ToList();

                default:
                    return _context.Database.SqlQuery<PARAM_MAPPING_DTL>(PowerQuery.GetDropDownScreeningField(sqlCase),
                                                                         new SqlParameter("s", "s")).ToList();
            }
        }

        public List<INFORMATION_SCHEMA_COLUMNS> GetDropDownScreeningFormula(Int32 sqlCase, _INFORMATION_SCHEMA_COLUMNS INFORMATION_SCHEMA_COLUMNS)
        {
            switch (sqlCase)
            {
                case 1:
                    return _context.Database.SqlQuery<INFORMATION_SCHEMA_COLUMNS>(PowerQuery.GetDropDownScreeningFormula(sqlCase),
                                                                        new SqlParameter("TABLE_NAME", INFORMATION_SCHEMA_COLUMNS.TABLE_NAME),
                                                                        new SqlParameter("COLUMN_NAME", INFORMATION_SCHEMA_COLUMNS.COLUMN_NAME)).ToList();

                default:
                    return _context.Database.SqlQuery<INFORMATION_SCHEMA_COLUMNS>(PowerQuery.GetDropDownScreeningFormula(sqlCase),
                                                                         new SqlParameter("s", "s")).ToList();
            }
        }
        public List<PARAM_MAPPING_DTL> GetDDParamMapDtl(Int32 sqlCase, _PARAM_MAPPING_DTL PARAM_MAPPING_DTL)
        {
            switch (sqlCase)
            {
                case 1:
                    return _context.Database.SqlQuery<PARAM_MAPPING_DTL>(PowerQuery.GetDDParamMapDtl(sqlCase),
                                                                        new SqlParameter("MAP_ID_HDR", PARAM_MAPPING_DTL.MAP_ID_HDR),
                                                                        new SqlParameter("MAP_PRODUCT", PARAM_MAPPING_DTL.MAP_PRODUCT)).ToList();

                default:
                    return _context.Database.SqlQuery<PARAM_MAPPING_DTL>(PowerQuery.GetDDParamMapDtl(sqlCase),
                                                                         new SqlParameter("s", "s")).ToList();
            }
        }
    }
}