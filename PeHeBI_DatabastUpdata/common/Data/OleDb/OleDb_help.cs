using Omu.ValueInjecter;
using PeHeBI_DatabastUpdata.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.common.Data.OleDb
{
  public  class OleDb_help
    {

        public  System.Collections.Generic.IEnumerable<T> GetList<T>(string sql, object parameters, string ConnectionString) where T : new()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.InjectFrom<SetParamsValues>(parameters);
                    conn.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var o = new T();
                            o.InjectFrom<ReaderInjection>(dr);
                            yield return o;
                        }
                    }
                }
            }
        }

    }
}
