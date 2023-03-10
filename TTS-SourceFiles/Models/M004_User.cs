namespace TTS_SourceFiles.Models
{
    public class M004_User
    {
        public string CURRENT_USER {get; set;}
        public List<M00001_NavigationName> M00001_NavigationNames{get; set;}
        public List<M00401_LabelTable> M00401_LabelTables{get; set;}
        public List<M00402_GetAllUser> M00402_GetAllUsers{get; set;}
        public List<M00403_LabelCreateUserForm> M00403_LabelCreateUserForms{get; set;}
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
        public string z_btn_delete_user {get; set;}
        public string z_message_delete_user {get; set;}
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
    public class M00403_LabelCreateUserForm
    {
        public string z_lbl_create_user_form {get; set;}
        public string z_lbl_request_user_name {get; set;}
        public string z_lbl_request_user_password {get; set;}
        public string z_lbl_is_active{get; set;}
        public string z_lbl_button_create {get; set;}
        public string z_lbl_button_cancel{get; set;}
        public string z_message_add_confirm{get; set;}
    }
}