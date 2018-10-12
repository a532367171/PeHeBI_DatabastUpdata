using PeHeBI_DatabastUpdata.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata
{
    public static class global_variable
    {
        private static string lastMonth;

        private static string thisMonth;

        private static string sharedPath;

        private static bool sharedPathisExists;

        private static string lastMonthpath;

        private static bool lastMonthpathisExists;

        private static string thisMonthpath;

        private static bool thisMonthpathisExists;

        private static bool completed_last_month;

        private static string connectionString_ThisMonthpat;

        private static string connectionString_LastMonthpat;




        //        string cs = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["SharedPath"].ToString() + "\\" + DateTime.Now.ToString("yyyyMM") + ".MDB";



        public static string LastMonth { get => lastMonth; set => lastMonth = value; }

   
        public static string ThisMonth { get => thisMonth; set => thisMonth = value; }
        public static string SharedPath { get => sharedPath; set => sharedPath = value; }
        public static string ThisMonthpath { get => thisMonthpath; set => thisMonthpath = value; }
        public static string LastMonthpath { get => lastMonthpath; set => lastMonthpath = value; }
     
        public static bool Completed_last_month { get => completed_last_month; set => completed_last_month = value; }
        public static bool SharedPathisExists { get => sharedPathisExists; set => sharedPathisExists = value; }
        public static bool LastMonthpathisExists { get => lastMonthpathisExists; set => lastMonthpathisExists = value; }
        public static bool ThisMonthpathisExists { get => thisMonthpathisExists; set => thisMonthpathisExists = value; }
        public static string ConnectionString_ThisMonthpat { get => connectionString_ThisMonthpat; set => connectionString_ThisMonthpat = value; }
        public static string ConnectionString_LastMonthpat { get => connectionString_LastMonthpat; set => connectionString_LastMonthpat = value; }

        public static  bool With_a_month()
        {
            if (DateTime.Now.ToString("yyyyMM") == thisMonth)
            {
                return true;
            }
            else
            {
                completed_last_month = false;
                Updata_global_variable();
                return false;

            }
        }

        public static void Updata_global_variable()
        {

            thisMonth = DateTime.Now.ToString("yyyyMM");
            lastMonth = DateTime.Now.AddMonths(-1).ToString("yyyyMM");
            ThisMonthpath = SharedPath + "\\" + thisMonth + ".MDB";
            LastMonthpath = SharedPath + "\\" + lastMonth + ".MDB";
            ConnectionString_LastMonthpat = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + LastMonthpath;
            ConnectionString_ThisMonthpat = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ThisMonthpath;

            if (FileHelper.isExists(global_variable.SharedPath))
            {
                SharedPathisExists = true;

                if (FileHelper.isExists_File(global_variable.LastMonthpath))
                {

                    LastMonthpathisExists = true;

                }
                else
                {
                    LastMonthpathisExists = false;

                }

                if (FileHelper.isExists_File(global_variable.ThisMonthpath))
                {
                    ThisMonthpathisExists = true;
                }
                else
                {
                    ThisMonthpathisExists = false;

                }
            }
            else
            {
                SharedPathisExists = false;
            }
            Updata_Config();



        }
        public static void Updata_Config()
        {
            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "ThisMonth", thisMonth);

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "LastMonth", lastMonth);

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "ThisMonthPath", thisMonthpath);

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "ThisMonthPathisExists", thisMonthpathisExists.ToString());

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "LastMonthPath", lastMonthpath);

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "LastMonthPathisExists", lastMonthpathisExists.ToString());

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "Completed_last_month", completed_last_month.ToString());

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "ConnectionString_LastMonthpat", ConnectionString_LastMonthpat.ToString());

            ConfigManager.UpdateOrCreateAppSetting(ConfigurationFile.AppConfig, "ConnectionString_ThisMonthpat", ConnectionString_ThisMonthpat.ToString());



        }

        public static bool is_null()
        {
            if (connectionString_ThisMonthpat == ""|| connectionString_LastMonthpat == "" || sharedPath == "" || thisMonth == "" || lastMonth == "" )
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
