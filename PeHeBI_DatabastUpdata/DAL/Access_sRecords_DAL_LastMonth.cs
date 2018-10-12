using PeHeBI_DatabastUpdata.common;
using PeHeBI_DatabastUpdata.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.DAL
{
    public class Access_sRecords_DAL_LastMonth
    {
        public Access_sRecords_DAL_LastMonth()
        { }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
		public List<Access_sRecords_Model> GetModel(String one,string two)
        {
            string sql = "ID BETWEEN {0} AND {1}";
            sql = string.Format(sql, one, two);

            return DbHelperOleDb_LastMonth.GetWhere(sql).ToList<Access_sRecords_Model>();
           
        }

        public virtual int GetMaxID()
        {
            return DbHelperOleDb_LastMonth.GetMaxID();
        }

    }
}
