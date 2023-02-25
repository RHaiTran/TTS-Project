using TTS_SourceFiles.Models;
using System.Text;
using TTS_SourceFiles.Common;
using Dapper;

namespace TTS_SourceFiles.Repository
{
    public class R001 : I001
    {
        public bool M00101_CheckUserInfo(string uname, string psw)
        {
            bool isCheck = false;
            using(var conn = ConnectDB.ConnectDataBase())
            {
                StringBuilder sqlFormat = new StringBuilder(string.Empty);
                sqlFormat.Append("SELECT * FROM ttsDB.dbo.z_AccountTbl ");
                sqlFormat.Append("WHERE z_account_name = '{0}' AND z_account_password = '{1}'");
                string sqlQuery = string.Format(sqlFormat.ToString(),uname, psw);
                List<M00101_GetUserInfo>  M00101_GetUserInfos = conn.Query<M00101_GetUserInfo>(sqlQuery).ToList();
                int cnt = M00101_GetUserInfos.Count();
                if(cnt == 1) {
                    string checkIsActive = M00101_GetUserInfos[0].z_is_active.ToString();
                    if(string.Compare(checkIsActive, "1") == 1)
                    {
                        isCheck = true;
                    }
                }
            }
            return isCheck;
        }
    }
}