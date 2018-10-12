using log4net;
using PeHeBI_DatabastUpdata.common;
using PeHeBI_DatabastUpdata.DAL;
using PeHeBI_DatabastUpdata.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PeHeBI_DatabastUpdata
{
    public partial class Form1 : Form
    {
        private ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        Access_sRecords_DAL_LastMonth access_SRecords_DAL_LastMonth = new Access_sRecords_DAL_LastMonth();
        Access_sRecords_DAL_ThisMonth access_SRecords_DAL_ThisMonthh = new Access_sRecords_DAL_ThisMonth();
        Sqlite_sRecords_Dal sqlite_SRecords_Dal = new Sqlite_sRecords_Dal();
        sql_pr_PeiHeBi_DAL sql_Pr_PeiHeBi_DAL = new sql_pr_PeiHeBi_DAL();



        //private readonly PeHeBI_DatabastUpdata.BLL.Access_sRecords_BLL access_SRecords= new PeHeBI_DatabastUpdata.BLL.Access_sRecords_BLL();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                if (accessMAXID> sqlMAXID)
                {
                  var  X1= access_SRecords_DAL_ThisMonthh.GetModel((sqlMAXID + 1).ToString(), accessMAXID.ToString());
                  int X2= sqlite_SRecords_Dal.Inserts(X1, global_variable.ThisMonth);
                }
            }
            else if(FileHelper.isExists_File(global_variable.LastMonthpath))
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

        public void ChangeProjectState(object source, System.Timers.ElapsedEventArgs e)
        {
            ////循环方法体
            if (!global_variable.With_a_month())
            {
                this._log.Error("日期更新");
            }
        }

        public void UpdataSqlite(object source, System.Timers.ElapsedEventArgs e)
        {
            ////循环方法体
            if (!global_variable.With_a_month())
            {
                this._log.Error("日期更新");
            }
        }
    }
}
