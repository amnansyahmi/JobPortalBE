using System.Configuration;

namespace JobPortal.Shares
{
    public enum ConnectionProviders
    {
        Unknown
        , Sql
        , OleDb
    }

    public static class GlobalVariables
    {
        public static readonly string AuthUser = ConfigurationManager.AppSettings["AuthUser"];
        public static readonly string AuthPswd = ConfigurationManager.AppSettings["AuthPswd"];

        public static string[] GlobalErrorMessage = new string[100];
        public static string[] GlobalAuditMessage = new string[25];

        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["JobPortalDB"].ConnectionString;   //.ConnectionStrings["JobPortalDB"];

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
                    return "JobPortalContext";
                else if (ConnectionProvider == ConnectionProviders.OleDb)
                    return "JobPortalContextOleDb";
                else
                    return "";
            }
        }
    }
}