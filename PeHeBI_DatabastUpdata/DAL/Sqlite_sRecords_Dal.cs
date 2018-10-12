using PeHeBI_DatabastUpdata.common.Data.SQLite;
using PeHeBI_DatabastUpdata.Model;
using PeHeBI_DatabastUpdata.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.DAL
{
    public class Sqlite_sRecords_Dal
    {
        public Sqlite_sRecords_Dal()
            {}



        public virtual int Insert(Access_sRecords_Model o,string s)
        {
            return SQLiteEasy.Insert(o,s);
        }
        public virtual int Inserts(List<Access_sRecords_Model> o, string s)
        {
            int x = 0;
            try
            {
                foreach (var item in o)
                {
                  var X1=  SQLiteEasy.Insert(item, s);
                    x++;
                }
                return x;
            }
            catch (Exception)
            {

                return x;

            }
        }

        public virtual int GetMaxID(string s)
        {
            return SQLiteEasy.GetMaxID(s);
        }

        public List<Sqlite_sRecords_Model> GetModel(String s="")
        {
            if (s=="")
            {
                return SQLiteEasy.GetWhere().ToList<Sqlite_sRecords_Model>();

            }
            else
            {
                return SQLiteEasy.GetWhere(s).ToList<Sqlite_sRecords_Model>();

            }
        }

        public void Change_state(String cXLDnode)
        {

            SQLiteEasy.Change_state(cXLDnode);


        }

    }
}
