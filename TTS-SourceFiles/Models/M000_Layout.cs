namespace TTS_SourceFiles.Models
{
    public class M000_Layout
    {
        public List<M00001_NavigationName> M00001_NavigationNames{get; set;}
        public List<M00201_GetAllNotification> M00201_GetAllNotifications{get; set;}
    }

    public class M00001_NavigationName
    {
        public string z_lbl_home {get; set;}
        public string z_lbl_notification {get; set;}
        public string z_lbl_scheldule {get; set;}
        public string z_lbl_message {get; set;}
        public string z_lbl_file_management {get; set;}
        public string z_lbl_create_new_department {get; set;}
        public string z_lbl_create_new_account {get; set;}
        public string z_lbl_account_setting {get; set;}
        public string z_lbl_logout {get; set;}
    }

}