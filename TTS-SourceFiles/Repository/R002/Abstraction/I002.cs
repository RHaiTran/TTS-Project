using TTS_SourceFiles.Models;

namespace TTS_SourceFiles.Repository
{
    public interface I002
    {
        public List<M00001_NavigationName> M00200_SetLabelLayout(string select_language);
        public bool M00201_CreateNotification(
            string title,
            string content,
            string current_user);

        public List<M00201_GetAllNotification> M00201_GetAllNotifications();
    }
}