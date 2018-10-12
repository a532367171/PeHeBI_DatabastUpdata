using log4net.Config;
using PeHeBI_DatabastUpdata.common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PeHeBI_DatabastUpdata
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CHS");
            CultureInfo cultureInfo = new CultureInfo("zh-CHS");
            DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();
            dateTimeFormatInfo.DateSeparator = "-";
            dateTimeFormatInfo.ShortDatePattern = "yyyy-MM-dd";
            dateTimeFormatInfo.LongDatePattern = "yyyy'年'M'月'd'日'";
            dateTimeFormatInfo.ShortTimePattern = "H:mm:ss";
            dateTimeFormatInfo.LongTimePattern = "H'时'mm'分'ss'秒'";
            cultureInfo.DateTimeFormat = dateTimeFormatInfo;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            XmlConfigurator.Configure();


            Ini_Global();

            //global_variable.LastMonth = ConfigurationManager.AppSettings["LastMonth"].ToString();
            //global_variable.ThisMonth = ConfigurationManager.AppSettings["ThisMonth"].ToString();



            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new Service1()
            //};
            //ServiceBase.Run(ServicesToRun);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
         static void Ini_Global()
        {
            global_variable.LastMonth = ConfigManager.ReadValueByKey(ConfigurationFile.AppConfig, "LastMonth").ToLower();
            //global_variable.ThisMonth = ConfigManager.ReadValueByKey(ConfigurationFile.AppConfig, "ThisMonth").ToLower();
            global_variable.SharedPath = ConfigManager.ReadValueByKey(ConfigurationFile.AppConfig, "SharedPath").ToLower();
            global_variable.ThisMonthpath = ConfigManager.ReadValueByKey(ConfigurationFile.AppConfig, "ThisMonthPath").ToLower();
            global_variable.LastMonthpath = ConfigManager.ReadValueByKey(ConfigurationFile.AppConfig, "LastMonthPath").ToLower();

            global_variable.ConnectionString_LastMonthpat = ConfigManager.ReadValueByKey(ConfigurationFile.AppConfig, "ConnectionString_LastMonthpat").ToLower();
            global_variable.ConnectionString_ThisMonthpat = ConfigManager.ReadValueByKey(ConfigurationFile.AppConfig, "ConnectionString_ThisMonthpat").ToLower();


        }

    }
}
