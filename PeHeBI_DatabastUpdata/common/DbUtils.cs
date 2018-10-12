using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.common
{
    //public static class DbUtils
    //{
    //    static string cs = SqlEasy.connString; //数据库连接字符串


    //    ///<returns> the id of the inserted object </returns>
    //    public static int Insert(object o)
    //    {
    //        using (var conn = new SqlConnection(cs))
    //        using (var cmd = conn.CreateCommand())
    //        {
    //            cmd.CommandType = CommandType.Text;
    //            //cmd.CommandText = "insert " + TableConvention.Resolve(o) + " ("
    //            //    .InjectFrom(new FieldsBy().IgnoreFields("keyid"), o) + ") values("
    //            //    .InjectFrom(new FieldsBy().IgnoreFields("keyid").SetFormat("@{0}"), o)
    //            //    + ") select @@identity";
    //            conn.Open();
    //            return Convert.ToInt32(cmd.ExecuteScalar());
    //        }
    //    }

    //    /// <returns>rows affected</returns>
    //    public static int ExecuteNonQuerySp1(string sp)
    //    {
    //        int affectedRows = 0;

    //        using (var conn = new SqlConnection(cs))
    //        {
    //            using (var cmd = conn.CreateCommand())
    //            {
    //                cmd.CommandType = CommandType.Text;
    //                cmd.CommandTimeout = 5;
  
    //                try
    //                {
    //                    cmd.CommandText = sp;
    //                    conn.Open();
    //                    affectedRows = cmd.ExecuteNonQuery();
    //                }
    //                catch (Exception) { throw; }

    //            }
    //        }
    //        return affectedRows;

    //    }

    //    public static int ExecuteNonQuerySp(string sp)
    //    {
    //        var conn = new SqlConnection(cs);
    //        try
    //        {
    //            var cmd = conn.CreateCommand();
    //            cmd.CommandType = CommandType.Text;
    //            cmd.CommandText = sp;
    //            cmd.CommandTimeout = 8000;

    //            if (cmd.Connection.State == ConnectionState.Closed)
    //            {
    //                conn.Open();
    //            }
    //            return cmd.ExecuteNonQuery();
    //        }
    //        catch (Exception)
    //        {
    //            return 0;
    //        }
    //        finally
    //        {

    //            conn.Close();
    //        }

    //    }


    //    public static DataTable ExecuteDataTable(string sp)
    //    {
    //        using (var conn = new SqlConnection(cs))
    //        {
    //            var cmd = conn.CreateCommand();

    //            cmd.CommandText = sp;

    //            cmd.CommandTimeout = 5;
     
    //            DataTable ds = new DataTable();
    //            if (conn.State == ConnectionState.Closed)
    //                conn.Open();

    //            SqlDataAdapter da = new SqlDataAdapter(cmd);
    //            da.Fill(ds);
    //            da.Dispose();
    //            cmd.Dispose();
    //            conn.Close();
    //            return ds;
    //        }
    //    }

      

    //}

}
