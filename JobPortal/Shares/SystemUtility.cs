using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Models;
using AdminQueryManager;
using PeopleQueryManager;
using JobPortal.Shares;

namespace JobPortal.Shares
{
    public static class SystemUtility
    {
        public enum CustomFieldType
        {
            DropDownListField = 5
            , TextField = 6
            , TextFieldReadOnly = 7
            , IntegerField = 8
            , DecimalField = 9
            , DateField = 10
            , LabelField = 1
        }

        public static string clsEmbeddedRQuoteToLQuote(string strText)
        {
            var clsEmbeddedRQuoteToLQuote = strText.Replace("'", "`");
            if (string.IsNullOrEmpty(clsEmbeddedRQuoteToLQuote) == true)
                clsEmbeddedRQuoteToLQuote = "";
            return clsEmbeddedRQuoteToLQuote;
        }

        public static string clsEmbeddedQuote(string strText)
        {
            var clsEmbeddedQuote = strText.Replace("'", "''");
            if (string.IsNullOrEmpty(clsEmbeddedQuote) == true)
                clsEmbeddedQuote = "";
            return clsEmbeddedQuote;
        }

        public static void RegisterAlertMessage_Ajax(string errorDesc, string errorDesc2 = "")
        {
            //
            string strMsg = errorDesc;
            if (errorDesc2.Trim().Length > 0)
                strMsg += " (" + errorDesc2 + ")";
            //
            string script = "alert('" + strMsg + "');";
            //ScriptManager.RegisterStartupScript(page, typeof(Page), "UserSecurity", script, true);
        }

        public static dynamic ConvertToInt<t>(string val)
        {
            string str = (val == "") ? "0" : val;
            return Convert.ChangeType(str, typeof(t));
        }

        public static int ConvertToInt(string val)
        {
            string str = (val == "") ? "0" : val;
            return int.Parse(str);
        }

        public static DateTime ConvertInt2DateTime(int date, int time = 0)
        {
            if (date.ToString().Length != 8)
                return new DateTime();

            string dt = date.ToString().Insert(4, "-").Insert(7, "-");
            string tm = time.ToString("D6").Insert(2, ":").Insert(5, ":");

            return DateTime.Parse(dt + " " + tm);
        }

        public static DateTime ConvertInt2DateTime(string date, string time = "0")
        {
            int dateVal = 0;
            int timeVal = 0;

            if (!int.TryParse(date, out dateVal))
                return new DateTime();
            if (!int.TryParse(time, out timeVal))
                return new DateTime();

            if (dateVal.ToString().Length != 8)
                return new DateTime();

            string dt = dateVal.ToString().Insert(4, "-").Insert(7, "-");
            string tm = timeVal.ToString("D6").Insert(2, ":").Insert(5, ":");

            return DateTime.Parse(dt + " " + tm);
        }

        //public static List<cor_code> ReadCorCodeDropDown(int cor_CodeNo)
        //{
        //    using (var context = new JobPortalContext())
        //    {
        //        return context.Database.SqlQuery<cor_code>(PowerQuery.GetStatement(PowerQuery.SqlCase.ReadCorCodeDropDown), SqlHelper.CreateDbParameter("cor_CodeNo", cor_CodeNo)).ToList();
        //    }
        //}

        //public static List<IHM_SearchCode> ReadSearchCodeDropDown(int CompanyCode, int SEARCH_CODE)
        //{
        //    using (var context = new JobPortalContext())
        //    {
        //        return context.Database.SqlQuery<IHM_SearchCode>(SharedQuery.GetStatement(SharedQuery.SqlCase.ReadSearchCodeDropDown),
        //                                                         SqlHelper.CreateDbParameter("CompanyCode", CompanyCode),
        //                                                         SqlHelper.CreateDbParameter("SEARCH_CODE", SEARCH_CODE)).ToList();
        //    }
        //}

        //public static List<cor_code> ReadCorCodeValues(params int[] cor_CodeNos)
        //{
        //    int index = 0;
        //    var paramNameList = new List<string>();
        //    var parJobPortalist = new List<KeyValuePair<String, Object>>();

        //    foreach (var s in cor_CodeNos)
        //    {
        //        string key = "@cor_CodeNo" + index.ToString();
        //        paramNameList.Add(key);
        //        parJobPortalist.Add(new KeyValuePair<String, Object>(key, s));
        //        index++;
        //    }

