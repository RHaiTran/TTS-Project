using TTS_SourceFiles.Models;

namespace TTS_SourceFiles.Repository
{
    public interface I004
    {

        public List<M00001_NavigationName> M00400_SetLabelLayout(string select_language);

        public List<M00401_LabelTable> M00401_SetLabelTable(string select_language);

        public List<M00402_GetAllAccount> M00402_GetAllAccounts();

        public bool M00403_IsCheckUserExists(string uname);
        public bool M00404_CreateNewAccount(string uname, string psw, int checkbox);
    }
}