using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.common
{
    public class ConfigHelper
    {
        public static string GetValue(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }


    }



}
