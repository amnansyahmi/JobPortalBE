using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace JobPortal.Shares
{
    public enum FindingTypes
    {
        SanctionPortCities = 1, Watchlist = 2, DUG = 3
    }

    public enum TNCStatus
    {
        Outstanding = 1, Completed = 2
    }

    public enum ApprovalStatus
    {
        None = 0, Pending = 1, Reject = 2, Approve = 3
    }

    public enum WatchlistOnBoardStatus
    {
        None = 0, Pending = 1, Reject = 2, Relase = 3, Escalate = 6
    }

    public enum MessageScanStatus
    {
        NoHit = 0, HitEntity = 1, Release = 2, ConfirmHit = 3, PendingApproval = 7, PendingRelease = 8, MsgError = 9
    }

    public enum MessageActionStatus
    {
        NoHit = 0, HitEntity = 1, Release = 2, ConfirmHit = 3, PendingApproval = 7, PendingRelease = 8, MsgError = 9
    }

    public enum ConnectionProviders
    {
        Unknown
        , Sql
        , OleDb
    }

    public enum WatchListType
    {
        DJ = 2170
        , WC = 2720
        , STD = 2610
        , LNX = 2740
    }

    public static class GlobalVariables
    {
        public static readonly string AuthUser = ConfigurationManager.AppSettings["AuthUser"];
        public static readonly string AuthPswd = ConfigurationManager.AppSettings["AuthPswd"];
        public static readonly string RecoverAccessLink = ConfigurationManager.AppSettings["RecoverAccessLink"];
        public static string GlobalUsedWatchListType = "DJ";
        public static Int16 GlobalInsertWatchlistLogger = Int16.Parse(ConfigurationManager.AppSettings["InsertWatchlistLogger"]);

        public static string[] GlobalErrorMessage = new string[100];
        public static string[] GlobalAuditMessage = new string[25];
        public static int ScanCountryTable = int.Parse(ConfigurationManager.AppSettings["ScanCountryTable"]);
        public static readonly Int16 CompanyCode = SystemUtility.ConvertToInt<Int16>(ConfigurationManager.AppSettings["CompanyCode"]);
        public static string FilterSetting = ConfigurationManager.AppSettings["FilterSetting"];
        public static string APIURI = ConfigurationManager.AppSettings["APIURI"];
        public static string ES_GETTOKEN_APIURI = ConfigurationManager.AppSettings["ES_GETTOKEN_APIURI"];
        public static string ES_GETTOKEN_APIName = ConfigurationManager.AppSettings["ES_GETTOKEN_APIName"];
        public static string ES_SEARCH_APIURI = ConfigurationManager.AppSettings["ES_SEARCH_APIURI"];
        public static string ES_SEARCH_APIName = ConfigurationManager.AppSettings["ES_SEARCH_APIName"];

        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["TBMLBulk"].ConnectionString;   //.ConnectionStrings["TBMLBulk"];

        public static ConnectionProviders ConnectionProvider
        {
            get
            {
                string providerName = ConfigurationManager.AppSettings["ConnectionProvider"];
                if (providerName == "sql")
                    return ConnectionProviders.Sql;
                else if (providerName == "oledb")
                    return ConnectionProviders.Sql;
                else
                    return ConnectionProviders.Unknown;
            }
        }

        public static string ConnectionName
        {
            get
            {
                if (ConnectionProvider == ConnectionProviders.Sql)
                    return "TBMLContext";
                else if (ConnectionProvider == ConnectionProviders.OleDb)
                    return "TBMLContextOleDb";
                else
                    return "";
            }
        }
    }
}