using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Reflection;

using HRCore.Entity;


namespace HRUI
{
    public class Global
    {
        public string G_ApplicationName;                        //系统名称
        public string G_ApplicationTitle;                       //系统标题
        public string G_ApplicationVersion;
        public string G_ApplicationPath { get; set; }
        public string G_ConfigPath { get; set; }
        public string G_ConfigFile { get; set; }
        public string G_ConfigFile_Server { get; set; }
        public string G_ConfigFile_DockPanel { get; set; }

        public string G_DateTimeFormatNoDelimiter = "yyyyMMddHHmmss";
        public string G_QueryDateFormat = "yyyy-MM-dd";
        public string G_QueryDateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public Global()
        {
            //系统标题及版本
            G_ApplicationName = "HRMIS2023";
            G_ApplicationTitle = AssemblyTitle;
            G_ApplicationVersion = AssemblyVersion;

            //配置文件路径
            G_ApplicationPath = Application.StartupPath;
            G_ConfigPath = $"{G_ApplicationPath}\\.ate\\config";
            G_ConfigFile = $"{G_ConfigPath}\\config.json";
            G_ConfigFile_Server = $"{G_ConfigPath}\\server.json";
            G_ConfigFile_DockPanel = $"{G_ConfigPath}\\dockpanel.config";



        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

    }
}
