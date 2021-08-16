using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ConfigManager.Service
{
    public class ConfigManagerService
    {
        /// <summary>
        /// 取得 AppSettings 介面
        /// </summary>
        public static readonly NameValueCollection AppSettings = GetConfigurationUsingAppSettings();

        private static NameValueCollection GetConfigurationUsingAppSettings()
        {
            var configName = GetMachineAppSettings();
            var postSetting = ConfigurationManager.GetSection(configName) as NameValueCollection;
            return postSetting;
        }

        /// <summary>
        /// 取得目前程式運行設備AppSettings
        /// </summary>
        /// <returns></returns>
        private static string GetMachineAppSettings()
        {
            //預設設備為 MachineA
            var defaultMachineName = "MachineA";
            var group = "/appSettings";

            //取得運行主機名稱
            var machineName = Environment.MachineName.Trim().ToUpper();
            string machineAName = "MachineA";//設備A名稱
            string machineBName = "MachineB";//設備B名稱

            if(machineAName.Trim().ToUpper().Contains(machineName))
            {
                machineName = machineAName;
            }
            else if (machineBName.Trim().ToUpper().Contains(machineName))
            {
                machineName = machineBName;
            }
            else
            {
                machineName = defaultMachineName;
            }

            return machineName + group;

        }

    }
}
