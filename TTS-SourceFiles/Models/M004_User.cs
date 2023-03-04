namespace TTS_SourceFiles.Models
{
    public class M004_Account
    {
        public string CURRENT_USER {get; set;}
        public List<M00001_NavigationName> M00001_NavigationNames{get; set;}
        public List<M00401_LabelTable> M00401_LabelTables{get; set;}
        public List<M00402_GetAllUser> M00402_GetAllUsers{get; set;}
    }

    public class M00401_LabelTable
    {
        public string z_lbl_user_id {get; set;}
        public string z_lbl_user_name {get; set;}
        public string z_lbl_user_password {get; set;}
        public string z_lbl_user_role {get; set;}
        public string z_lbl_is_active {get; set;}
        public string z_lbl_create_date {get; set;}
        public string z_lbl_update_date {get; set;}
        public string z_lbl_create_by_user {get; set;}
        public string z_lbl_update_by_user {get; set;}
        public string z_btn_create_user {get; set;}
    }

    public class M00402_GetAllUser
    {
        public int z_user_id {get; set;}
        public string z_user_email {get; set;}
        public string z_user_password {get; set;}
        public string z_user_role {get; set;}
        public bool z_is_active {get; set;}
        public DateTime z_create_date {get; set;}
        public DateTime z_update_date {get; set;}
        public string z_create_by_user {get; set;}
        public string z_update_by_user {get; set;}
    }
}