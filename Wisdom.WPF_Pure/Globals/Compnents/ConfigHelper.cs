using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.WPF_Pure.Globals.Compnents
{
    /// <summary>
    /// 配置帮助类
    /// </summary>
    public class ConfigHelper
    {
        /* 使用热更新
        var uploadConfig = new ConfigHelper().Load("uploadconfig", _env.EnvironmentName, true);
        services.Configure<UploadConfig>(uploadConfig);

        private readonly UploadConfig _uploadConfig;
        public ImgController(IOptionsMonitor<UploadConfig> uploadConfig)
        {
            _uploadConfig = uploadConfig.CurrentValue;
        }
        */

        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <param name="fileName">文件名称</param>
        /// <param name="environmentName">环境名称</param>
        /// <param name="optional">可选</param>
        /// <param name="reloadOnChange">自动更新</param>
        /// <returns></returns>
        public static IConfiguration Load(string fileName, string environmentName = "", 
            bool optional = true, bool reloadOnChange = false,
            string path= "DataTable", IConfigurationBuilder? cBuilder=null)
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, path);
            if (!Directory.Exists(filePath))
                return null;
            var builder = cBuilder?? new ConfigurationBuilder()
                .SetBasePath(filePath)
                .AddJsonFile(fileName.ToLower() + ".json", optional, reloadOnChange)
                ;

            if (string.IsNullOrEmpty(environmentName))
            {
                builder.AddJsonFile(fileName.ToLower() + "." + environmentName + ".json", optional: optional, reloadOnChange: reloadOnChange);
            }

            return builder.Build();
        }

        /// <summary>
        /// 获得配置信息
        /// </summary>
        /// <typeparam name="T">配置信息</typeparam>
        /// <param name="fileName">文件名称</param>
        /// <param name="environmentName">环境名称</param>
        /// <param name="optional">可选</param>
        /// <param name="reloadOnChange">自动更新</param>
        /// <returns></returns>
        public static T Get<T>(string fileName, string environmentName = "", bool optional = true, bool reloadOnChange = false)
        {
            var configuration = Load(fileName, environmentName, optional, reloadOnChange);
            if (configuration == null)
                return default;

            return configuration.Get<T>();
        }

        public static T Get<T>(string fileName, string environmentName = "", bool optional = true, bool reloadOnChange = false, string path = "DataTable")
        {
            //JsonConfigurationProvider
            var configuration = Load(fileName, environmentName, optional, reloadOnChange);
            if (configuration == null)
                return default;

            return configuration.Get<T>();
        }


        public static T Get<T>(IConfiguration cfg)
        {
            //JsonConfigurationProvider
            var configuration = cfg;
            if (configuration == null)
                return default;

            return configuration.Get<T>();
        }


        /// <summary>
        /// 绑定实例配置信息
        /// </summary>
        /// <param name="fileName">文件名称</param>
        /// <param name="instance">实例配置</param>
        /// <param name="environmentName">环境名称</param>
        /// <param name="optional">可选</param>
        /// <param name="reloadOnChange">自动更新</param>
        public static void Bind(string fileName, object instance, string environmentName = "", bool optional = true, bool reloadOnChange = false)
        {
            var configuration = Load(fileName, environmentName, optional, reloadOnChange);
            if (configuration == null || instance == null)
                return;

            configuration.Bind(instance);
        }
        public static void Bind(string fileName, object instance, string environmentName = "", bool optional = true, bool reloadOnChange = false, string path = "DataTable")
        {
            var configuration = Load(fileName, environmentName, optional, reloadOnChange);
            if (configuration == null || instance == null)
                return;

            configuration.Bind(instance);
        }
    }
}