        //    using (var context = new JobPortalContext())
        //    {
        //        string sql = String.Format(SharedQuery.GetStatement(SharedQuery.SqlCase.ReadCorCodeValues), String.Join(", ", paramNameList));
        //        return context.Database.SqlQuery<cor_code>(sql, SqlHelper.CreateDbParameters(parJobPortalist.ToArray()).ToArray()).ToList();
        //    }
        //}

        //public static cor_code ReadCorCodeKeyValues(int cor_CodeNo, string cor_CodeKey)
        //{
        //    using (var context = new JobPortalContext())
        //    {
        //        return context.Database.SqlQuery<cor_code>(SharedQuery.GetStatement(SharedQuery.SqlCase.ReadCorCodeKeyValues),
        //                                                          SqlHelper.CreateDbParameter("cor_CodeNo", cor_CodeNo),
        //                                                          SqlHelper.CreateDbParameter("cor_CodeKey", cor_CodeKey)).FirstOrDefault();
        //    }
        //}

        //public static bool ValidateSession(SessionState sessionState, string menuid = "")
        //{
        //    if (sessionState != null && sessionState.StaffProfile != null)
        //    {
        //        if (menuid != "" && ("," + sessionState.StaffProfile.cor_menu_ids.Replace(";", ",") + ",").Contains("," + menuid + ","))
        //            return true;
        //    }
        //    return false;
        //}

        //public static List<ConfigTrdMasTblDalist> GetCustomFieldMetadata(string templateCode, Int16 status)
        //{
        //    using (var context = new JobPortalContext())
        //    {
        //        return context.Database.SqlQuery<ConfigTrdMasTblDalist>(SharedQuery.GetStatement(SharedQuery.SqlCase.GetCustomFieldMetadata),
        //                                                          SqlHelper.CreateDbParameter("CompanyCode", GlobalVariables.CompanyCode),
        //                                                          SqlHelper.CreateDbParameter("TEMPLATE_CODE", templateCode),
        //                                                          SqlHelper.CreateDbParameter("STATUS", status)).ToList();

        //    }
        //}
        //public static List<t> GetCustomFieldMetadata<t>(string templateCode, Int16 status)
        //{
        //    using (var context = new JobPortalContext())
        //    {
        //        var sql = SharedQuery.GetStatement(SharedQuery.SqlCase.GetCustomFieldMetadata);
        //        sql = String.Format(sql, typeof(t).Name);

        //        return context.Database.SqlQuery<t>(sql,
        //                                            SqlHelper.CreateDbParameter("CompanyCode", GlobalVariables.CompanyCode),
        //                                            SqlHelper.CreateDbParameter("TEMPLATE_CODE", templateCode),
        //                                            SqlHelper.CreateDbParameter("STATUS", status)).ToList();
        //    }
        //}

        //public static string BuildCustomField(ConfigTrdMasTblDalist metadata, string value, bool isReadOnly, string htmlAttribute)
        //{
        //    bool isNullValue = false;
        //    if (string.IsNullOrEmpty(value))
        //    {
        //        value = "";
        //        isNullValue = true;
        //    }

        //    string field = "";
        //    if ((((CustomFieldType)metadata.ANS_TYPE) != CustomFieldType.LabelField))
        //        field = "<td>" + metadata.SHORT_FD_DESC + "</td>";

        //    switch ((CustomFieldType)metadata.ANS_TYPE)
        //    {
        //        case CustomFieldType.LabelField:
        //            field += "<td colspan='2' style='padding-top:20px;font-weight:bold;'><span style='font-size:12px;text-decoration:underline;'>" + metadata.SHORT_FD_DESC + "</span></td>";
        //            break;
        //        case CustomFieldType.DropDownListField:
        //            if (isReadOnly)
        //            {
        //                string val = "";
        //                if (!isNullValue)
        //                {
        //                    var codeValue = SystemUtility.ReadCorCodeKeyValues(metadata.DDL_TABLENO, value);
        //                    if (codeValue != null)
        //                        val = codeValue.cor_Desc;
        //                }

        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + val + "' ReadOnly " + htmlAttribute + " /></td>";
        //            }
        //            else
        //            {
        //                field += "<td><select id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' " + htmlAttribute + " >";
        //                var codelist = SystemUtility.ReadCorCodeDropDown(metadata.DDL_TABLENO);

        //                foreach (var c in codelist)
        //                {
        //                    if (value == c.cor_CodeKey)
        //                        field += "<option value='" + c.cor_CodeKey + "' selected>" + c.cor_Desc + "</option>";
        //                    else
        //                        field += "<option value='" + c.cor_CodeKey + "'>" + c.cor_Desc + "</option>";
        //                }
        //                field += "</select></td>";
        //            }
        //            break;

