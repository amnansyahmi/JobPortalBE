using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMLP.Query
{
    public class SettingQuery
    {

        public enum SqlCase
        {
                GetOrgLoad
                , GetOrgDetail
                , GetAuthLoad
                , GetLocLoad
                , GetRouteLoad
                , GetDataMappingLoad
                , GetCannedResponseLoad
                , GetWorkflowLoad

        }

        public static string GetStatement(SqlCase sqlCase)
        {
            string sqlStatement = "";

            switch (sqlCase)
            {

                //siti added 25062020
                case SqlCase.GetOrgLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by CODE_ORG asc) as Row, *  FROM PARAM_LICENSE";
                    break;

                case SqlCase.GetOrgDetail:
                    sqlStatement = "SELECT * FROM PARAM_LICENSE WHERE  " +
                          " (CODE_ORG =@CODE_ORG)";
                    break;

                case SqlCase.GetAuthLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by domainName asc) as Row, *  FROM SETTING_AUTH_DOMAIN";
                    break;

                case SqlCase.GetLocLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by locationName asc) as Row, *  FROM SETTING_LOCATION";
                    break;

                case SqlCase.GetRouteLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by masterRouteId asc) as Row, *  FROM SETTING_RFLAGROUTE";
                    break;

                case SqlCase.GetDataMappingLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by mappingType asc) as Row, *  FROM SETTING_DATA_MAPPING";
                    break;

                case SqlCase.GetCannedResponseLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by CRName asc) as Row, *  FROM SETTING_CANNED_RESPONSE";
                    break;

                case SqlCase.GetWorkflowLoad:
                    sqlStatement = "select ROW_NUMBER() over(order by MasterTemplateNo asc) as Row, *  FROM SETTING_TMWORKFLOW";
                    break;
            }
            return sqlStatement;
        }

    }
}