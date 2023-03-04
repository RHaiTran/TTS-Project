using System;
using System.Data.SqlClient;

namespace TTS_SourceFiles.Common
{
    public static class SetLanguage
    {
        // 言語によって、ラベル名を変更になる。
        public static string GetFieldName(string language, string fieldID)
        {
            string languageFile = string.Empty;
            switch(language) 
            {
            case "ja":
                languageFile = "japanese_resource.json";
                break;
            case "en":
                languageFile = "english_resource.json";
                break;
            case "vn":
                languageFile = "vietnamese_resource.json";
                break;
            default:
                languageFile = "japanese_resource.json";
                break;
            }

            string fieldName = string.Empty;
            try
            {
                var configurationBuilder = new ConfigurationBuilder();
                string path = Path.Combine(Directory.GetCurrentDirectory(), languageFile);
                configurationBuilder.AddJsonFile(path, optional: false);

                var configuration = configurationBuilder.Build();
                fieldName = configuration.GetSection("Resource").GetValue<string>(fieldID);
                if(string.IsNullOrEmpty(fieldName))
                {
                    fieldName = "更新中";
                };
            }
            catch (Exception)
            {
                fieldName = "更新中";
            }
            finally
            {
                // 処理なし
            }
            return fieldName;
        }
    }
}