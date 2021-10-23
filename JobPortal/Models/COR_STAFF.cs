using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class COR_STAFF
    {
        public Int16 cor_comp_code { get; set; }
        public string cor_userid { get; set; }
        public Int16 cor_user_type { get; set; }
        public Int16 cor_allow_job_process_ind { get; set; }
        public string cor_template_id { get; set; }
        public string cor_branch { get; set; }
        public string cor_branch_group { get; set; }
        public string cor_nric { get; set; }
        public Int16 cor_salutation_id { get; set; }
        public string cor_full_name { get; set; }
        public string cor_first_name { get; set; }
        public string cor_middle_name { get; set; }
        public string cor_last_name { get; set; }
        public Int16 cor_Deparment { get; set; }
        public Int16 cor_role_id { get; set; }
        public Int16 cor_group_id { get; set; }
        public Int16 cor_position { get; set; }
        public Int16 cor_gender { get; set; }
        public Int16 cor_office_country_code { get; set; }
        public Int16 cor_office_area_code { get; set; }
        public string cor_office_number { get; set; }
        public string cor_office_ext { get; set; }
        public Int32 cor_mobile_country_code { get; set; }
        public Int32 cor_mobile_area_code { get; set; }
        public string cor_mobile_number { get; set; }
        public string cor_Fax_number { get; set; }
        public string cor_home_address1 { get; set; }
        public string cor_home_address2 { get; set; }
        public string cor_home_address3 { get; set; }
        public string cor_home_postcode { get; set; }
        public string cor_emailId { get; set; }
        public Int16 cor_newly_created_ind { get; set; }
        public Int16 cor_login_status { get; set; }
        public Int32 cor_first_login_date { get; set; }
        public Int32 cor_first_login_time { get; set; }
        public Int32 cor_login_date { get; set; }
        public Int32 cor_login_time { get; set; }
        public DateTime? cor_logout_datetime { get; set; }
        public string cor_password { get; set; }
        public Int32 cor_pwsd_expiry_date { get; set; }
        public Int16 cor_pwsd_expiry_days { get; set; }
        public Int16 cor_pwsd_max_retry { get; set; }
        public Int16 cor_pwsd_retry { get; set; }
        public Double cor_access_time_from { get; set; }
        public Double cor_access_time_to { get; set; }
        public Int32 cor_access_date_from { get; set; }
        public Int32 cor_access_date_to { get; set; }
        public string cor_auth_user { get; set; }
        public Int32 cor_auth_date { get; set; }
        public Int32 cor_auth_time { get; set; }
        public string cor_pw_modified_user { get; set; }
        public Int32 cor_pw_modified_date { get; set; }
        public Int32 cor_pw_modified_time { get; set; }
        public DateTime? cor_created_datetime { get; set; }
        public string cor_created_user { get; set; }
        public DateTime? cor_modified_datetime { get; set; }
        public string cor_modified_user { get; set; }
        public string cor_deactivated_user { get; set; }
        public DateTime? cor_deactivated_datetime { get; set; }
        public string cor_question { get; set; }
        public string cor_answer { get; set; }
        public string cor_emp_no { get; set; }
        public string cor_remarks { get; set; }
        public string cor_Theme { get; set; }
        public string cor_Language { get; set; }
        public string cor_branch_Desc { get; set; }
        public string cor_role_id_Desc { get; set; }
    }

    [Table("COR_STAFF")]
    public class _COR_STAFF
    {
        public _COR_STAFF()
        {
        }

        public _COR_STAFF(bool setDefaultValue)
        {
            cor_comp_code = 0;
            cor_userid = "";
            cor_user_type = 0;
            cor_allow_job_process_ind = 0;
            cor_template_id = "";
            cor_branch = "";
            cor_branch_group = "";
            cor_nric = "";
            cor_salutation_id = 0;
            cor_full_name = "";
            cor_first_name = "";
            cor_middle_name = "";
            cor_last_name = "";
            cor_Deparment = 0;
            cor_role_id = 0;
            cor_group_id = 0;
            cor_position = 0;
            cor_gender = 0;
            cor_office_country_code = 0;
            cor_office_area_code = 0;
            cor_office_number = "";
            cor_office_ext = "";
            cor_mobile_country_code = 0;
            cor_mobile_area_code = 0;
            cor_mobile_number = "";
            cor_Fax_number = "";
            cor_home_address1 = "";
            cor_home_address2 = "";
            cor_home_address3 = "";
            cor_home_postcode = "";
            cor_emailId = "";
            cor_newly_created_ind = 0;
            cor_login_status = 0;
            cor_first_login_date = 0;
            cor_first_login_time = 0;
            cor_login_date = 0;
            cor_login_time = 0;
            //cor_logout_datetime = 0;
            cor_password = "";
            cor_pwsd_expiry_date = 0;
            cor_pwsd_expiry_days = 0;
            cor_pwsd_max_retry = 0;
            cor_pwsd_retry = 0;
            cor_access_time_from = 0.0;
            cor_access_time_to = 0;
            cor_access_date_from = 0;
            cor_access_date_to = 0;
            cor_auth_user = "";
            cor_auth_date = 0;
            cor_auth_time = 0;
            cor_pw_modified_user = "";
            cor_pw_modified_date = 0;
            cor_pw_modified_time = 0;
            //cor_created_datetime = DateTime.UtcNow;
            //cor_modified_datetime = DateTime.UtcNow;
            cor_modified_user = "";
            cor_deactivated_user = "";
            //cor_deactivated_datetime = DateTime.UtcNow;
            cor_question = "";
            cor_answer = "";
            cor_emp_no = "";
            cor_remarks = "";
            cor_Theme = "";
            cor_Language = "";
            cor_branch_Desc = "";
            cor_role_id_Desc = "";
        }

        [Key, Column(Order = 1)]
        public Int16 cor_comp_code { get; set; }

        public string cor_userid { get; set; }
        public Int16 cor_user_type { get; set; }
        public Int16 cor_allow_job_process_ind { get; set; }
        public string cor_template_id { get; set; }
        public string cor_branch { get; set; }
        public string cor_branch_group { get; set; }
        public string cor_nric { get; set; }
        public Int16 cor_salutation_id { get; set; }
        public string cor_full_name { get; set; }
        public string cor_first_name { get; set; }
        public string cor_middle_name { get; set; }
        public string cor_last_name { get; set; }
        public Int16 cor_Deparment { get; set; }
        public Int16 cor_role_id { get; set; }
        public Int16 cor_group_id { get; set; }
        public Int16 cor_position { get; set; }
        public Int16 cor_gender { get; set; }
        public Int16 cor_office_country_code { get; set; }
        public Int16 cor_office_area_code { get; set; }
        public string cor_office_number { get; set; }
        public string cor_office_ext { get; set; }
        public Int32 cor_mobile_country_code { get; set; }
        public Int32 cor_mobile_area_code { get; set; }
        public string cor_mobile_number { get; set; }
        public string cor_Fax_number { get; set; }
        public string cor_home_address1 { get; set; }
        public string cor_home_address2 { get; set; }
        public string cor_home_address3 { get; set; }
        public string cor_home_postcode { get; set; }
        public string cor_emailId { get; set; }
        public Int16 cor_newly_created_ind { get; set; }
        public Int16 cor_login_status { get; set; }
        public Int32 cor_first_login_date { get; set; }
        public Int32 cor_first_login_time { get; set; }
        public Int32 cor_login_date { get; set; }
        public Int32 cor_login_time { get; set; }
        public DateTime? cor_logout_datetime { get; set; }
        public string cor_password { get; set; }
        public Int32 cor_pwsd_expiry_date { get; set; }
        public Int16 cor_pwsd_expiry_days { get; set; }
        public Int16 cor_pwsd_max_retry { get; set; }
        public Int16 cor_pwsd_retry { get; set; }
        public Double cor_access_time_from { get; set; }
        public Double cor_access_time_to { get; set; }
        public Int32 cor_access_date_from { get; set; }
        public Int32 cor_access_date_to { get; set; }
        public string cor_auth_user { get; set; }
        public Int32 cor_auth_date { get; set; }
        public Int32 cor_auth_time { get; set; }
        public string cor_pw_modified_user { get; set; }
        public Int32 cor_pw_modified_date { get; set; }
        public Int32 cor_pw_modified_time { get; set; }
        public DateTime? cor_created_datetime { get; set; }
        public string cor_created_user { get; set; }
        public DateTime? cor_modified_datetime { get; set; }
        public string cor_modified_user { get; set; }
        public string cor_deactivated_user { get; set; }
        public DateTime? cor_deactivated_datetime { get; set; }
        public string cor_question { get; set; }
        public string cor_answer { get; set; }
        public string cor_emp_no { get; set; }
        public string cor_remarks { get; set; }
        public string cor_Theme { get; set; }
        public string cor_Language { get; set; }
        public string cor_branch_Desc { get; set; }
        public string cor_role_id_Desc { get; set; }
    }
}