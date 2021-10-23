using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminQueryManager
{
    public class AdminQuery
    {
        public enum SqlCase
        {
            //Get Statement
            GetParameterValue

                    , GetProdTypeList
                    , GetTranTypeList
                    , GetGroupName
                    , GetCorCodeDetails

                    //insert Statement
                    , insertIntoEventViewer

                    , Staff_login1

                    //Update Statement
                    , UpdateStaffDetail
        }

        public static string GetMenuDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                case 1:
                    sqlStatement = "SELECT * " +
                          " FROM MENU " +
                          " WHERE FLAG_ENABLE = 1";
                    break;

                case 2:
                    sqlStatement = "SELECT cor_staff.cor_comp_code, " +
                          "cor_staff.cor_full_name, " +
                          "cor_staff.cor_user_type, " +
                          "cor_staff.cor_pwsd_retry, " +
                          "cor_staff.cor_login_status, " +
                          "cor_staff.cor_access_date_from, " +
                          "cor_staff.cor_access_date_to, " +
                          "cor_staff.cor_access_time_from, " +
                          "cor_staff.cor_access_time_to, " +
                          "cor_staff.cor_first_login_date, " +
                          "cor_staff.cor_first_login_time, " +
                          "cor_staff.cor_auth_user, " +
                          "cor_staff.cor_pwsd_max_retry, " +
                          "cor_staff.cor_pw_modified_date, " +
                          "cor_staff.cor_pw_modified_time, " +
                          "cor_staff.cor_pwsd_expiry_days, " +
                          "cor_staff.cor_password, " +
                          "cor_staff.cor_login_date, " +
                          "cor_staff.cor_login_time, " +
                          "cor_staff.cor_emailId, " +
                          "cor_staff.cor_template_id, " +
                          "cor_staff.cor_role_id, " +
                          "cor_staff.cor_group_id, " +
                          "cor_staff.cor_branch, " +
                          "cor_staff.cor_Language, " +
                          "(select cor_name from cor_branch where cor_br_id = cor_staff.cor_branch) as cor_branch_Desc, " +
                          "cor_staff.cor_branch_group, " +
                          "cor_staff.cor_answer, " +
                          "(Select cor_role.cor_name From cor_role where cor_role.cor_role_id = cor_staff.cor_role_id) as cor_role_id_Desc, " +
                          "(Select cor_role_menu_access.cor_menu_ids From cor_role_menu_access where cor_role_menu_access.cor_role_id = cor_staff.cor_role_id) as cor_menu_ids, " +
                          "(Select cor_role_menu_access.cor_menu_buttons From cor_role_menu_access where cor_role_menu_access.cor_role_id = cor_staff.cor_role_id) as cor_menu_buttons " +
                          ", cor_staff.cor_Theme " +
                          " FROM cor_staff " +
                          " WHERE cor_staff.cor_userid =@cor_userId" +
                          " and cor_staff.cor_emailId =@cor_emailId";

                    break;
                    // please revisit to optimize. doing this to avoid sql join.
            }
            return sqlStatement;
        }

        //public static string GetStaffDetail(SqlCase sqlCase)
        public static string GetStaffDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                case 1:
                    sqlStatement = "SELECT STAFF.USER_ID, STAFF.CODE_COMP, " +
                          "STAFF.INFO_NAME_FULL, " +
                          "STAFF.USER_TYPE, " +
                          "STAFF.AUDIT_RETRY, " +
                          "STAFF.CONFIG_STATUS, " +
                          "STAFF.CONFIG_ACCESS_TIME_FROM, " +
                          "STAFF.CONFIG_ACCESS_TIME_TO, " +
                          "STAFF.CONFIG_ACCESS_DATE_FROM, " +
                          "STAFF.CONFIG_ACCESS_DATE_TO, " +
                          "STAFF.AUDIT_FIRST_LOGINDATE, " +
                          "STAFF.AUDIT_FIRST_LOGINTIME, " +
                          "STAFF.CODE_ORG, " +
                          //"STAFF.CONFIG_AUTH_USER, " +
                          "STAFF.CONFIG_MAX_RETRY, " +
                          //"USER1.cor_pw_modified_date, " +
                          //"USER1.cor_pw_modified_time, " +
                          "STAFF.CONFIG_EXPIRY_DAY, " +
                          "STAFF.CONFIG_PASSWORD, " +
                          "STAFF.AUDIT_LAST_LOGINDATE, " +
                          "STAFF.AUDIT_LAST_LOGINTIME, " +
                          //"STAFF.USER_WORKFLOW, " +
                          //"USER1.cor_role_id, " +
                          //"USER1.cor_group_id, " +
                          "STAFF.USER_OFFICE, " +
                          //"(select cor_name from cor_branch where cor_br_id = STAFF.USER_OFFICE) as cor_branch_Desc, " +
                          "STAFF.USER_ROUTING " +
                          //"USER1.cor_answer, " +
                          //"(Select cor_role.cor_name From cor_role where cor_role.cor_role_id = STAFF.USER_ROLE) as cor_role_id_Desc, " +
                          //"(Select cor_role_menu_access.cor_menu_ids From cor_role_menu_access where cor_role_menu_access.cor_role_id = STAFF.USER_ROLE) as cor_menu_ids, " +
                          //"(Select cor_role_menu_access.cor_menu_buttons From cor_role_menu_access where cor_role_menu_access.cor_role_id = STAFF.USER_ROLE) as cor_menu_buttons " +
                          //" STAFF.CONFIG_THEME " +
                          " FROM STAFF " +
                          " WHERE STAFF.USER_ID =@USER_ID";
                    break;

                case 2:
                    sqlStatement = "SELECT STAFF.CODE_COMP, " +
                          "STAFF.INFO_NAME_FULL, " +
                          "STAFF.USER_TYPE, " +
                          "STAFF.AUDIT_RETRY, " +
                          "STAFF.CONFIG_STATUS, " +
                          "STAFF.CONFIG_ACCESS_DATE_FROM, " +
                          "STAFF.CONFIG_ACCESS_DATE_TO, " +
                          "STAFF.CONFIG_ACCESS_TIME_FROM, " +
                          "STAFF.CONFIG_ACCESS_TIME_TO, " +
                          "STAFF.AUDIT_FIRST_LOGINDATE, " +
                          "STAFF.AUDIT_FIRST_LOGINTIME, " +
                          "STAFF.CODE_ORG, " +
                          //"STAFF.CONFIG_AUTH_USER, " +
                          "STAFF.CONFIG_MAX_RETRY, " +
                          //"USER1.cor_pw_modified_date, " +
                          //"USER1.cor_pw_modified_time, " +
                          "STAFF.CONFIG_EXPIRY_DAY, " +
                          "STAFF.CONFIG_PASSWORD, " +
                          "STAFF.AUDIT_LAST_LOGINDATE, " +
                          "STAFF.AUDIT_LAST_LOGINTIME, " +
                          "STAFF.USER_EMAIL, " +
                          //"STAFF.USER_WORKFLOW, " +
                          //"USER1.cor_role_id, " +
                          //"USER1.cor_group_id, " +
                          "STAFF.USER_OFFICE, " +
                          //"(select cor_name from cor_branch where cor_br_id = STAFF.USER_OFFICE) as cor_branch_Desc " +
                          //"USER1.cor_branch_group, " +
                          //"USER1.cor_answer, " +
                          //"(Select cor_role.cor_name From cor_role where cor_role.cor_role_id = STAFF.USER_ROLE) as cor_role_id_Desc, " +
                          //"(Select cor_role_menu_access.cor_menu_ids From cor_role_menu_access where cor_role_menu_access.cor_role_id = STAFF.USER_ROLE) as cor_menu_ids, " +
                          //"(Select cor_role_menu_access.cor_menu_buttons From cor_role_menu_access where cor_role_menu_access.cor_role_id = STAFF.USER_ROLE) as cor_menu_buttons " +
                          //", STAFF.CONFIG_THEME " +
                          " FROM STAFF " +
                          " WHERE STAFF.USER_ID =@USER_ID" +
                          " and STAFF.USER_EMAIL =@USER_EMAIL";

                    break;

                    // please revisit to optimize. doing this to avoid sql join.
            }
            return sqlStatement;
        }

        public static string getParameterDetail()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT * FROM PARAM_STAFF WHERE  " +
                          " (CODE_COMP =@CODE_COMP)";

            return sqlStatement;
        }

        public static string getSMSEmailDetail()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT * FROM PARAM_SMSEMAIL WHERE  " +
                            " COMP_CODE = @COMP_CODE " +
                            " AND GRP_DESC =@GRP_DESC ";

            return sqlStatement;
        }

        public static string UpdateStaffDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                case 1:
                    sqlStatement = "UPDATE STAFF SET  " +
                                    " AUDIT_RETRY=@AUDIT_RETRY" +
                                    " WHERE USER_ID=@USER_ID";
                    break;

                case 2:
                    sqlStatement = "UPDATE STAFF SET  " +
                                    " CONFIG_PASSWORD=@CONFIG_PASSWORD, " +
                                    " AUDIT_RETRY = 0 " +
                                    " WHERE USER_ID=@USER_ID";
                    break;

                case 3:
                    sqlStatement = "UPDATE STAFF SET  " +
                                    " AUDIT_FIRST_LOGINDATE = @AUDIT_FIRST_LOGINDATE " +
                                    " WHERE USER_ID=@USER_ID";
                    break;
            }
            return sqlStatement;
        }
    }
}