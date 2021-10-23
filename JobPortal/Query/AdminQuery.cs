using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMLP.Query
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
                    sqlStatement = "SELECT cor_staff.cor_comp_code, cor_staff.cor_userid," +
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
                          " WHERE cor_staff.cor_userid =@cor_userId";
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

        public static string getParameterDetail()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT * FROM COR_PARAMETER WHERE  " +
                          " (COR_COMP_CODE =@COR_COMP_CODE)";

            return sqlStatement;
        }

        public static string getSMSEmailDetail()
        {
            string sqlStatement = "";

            sqlStatement = "SELECT * FROM SMSeMailGroup WHERE  " +
                            " COMP_CODE =@COR_COMP_CODE " +
                            " AND SMSEMAIL_KEY =@SMSEMAIL_KEY ";

            return sqlStatement;
        }

        public static string UpdateStaffDetail(Int32 SQLCase)
        {
            string sqlStatement = "";

            switch (SQLCase)
            {
                case 1:
                    sqlStatement = "UPDATE cor_staff SET  " +
                                    " cor_pwsd_retry=@cor_pwsd_retry" +
                                    " WHERE cor_userId=@cor_userId";
                    break;
                case 2:
                    sqlStatement = "UPDATE cor_staff SET  " +
                                    " cor_password=@cor_password, " +
                                    " cor_pwsd_retry = 0, " +
                                    " cor_login_status = 0 " +
                                    " WHERE cor_userId=@cor_userId";
                    break;
                case 3:
                    sqlStatement = "UPDATE cor_staff SET  " +
                                    " cor_password=@cor_password, " +
                                    " cor_pwsd_retry = 0, " +
                                    " cor_login_status = 1 " +
                                    " WHERE cor_userId=@cor_userId";
                    break;
            }
            return sqlStatement;
        }

    }
}