using TTS_SourceFiles.Models;
using System.Text;
using TTS_SourceFiles.Common;
using Dapper;

namespace TTS_SourceFiles.Repository
{
    public class R002 : I002
    {
        public List<M00001_NavigationName> M00200_SetLabelLayout(string select_language)
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

            List<M00001_NavigationName> m00001_NavigationNames = new List<M00001_NavigationName>();
            m00001_NavigationNames.Add(new M00001_NavigationName() { 
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
            return m00001_NavigationNames;
        }
    }
}