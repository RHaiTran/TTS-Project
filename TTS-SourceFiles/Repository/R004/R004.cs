using TTS_SourceFiles.Models;
using System.Text;
using TTS_SourceFiles.Common;
using Dapper;

namespace TTS_SourceFiles.Repository
{
    public class R004 : I004
    {
        public List<M00001_NavigationName> M00400_SetLabelLayout(string select_language)
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

        public List<M00401_LabelTable> M00401_SetLabelTable(string select_language)
        {
            string z_lbl_account_id = SetLanguage.GetFieldName(select_language, "Label_V004_001");
            string z_lbl_account_name = SetLanguage.GetFieldName(select_language, "Label_V004_002");
            string z_lbl_account_password = SetLanguage.GetFieldName(select_language, "Label_V004_003");
            string z_lbl_is_active = SetLanguage.GetFieldName(select_language, "Label_V004_004");
            string z_lbl_create_date = SetLanguage.GetFieldName(select_language, "Label_V004_005");
            string z_lbl_update_date = SetLanguage.GetFieldName(select_language, "Label_V004_006");
            string z_lbl_create_by_user = SetLanguage.GetFieldName(select_language, "Label_V004_007");
            string z_lbl_update_by_user = SetLanguage.GetFieldName(select_language, "Label_V004_008");

            List<M00401_LabelTable> m00401_LabelTables = new List<M00401_LabelTable>();
            m00401_LabelTables.Add(new M00401_LabelTable() { 
                z_lbl_account_id = z_lbl_account_id, 
                z_lbl_account_name = z_lbl_account_name,
                z_lbl_account_password = z_lbl_account_password,
                z_lbl_is_active = z_lbl_is_active,
                z_lbl_create_date = z_lbl_create_date,
                z_lbl_update_date = z_lbl_update_date,
                z_lbl_create_by_user = z_lbl_create_by_user,
                z_lbl_update_by_user = z_lbl_update_by_user
            });
            return m00401_LabelTables;
        }

        public List<M00402_GetAllAccount> M00402_GetAllAccounts()
        {
            using(var conn = ConnectDB.ConnectDataBase())
            {
                StringBuilder sqlFormat = new StringBuilder(string.Empty);
                sqlFormat.Append("SELECT * FROM ttsDB.dbo.z_AccountTbl ");
                return conn.Query<M00402_GetAllAccount>(sqlFormat.ToString()).ToList();
            }
        }
    }
}