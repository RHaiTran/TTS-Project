using TTS_SourceFiles.Models;

namespace TTS_SourceFiles.Repository
{
    public interface I001
    {
        public bool M00101_CheckUserInfo(string uname, string psw);

        public List<M00001_NavigationName> M00001_SetLanguage(string select_language);
    }
}