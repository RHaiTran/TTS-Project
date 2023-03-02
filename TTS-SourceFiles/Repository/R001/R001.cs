using TTS_SourceFiles.Models;
using System.Text;
using TTS_SourceFiles.Common;
using Dapper;

namespace TTS_SourceFiles.Repository
{
    public class R001 : I001
    {
        public int M00101_CheckUserInfo(string uname, string psw)
        {
            int value = 0;
            using(var conn = ConnectDB.ConnectDataBase())
            {
                StringBuilder sqlFormat = new StringBuilder(string.Empty);
                sqlFormat.Append("SELECT * FROM ttsDB.dbo.z_AccountTbl ");
                sqlFormat.Append("WHERE z_account_email = '{0}' AND z_account_password = '{1}'");
                string sqlQuery = string.Format(sqlFormat.ToString(),uname, psw);
                List<M00101_GetUserInfo>  M00101_GetUserInfos = conn.Query<M00101_GetUserInfo>(sqlQuery).ToList();
                int cnt = M00101_GetUserInfos.Count();
                if(cnt == 1) {
                    string checkIsActive = M00101_GetUserInfos[0].z_is_active.ToString();
                    if(string.Compare(checkIsActive, "True") == 0)
                    {
                        value = 1;
                    } else {
                        value = -1;
                    }
                }
            }
            return value;
        }

        public List<M00001_NavigationName> M00001_SetLanguage(string select_language)
        {
            string z_lbl_home = SetLanguage.GetFieldName(select_language, "Label_V000_001");
            string z_lbl_notification = SetLanguage.GetFieldName(select_language, "Label_V000_002");
            string z_lbl_scheldule = SetLanguage.GetFieldName(select_language, "Label_V000_003");
            string z_lbl_message = SetLanguage.GetFieldName(select_language, "Label_V000_004");
            string z_lbl_file_management = SetLanguage.GetFieldName(select_language, "Label_V000_005");
            string z_lbl_create_new_department = SetLanguage.GetFieldName(select_language, "Label_V000_006");
            string z_lbl_create_new_account = SetLanguage.GetFieldName(select_language, "Label_V000_007");
            string z_lbl_account_setting = SetLanguage.GetFieldName(select_language, "Label_V000_008");
            string z_lbl_logout = SetLanguage.GetFieldName(select_language, "Label_V000_009");

            List<M00001_NavigationName> zNNLst = new List<M00001_NavigationName>();
            zNNLst.Add(new M00001_NavigationName() { 
                z_lbl_home = z_lbl_home, 
                z_lbl_notification = z_lbl_notification,
                z_lbl_scheldule = z_lbl_scheldule,
                z_lbl_message = z_lbl_message,
                z_lbl_file_management = z_lbl_file_management,
                z_lbl_create_new_department = z_lbl_create_new_department,
                z_lbl_create_new_account = z_lbl_create_new_account,
                z_lbl_account_setting = z_lbl_account_setting,
                z_lbl_logout = z_lbl_logout
            });
            return zNNLst;
        }

        public List<M00102_SetLoginPageLanguage> M00102_SetLoginPageLanguage(string select_language){
            string z_lbl_system_name = SetLanguage.GetFieldName(select_language, "Label_V001_001");
            string z_lbl_account_email = SetLanguage.GetFieldName(select_language, "Label_V001_002");
            string z_lbl_account_password = SetLanguage.GetFieldName(select_language, "Label_V001_003");
            string z_lbl_input_account_email = SetLanguage.GetFieldName(select_language, "Label_V001_004");
            string z_lbl_input_account_password = SetLanguage.GetFieldName(select_language, "Label_V001_005");
            string z_lbl_login_button = SetLanguage.GetFieldName(select_language, "Label_V001_006");
            string z_lbl_infor = SetLanguage.GetFieldName(select_language, "Label_V001_007");
            string z_lbl_infor_select_language = SetLanguage.GetFieldName(select_language, "Label_V001_008");

            List<M00102_SetLoginPageLanguage> m00102_SetLoginPageLanguages = new List<M00102_SetLoginPageLanguage>();
            m00102_SetLoginPageLanguages.Add(new M00102_SetLoginPageLanguage() { 
                z_lbl_system_name = z_lbl_system_name, 
                z_lbl_account_email = z_lbl_account_email,
                z_lbl_account_password = z_lbl_account_password,
                z_lbl_input_account_email = z_lbl_input_account_email,
                z_lbl_input_account_password = z_lbl_input_account_password,
                z_lbl_login_button = z_lbl_login_button,
                z_lbl_infor = z_lbl_infor,
                z_lbl_infor_select_language = z_lbl_infor_select_language
            });
            return m00102_SetLoginPageLanguages;
        }
    }
}