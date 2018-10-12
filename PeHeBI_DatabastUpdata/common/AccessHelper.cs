using System;
using System.Data;
using System.Configuration;
using System.Data.OleDb;

namespace PeHeBI_DatabastUpdata.common
{
    /// <summary>
    /// AccessHelper 的摘要说明
    /// </summary>
    public class AccessHelper
    {
        //定义连接字符串
         //public static readonly string sqlAccessStr = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["SharedPath"].ToString()+"\\"+ DateTime.Now.ToString("yyyyMM")+ ".MDB" + ";Jet OLEDB:Database Password=123456;";
        public static readonly string sqlAccessStr = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["SharedPath"].ToString() + "\\" + DateTime.Now.ToString("yyyyMM") + ".MDB";

        // conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ conStr +";Jet OLEDB:System Database=system.mdw;");

        //创建常用方法

        private static void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, OleDbTransaction trans, CommandType cmdType, string cmdText, OleDbParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (OleDbParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static int DeleteByWhere(String cmdText)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(sqlAccessStr))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }
        /// <summary>
        /// 查询集datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ExecuteOleDbTable(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection connection = new OleDbConnection(sqlAccessStr))
            {
                PrepareCommand(cmd, connection, null, CommandType.Text, sql, null);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmd.Parameters.Clear();
                return dataTable;
            }
        }
        /// <summary>
        /// 查询datareader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string sql)
        {
            OleDbDataReader rdr;
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection conn = new OleDbConnection(sqlAccessStr);
            try
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, sql, null);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
            }
            catch
            {
                conn.Close();
                throw;
            }
            return rdr;
        }
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(sqlAccessStr))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, cmdParms);

                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(sqlAccessStr))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }
        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static int getCount(string sql)
        {
            int count;
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection conn = new OleDbConnection(sqlAccessStr);
            try
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, sql, null);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Parameters.Clear();
            }
            catch
            {
                conn.Close();
                throw;
            }
            return count;
        }
    }
}