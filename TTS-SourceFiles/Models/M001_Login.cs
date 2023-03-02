namespace TTS_SourceFiles.Models
{
    public class M001_Login
    {
        public List<M00101_GetUserInfo> M00101_GetUserInfos {get; set;}
        public List<M00102_SetLoginPageLanguage> M00102_SetLoginPageLanguages {get; set;}
    }

    public class M00101_GetUserInfo
    {
        public string z_account_name {get; set;}
        public string z_account_password {get; set;}
        public bool z_is_active{get; set;}
    }

    public class M00102_SetLoginPageLanguage
    {
        public string z_lbl_system_name {get; set;}
        public string z_lbl_account_email {get; set;}
        public string z_lbl_account_password {get; set;}
        public string z_lbl_input_account_email {get; set;}
        public string z_lbl_input_account_password {get; set;}
        public string z_lbl_login_button {get; set;}
        public string z_lbl_infor {get; set;}
        public string z_lbl_infor_select_language {get; set;}
    }
}