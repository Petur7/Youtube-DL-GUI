using System.Text.Json;

namespace Youtube_DL_GUI
{
    public partial class Youtube_DL_GUI
    {
        public class ApplicationConfig
        {
            public string appDir { get; set; }
            public string binDir { get; set; }
            public string coreDir { get; set; }
            public string tempDir { get; set; }
            public string shortcutLocation { get; set; }

            public string youtubedlVersion { get; set; }
            public string ffmpegVersion { get; set; }
        }

        private string ApplicationConfigSerialize(ApplicationConfig appConfig)
        {
            return JsonSerializer.Serialize<ApplicationConfig>(appConfig);
        }

        private static ApplicationConfig ApplicationConfigDeserialize(string content)
        {
            return JsonSerializer.Deserialize<ApplicationConfig>(content);
        }
    }
}
