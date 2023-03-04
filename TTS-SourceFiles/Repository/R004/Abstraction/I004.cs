using TTS_SourceFiles.Models;

namespace TTS_SourceFiles.Repository
{
    public interface I004
    {

        public List<M00001_NavigationName> M00400_SetLabelLayout(string select_language);
        public List<M00401_LabelTable> M00401_SetLabelTable(string select_language);
        public List<M00402_GetAllUser> M00402_GetAllUsers();
        public bool M00403_IsCheckUserExists(string uname);
        public bool M00404_CreateNewAccount(
            string uname,
            string psw,
            int checkbox,
            string current_user,
            string user_role);
        public bool M00405_DeleteAccount(int ACCOUNT_ID);
    }
}