        //        case CustomFieldType.TextField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.TextFieldReadOnly:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.IntegerField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.DecimalField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.DateField:

        //            int dateValue = 0;
        //            if (int.TryParse(value, out dateValue))
        //            {
        //                if (dateValue.ToString().Length == 8)
        //                    value = SystemUtility.ConvertInt2DateTime(dateValue).ToString(GlobalVariables.SysDateFormat);
        //                else
        //                    value = "";
        //            }

        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;
        //    }

        //    return field;
        //}

        //public static string BuildDocumentMatchCustomField(DocumentMatchCustomFields metadata, string value, string value_M, bool isReadOnly, string htmlAttribute)
        //{
        //    bool isNullValue = false;
        //    if (string.IsNullOrEmpty(value))
        //    {
        //        value = "";
        //        isNullValue = true;
        //    }

        //    string field = "";

        //    field = "<td>" + metadata.SHORT_FD_DESC + "</td>";

        //    switch ((CustomFieldType)metadata.ANS_TYPE)
        //    {
        //        case CustomFieldType.LabelField:
        //            field += "<td colspan='2' style='padding-top:20px;font-weight:bold;'><span style='font-size:12px;text-decoration:underline;'>" + metadata.SHORT_FD_DESC + "</span></td>";
        //            break;
        //        case CustomFieldType.DropDownListField:
        //            if (isReadOnly)
        //            {
        //                string val = "";
        //                if (!isNullValue)
        //                {
        //                    var codeValue = SystemUtility.ReadCorCodeKeyValues(metadata.DDL_TABLENO, value);
        //                    if (codeValue != null)
        //                        val = codeValue.cor_Desc;
        //                }

        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + val + "' ReadOnly " + htmlAttribute + " /></td>";
        //            }
        //            else
        //            {
        //                field += "<td><select id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' " + htmlAttribute + " >";
        //                var codelist = SystemUtility.ReadCorCodeDropDown(metadata.DDL_TABLENO);

        //                foreach (var c in codelist)
        //                {
        //                    if (value == c.cor_CodeKey)
        //                        field += "<option value='" + c.cor_CodeKey + "' selected>" + c.cor_Desc + "</option>";
        //                    else
        //                        field += "<option value='" + c.cor_CodeKey + "'>" + c.cor_Desc + "</option>";
        //                }
        //                field += "</select></td>";
        //            }
        //            break;

        //        case CustomFieldType.TextField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.TextFieldReadOnly:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.IntegerField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.DecimalField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.DateField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID + "' name='" + metadata.FIELD_ID + "' value='" + value + "' " + htmlAttribute + " /></td>";
        //            break;
        //    }

        //    switch ((CustomFieldType)metadata.ANS_TYPE_M)
        //    {
        //        case CustomFieldType.DropDownListField:
        //            if (isReadOnly)
        //            {
        //                string val = "";
        //                if (!isNullValue)
        //                {
        //                    var codeValue = SystemUtility.ReadCorCodeKeyValues(metadata.DDL_TABLENO_M, value_M);
        //                    if (codeValue != null)
        //                        val = codeValue.cor_Desc;
        //                }

        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + val + "' ReadOnly " + htmlAttribute + " /></td>";
        //            }
        //            else
        //            {
        //                field += "<td><select id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' " + htmlAttribute + " >";
        //                var codelist = SystemUtility.ReadCorCodeDropDown(metadata.DDL_TABLENO_M);

        //                foreach (var c in codelist)
        //                {
        //                    if (value == c.cor_CodeKey)
        //                        field += "<option value='" + c.cor_CodeKey + "' selected>" + c.cor_Desc + "</option>";
        //                    else
        //                        field += "<option value='" + c.cor_CodeKey + "'>" + c.cor_Desc + "</option>";
        //                }
        //                field += "</select></td>";
        //            }
        //            break;

        //        case CustomFieldType.TextField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.TextFieldReadOnly:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.IntegerField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.DecimalField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' " + htmlAttribute + " /></td>";
        //            break;

        //        case CustomFieldType.DateField:
        //            if (isReadOnly)
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' ReadOnly " + htmlAttribute + " /></td>";
        //            else
        //                field += "<td><input type='text' id='" + metadata.FIELD_ID_M + "' name='" + metadata.FIELD_ID_M + "' value='" + value_M + "' " + htmlAttribute + " /></td>";
        //            break;
        //    }

        //    return field;
        //}
    }
}