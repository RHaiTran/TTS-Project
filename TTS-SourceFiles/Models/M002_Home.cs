namespace TTS_SourceFiles.Models
{
	public class M002_Home
	{
		public List<M00001_NavigationName> M00001_NavigationNames{get; set;}
		public List<M00201_GetAllNotification> M00201_GetAllNotifications{get; set;}
	}
	public class M00201_GetAllNotification
	{
		public string z_notifice_title;
	}
}