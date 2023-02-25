namespace TTS_SourceFiles.Models
{
    public class M001_Login
    {
        public List<M00101_GetUserInfo> M00101_GetUserInfos {get; set;}
    }

    public class M00101_GetUserInfo
    {
        public string z_account_name {get; set;}
        public string z_account_password {get; set;}
        public bool z_is_active{get; set;}
    }
}