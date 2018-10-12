using log4net;
using PeHeBI_DatabastUpdata.common;
using PeHeBI_DatabastUpdata.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;

namespace PeHeBI_DatabastUpdata
{
    public partial class Service1 : ServiceBase
    {
        ILog _log;
        Access_sRecords_DAL_LastMonth access_SRecords_DAL_LastMonth;
        Access_sRecords_DAL_ThisMonth access_SRecords_DAL_ThisMonthh;
        Sqlite_sRecords_Dal sqlite_SRecords_Dal;
        sql_pr_PeiHeBi_DAL sql_Pr_PeiHeBi_DAL;


        public Service1()
        {
            InitializeComponent();
            InitializeClass();
        }

        private void InitializeClass()
        {
            _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            access_SRecords_DAL_LastMonth = new Access_sRecords_DAL_LastMonth();
            access_SRecords_DAL_ThisMonthh = new Access_sRecords_DAL_ThisMonth();
            sqlite_SRecords_Dal = new Sqlite_sRecords_Dal();
            sql_Pr_PeiHeBi_DAL = new sql_pr_PeiHeBi_DAL();
        }

        private void InitService()
        {
            base.AutoLog = false;
            base.CanShutdown = true;
            base.CanStop = true;
            base.CanPauseAndContinue = true;
            base.ServiceName = "PeHeBI_DatabastUpdata";  //这个名字很重要，设置不一致会产生 1083 错误哦(在文章最后会说到这个问题)！


        }

        protected override void OnStart(string[] args)
        {
            while (true)
            {
                try
                {
                    if (!global_variable.With_a_month())
                    {
                        this._log.Error("日期更新");
                    }

                    if (global_variable.is_null())
                    {
                        global_variable.Updata_global_variable();
                    }

                    if (global_variable.Completed_last_month && FileHelper.isExists_File(global_variable.ThisMonthpath))
                    {
                        int accessMAXID = access_SRecords_DAL_ThisMonthh.GetMaxID();
                        int sqlMAXID = sqlite_SRecords_Dal.GetMaxID(global_variable.ThisMonth);

                        if (accessMAXID > sqlMAXID)
                        {
                            var X1 = access_SRecords_DAL_ThisMonthh.GetModel((sqlMAXID + 1).ToString(), accessMAXID.ToString());
                            int X2 = sqlite_SRecords_Dal.Inserts(X1, global_variable.ThisMonth);
                        }
                    }
                    else if (FileHelper.isExists_File(global_variable.LastMonthpath))
                    {
                        int accessMAXID = access_SRecords_DAL_LastMonth.GetMaxID();
                        int sqlMAXID = sqlite_SRecords_Dal.GetMaxID(global_variable.LastMonth);
                        if (accessMAXID > sqlMAXID)
                        {
                            var X1 = access_SRecords_DAL_LastMonth.GetModel((sqlMAXID + 1).ToString(), accessMAXID.ToString());
                            int X2 = sqlite_SRecords_Dal.Inserts(X1, global_variable.LastMonth);
                        }
                        else if (FileHelper.isExists_File(global_variable.ThisMonthpath) && (accessMAXID == sqlMAXID))
                        {
                            global_variable.Completed_last_month = true;
                            global_variable.Updata_Config();
                        }

                    }

                    if (www_Connect.IsConnectNetwork())
                    {
                        var collection = sqlite_SRecords_Dal.GetModel();
                        foreach (var item in collection)
                        {
                            int y = sql_Pr_PeiHeBi_DAL.Insert(ModleHelper.Sqlite_sRecords_Model_To_pr_PeiHeBi_Model(item));
                            if (y > 0)
                            {

                                sqlite_SRecords_Dal.Change_state(item.AttemperCode);

                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {

                    this._log.Error(ex.Message);
                }
            }
        }

        protected override void OnStop()
        {
        }
    }
}
