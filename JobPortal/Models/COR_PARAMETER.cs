using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class COR_PARAMETER
    {
        public Int16 cor_comp_code { get; set; }
        public Int16 cor_frequency { get; set; }
        public Int16 cor_try_allow { get; set; }
        public Int16 cor_force_chg { get; set; }
        public Int16 cor_minlength_userid { get; set; }
        public Int16 cor_maxlength_userid { get; set; }
        public Int16 cor_minlength_pswd { get; set; }
        public Int16 cor_maxlength_pwsd { get; set; }
        public Int16 cor_consecutive { get; set; }
        public Int16 cor_blankchar { get; set; }
        public Int16 cor_specialchar { get; set; }
        public Int16 cor_defaultpswd_to_userid { get; set; }
        public string cor_defaultpswd { get; set; }
        public Int32 cor_auto_userno { get; set; }
        public Int16 cor_insert_logger_ind { get; set; }
        public Int32 cor_start_access_date { get; set; }
        public Int32 cor_end_access_date { get; set; }
        public Double cor_start_access_time { get; set; }
        public Double cor_end_access_time { get; set; }
        public string cor_curr_cd { get; set; }
        public Int16 cor_auth_req { get; set; }
        public Int16 cor_allow_sms_ind { get; set; }
        public Int16 cor_allow_mail_ind { get; set; }
        public Int16 cor_allow_same_level_appr_ind { get; set; }
        public Int32 cor_Last_verified_lisense_dt { get; set; }
        public string cor_lisense_comp_Name { get; set; }
        public Int32 cor_lisense_expiry_date { get; set; }
        public Int16 cor_lisense_grace_period { get; set; }
        public Int16 cor_sms_server_status_ind { get; set; }
        public string cor_sms_Userid { get; set; }
        public string cor_sms_password { get; set; }
        public string cor_based_language { get; set; }
        public string cor_based_language_rec { get; set; }
        public Int16 cor_based_theme { get; set; }
        public string cor_display_msg { get; set; }
        public DateTime? cor_stamp_dttm { get; set; }
        public string cor_user_id { get; set; }
        public string cor_mode_mn { get; set; }
        public DateTime? cor_created_date { get; set; }
        public string cor_created_user { get; set; }
        public DateTime? cor_modified_date { get; set; }
        public string cor_modified_user { get; set; }
        public string cor_restricted_pwd { get; set; }
        public string cor_dateformat { get; set; }
        public string cor_timeformat { get; set; }
        public Int16 cor_noofdigitsafterdecimal { get; set; }
        public Int16 cor_JobPortal_Sys_OK { get; set; }
        public Int16 cor_BI_Sys_OK { get; set; }
    }

    [Table("COR_PARAMETER")]
    public class _COR_PARAMETER
    {
        public _COR_PARAMETER()
        {
        }

        public _COR_PARAMETER(bool setDefaultValue)
        {
            cor_comp_code = 0;
            cor_frequency = 0;
            cor_try_allow = 0;
            cor_force_chg = 0;
            cor_minlength_userid = 0;
            cor_maxlength_userid = 0;
            cor_minlength_pswd = 0;
            cor_maxlength_pwsd = 0;
            cor_consecutive = 0;
            cor_blankchar = 0;
            cor_specialchar = 0;
            cor_defaultpswd_to_userid = 0;
            cor_defaultpswd = "";
            cor_auto_userno = 0;
            cor_insert_logger_ind = 0;
            cor_start_access_date = 0;
            cor_end_access_date = 0;
            cor_start_access_time = 0.0;
            cor_end_access_time = 0.0;
            cor_curr_cd = "";
            cor_auth_req = 0;
            cor_allow_sms_ind = 0;
            cor_allow_mail_ind = 0;
            cor_allow_same_level_appr_ind = 0;
            cor_Last_verified_lisense_dt = 0;
            cor_lisense_comp_Name = "";
            cor_lisense_expiry_date = 0;
            cor_lisense_grace_period = 0;
            cor_sms_server_status_ind = 0;
            cor_sms_Userid = "";
            cor_sms_password = "";
            cor_based_language = "";
            cor_based_language_rec = "";
            cor_based_theme = 0;
            cor_display_msg = "";
            //cor_stamp_dttm = "";
            cor_user_id = "";
            cor_mode_mn = "";
            //cor_created_date = "";
            cor_created_user = "";
            //cor_modified_date = "";
            cor_modified_user = "";
            cor_restricted_pwd = "";
            cor_dateformat = "";
            cor_timeformat = "";
            cor_noofdigitsafterdecimal = 0;
            cor_JobPortal_Sys_OK = 0;
            cor_BI_Sys_OK = 0;
        }

        [Key, Column(Order = 1)]
        public Int16 cor_comp_code { get; set; }

        public Int16 cor_frequency { get; set; }
        public Int16 cor_try_allow { get; set; }
        public Int16 cor_force_chg { get; set; }
        public Int16 cor_minlength_userid { get; set; }
        public Int16 cor_maxlength_userid { get; set; }
        public Int16 cor_minlength_pswd { get; set; }
        public Int16 cor_maxlength_pwsd { get; set; }
        public Int16 cor_consecutive { get; set; }
        public Int16 cor_blankchar { get; set; }
        public Int16 cor_specialchar { get; set; }
        public Int16 cor_defaultpswd_to_userid { get; set; }
        public string cor_defaultpswd { get; set; }
        public Int32 cor_auto_userno { get; set; }
        public Int16 cor_insert_logger_ind { get; set; }
        public Int32 cor_start_access_date { get; set; }
        public Int32 cor_end_access_date { get; set; }
        public Double cor_start_access_time { get; set; }
        public Double cor_end_access_time { get; set; }
        public string cor_curr_cd { get; set; }
        public Int16 cor_auth_req { get; set; }
        public Int16 cor_allow_sms_ind { get; set; }
        public Int16 cor_allow_mail_ind { get; set; }
        public Int16 cor_allow_same_level_appr_ind { get; set; }
        public Int32 cor_Last_verified_lisense_dt { get; set; }
        public string cor_lisense_comp_Name { get; set; }
        public Int32 cor_lisense_expiry_date { get; set; }
        public Int16 cor_lisense_grace_period { get; set; }
        public Int16 cor_sms_server_status_ind { get; set; }
        public string cor_sms_Userid { get; set; }
        public string cor_sms_password { get; set; }
        public string cor_based_language { get; set; }
        public string cor_based_language_rec { get; set; }
        public Int16 cor_based_theme { get; set; }
        public string cor_display_msg { get; set; }
        public DateTime? cor_stamp_dttm { get; set; }
        public string cor_user_id { get; set; }
        public string cor_mode_mn { get; set; }
        public DateTime? cor_created_date { get; set; }
        public string cor_created_user { get; set; }
        public DateTime? cor_modified_date { get; set; }
        public string cor_modified_user { get; set; }
        public string cor_restricted_pwd { get; set; }
        public string cor_dateformat { get; set; }
        public string cor_timeformat { get; set; }
        public Int16 cor_noofdigitsafterdecimal { get; set; }
        public Int16 cor_JobPortal_Sys_OK { get; set; }
        public Int16 cor_BI_Sys_OK { get; set; }
    }
}