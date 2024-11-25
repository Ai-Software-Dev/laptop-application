using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudService
{
    class ServiceConfig
    {
        public static string CloudinaryCloudName { get; private set; }
        public static string CloudinaryApiKey { get; private set; }
        public static string CloudinaryApiSecret { get; private set; }

        static ServiceConfig()
        {
            // Lấy thư mục chứa ứng dụng .exe (hoặc thư mục gốc của ứng dụng)
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Tạo đường dẫn tới thư mục CloudService nằm ngoài thư mục GUI
            string configFilePath = Path.Combine(baseDirectory, "..\\..\\..\\CloudService\\CloudServiceConfig.config");

            // Chuyển đường dẫn tương đối thành đường dẫn tuyệt đối
            configFilePath = Path.GetFullPath(configFilePath);

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = configFilePath // Đường dẫn tệp cấu hình
            };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            CloudinaryCloudName = config.AppSettings.Settings["CloudinaryCloudName"].Value;
            CloudinaryApiKey = config.AppSettings.Settings["CloudinaryApiKey"].Value;
            CloudinaryApiSecret = config.AppSettings.Settings["CloudinaryApiSecret"].Value;
        }
    }
}
