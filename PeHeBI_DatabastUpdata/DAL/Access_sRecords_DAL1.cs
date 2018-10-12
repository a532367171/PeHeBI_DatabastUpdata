//using System;
//using System.Data;
//using System.Text;
//using System.Data.OleDb;
//using PeHeBI_DatabastUpdata.common;
//using PeHeBI_DatabastUpdata.Model;
//using System.Collections.Generic;
//using System.Collections;
//using PeHeBI_DatabastUpdata.common.Data;
//using PeHeBI_DatabastUpdata.common.Provider;
//using System.Data.SqlClient;
//using PeHeBI_DatabastUpdata.common.Data.OleDb;
//using Omu.ValueInjecter;
//using System.Configuration;

//namespace PeHeBI_DatabastUpdata.DAL
//{
//    /// <summary>
//    /// 数据访问类:sRecords
//    /// </summary>
//    //public  class Access_sRecords_DAL : BaseRepository<Access_sRecords_Model>
//     public class Access_sRecords_DAL1
//    {
//        public static Access_sRecords_DAL1 Instance
//        {
//            get { return SingletonProvider<Access_sRecords_DAL1>.Instance; }
//        }
//        public Access_sRecords_DAL1()
//        {


//        }

//        /// <summary>
//        /// 根据主键Id,获取一行数据
//        /// </summary>
//        /// <param name="tableName">表名</param>
//        /// <param name="keyName">主键名称</param>
//        /// <param name="value">值</param>
//        /// <param name="msg">返回信息</param>
//        /// <returns></returns>
//        public  DataRow GetADataRow(string tableName, string keyName, string value, out string msg)
//        {
//            try
//            {
//                string s = "select * from @table where @keyname=@value";
//                SqlParameter[] sp ={new SqlParameter("@table",tableName),
//                    new SqlParameter("@keyname",keyName),
//                    new SqlParameter("@value",value)
//                };

//                DataTable dt = OleDbEasy.ExecuteDataTable(s, sp);

//                if (dt.Rows.Count > 0)
//                {
//                    msg = "OK";
//                    return dt.Rows[0];
//                }
//                else
//                {
//                    msg = "";
//                    return null;
//                }
//            }
//            catch (Exception ex)
//            {
//                msg = ex.Message;
//                return null;
//            }
//        }

//        public  IEnumerable GetModels(string sql)
//        {
//            string cs = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["SharedPath"].ToString() + "\\" + DateTime.Now.ToString("yyyyMM") + ".MDB";

//            using (var conn = new SqlConnection(cs))
//            {
//                using (var cmd = conn.CreateCommand())
//                {
//                    cmd.CommandType = CommandType.Text;

//                    cmd.CommandText = "select * from " + TableConvention.Resolve(typeof(Access_sRecords_Model)) + " where "
//                        .InjectFrom(new FieldsBy()
//                        .SetFormat("{0}=@{0}")
//                        .SetNullFormat("{0} is null")
//                        .SetGlue("and"),
//                        sql);
//                    cmd.InjectFrom<SetParamsValues>(sql);
//                    conn.Open();

//                    using (var dr = cmd.ExecuteReader())
//                    {
//                        while (dr.Read())
//                        {
//                            var o = new Access_sRecords_Model();
//                            o.InjectFrom<ReaderInjection>(dr);
//                            yield return o;
//                        }
//                    }
//                }
//            }


//        }

//        public ArrayList GetModels(int startId, int lastId)
//        {
//            //IEnumerable<Model.Access_sRecords_Model> mList = new IEnumerable<Model.Access_sRecords_Model>();
//            ArrayList mList = new ArrayList();
//            string strWhere = "ID BTWEEN '" + startId + "' AND '" + lastId + "'";
//            DataSet ds = GetList(strWhere);
//            if (ds.Tables[0].Rows.Count > 0)
//            {
//                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
//                {
//                    Model.Access_sRecords_Model sRecords = DataRowToModel(ds.Tables[0].Rows[i]);
//                    mList.Add(sRecords);
//                }
//                return mList;
//            }
//            else
//            {
//                return null;
//            }
//        }


//        #region  BasicMethod

//        /// <summary>
//        /// 是否存在该记录
//        /// </summary>
//        public bool Exists(string id)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("select count(1) from sRecords");
//            strSql.Append(" where ID=@id ");
//            OleDbParameter[] parameters = {
//                    new OleDbParameter("@id", OleDbType.VarChar)
//                                          };
//            parameters[0].Value = id;

//            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
//        }


//        /// <summary>
//        /// 增加一条数据
//        /// </summary>
//        public bool Add(PeHeBI_DatabastUpdata.Model.Access_sRecords_Model model)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("insert into sRecords(");
//            strSql.Append("ScTime,Output_vol,NAM_GL1,MBZ_GL1,CLZ_GL1,JDZ_GL1,XDZ_GL1,HSL_GL1,NAM_GL2,MBZ_GL2,CLZ_GL2,JDZ_GL2,XDZ_GL2,HSL_GL2,NAM_GL3,MBZ_GL3,CLZ_GL3,JDZ_GL3,XDZ_GL3,HSL_GL3,NAM_GL4,MBZ_GL4,CLZ_GL4,JDZ_GL4,XDZ_GL4,HSL_GL4,NAM_GL5,MBZ_GL5,CLZ_GL5,JDZ_GL5,XDZ_GL5,HSL_GL5,NAM_GL6,MBZ_GL6,CLZ_GL6,JDZ_GL6,XDZ_GL6,HSL_GL6,NAM_GL7,MBZ_GL7,CLZ_GL7,JDZ_GL7,XDZ_GL7,HSL_GL7,NAM_GL8,MBZ_GL8,CLZ_GL8,JDZ_GL8,XDZ_GL8,HSL_GL8,NAM_FLA1,MBZ_FLA1,CLZ_FLA1,JDZ_FLA1,XDZ_FLA1,NAM_FLA2,MBZ_FLA2,CLZ_FLA2,JDZ_FLA2,XDZ_FLA2,NAM_FLA3,MBZ_FLA3,CLZ_FLA3,JDZ_FLA3,XDZ_FLA3,NAM_FLA4,MBZ_FLA4,CLZ_FLA4,JDZ_FLA4,XDZ_FLA4,NAM_FLB1,MBZ_FLB1,CLZ_FLB1,JDZ_FLB1,XDZ_FLB1,NAM_FLB2,MBZ_FLB2,CLZ_FLB2,JDZ_FLB2,XDZ_FLB2,NAM_FLB3,MBZ_FLB3,CLZ_FLB3,JDZ_FLB3,XDZ_FLB3,NAM_FLC1,MBZ_FLC1,CLZ_FLC1,JDZ_FLC1,XDZ_FLC1,NAM_FLC2,MBZ_FLC2,CLZ_FLC2,JDZ_FLC2,XDZ_FLC2,NAM_WJA1,MBZ_WJA1,CLZ_WJA1,JDZ_WJA1,XDZ_WJA1,HGL_WJA1,NAM_WJA2,MBZ_WJA2,CLZ_WJA2,JDZ_WJA2,XDZ_WJA2,HGL_WJA2,NAM_WJA3,MBZ_WJA3,CLZ_WJA3,JDZ_WJA3,XDZ_WJA3,HGL_WJA3,NAM_WJA4,MBZ_WJA4,CLZ_WJA4,JDZ_WJA4,XDZ_WJA4,HGL_WJA4,NAM_WJB1,MBZ_WJB1,CLZ_WJB1,JDZ_WJB1,XDZ_WJB1,HGL_WJB1,NAM_WJB2,MBZ_WJB2,CLZ_WJB2,JDZ_WJB2,XDZ_WJB2,HGL_WJB2,NAM_WJB3,MBZ_WJB3,CLZ_WJB3,JDZ_WJB3,XDZ_WJB3,HGL_WJB3,NAM_WJB4,MBZ_WJB4,CLZ_WJB4,JDZ_WJB4,XDZ_WJB4,HGL_WJB4,NAM_WJC1,MBZ_WJC1,CLZ_WJC1,JDZ_WJC1,XDZ_WJC1,HGL_WJC1,NAM_WJC2,MBZ_WJC2,CLZ_WJC2,JDZ_WJC2,XDZ_WJC2,HGL_WJC2,NAM_WJC3,MBZ_WJC3,CLZ_WJC3,JDZ_WJC3,XDZ_WJC3,HGL_WJC3,NAM_WJC4,MBZ_WJC4,CLZ_WJC4,JDZ_WJC4,XDZ_WJC4,HGL_WJC4,NAM_Shui1,MBZ_Shui1,CLZ_Shui1,JDZ_Shui1,XDZ_Shui1,NAM_Shui2,MBZ_Shui2,CLZ_Shui2,JDZ_Shui2,XDZ_Shui2,Job_No,Prop_No,Cust_Nm,Proj_Nm,Location,Site_No,Contr_No,Tech_Req,Delivery_Mode,Remark,Truck_No,Driver,Strength,RecordRemark,SynchRemark,SaJiangSymbol,ReadState,Operator,AttemperCode,ProduceLine,Const_Unit,Truck_vol,KangShenLevel,TaLuoDu,OperationState)");
//            strSql.Append(" values (");
//            strSql.Append("@ScTime,@Output_vol,@NAM_GL1,@MBZ_GL1,@CLZ_GL1,@JDZ_GL1,@XDZ_GL1,@HSL_GL1,@NAM_GL2,@MBZ_GL2,@CLZ_GL2,@JDZ_GL2,@XDZ_GL2,@HSL_GL2,@NAM_GL3,@MBZ_GL3,@CLZ_GL3,@JDZ_GL3,@XDZ_GL3,@HSL_GL3,@NAM_GL4,@MBZ_GL4,@CLZ_GL4,@JDZ_GL4,@XDZ_GL4,@HSL_GL4,@NAM_GL5,@MBZ_GL5,@CLZ_GL5,@JDZ_GL5,@XDZ_GL5,@HSL_GL5,@NAM_GL6,@MBZ_GL6,@CLZ_GL6,@JDZ_GL6,@XDZ_GL6,@HSL_GL6,@NAM_GL7,@MBZ_GL7,@CLZ_GL7,@JDZ_GL7,@XDZ_GL7,@HSL_GL7,@NAM_GL8,@MBZ_GL8,@CLZ_GL8,@JDZ_GL8,@XDZ_GL8,@HSL_GL8,@NAM_FLA1,@MBZ_FLA1,@CLZ_FLA1,@JDZ_FLA1,@XDZ_FLA1,@NAM_FLA2,@MBZ_FLA2,@CLZ_FLA2,@JDZ_FLA2,@XDZ_FLA2,@NAM_FLA3,@MBZ_FLA3,@CLZ_FLA3,@JDZ_FLA3,@XDZ_FLA3,@NAM_FLA4,@MBZ_FLA4,@CLZ_FLA4,@JDZ_FLA4,@XDZ_FLA4,@NAM_FLB1,@MBZ_FLB1,@CLZ_FLB1,@JDZ_FLB1,@XDZ_FLB1,@NAM_FLB2,@MBZ_FLB2,@CLZ_FLB2,@JDZ_FLB2,@XDZ_FLB2,@NAM_FLB3,@MBZ_FLB3,@CLZ_FLB3,@JDZ_FLB3,@XDZ_FLB3,@NAM_FLC1,@MBZ_FLC1,@CLZ_FLC1,@JDZ_FLC1,@XDZ_FLC1,@NAM_FLC2,@MBZ_FLC2,@CLZ_FLC2,@JDZ_FLC2,@XDZ_FLC2,@NAM_WJA1,@MBZ_WJA1,@CLZ_WJA1,@JDZ_WJA1,@XDZ_WJA1,@HGL_WJA1,@NAM_WJA2,@MBZ_WJA2,@CLZ_WJA2,@JDZ_WJA2,@XDZ_WJA2,@HGL_WJA2,@NAM_WJA3,@MBZ_WJA3,@CLZ_WJA3,@JDZ_WJA3,@XDZ_WJA3,@HGL_WJA3,@NAM_WJA4,@MBZ_WJA4,@CLZ_WJA4,@JDZ_WJA4,@XDZ_WJA4,@HGL_WJA4,@NAM_WJB1,@MBZ_WJB1,@CLZ_WJB1,@JDZ_WJB1,@XDZ_WJB1,@HGL_WJB1,@NAM_WJB2,@MBZ_WJB2,@CLZ_WJB2,@JDZ_WJB2,@XDZ_WJB2,@HGL_WJB2,@NAM_WJB3,@MBZ_WJB3,@CLZ_WJB3,@JDZ_WJB3,@XDZ_WJB3,@HGL_WJB3,@NAM_WJB4,@MBZ_WJB4,@CLZ_WJB4,@JDZ_WJB4,@XDZ_WJB4,@HGL_WJB4,@NAM_WJC1,@MBZ_WJC1,@CLZ_WJC1,@JDZ_WJC1,@XDZ_WJC1,@HGL_WJC1,@NAM_WJC2,@MBZ_WJC2,@CLZ_WJC2,@JDZ_WJC2,@XDZ_WJC2,@HGL_WJC2,@NAM_WJC3,@MBZ_WJC3,@CLZ_WJC3,@JDZ_WJC3,@XDZ_WJC3,@HGL_WJC3,@NAM_WJC4,@MBZ_WJC4,@CLZ_WJC4,@JDZ_WJC4,@XDZ_WJC4,@HGL_WJC4,@NAM_Shui1,@MBZ_Shui1,@CLZ_Shui1,@JDZ_Shui1,@XDZ_Shui1,@NAM_Shui2,@MBZ_Shui2,@CLZ_Shui2,@JDZ_Shui2,@XDZ_Shui2,@Job_No,@Prop_No,@Cust_Nm,@Proj_Nm,@Location,@Site_No,@Contr_No,@Tech_Req,@Delivery_Mode,@Remark,@Truck_No,@Driver,@Strength,@RecordRemark,@SynchRemark,@SaJiangSymbol,@ReadState,@Operator,@AttemperCode,@ProduceLine,@Const_Unit,@Truck_vol,@KangShenLevel,@TaLuoDu,@OperationState)");
//            OleDbParameter[] parameters = {
//                    new OleDbParameter("@ScTime", OleDbType.Date),
//                    new OleDbParameter("@Output_vol", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL1", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL2", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL3", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL4", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL5", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL5", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL6", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL6", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL7", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL7", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL8", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL8", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLB1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLB2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLB3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLC1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLC2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA1", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA3", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA4", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB1", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB3", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB4", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC1", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC3", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC4", OleDbType.Double),
//                    new OleDbParameter("@NAM_Shui1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@NAM_Shui2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@Job_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Prop_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Cust_Nm", OleDbType.VarChar,50),
//                    new OleDbParameter("@Proj_Nm", OleDbType.VarChar,50),
//                    new OleDbParameter("@Location", OleDbType.VarChar,50),
//                    new OleDbParameter("@Site_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Contr_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Tech_Req", OleDbType.VarChar,50),
//                    new OleDbParameter("@Delivery_Mode", OleDbType.VarChar,50),
//                    new OleDbParameter("@Remark", OleDbType.VarChar,50),
//                    new OleDbParameter("@Truck_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Driver", OleDbType.VarChar,50),
//                    new OleDbParameter("@Strength", OleDbType.VarChar,50),
//                    new OleDbParameter("@RecordRemark", OleDbType.VarChar,50),
//                    new OleDbParameter("@SynchRemark", OleDbType.VarChar,50),
//                    new OleDbParameter("@SaJiangSymbol", OleDbType.Integer,4),
//                    new OleDbParameter("@ReadState", OleDbType.Integer,4),
//                    new OleDbParameter("@Operator", OleDbType.VarChar,50),
//                    new OleDbParameter("@AttemperCode", OleDbType.VarChar,50),
//                    new OleDbParameter("@ProduceLine", OleDbType.VarChar,50),
//                    new OleDbParameter("@Const_Unit", OleDbType.VarChar,50),
//                    new OleDbParameter("@Truck_vol", OleDbType.Double),
//                    new OleDbParameter("@KangShenLevel", OleDbType.VarChar,50),
//                    new OleDbParameter("@TaLuoDu", OleDbType.VarChar,50),
//                    new OleDbParameter("@OperationState", OleDbType.Double)};
//            parameters[0].Value = model.ScTime;
//            parameters[1].Value = model.Output_vol;
//            parameters[2].Value = model.NAM_GL1;
//            parameters[3].Value = model.MBZ_GL1;
//            parameters[4].Value = model.CLZ_GL1;
//            parameters[5].Value = model.JDZ_GL1;
//            parameters[6].Value = model.XDZ_GL1;
//            parameters[7].Value = model.HSL_GL1;
//            parameters[8].Value = model.NAM_GL2;
//            parameters[9].Value = model.MBZ_GL2;
//            parameters[10].Value = model.CLZ_GL2;
//            parameters[11].Value = model.JDZ_GL2;
//            parameters[12].Value = model.XDZ_GL2;
//            parameters[13].Value = model.HSL_GL2;
//            parameters[14].Value = model.NAM_GL3;
//            parameters[15].Value = model.MBZ_GL3;
//            parameters[16].Value = model.CLZ_GL3;
//            parameters[17].Value = model.JDZ_GL3;
//            parameters[18].Value = model.XDZ_GL3;
//            parameters[19].Value = model.HSL_GL3;
//            parameters[20].Value = model.NAM_GL4;
//            parameters[21].Value = model.MBZ_GL4;
//            parameters[22].Value = model.CLZ_GL4;
//            parameters[23].Value = model.JDZ_GL4;
//            parameters[24].Value = model.XDZ_GL4;
//            parameters[25].Value = model.HSL_GL4;
//            parameters[26].Value = model.NAM_GL5;
//            parameters[27].Value = model.MBZ_GL5;
//            parameters[28].Value = model.CLZ_GL5;
//            parameters[29].Value = model.JDZ_GL5;
//            parameters[30].Value = model.XDZ_GL5;
//            parameters[31].Value = model.HSL_GL5;
//            parameters[32].Value = model.NAM_GL6;
//            parameters[33].Value = model.MBZ_GL6;
//            parameters[34].Value = model.CLZ_GL6;
//            parameters[35].Value = model.JDZ_GL6;
//            parameters[36].Value = model.XDZ_GL6;
//            parameters[37].Value = model.HSL_GL6;
//            parameters[38].Value = model.NAM_GL7;
//            parameters[39].Value = model.MBZ_GL7;
//            parameters[40].Value = model.CLZ_GL7;
//            parameters[41].Value = model.JDZ_GL7;
//            parameters[42].Value = model.XDZ_GL7;
//            parameters[43].Value = model.HSL_GL7;
//            parameters[44].Value = model.NAM_GL8;
//            parameters[45].Value = model.MBZ_GL8;
//            parameters[46].Value = model.CLZ_GL8;
//            parameters[47].Value = model.JDZ_GL8;
//            parameters[48].Value = model.XDZ_GL8;
//            parameters[49].Value = model.HSL_GL8;
//            parameters[50].Value = model.NAM_FLA1;
//            parameters[51].Value = model.MBZ_FLA1;
//            parameters[52].Value = model.CLZ_FLA1;
//            parameters[53].Value = model.JDZ_FLA1;
//            parameters[54].Value = model.XDZ_FLA1;
//            parameters[55].Value = model.NAM_FLA2;
//            parameters[56].Value = model.MBZ_FLA2;
//            parameters[57].Value = model.CLZ_FLA2;
//            parameters[58].Value = model.JDZ_FLA2;
//            parameters[59].Value = model.XDZ_FLA2;
//            parameters[60].Value = model.NAM_FLA3;
//            parameters[61].Value = model.MBZ_FLA3;
//            parameters[62].Value = model.CLZ_FLA3;
//            parameters[63].Value = model.JDZ_FLA3;
//            parameters[64].Value = model.XDZ_FLA3;
//            parameters[65].Value = model.NAM_FLA4;
//            parameters[66].Value = model.MBZ_FLA4;
//            parameters[67].Value = model.CLZ_FLA4;
//            parameters[68].Value = model.JDZ_FLA4;
//            parameters[69].Value = model.XDZ_FLA4;
//            parameters[70].Value = model.NAM_FLB1;
//            parameters[71].Value = model.MBZ_FLB1;
//            parameters[72].Value = model.CLZ_FLB1;
//            parameters[73].Value = model.JDZ_FLB1;
//            parameters[74].Value = model.XDZ_FLB1;
//            parameters[75].Value = model.NAM_FLB2;
//            parameters[76].Value = model.MBZ_FLB2;
//            parameters[77].Value = model.CLZ_FLB2;
//            parameters[78].Value = model.JDZ_FLB2;
//            parameters[79].Value = model.XDZ_FLB2;
//            parameters[80].Value = model.NAM_FLB3;
//            parameters[81].Value = model.MBZ_FLB3;
//            parameters[82].Value = model.CLZ_FLB3;
//            parameters[83].Value = model.JDZ_FLB3;
//            parameters[84].Value = model.XDZ_FLB3;
//            parameters[85].Value = model.NAM_FLC1;
//            parameters[86].Value = model.MBZ_FLC1;
//            parameters[87].Value = model.CLZ_FLC1;
//            parameters[88].Value = model.JDZ_FLC1;
//            parameters[89].Value = model.XDZ_FLC1;
//            parameters[90].Value = model.NAM_FLC2;
//            parameters[91].Value = model.MBZ_FLC2;
//            parameters[92].Value = model.CLZ_FLC2;
//            parameters[93].Value = model.JDZ_FLC2;
//            parameters[94].Value = model.XDZ_FLC2;
//            parameters[95].Value = model.NAM_WJA1;
//            parameters[96].Value = model.MBZ_WJA1;
//            parameters[97].Value = model.CLZ_WJA1;
//            parameters[98].Value = model.JDZ_WJA1;
//            parameters[99].Value = model.XDZ_WJA1;
//            parameters[100].Value = model.HGL_WJA1;
//            parameters[101].Value = model.NAM_WJA2;
//            parameters[102].Value = model.MBZ_WJA2;
//            parameters[103].Value = model.CLZ_WJA2;
//            parameters[104].Value = model.JDZ_WJA2;
//            parameters[105].Value = model.XDZ_WJA2;
//            parameters[106].Value = model.HGL_WJA2;
//            parameters[107].Value = model.NAM_WJA3;
//            parameters[108].Value = model.MBZ_WJA3;
//            parameters[109].Value = model.CLZ_WJA3;
//            parameters[110].Value = model.JDZ_WJA3;
//            parameters[111].Value = model.XDZ_WJA3;
//            parameters[112].Value = model.HGL_WJA3;
//            parameters[113].Value = model.NAM_WJA4;
//            parameters[114].Value = model.MBZ_WJA4;
//            parameters[115].Value = model.CLZ_WJA4;
//            parameters[116].Value = model.JDZ_WJA4;
//            parameters[117].Value = model.XDZ_WJA4;
//            parameters[118].Value = model.HGL_WJA4;
//            parameters[119].Value = model.NAM_WJB1;
//            parameters[120].Value = model.MBZ_WJB1;
//            parameters[121].Value = model.CLZ_WJB1;
//            parameters[122].Value = model.JDZ_WJB1;
//            parameters[123].Value = model.XDZ_WJB1;
//            parameters[124].Value = model.HGL_WJB1;
//            parameters[125].Value = model.NAM_WJB2;
//            parameters[126].Value = model.MBZ_WJB2;
//            parameters[127].Value = model.CLZ_WJB2;
//            parameters[128].Value = model.JDZ_WJB2;
//            parameters[129].Value = model.XDZ_WJB2;
//            parameters[130].Value = model.HGL_WJB2;
//            parameters[131].Value = model.NAM_WJB3;
//            parameters[132].Value = model.MBZ_WJB3;
//            parameters[133].Value = model.CLZ_WJB3;
//            parameters[134].Value = model.JDZ_WJB3;
//            parameters[135].Value = model.XDZ_WJB3;
//            parameters[136].Value = model.HGL_WJB3;
//            parameters[137].Value = model.NAM_WJB4;
//            parameters[138].Value = model.MBZ_WJB4;
//            parameters[139].Value = model.CLZ_WJB4;
//            parameters[140].Value = model.JDZ_WJB4;
//            parameters[141].Value = model.XDZ_WJB4;
//            parameters[142].Value = model.HGL_WJB4;
//            parameters[143].Value = model.NAM_WJC1;
//            parameters[144].Value = model.MBZ_WJC1;
//            parameters[145].Value = model.CLZ_WJC1;
//            parameters[146].Value = model.JDZ_WJC1;
//            parameters[147].Value = model.XDZ_WJC1;
//            parameters[148].Value = model.HGL_WJC1;
//            parameters[149].Value = model.NAM_WJC2;
//            parameters[150].Value = model.MBZ_WJC2;
//            parameters[151].Value = model.CLZ_WJC2;
//            parameters[152].Value = model.JDZ_WJC2;
//            parameters[153].Value = model.XDZ_WJC2;
//            parameters[154].Value = model.HGL_WJC2;
//            parameters[155].Value = model.NAM_WJC3;
//            parameters[156].Value = model.MBZ_WJC3;
//            parameters[157].Value = model.CLZ_WJC3;
//            parameters[158].Value = model.JDZ_WJC3;
//            parameters[159].Value = model.XDZ_WJC3;
//            parameters[160].Value = model.HGL_WJC3;
//            parameters[161].Value = model.NAM_WJC4;
//            parameters[162].Value = model.MBZ_WJC4;
//            parameters[163].Value = model.CLZ_WJC4;
//            parameters[164].Value = model.JDZ_WJC4;
//            parameters[165].Value = model.XDZ_WJC4;
//            parameters[166].Value = model.HGL_WJC4;
//            parameters[167].Value = model.NAM_Shui1;
//            parameters[168].Value = model.MBZ_Shui1;
//            parameters[169].Value = model.CLZ_Shui1;
//            parameters[170].Value = model.JDZ_Shui1;
//            parameters[171].Value = model.XDZ_Shui1;
//            parameters[172].Value = model.NAM_Shui2;
//            parameters[173].Value = model.MBZ_Shui2;
//            parameters[174].Value = model.CLZ_Shui2;
//            parameters[175].Value = model.JDZ_Shui2;
//            parameters[176].Value = model.XDZ_Shui2;
//            parameters[177].Value = model.Job_No;
//            parameters[178].Value = model.Prop_No;
//            parameters[179].Value = model.Cust_Nm;
//            parameters[180].Value = model.Proj_Nm;
//            parameters[181].Value = model.Location;
//            parameters[182].Value = model.Site_No;
//            parameters[183].Value = model.Contr_No;
//            parameters[184].Value = model.Tech_Req;
//            parameters[185].Value = model.Delivery_Mode;
//            parameters[186].Value = model.Remark;
//            parameters[187].Value = model.Truck_No;
//            parameters[188].Value = model.Driver;
//            parameters[189].Value = model.Strength;
//            parameters[190].Value = model.RecordRemark;
//            parameters[191].Value = model.SynchRemark;
//            parameters[192].Value = model.SaJiangSymbol;
//            parameters[193].Value = model.ReadState;
//            parameters[194].Value = model.Operator;
//            parameters[195].Value = model.AttemperCode;
//            parameters[196].Value = model.ProduceLine;
//            parameters[197].Value = model.Const_Unit;
//            parameters[198].Value = model.Truck_vol;
//            parameters[199].Value = model.KangShenLevel;
//            parameters[200].Value = model.TaLuoDu;
//            parameters[201].Value = model.OperationState;

//            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }


//        /// <summary>
//        /// 更新一条数据
//        /// </summary>
//        public bool Update(PeHeBI_DatabastUpdata.Model.Access_sRecords_Model model)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("update sRecords set ");
//            strSql.Append("Output_vol=@Output_vol,");
//            strSql.Append("NAM_GL1=@NAM_GL1,");
//            strSql.Append("MBZ_GL1=@MBZ_GL1,");
//            strSql.Append("CLZ_GL1=@CLZ_GL1,");
//            strSql.Append("JDZ_GL1=@JDZ_GL1,");
//            strSql.Append("XDZ_GL1=@XDZ_GL1,");
//            strSql.Append("HSL_GL1=@HSL_GL1,");
//            strSql.Append("NAM_GL2=@NAM_GL2,");
//            strSql.Append("MBZ_GL2=@MBZ_GL2,");
//            strSql.Append("CLZ_GL2=@CLZ_GL2,");
//            strSql.Append("JDZ_GL2=@JDZ_GL2,");
//            strSql.Append("XDZ_GL2=@XDZ_GL2,");
//            strSql.Append("HSL_GL2=@HSL_GL2,");
//            strSql.Append("NAM_GL3=@NAM_GL3,");
//            strSql.Append("MBZ_GL3=@MBZ_GL3,");
//            strSql.Append("CLZ_GL3=@CLZ_GL3,");
//            strSql.Append("JDZ_GL3=@JDZ_GL3,");
//            strSql.Append("XDZ_GL3=@XDZ_GL3,");
//            strSql.Append("HSL_GL3=@HSL_GL3,");
//            strSql.Append("NAM_GL4=@NAM_GL4,");
//            strSql.Append("MBZ_GL4=@MBZ_GL4,");
//            strSql.Append("CLZ_GL4=@CLZ_GL4,");
//            strSql.Append("JDZ_GL4=@JDZ_GL4,");
//            strSql.Append("XDZ_GL4=@XDZ_GL4,");
//            strSql.Append("HSL_GL4=@HSL_GL4,");
//            strSql.Append("NAM_GL5=@NAM_GL5,");
//            strSql.Append("MBZ_GL5=@MBZ_GL5,");
//            strSql.Append("CLZ_GL5=@CLZ_GL5,");
//            strSql.Append("JDZ_GL5=@JDZ_GL5,");
//            strSql.Append("XDZ_GL5=@XDZ_GL5,");
//            strSql.Append("HSL_GL5=@HSL_GL5,");
//            strSql.Append("NAM_GL6=@NAM_GL6,");
//            strSql.Append("MBZ_GL6=@MBZ_GL6,");
//            strSql.Append("CLZ_GL6=@CLZ_GL6,");
//            strSql.Append("JDZ_GL6=@JDZ_GL6,");
//            strSql.Append("XDZ_GL6=@XDZ_GL6,");
//            strSql.Append("HSL_GL6=@HSL_GL6,");
//            strSql.Append("NAM_GL7=@NAM_GL7,");
//            strSql.Append("MBZ_GL7=@MBZ_GL7,");
//            strSql.Append("CLZ_GL7=@CLZ_GL7,");
//            strSql.Append("JDZ_GL7=@JDZ_GL7,");
//            strSql.Append("XDZ_GL7=@XDZ_GL7,");
//            strSql.Append("HSL_GL7=@HSL_GL7,");
//            strSql.Append("NAM_GL8=@NAM_GL8,");
//            strSql.Append("MBZ_GL8=@MBZ_GL8,");
//            strSql.Append("CLZ_GL8=@CLZ_GL8,");
//            strSql.Append("JDZ_GL8=@JDZ_GL8,");
//            strSql.Append("XDZ_GL8=@XDZ_GL8,");
//            strSql.Append("HSL_GL8=@HSL_GL8,");
//            strSql.Append("NAM_FLA1=@NAM_FLA1,");
//            strSql.Append("MBZ_FLA1=@MBZ_FLA1,");
//            strSql.Append("CLZ_FLA1=@CLZ_FLA1,");
//            strSql.Append("JDZ_FLA1=@JDZ_FLA1,");
//            strSql.Append("XDZ_FLA1=@XDZ_FLA1,");
//            strSql.Append("NAM_FLA2=@NAM_FLA2,");
//            strSql.Append("MBZ_FLA2=@MBZ_FLA2,");
//            strSql.Append("CLZ_FLA2=@CLZ_FLA2,");
//            strSql.Append("JDZ_FLA2=@JDZ_FLA2,");
//            strSql.Append("XDZ_FLA2=@XDZ_FLA2,");
//            strSql.Append("NAM_FLA3=@NAM_FLA3,");
//            strSql.Append("MBZ_FLA3=@MBZ_FLA3,");
//            strSql.Append("CLZ_FLA3=@CLZ_FLA3,");
//            strSql.Append("JDZ_FLA3=@JDZ_FLA3,");
//            strSql.Append("XDZ_FLA3=@XDZ_FLA3,");
//            strSql.Append("NAM_FLA4=@NAM_FLA4,");
//            strSql.Append("MBZ_FLA4=@MBZ_FLA4,");
//            strSql.Append("CLZ_FLA4=@CLZ_FLA4,");
//            strSql.Append("JDZ_FLA4=@JDZ_FLA4,");
//            strSql.Append("XDZ_FLA4=@XDZ_FLA4,");
//            strSql.Append("NAM_FLB1=@NAM_FLB1,");
//            strSql.Append("MBZ_FLB1=@MBZ_FLB1,");
//            strSql.Append("CLZ_FLB1=@CLZ_FLB1,");
//            strSql.Append("JDZ_FLB1=@JDZ_FLB1,");
//            strSql.Append("XDZ_FLB1=@XDZ_FLB1,");
//            strSql.Append("NAM_FLB2=@NAM_FLB2,");
//            strSql.Append("MBZ_FLB2=@MBZ_FLB2,");
//            strSql.Append("CLZ_FLB2=@CLZ_FLB2,");
//            strSql.Append("JDZ_FLB2=@JDZ_FLB2,");
//            strSql.Append("XDZ_FLB2=@XDZ_FLB2,");
//            strSql.Append("NAM_FLB3=@NAM_FLB3,");
//            strSql.Append("MBZ_FLB3=@MBZ_FLB3,");
//            strSql.Append("CLZ_FLB3=@CLZ_FLB3,");
//            strSql.Append("JDZ_FLB3=@JDZ_FLB3,");
//            strSql.Append("XDZ_FLB3=@XDZ_FLB3,");
//            strSql.Append("NAM_FLC1=@NAM_FLC1,");
//            strSql.Append("MBZ_FLC1=@MBZ_FLC1,");
//            strSql.Append("CLZ_FLC1=@CLZ_FLC1,");
//            strSql.Append("JDZ_FLC1=@JDZ_FLC1,");
//            strSql.Append("XDZ_FLC1=@XDZ_FLC1,");
//            strSql.Append("NAM_FLC2=@NAM_FLC2,");
//            strSql.Append("MBZ_FLC2=@MBZ_FLC2,");
//            strSql.Append("CLZ_FLC2=@CLZ_FLC2,");
//            strSql.Append("JDZ_FLC2=@JDZ_FLC2,");
//            strSql.Append("XDZ_FLC2=@XDZ_FLC2,");
//            strSql.Append("NAM_WJA1=@NAM_WJA1,");
//            strSql.Append("MBZ_WJA1=@MBZ_WJA1,");
//            strSql.Append("CLZ_WJA1=@CLZ_WJA1,");
//            strSql.Append("JDZ_WJA1=@JDZ_WJA1,");
//            strSql.Append("XDZ_WJA1=@XDZ_WJA1,");
//            strSql.Append("HGL_WJA1=@HGL_WJA1,");
//            strSql.Append("NAM_WJA2=@NAM_WJA2,");
//            strSql.Append("MBZ_WJA2=@MBZ_WJA2,");
//            strSql.Append("CLZ_WJA2=@CLZ_WJA2,");
//            strSql.Append("JDZ_WJA2=@JDZ_WJA2,");
//            strSql.Append("XDZ_WJA2=@XDZ_WJA2,");
//            strSql.Append("HGL_WJA2=@HGL_WJA2,");
//            strSql.Append("NAM_WJA3=@NAM_WJA3,");
//            strSql.Append("MBZ_WJA3=@MBZ_WJA3,");
//            strSql.Append("CLZ_WJA3=@CLZ_WJA3,");
//            strSql.Append("JDZ_WJA3=@JDZ_WJA3,");
//            strSql.Append("XDZ_WJA3=@XDZ_WJA3,");
//            strSql.Append("HGL_WJA3=@HGL_WJA3,");
//            strSql.Append("NAM_WJA4=@NAM_WJA4,");
//            strSql.Append("MBZ_WJA4=@MBZ_WJA4,");
//            strSql.Append("CLZ_WJA4=@CLZ_WJA4,");
//            strSql.Append("JDZ_WJA4=@JDZ_WJA4,");
//            strSql.Append("XDZ_WJA4=@XDZ_WJA4,");
//            strSql.Append("HGL_WJA4=@HGL_WJA4,");
//            strSql.Append("NAM_WJB1=@NAM_WJB1,");
//            strSql.Append("MBZ_WJB1=@MBZ_WJB1,");
//            strSql.Append("CLZ_WJB1=@CLZ_WJB1,");
//            strSql.Append("JDZ_WJB1=@JDZ_WJB1,");
//            strSql.Append("XDZ_WJB1=@XDZ_WJB1,");
//            strSql.Append("HGL_WJB1=@HGL_WJB1,");
//            strSql.Append("NAM_WJB2=@NAM_WJB2,");
//            strSql.Append("MBZ_WJB2=@MBZ_WJB2,");
//            strSql.Append("CLZ_WJB2=@CLZ_WJB2,");
//            strSql.Append("JDZ_WJB2=@JDZ_WJB2,");
//            strSql.Append("XDZ_WJB2=@XDZ_WJB2,");
//            strSql.Append("HGL_WJB2=@HGL_WJB2,");
//            strSql.Append("NAM_WJB3=@NAM_WJB3,");
//            strSql.Append("MBZ_WJB3=@MBZ_WJB3,");
//            strSql.Append("CLZ_WJB3=@CLZ_WJB3,");
//            strSql.Append("JDZ_WJB3=@JDZ_WJB3,");
//            strSql.Append("XDZ_WJB3=@XDZ_WJB3,");
//            strSql.Append("HGL_WJB3=@HGL_WJB3,");
//            strSql.Append("NAM_WJB4=@NAM_WJB4,");
//            strSql.Append("MBZ_WJB4=@MBZ_WJB4,");
//            strSql.Append("CLZ_WJB4=@CLZ_WJB4,");
//            strSql.Append("JDZ_WJB4=@JDZ_WJB4,");
//            strSql.Append("XDZ_WJB4=@XDZ_WJB4,");
//            strSql.Append("HGL_WJB4=@HGL_WJB4,");
//            strSql.Append("NAM_WJC1=@NAM_WJC1,");
//            strSql.Append("MBZ_WJC1=@MBZ_WJC1,");
//            strSql.Append("CLZ_WJC1=@CLZ_WJC1,");
//            strSql.Append("JDZ_WJC1=@JDZ_WJC1,");
//            strSql.Append("XDZ_WJC1=@XDZ_WJC1,");
//            strSql.Append("HGL_WJC1=@HGL_WJC1,");
//            strSql.Append("NAM_WJC2=@NAM_WJC2,");
//            strSql.Append("MBZ_WJC2=@MBZ_WJC2,");
//            strSql.Append("CLZ_WJC2=@CLZ_WJC2,");
//            strSql.Append("JDZ_WJC2=@JDZ_WJC2,");
//            strSql.Append("XDZ_WJC2=@XDZ_WJC2,");
//            strSql.Append("HGL_WJC2=@HGL_WJC2,");
//            strSql.Append("NAM_WJC3=@NAM_WJC3,");
//            strSql.Append("MBZ_WJC3=@MBZ_WJC3,");
//            strSql.Append("CLZ_WJC3=@CLZ_WJC3,");
//            strSql.Append("JDZ_WJC3=@JDZ_WJC3,");
//            strSql.Append("XDZ_WJC3=@XDZ_WJC3,");
//            strSql.Append("HGL_WJC3=@HGL_WJC3,");
//            strSql.Append("NAM_WJC4=@NAM_WJC4,");
//            strSql.Append("MBZ_WJC4=@MBZ_WJC4,");
//            strSql.Append("CLZ_WJC4=@CLZ_WJC4,");
//            strSql.Append("JDZ_WJC4=@JDZ_WJC4,");
//            strSql.Append("XDZ_WJC4=@XDZ_WJC4,");
//            strSql.Append("HGL_WJC4=@HGL_WJC4,");
//            strSql.Append("NAM_Shui1=@NAM_Shui1,");
//            strSql.Append("MBZ_Shui1=@MBZ_Shui1,");
//            strSql.Append("CLZ_Shui1=@CLZ_Shui1,");
//            strSql.Append("JDZ_Shui1=@JDZ_Shui1,");
//            strSql.Append("XDZ_Shui1=@XDZ_Shui1,");
//            strSql.Append("NAM_Shui2=@NAM_Shui2,");
//            strSql.Append("MBZ_Shui2=@MBZ_Shui2,");
//            strSql.Append("CLZ_Shui2=@CLZ_Shui2,");
//            strSql.Append("JDZ_Shui2=@JDZ_Shui2,");
//            strSql.Append("XDZ_Shui2=@XDZ_Shui2,");
//            strSql.Append("Job_No=@Job_No,");
//            strSql.Append("Prop_No=@Prop_No,");
//            strSql.Append("Cust_Nm=@Cust_Nm,");
//            strSql.Append("Proj_Nm=@Proj_Nm,");
//            strSql.Append("Location=@Location,");
//            strSql.Append("Site_No=@Site_No,");
//            strSql.Append("Contr_No=@Contr_No,");
//            strSql.Append("Tech_Req=@Tech_Req,");
//            strSql.Append("Delivery_Mode=@Delivery_Mode,");
//            strSql.Append("Remark=@Remark,");
//            strSql.Append("Truck_No=@Truck_No,");
//            strSql.Append("Driver=@Driver,");
//            strSql.Append("Strength=@Strength,");
//            strSql.Append("RecordRemark=@RecordRemark,");
//            strSql.Append("SynchRemark=@SynchRemark,");
//            strSql.Append("SaJiangSymbol=@SaJiangSymbol,");
//            strSql.Append("ReadState=@ReadState,");
//            strSql.Append("Operator=@Operator,");
//            strSql.Append("AttemperCode=@AttemperCode,");
//            strSql.Append("ProduceLine=@ProduceLine,");
//            strSql.Append("Const_Unit=@Const_Unit,");
//            strSql.Append("Truck_vol=@Truck_vol,");
//            strSql.Append("KangShenLevel=@KangShenLevel,");
//            strSql.Append("TaLuoDu=@TaLuoDu,");
//            strSql.Append("OperationState=@OperationState");
//            strSql.Append(" where ScTime=@ScTime ");
//            OleDbParameter[] parameters = {
//                    new OleDbParameter("@Output_vol", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL1", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL1", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL2", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL2", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL3", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL3", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL4", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL4", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL5", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL5", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL5", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL6", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL6", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL6", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL7", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL7", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL7", OleDbType.Double),
//                    new OleDbParameter("@NAM_GL8", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@CLZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@JDZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@XDZ_GL8", OleDbType.Double),
//                    new OleDbParameter("@HSL_GL8", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA1", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA2", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA3", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLA4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLA4", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLB1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLB1", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLB2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLB2", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLB3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLB3", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLC1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLC1", OleDbType.Double),
//                    new OleDbParameter("@NAM_FLC2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_FLC2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA1", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA1", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA2", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA3", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA3", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJA4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJA4", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJA4", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB1", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB1", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB2", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB3", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB3", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJB4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJB4", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJB4", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC1", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC1", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC2", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC2", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC3", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC3", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC3", OleDbType.Double),
//                    new OleDbParameter("@NAM_WJC4", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@CLZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@JDZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@XDZ_WJC4", OleDbType.Double),
//                    new OleDbParameter("@HGL_WJC4", OleDbType.Double),
//                    new OleDbParameter("@NAM_Shui1", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@CLZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@JDZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@XDZ_Shui1", OleDbType.Double),
//                    new OleDbParameter("@NAM_Shui2", OleDbType.VarChar,60),
//                    new OleDbParameter("@MBZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@CLZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@JDZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@XDZ_Shui2", OleDbType.Double),
//                    new OleDbParameter("@Job_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Prop_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Cust_Nm", OleDbType.VarChar,50),
//                    new OleDbParameter("@Proj_Nm", OleDbType.VarChar,50),
//                    new OleDbParameter("@Location", OleDbType.VarChar,50),
//                    new OleDbParameter("@Site_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Contr_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Tech_Req", OleDbType.VarChar,50),
//                    new OleDbParameter("@Delivery_Mode", OleDbType.VarChar,50),
//                    new OleDbParameter("@Remark", OleDbType.VarChar,50),
//                    new OleDbParameter("@Truck_No", OleDbType.VarChar,50),
//                    new OleDbParameter("@Driver", OleDbType.VarChar,50),
//                    new OleDbParameter("@Strength", OleDbType.VarChar,50),
//                    new OleDbParameter("@RecordRemark", OleDbType.VarChar,50),
//                    new OleDbParameter("@SynchRemark", OleDbType.VarChar,50),
//                    new OleDbParameter("@SaJiangSymbol", OleDbType.Integer,4),
//                    new OleDbParameter("@ReadState", OleDbType.Integer,4),
//                    new OleDbParameter("@Operator", OleDbType.VarChar,50),
//                    new OleDbParameter("@AttemperCode", OleDbType.VarChar,50),
//                    new OleDbParameter("@ProduceLine", OleDbType.VarChar,50),
//                    new OleDbParameter("@Const_Unit", OleDbType.VarChar,50),
//                    new OleDbParameter("@Truck_vol", OleDbType.Double),
//                    new OleDbParameter("@KangShenLevel", OleDbType.VarChar,50),
//                    new OleDbParameter("@TaLuoDu", OleDbType.VarChar,50),
//                    new OleDbParameter("@OperationState", OleDbType.Double),
//                    new OleDbParameter("@ID", OleDbType.Integer,4),
//                    new OleDbParameter("@ScTime", OleDbType.Date)};
//            parameters[0].Value = model.Output_vol;
//            parameters[1].Value = model.NAM_GL1;
//            parameters[2].Value = model.MBZ_GL1;
//            parameters[3].Value = model.CLZ_GL1;
//            parameters[4].Value = model.JDZ_GL1;
//            parameters[5].Value = model.XDZ_GL1;
//            parameters[6].Value = model.HSL_GL1;
//            parameters[7].Value = model.NAM_GL2;
//            parameters[8].Value = model.MBZ_GL2;
//            parameters[9].Value = model.CLZ_GL2;
//            parameters[10].Value = model.JDZ_GL2;
//            parameters[11].Value = model.XDZ_GL2;
//            parameters[12].Value = model.HSL_GL2;
//            parameters[13].Value = model.NAM_GL3;
//            parameters[14].Value = model.MBZ_GL3;
//            parameters[15].Value = model.CLZ_GL3;
//            parameters[16].Value = model.JDZ_GL3;
//            parameters[17].Value = model.XDZ_GL3;
//            parameters[18].Value = model.HSL_GL3;
//            parameters[19].Value = model.NAM_GL4;
//            parameters[20].Value = model.MBZ_GL4;
//            parameters[21].Value = model.CLZ_GL4;
//            parameters[22].Value = model.JDZ_GL4;
//            parameters[23].Value = model.XDZ_GL4;
//            parameters[24].Value = model.HSL_GL4;
//            parameters[25].Value = model.NAM_GL5;
//            parameters[26].Value = model.MBZ_GL5;
//            parameters[27].Value = model.CLZ_GL5;
//            parameters[28].Value = model.JDZ_GL5;
//            parameters[29].Value = model.XDZ_GL5;
//            parameters[30].Value = model.HSL_GL5;
//            parameters[31].Value = model.NAM_GL6;
//            parameters[32].Value = model.MBZ_GL6;
//            parameters[33].Value = model.CLZ_GL6;
//            parameters[34].Value = model.JDZ_GL6;
//            parameters[35].Value = model.XDZ_GL6;
//            parameters[36].Value = model.HSL_GL6;
//            parameters[37].Value = model.NAM_GL7;
//            parameters[38].Value = model.MBZ_GL7;
//            parameters[39].Value = model.CLZ_GL7;
//            parameters[40].Value = model.JDZ_GL7;
//            parameters[41].Value = model.XDZ_GL7;
//            parameters[42].Value = model.HSL_GL7;
//            parameters[43].Value = model.NAM_GL8;
//            parameters[44].Value = model.MBZ_GL8;
//            parameters[45].Value = model.CLZ_GL8;
//            parameters[46].Value = model.JDZ_GL8;
//            parameters[47].Value = model.XDZ_GL8;
//            parameters[48].Value = model.HSL_GL8;
//            parameters[49].Value = model.NAM_FLA1;
//            parameters[50].Value = model.MBZ_FLA1;
//            parameters[51].Value = model.CLZ_FLA1;
//            parameters[52].Value = model.JDZ_FLA1;
//            parameters[53].Value = model.XDZ_FLA1;
//            parameters[54].Value = model.NAM_FLA2;
//            parameters[55].Value = model.MBZ_FLA2;
//            parameters[56].Value = model.CLZ_FLA2;
//            parameters[57].Value = model.JDZ_FLA2;
//            parameters[58].Value = model.XDZ_FLA2;
//            parameters[59].Value = model.NAM_FLA3;
//            parameters[60].Value = model.MBZ_FLA3;
//            parameters[61].Value = model.CLZ_FLA3;
//            parameters[62].Value = model.JDZ_FLA3;
//            parameters[63].Value = model.XDZ_FLA3;
//            parameters[64].Value = model.NAM_FLA4;
//            parameters[65].Value = model.MBZ_FLA4;
//            parameters[66].Value = model.CLZ_FLA4;
//            parameters[67].Value = model.JDZ_FLA4;
//            parameters[68].Value = model.XDZ_FLA4;
//            parameters[69].Value = model.NAM_FLB1;
//            parameters[70].Value = model.MBZ_FLB1;
//            parameters[71].Value = model.CLZ_FLB1;
//            parameters[72].Value = model.JDZ_FLB1;
//            parameters[73].Value = model.XDZ_FLB1;
//            parameters[74].Value = model.NAM_FLB2;
//            parameters[75].Value = model.MBZ_FLB2;
//            parameters[76].Value = model.CLZ_FLB2;
//            parameters[77].Value = model.JDZ_FLB2;
//            parameters[78].Value = model.XDZ_FLB2;
//            parameters[79].Value = model.NAM_FLB3;
//            parameters[80].Value = model.MBZ_FLB3;
//            parameters[81].Value = model.CLZ_FLB3;
//            parameters[82].Value = model.JDZ_FLB3;
//            parameters[83].Value = model.XDZ_FLB3;
//            parameters[84].Value = model.NAM_FLC1;
//            parameters[85].Value = model.MBZ_FLC1;
//            parameters[86].Value = model.CLZ_FLC1;
//            parameters[87].Value = model.JDZ_FLC1;
//            parameters[88].Value = model.XDZ_FLC1;
//            parameters[89].Value = model.NAM_FLC2;
//            parameters[90].Value = model.MBZ_FLC2;
//            parameters[91].Value = model.CLZ_FLC2;
//            parameters[92].Value = model.JDZ_FLC2;
//            parameters[93].Value = model.XDZ_FLC2;
//            parameters[94].Value = model.NAM_WJA1;
//            parameters[95].Value = model.MBZ_WJA1;
//            parameters[96].Value = model.CLZ_WJA1;
//            parameters[97].Value = model.JDZ_WJA1;
//            parameters[98].Value = model.XDZ_WJA1;
//            parameters[99].Value = model.HGL_WJA1;
//            parameters[100].Value = model.NAM_WJA2;
//            parameters[101].Value = model.MBZ_WJA2;
//            parameters[102].Value = model.CLZ_WJA2;
//            parameters[103].Value = model.JDZ_WJA2;
//            parameters[104].Value = model.XDZ_WJA2;
//            parameters[105].Value = model.HGL_WJA2;
//            parameters[106].Value = model.NAM_WJA3;
//            parameters[107].Value = model.MBZ_WJA3;
//            parameters[108].Value = model.CLZ_WJA3;
//            parameters[109].Value = model.JDZ_WJA3;
//            parameters[110].Value = model.XDZ_WJA3;
//            parameters[111].Value = model.HGL_WJA3;
//            parameters[112].Value = model.NAM_WJA4;
//            parameters[113].Value = model.MBZ_WJA4;
//            parameters[114].Value = model.CLZ_WJA4;
//            parameters[115].Value = model.JDZ_WJA4;
//            parameters[116].Value = model.XDZ_WJA4;
//            parameters[117].Value = model.HGL_WJA4;
//            parameters[118].Value = model.NAM_WJB1;
//            parameters[119].Value = model.MBZ_WJB1;
//            parameters[120].Value = model.CLZ_WJB1;
//            parameters[121].Value = model.JDZ_WJB1;
//            parameters[122].Value = model.XDZ_WJB1;
//            parameters[123].Value = model.HGL_WJB1;
//            parameters[124].Value = model.NAM_WJB2;
//            parameters[125].Value = model.MBZ_WJB2;
//            parameters[126].Value = model.CLZ_WJB2;
//            parameters[127].Value = model.JDZ_WJB2;
//            parameters[128].Value = model.XDZ_WJB2;
//            parameters[129].Value = model.HGL_WJB2;
//            parameters[130].Value = model.NAM_WJB3;
//            parameters[131].Value = model.MBZ_WJB3;
//            parameters[132].Value = model.CLZ_WJB3;
//            parameters[133].Value = model.JDZ_WJB3;
//            parameters[134].Value = model.XDZ_WJB3;
//            parameters[135].Value = model.HGL_WJB3;
//            parameters[136].Value = model.NAM_WJB4;
//            parameters[137].Value = model.MBZ_WJB4;
//            parameters[138].Value = model.CLZ_WJB4;
//            parameters[139].Value = model.JDZ_WJB4;
//            parameters[140].Value = model.XDZ_WJB4;
//            parameters[141].Value = model.HGL_WJB4;
//            parameters[142].Value = model.NAM_WJC1;
//            parameters[143].Value = model.MBZ_WJC1;
//            parameters[144].Value = model.CLZ_WJC1;
//            parameters[145].Value = model.JDZ_WJC1;
//            parameters[146].Value = model.XDZ_WJC1;
//            parameters[147].Value = model.HGL_WJC1;
//            parameters[148].Value = model.NAM_WJC2;
//            parameters[149].Value = model.MBZ_WJC2;
//            parameters[150].Value = model.CLZ_WJC2;
//            parameters[151].Value = model.JDZ_WJC2;
//            parameters[152].Value = model.XDZ_WJC2;
//            parameters[153].Value = model.HGL_WJC2;
//            parameters[154].Value = model.NAM_WJC3;
//            parameters[155].Value = model.MBZ_WJC3;
//            parameters[156].Value = model.CLZ_WJC3;
//            parameters[157].Value = model.JDZ_WJC3;
//            parameters[158].Value = model.XDZ_WJC3;
//            parameters[159].Value = model.HGL_WJC3;
//            parameters[160].Value = model.NAM_WJC4;
//            parameters[161].Value = model.MBZ_WJC4;
//            parameters[162].Value = model.CLZ_WJC4;
//            parameters[163].Value = model.JDZ_WJC4;
//            parameters[164].Value = model.XDZ_WJC4;
//            parameters[165].Value = model.HGL_WJC4;
//            parameters[166].Value = model.NAM_Shui1;
//            parameters[167].Value = model.MBZ_Shui1;
//            parameters[168].Value = model.CLZ_Shui1;
//            parameters[169].Value = model.JDZ_Shui1;
//            parameters[170].Value = model.XDZ_Shui1;
//            parameters[171].Value = model.NAM_Shui2;
//            parameters[172].Value = model.MBZ_Shui2;
//            parameters[173].Value = model.CLZ_Shui2;
//            parameters[174].Value = model.JDZ_Shui2;
//            parameters[175].Value = model.XDZ_Shui2;
//            parameters[176].Value = model.Job_No;
//            parameters[177].Value = model.Prop_No;
//            parameters[178].Value = model.Cust_Nm;
//            parameters[179].Value = model.Proj_Nm;
//            parameters[180].Value = model.Location;
//            parameters[181].Value = model.Site_No;
//            parameters[182].Value = model.Contr_No;
//            parameters[183].Value = model.Tech_Req;
//            parameters[184].Value = model.Delivery_Mode;
//            parameters[185].Value = model.Remark;
//            parameters[186].Value = model.Truck_No;
//            parameters[187].Value = model.Driver;
//            parameters[188].Value = model.Strength;
//            parameters[189].Value = model.RecordRemark;
//            parameters[190].Value = model.SynchRemark;
//            parameters[191].Value = model.SaJiangSymbol;
//            parameters[192].Value = model.ReadState;
//            parameters[193].Value = model.Operator;
//            parameters[194].Value = model.AttemperCode;
//            parameters[195].Value = model.ProduceLine;
//            parameters[196].Value = model.Const_Unit;
//            parameters[197].Value = model.Truck_vol;
//            parameters[198].Value = model.KangShenLevel;
//            parameters[199].Value = model.TaLuoDu;
//            parameters[200].Value = model.OperationState;
//            parameters[201].Value = model.ID;
//            parameters[202].Value = model.ScTime;

//            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        /// <summary>
//        /// 删除一条数据
//        /// </summary>
//        public bool Delete(DateTime ScTime)
//        {

//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("delete from sRecords ");
//            strSql.Append(" where ScTime=@ScTime ");
//            OleDbParameter[] parameters = {
//                    new OleDbParameter("@ScTime", OleDbType.Date)           };
//            parameters[0].Value = ScTime;

//            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        /// <summary>
//        /// 批量删除数据
//        /// </summary>
//        public bool DeleteList(string ScTimelist)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("delete from sRecords ");
//            strSql.Append(" where ScTime in (" + ScTimelist + ")  ");
//            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }


//        /// <summary>
//        /// 得到一个对象实体
//        /// </summary>
//        public PeHeBI_DatabastUpdata.Model.Access_sRecords_Model GetModel(int Id)
//        {

//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("select ID,ScTime,Output_vol,NAM_GL1,MBZ_GL1,CLZ_GL1,JDZ_GL1,XDZ_GL1,HSL_GL1,NAM_GL2,MBZ_GL2,CLZ_GL2,JDZ_GL2,XDZ_GL2,HSL_GL2,NAM_GL3,MBZ_GL3,CLZ_GL3,JDZ_GL3,XDZ_GL3,HSL_GL3,NAM_GL4,MBZ_GL4,CLZ_GL4,JDZ_GL4,XDZ_GL4,HSL_GL4,NAM_GL5,MBZ_GL5,CLZ_GL5,JDZ_GL5,XDZ_GL5,HSL_GL5,NAM_GL6,MBZ_GL6,CLZ_GL6,JDZ_GL6,XDZ_GL6,HSL_GL6,NAM_GL7,MBZ_GL7,CLZ_GL7,JDZ_GL7,XDZ_GL7,HSL_GL7,NAM_GL8,MBZ_GL8,CLZ_GL8,JDZ_GL8,XDZ_GL8,HSL_GL8,NAM_FLA1,MBZ_FLA1,CLZ_FLA1,JDZ_FLA1,XDZ_FLA1,NAM_FLA2,MBZ_FLA2,CLZ_FLA2,JDZ_FLA2,XDZ_FLA2,NAM_FLA3,MBZ_FLA3,CLZ_FLA3,JDZ_FLA3,XDZ_FLA3,NAM_FLA4,MBZ_FLA4,CLZ_FLA4,JDZ_FLA4,XDZ_FLA4,NAM_FLB1,MBZ_FLB1,CLZ_FLB1,JDZ_FLB1,XDZ_FLB1,NAM_FLB2,MBZ_FLB2,CLZ_FLB2,JDZ_FLB2,XDZ_FLB2,NAM_FLB3,MBZ_FLB3,CLZ_FLB3,JDZ_FLB3,XDZ_FLB3,NAM_FLC1,MBZ_FLC1,CLZ_FLC1,JDZ_FLC1,XDZ_FLC1,NAM_FLC2,MBZ_FLC2,CLZ_FLC2,JDZ_FLC2,XDZ_FLC2,NAM_WJA1,MBZ_WJA1,CLZ_WJA1,JDZ_WJA1,XDZ_WJA1,HGL_WJA1,NAM_WJA2,MBZ_WJA2,CLZ_WJA2,JDZ_WJA2,XDZ_WJA2,HGL_WJA2,NAM_WJA3,MBZ_WJA3,CLZ_WJA3,JDZ_WJA3,XDZ_WJA3,HGL_WJA3,NAM_WJA4,MBZ_WJA4,CLZ_WJA4,JDZ_WJA4,XDZ_WJA4,HGL_WJA4,NAM_WJB1,MBZ_WJB1,CLZ_WJB1,JDZ_WJB1,XDZ_WJB1,HGL_WJB1,NAM_WJB2,MBZ_WJB2,CLZ_WJB2,JDZ_WJB2,XDZ_WJB2,HGL_WJB2,NAM_WJB3,MBZ_WJB3,CLZ_WJB3,JDZ_WJB3,XDZ_WJB3,HGL_WJB3,NAM_WJB4,MBZ_WJB4,CLZ_WJB4,JDZ_WJB4,XDZ_WJB4,HGL_WJB4,NAM_WJC1,MBZ_WJC1,CLZ_WJC1,JDZ_WJC1,XDZ_WJC1,HGL_WJC1,NAM_WJC2,MBZ_WJC2,CLZ_WJC2,JDZ_WJC2,XDZ_WJC2,HGL_WJC2,NAM_WJC3,MBZ_WJC3,CLZ_WJC3,JDZ_WJC3,XDZ_WJC3,HGL_WJC3,NAM_WJC4,MBZ_WJC4,CLZ_WJC4,JDZ_WJC4,XDZ_WJC4,HGL_WJC4,NAM_Shui1,MBZ_Shui1,CLZ_Shui1,JDZ_Shui1,XDZ_Shui1,NAM_Shui2,MBZ_Shui2,CLZ_Shui2,JDZ_Shui2,XDZ_Shui2,Job_No,Prop_No,Cust_Nm,Proj_Nm,Location,Site_No,Contr_No,Tech_Req,Delivery_Mode,Remark,Truck_No,Driver,Strength,RecordRemark,SynchRemark,SaJiangSymbol,ReadState,Operator,AttemperCode,ProduceLine,Const_Unit,Truck_vol,KangShenLevel,TaLuoDu,OperationState from sRecords ");
//            strSql.Append(" where ID=@Id ");
//            OleDbParameter[] parameters = {
//                    new OleDbParameter("@Id", OleDbType.Integer)           };
//            parameters[0].Value = Id;

//            PeHeBI_DatabastUpdata.Model.Access_sRecords_Model model = new PeHeBI_DatabastUpdata.Model.Access_sRecords_Model();
//            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
//            if (ds.Tables[0].Rows.Count > 0)
//            {
//                return DataRowToModel(ds.Tables[0].Rows[0]);
//            }
//            else
//            {
//                return null;
//            }
//        }


//        /// <summary>
//        /// 得到一个对象实体
//        /// </summary>
//        //public PeHeBI_DatabastUpdata.Model.Access_sRecords_Model DataRowToModel(DataRow row)
//        //{
//        //    PeHeBI_DatabastUpdata.Model.Access_sRecords_Model model = new PeHeBI_DatabastUpdata.Model.Access_sRecords_Model();
//        //    if (row != null)
//        //    {
//        //        if (row["ID"] != null && row["ID"].ToString() != "")
//        //        {
//        //            model.ID = int.Parse(row["ID"].ToString());
//        //        }
//        //        if (row["ScTime"] != null && row["ScTime"].ToString() != "")
//        //        {
//        //            model.ScTime = row["ScTime"].ToString();
//        //        }
//        //        model.Output_vol = row["Output_vol"].ToString();
//        //        if (row["NAM_GL1"] != null)
//        //        {
//        //            model.NAM_GL1 = row["NAM_GL1"].ToString();
//        //        }
//        //        model.MBZ_GL1 = row["MBZ_GL1"].ToString();
//        //        model.CLZ_GL1 = row["CLZ_GL1"].ToString();
//        //        model.JDZ_GL1 = row["JDZ_GL1"].ToString();
//        //        model.XDZ_GL1 = row["XDZ_GL1"].ToString();
//        //        model.HSL_GL1 = row["HSL_GL1"].ToString();
//        //        if (row["NAM_GL2"] != null)
//        //        {
//        //            model.NAM_GL2 = row["NAM_GL2"].ToString();
//        //        }
//        //        model.MBZ_GL2 = row["MBZ_GL2"].ToString();
//        //        model.CLZ_GL2 = row["CLZ_GL2"].ToString();
//        //        model.JDZ_GL2 = row["JDZ_GL2"].ToString();
//        //        model.XDZ_GL2 = row["XDZ_GL2"].ToString();
//        //        model.HSL_GL2 = row["HSL_GL2"].ToString();
//        //        if (row["NAM_GL3"] != null)
//        //        {
//        //            model.NAM_GL3 = row["NAM_GL3"].ToString();
//        //        }
//        //        model.MBZ_GL3 = row["MBZ_GL3"].ToString();
//        //        model.CLZ_GL3 = row["CLZ_GL3"].ToString();
//        //        model.JDZ_GL3 = row["JDZ_GL3"].ToString();
//        //        model.XDZ_GL3 = row["XDZ_GL3"].ToString();
//        //        model.HSL_GL3 = row["HSL_GL3"].ToString();
//        //        if (row["NAM_GL4"] != null)
//        //        {
//        //            model.NAM_GL4 = row["NAM_GL4"].ToString();
//        //        }
//        //        model.MBZ_GL4 = row["MBZ_GL4"].ToString();
//        //        model.CLZ_GL4 = row["CLZ_GL4"].ToString();
//        //        model.JDZ_GL4 = row["JDZ_GL4"].ToString();
//        //        model.XDZ_GL4 = row["XDZ_GL4"].ToString();
//        //        model.HSL_GL4 = row["HSL_GL4"].ToString();
//        //        if (row["NAM_GL5"] != null)
//        //        {
//        //            model.NAM_GL5 = row["NAM_GL5"].ToString();
//        //        }
//        //        model.MBZ_GL5 = row["MBZ_GL5"].ToString();
//        //        model.CLZ_GL5 = row["CLZ_GL5"].ToString();
//        //        model.JDZ_GL5 = row["JDZ_GL5"].ToString();
//        //        model.XDZ_GL5 = row["XDZ_GL5"].ToString();
//        //        model.HSL_GL5 = row["HSL_GL5"].ToString();
//        //        if (row["NAM_GL6"] != null)
//        //        {
//        //            model.NAM_GL6 = row["NAM_GL6"].ToString();
//        //        }
//        //        model.MBZ_GL6 = row["MBZ_GL6"].ToString();
//        //        model.CLZ_GL6 = row["CLZ_GL6"].ToString();
//        //        model.JDZ_GL6 = row["JDZ_GL6"].ToString();
//        //        model.XDZ_GL6 = row["XDZ_GL6"].ToString();
//        //        model.HSL_GL6 = row["HSL_GL6"].ToString();
//        //        if (row["NAM_GL7"] != null)
//        //        {
//        //            model.NAM_GL7 = row["NAM_GL7"].ToString();
//        //        }
//        //        model.MBZ_GL7 = row["MBZ_GL7"].ToString();
//        //        model.CLZ_GL7 = row["CLZ_GL7"].ToString();
//        //        model.JDZ_GL7 = row["JDZ_GL7"].ToString();
//        //        model.XDZ_GL7 = row["XDZ_GL7"].ToString();
//        //        model.HSL_GL7 = row["HSL_GL7"].ToString();
//        //        if (row["NAM_GL8"] != null)
//        //        {
//        //            model.NAM_GL8 = row["NAM_GL8"].ToString();
//        //        }
//        //        model.MBZ_GL8 = row["MBZ_GL8"].ToString();
//        //        model.CLZ_GL8 = row["CLZ_GL8"].ToString();
//        //        model.JDZ_GL8 = row["JDZ_GL8"].ToString();
//        //        model.XDZ_GL8 = row["XDZ_GL8"].ToString();
//        //        model.HSL_GL8 = row["HSL_GL8"].ToString();
//        //        if (row["NAM_FLA1"] != null)
//        //        {
//        //            model.NAM_FLA1 = row["NAM_FLA1"].ToString();
//        //        }
//        //        model.MBZ_FLA1 = row["MBZ_FLA1"].ToString();
//        //        model.CLZ_FLA1 = row["CLZ_FLA1"].ToString();
//        //        model.JDZ_FLA1 = row["JDZ_FLA1"].ToString();
//        //        model.XDZ_FLA1 = row["XDZ_FLA1"].ToString();
//        //        if (row["NAM_FLA2"] != null)
//        //        {
//        //            model.NAM_FLA2 = row["NAM_FLA2"].ToString();
//        //        }
//        //        model.MBZ_FLA2 = row["MBZ_FLA2"].ToString();
//        //        model.CLZ_FLA2 = row["CLZ_FLA2"].ToString();
//        //        model.JDZ_FLA2 = row["JDZ_FLA2"].ToString();
//        //        model.XDZ_FLA2 = row["XDZ_FLA2"].ToString();
//        //        if (row["NAM_FLA3"] != null)
//        //        {
//        //            model.NAM_FLA3 = row["NAM_FLA3"].ToString();
//        //        }
//        //        model.MBZ_FLA3 = row["MBZ_FLA3"].ToString();
//        //        model.CLZ_FLA3 = row["CLZ_FLA3"].ToString();
//        //        model.JDZ_FLA3 = row["JDZ_FLA3"].ToString();
//        //        model.XDZ_FLA3 = row["XDZ_FLA3"].ToString();
//        //        if (row["NAM_FLA4"] != null)
//        //        {
//        //            model.NAM_FLA4 = row["NAM_FLA4"].ToString();
//        //        }
//        //        model.MBZ_FLA4 = row["MBZ_FLA4"].ToString();
//        //        model.CLZ_FLA4 = row["CLZ_FLA4"].ToString();
//        //        model.JDZ_FLA4 = row["JDZ_FLA4"].ToString();
//        //        model.XDZ_FLA4 = row["XDZ_FLA4"].ToString();
//        //        if (row["NAM_FLB1"] != null)
//        //        {
//        //            model.NAM_FLB1 = row["NAM_FLB1"].ToString();
//        //        }
//        //        model.MBZ_FLB1 = row["MBZ_FLB1"].ToString();
//        //        model.CLZ_FLB1 = row["CLZ_FLB1"].ToString();
//        //        model.JDZ_FLB1 = row["JDZ_FLB1"].ToString();
//        //        model.XDZ_FLB1 = row["XDZ_FLB1"].ToString();
//        //        if (row["NAM_FLB2"] != null)
//        //        {
//        //            model.NAM_FLB2 = row["NAM_FLB2"].ToString();
//        //        }
//        //        model.MBZ_FLB2 = row["MBZ_FLB2"].ToString();
//        //        model.CLZ_FLB2 = row["CLZ_FLB2"].ToString();
//        //        model.JDZ_FLB2 = row["JDZ_FLB2"].ToString();
//        //        model.XDZ_FLB2 = row["XDZ_FLB2"].ToString();
//        //        if (row["NAM_FLB3"] != null)
//        //        {
//        //            model.NAM_FLB3 = row["NAM_FLB3"].ToString();
//        //        }
//        //        model.MBZ_FLB3 = row["MBZ_FLB3"].ToString();
//        //        model.CLZ_FLB3 = row["CLZ_FLB3"].ToString();
//        //        model.JDZ_FLB3 = row["JDZ_FLB3"].ToString();
//        //        model.XDZ_FLB3 = row["XDZ_FLB3"].ToString();
//        //        if (row["NAM_FLC1"] != null)
//        //        {
//        //            model.NAM_FLC1 = row["NAM_FLC1"].ToString();
//        //        }
//        //        model.MBZ_FLC1 = row["MBZ_FLC1"].ToString();
//        //        model.CLZ_FLC1 = row["CLZ_FLC1"].ToString();
//        //        model.JDZ_FLC1 = row["JDZ_FLC1"].ToString();
//        //        model.XDZ_FLC1 = row["XDZ_FLC1"].ToString();
//        //        if (row["NAM_FLC2"] != null)
//        //        {
//        //            model.NAM_FLC2 = row["NAM_FLC2"].ToString();
//        //        }
//        //        model.MBZ_FLC2 = row["MBZ_FLC2"].ToString();
//        //        model.CLZ_FLC2 = row["CLZ_FLC2"].ToString();
//        //        model.JDZ_FLC2 = row["JDZ_FLC2"].ToString();
//        //        model.XDZ_FLC2 = row["XDZ_FLC2"].ToString();
//        //        if (row["NAM_WJA1"] != null)
//        //        {
//        //            model.NAM_WJA1 = row["NAM_WJA1"].ToString();
//        //        }
//        //        model.MBZ_WJA1 = row["MBZ_WJA1"].ToString();
//        //        model.CLZ_WJA1 = row["CLZ_WJA1"].ToString();
//        //        model.JDZ_WJA1 = row["JDZ_WJA1"].ToString();
//        //        model.XDZ_WJA1 = row["XDZ_WJA1"].ToString();
//        //        model.HGL_WJA1 = row["HGL_WJA1"].ToString();
//        //        if (row["NAM_WJA2"] != null)
//        //        {
//        //            model.NAM_WJA2 = row["NAM_WJA2"].ToString();
//        //        }
//        //        model.MBZ_WJA2 = row["MBZ_WJA2"].ToString();
//        //        model.CLZ_WJA2 = row["CLZ_WJA2"].ToString();
//        //        model.JDZ_WJA2 = row["JDZ_WJA2"].ToString();
//        //        model.XDZ_WJA2 = row["XDZ_WJA2"].ToString();
//        //        model.HGL_WJA2 = row["HGL_WJA2"].ToString();
//        //        if (row["NAM_WJA3"] != null)
//        //        {
//        //            model.NAM_WJA3 = row["NAM_WJA3"].ToString();
//        //        }
//        //        model.MBZ_WJA3 = row["MBZ_WJA3"].ToString();
//        //        model.CLZ_WJA3 = row["CLZ_WJA3"].ToString();
//        //        model.JDZ_WJA3 = row["JDZ_WJA3"].ToString();
//        //        model.XDZ_WJA3 = row["XDZ_WJA3"].ToString();
//        //        model.HGL_WJA3 = row["HGL_WJA3"].ToString();
//        //        if (row["NAM_WJA4"] != null)
//        //        {
//        //            model.NAM_WJA4 = row["NAM_WJA4"].ToString();
//        //        }
//        //        model.MBZ_WJA4 = row["MBZ_WJA4"].ToString();
//        //        model.CLZ_WJA4 = row["CLZ_WJA4"].ToString();
//        //        model.JDZ_WJA4 = row["JDZ_WJA4"].ToString();
//        //        model.XDZ_WJA4 = row["XDZ_WJA4"].ToString();
//        //        model.HGL_WJA4 = row["HGL_WJA4"].ToString();
//        //        if (row["NAM_WJB1"] != null)
//        //        {
//        //            model.NAM_WJB1 = row["NAM_WJB1"].ToString();
//        //        }
//        //        model.MBZ_WJB1 = row["MBZ_WJB1"].ToString();
//        //        model.CLZ_WJB1 = row["CLZ_WJB1"].ToString();
//        //        model.JDZ_WJB1 = row["JDZ_WJB1"].ToString();
//        //        model.XDZ_WJB1 = row["XDZ_WJB1"].ToString();
//        //        model.HGL_WJB1 = row["HGL_WJB1"].ToString();
//        //        if (row["NAM_WJB2"] != null)
//        //        {
//        //            model.NAM_WJB2 = row["NAM_WJB2"].ToString();
//        //        }
//        //        model.MBZ_WJB2 = row["MBZ_WJB2"].ToString();
//        //        model.CLZ_WJB2 = row["CLZ_WJB2"].ToString();
//        //        model.JDZ_WJB2 = row["JDZ_WJB2"].ToString();
//        //        model.XDZ_WJB2 = row["XDZ_WJB2"].ToString();
//        //        model.HGL_WJB2 = row["HGL_WJB2"].ToString();
//        //        if (row["NAM_WJB3"] != null)
//        //        {
//        //            model.NAM_WJB3 = row["NAM_WJB3"].ToString();
//        //        }
//        //        model.MBZ_WJB3 = row["MBZ_WJB3"].ToString();
//        //        model.CLZ_WJB3 = row["CLZ_WJB3"].ToString();
//        //        model.JDZ_WJB3 = row["JDZ_WJB3"].ToString();
//        //        model.XDZ_WJB3 = row["XDZ_WJB3"].ToString();
//        //        model.HGL_WJB3 = row["HGL_WJB3"].ToString();
//        //        if (row["NAM_WJB4"] != null)
//        //        {
//        //            model.NAM_WJB4 = row["NAM_WJB4"].ToString();
//        //        }
//        //        model.MBZ_WJB4 = row["MBZ_WJB4"].ToString();
//        //        model.CLZ_WJB4 = row["CLZ_WJB4"].ToString();
//        //        model.JDZ_WJB4 = row["JDZ_WJB4"].ToString();
//        //        model.XDZ_WJB4 = row["XDZ_WJB4"].ToString();
//        //        model.HGL_WJB4 = row["HGL_WJB4"].ToString();
//        //        if (row["NAM_WJC1"] != null)
//        //        {
//        //            model.NAM_WJC1 = row["NAM_WJC1"].ToString();
//        //        }
//        //        model.MBZ_WJC1 = row["MBZ_WJC1"].ToString();
//        //        model.CLZ_WJC1 = row["CLZ_WJC1"].ToString();
//        //        model.JDZ_WJC1 = row["JDZ_WJC1"].ToString();
//        //        model.XDZ_WJC1 = row["XDZ_WJC1"].ToString();
//        //        model.HGL_WJC1 = row["HGL_WJC1"].ToString();
//        //        if (row["NAM_WJC2"] != null)
//        //        {
//        //            model.NAM_WJC2 = row["NAM_WJC2"].ToString();
//        //        }
//        //        model.MBZ_WJC2 = row["MBZ_WJC2"].ToString();
//        //        model.CLZ_WJC2 = row["CLZ_WJC2"].ToString();
//        //        model.JDZ_WJC2 = row["JDZ_WJC2"].ToString();
//        //        model.XDZ_WJC2 = row["XDZ_WJC2"].ToString();
//        //        model.HGL_WJC2 = row["HGL_WJC2"].ToString();
//        //        if (row["NAM_WJC3"] != null)
//        //        {
//        //            model.NAM_WJC3 = row["NAM_WJC3"].ToString();
//        //        }
//        //        model.MBZ_WJC3 = row["MBZ_WJC3"].ToString();
//        //        model.CLZ_WJC3 = row["CLZ_WJC3"].ToString();
//        //        model.JDZ_WJC3 = row["JDZ_WJC3"].ToString();
//        //        model.XDZ_WJC3 = row["XDZ_WJC3"].ToString();
//        //        model.HGL_WJC3 = row["HGL_WJC3"].ToString();
//        //        if (row["NAM_WJC4"] != null)
//        //        {
//        //            model.NAM_WJC4 = row["NAM_WJC4"].ToString();
//        //        }
//        //        model.MBZ_WJC4 = row["MBZ_WJC4"].ToString();
//        //        model.CLZ_WJC4 = row["CLZ_WJC4"].ToString();
//        //        model.JDZ_WJC4 = row["JDZ_WJC4"].ToString();
//        //        model.XDZ_WJC4 = row["XDZ_WJC4"].ToString();
//        //        model.HGL_WJC4 = row["HGL_WJC4"].ToString();
//        //        if (row["NAM_Shui1"] != null)
//        //        {
//        //            model.NAM_Shui1 = row["NAM_Shui1"].ToString();
//        //        }
//        //        model.MBZ_Shui1 = row["MBZ_Shui1"].ToString();
//        //        model.CLZ_Shui1 = row["CLZ_Shui1"].ToString();
//        //        model.JDZ_Shui1 = row["JDZ_Shui1"].ToString();
//        //        model.XDZ_Shui1 = row["XDZ_Shui1"].ToString();
//        //        if (row["NAM_Shui2"] != null)
//        //        {
//        //            model.NAM_Shui2 = row["NAM_Shui2"].ToString();
//        //        }
//        //        model.MBZ_Shui2 = row["MBZ_Shui2"].ToString();
//        //        model.CLZ_Shui2 = row["CLZ_Shui2"].ToString();
//        //        model.JDZ_Shui2 = row["JDZ_Shui2"].ToString();
//        //        model.XDZ_Shui2 = row["XDZ_Shui2"].ToString();
//        //        if (row["Job_No"] != null)
//        //        {
//        //            model.Job_No = row["Job_No"].ToString();
//        //        }
//        //        if (row["Prop_No"] != null)
//        //        {
//        //            model.Prop_No = row["Prop_No"].ToString();
//        //        }
//        //        if (row["Cust_Nm"] != null)
//        //        {
//        //            model.Cust_Nm = row["Cust_Nm"].ToString();
//        //        }
//        //        if (row["Proj_Nm"] != null)
//        //        {
//        //            model.Proj_Nm = row["Proj_Nm"].ToString();
//        //        }
//        //        if (row["Location"] != null)
//        //        {
//        //            model.Location = row["Location"].ToString();
//        //        }
//        //        if (row["Site_No"] != null)
//        //        {
//        //            model.Site_No = row["Site_No"].ToString();
//        //        }
//        //        if (row["Contr_No"] != null)
//        //        {
//        //            model.Contr_No = row["Contr_No"].ToString();
//        //        }
//        //        if (row["Tech_Req"] != null)
//        //        {
//        //            model.Tech_Req = row["Tech_Req"].ToString();
//        //        }
//        //        if (row["Delivery_Mode"] != null)
//        //        {
//        //            model.Delivery_Mode = row["Delivery_Mode"].ToString();
//        //        }
//        //        if (row["Remark"] != null)
//        //        {
//        //            model.Remark = row["Remark"].ToString();
//        //        }
//        //        if (row["Truck_No"] != null)
//        //        {
//        //            model.Truck_No = row["Truck_No"].ToString();
//        //        }
//        //        if (row["Driver"] != null)
//        //        {
//        //            model.Driver = row["Driver"].ToString();
//        //        }
//        //        if (row["Strength"] != null)
//        //        {
//        //            model.Strength = row["Strength"].ToString();
//        //        }
//        //        if (row["RecordRemark"] != null)
//        //        {
//        //            model.RecordRemark = row["RecordRemark"].ToString();
//        //        }
//        //        if (row["SynchRemark"] != null)
//        //        {
//        //            model.SynchRemark = row["SynchRemark"].ToString();
//        //        }
//        //        if (row["SaJiangSymbol"] != null && row["SaJiangSymbol"].ToString() != "")
//        //        {
//        //            model.SaJiangSymbol = int.Parse(row["SaJiangSymbol"].ToString());
//        //        }
//        //        if (row["ReadState"] != null && row["ReadState"].ToString() != "")
//        //        {
//        //            model.ReadState = int.Parse(row["ReadState"].ToString());
//        //        }
//        //        if (row["Operator"] != null)
//        //        {
//        //            model.Operator = row["Operator"].ToString();
//        //        }
//        //        if (row["AttemperCode"] != null)
//        //        {
//        //            model.AttemperCode = row["AttemperCode"].ToString();
//        //        }
//        //        if (row["ProduceLine"] != null)
//        //        {
//        //            model.ProduceLine = row["ProduceLine"].ToString();
//        //        }
//        //        if (row["Const_Unit"] != null)
//        //        {
//        //            model.Const_Unit = row["Const_Unit"].ToString();
//        //        }
//        //        model.Truck_vol = row["Truck_vol"].ToString();
//        //        if (row["KangShenLevel"] != null)
//        //        {
//        //            model.KangShenLevel = row["KangShenLevel"].ToString();
//        //        }
//        //        if (row["TaLuoDu"] != null)
//        //        {
//        //            model.TaLuoDu = row["TaLuoDu"].ToString();
//        //        }
//        //        model.OperationState = row["OperationState"].ToString();
//        //    }
//        //    return model;
//        //}

       

//        /// <summary>
//        /// 获取记录总数
//        /// </summary>
//        public int GetRecordCount(string strWhere)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("select count(1) FROM sRecords ");
//            if (strWhere.Trim() != "")
//            {
//                strSql.Append(" where " + strWhere);
//            }
//            object obj = DbHelperSQL.GetSingle(strSql.ToString());
//            if (obj == null)
//            {
//                return 0;
//            }
//            else
//            {
//                return Convert.ToInt32(obj);
//            }
//        }
//        /// <summary>
//        /// 分页获取数据列表
//        /// </summary>
//        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("SELECT * FROM ( ");
//            strSql.Append(" SELECT ROW_NUMBER() OVER (");
//            if (!string.IsNullOrEmpty(orderby.Trim()))
//            {
//                strSql.Append("order by T." + orderby);
//            }
//            else
//            {
//                strSql.Append("order by T.ScTime desc");
//            }
//            strSql.Append(")AS Row, T.*  from sRecords T ");
//            if (!string.IsNullOrEmpty(strWhere.Trim()))
//            {
//                strSql.Append(" WHERE " + strWhere);
//            }
//            strSql.Append(" ) TT");
//            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
//            return DbHelperOleDb.Query(strSql.ToString());
//        }

//        public IEnumerable<Access_sRecords_Model> GetList(string sql, object parameters, string ConnectionString)
//        {
//            OleDb_help oleDb_Help = new OleDb_help();

//            IEnumerable<Access_sRecords_Model> Ev = oleDb_Help.GetList<Access_sRecords_Model>(sql, parameters, ConnectionString);
//            //System.Collections.Generic.IEnumerable<TSource> source)
//             return Ev;

//        }
//        /// <summary>
//        /// 获得数据列表
//        /// </summary>
//        public DataSet GetList(string strWhere)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("select ID,ScTime,Output_vol,NAM_GL1,MBZ_GL1,CLZ_GL1,JDZ_GL1,XDZ_GL1,HSL_GL1,NAM_GL2,MBZ_GL2,CLZ_GL2,JDZ_GL2,XDZ_GL2,HSL_GL2,NAM_GL3,MBZ_GL3,CLZ_GL3,JDZ_GL3,XDZ_GL3,HSL_GL3,NAM_GL4,MBZ_GL4,CLZ_GL4,JDZ_GL4,XDZ_GL4,HSL_GL4,NAM_GL5,MBZ_GL5,CLZ_GL5,JDZ_GL5,XDZ_GL5,HSL_GL5,NAM_GL6,MBZ_GL6,CLZ_GL6,JDZ_GL6,XDZ_GL6,HSL_GL6,NAM_GL7,MBZ_GL7,CLZ_GL7,JDZ_GL7,XDZ_GL7,HSL_GL7,NAM_GL8,MBZ_GL8,CLZ_GL8,JDZ_GL8,XDZ_GL8,HSL_GL8,NAM_FLA1,MBZ_FLA1,CLZ_FLA1,JDZ_FLA1,XDZ_FLA1,NAM_FLA2,MBZ_FLA2,CLZ_FLA2,JDZ_FLA2,XDZ_FLA2,NAM_FLA3,MBZ_FLA3,CLZ_FLA3,JDZ_FLA3,XDZ_FLA3,NAM_FLA4,MBZ_FLA4,CLZ_FLA4,JDZ_FLA4,XDZ_FLA4,NAM_FLB1,MBZ_FLB1,CLZ_FLB1,JDZ_FLB1,XDZ_FLB1,NAM_FLB2,MBZ_FLB2,CLZ_FLB2,JDZ_FLB2,XDZ_FLB2,NAM_FLB3,MBZ_FLB3,CLZ_FLB3,JDZ_FLB3,XDZ_FLB3,NAM_FLC1,MBZ_FLC1,CLZ_FLC1,JDZ_FLC1,XDZ_FLC1,NAM_FLC2,MBZ_FLC2,CLZ_FLC2,JDZ_FLC2,XDZ_FLC2,NAM_WJA1,MBZ_WJA1,CLZ_WJA1,JDZ_WJA1,XDZ_WJA1,HGL_WJA1,NAM_WJA2,MBZ_WJA2,CLZ_WJA2,JDZ_WJA2,XDZ_WJA2,HGL_WJA2,NAM_WJA3,MBZ_WJA3,CLZ_WJA3,JDZ_WJA3,XDZ_WJA3,HGL_WJA3,NAM_WJA4,MBZ_WJA4,CLZ_WJA4,JDZ_WJA4,XDZ_WJA4,HGL_WJA4,NAM_WJB1,MBZ_WJB1,CLZ_WJB1,JDZ_WJB1,XDZ_WJB1,HGL_WJB1,NAM_WJB2,MBZ_WJB2,CLZ_WJB2,JDZ_WJB2,XDZ_WJB2,HGL_WJB2,NAM_WJB3,MBZ_WJB3,CLZ_WJB3,JDZ_WJB3,XDZ_WJB3,HGL_WJB3,NAM_WJB4,MBZ_WJB4,CLZ_WJB4,JDZ_WJB4,XDZ_WJB4,HGL_WJB4,NAM_WJC1,MBZ_WJC1,CLZ_WJC1,JDZ_WJC1,XDZ_WJC1,HGL_WJC1,NAM_WJC2,MBZ_WJC2,CLZ_WJC2,JDZ_WJC2,XDZ_WJC2,HGL_WJC2,NAM_WJC3,MBZ_WJC3,CLZ_WJC3,JDZ_WJC3,XDZ_WJC3,HGL_WJC3,NAM_WJC4,MBZ_WJC4,CLZ_WJC4,JDZ_WJC4,XDZ_WJC4,HGL_WJC4,NAM_Shui1,MBZ_Shui1,CLZ_Shui1,JDZ_Shui1,XDZ_Shui1,NAM_Shui2,MBZ_Shui2,CLZ_Shui2,JDZ_Shui2,XDZ_Shui2,Job_No,Prop_No,Cust_Nm,Proj_Nm,Location,Site_No,Contr_No,Tech_Req,Delivery_Mode,Remark,Truck_No,Driver,Strength,RecordRemark,SynchRemark,SaJiangSymbol,ReadState,Operator,AttemperCode,ProduceLine,Const_Unit,Truck_vol,KangShenLevel,TaLuoDu,OperationState ");
//            strSql.Append(" FROM sRecords ");
//            if (strWhere.Trim() != "")
//            {
//                strSql.Append(" where " + strWhere);
//            }
//            return DbHelperOleDb.Query(strSql.ToString());
//        }

//        /*
//		/// <summary>
//		/// 分页获取数据列表
//		/// </summary>
//		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
//		{
//			OleDbParameter[] parameters = {
//					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
//					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
//					new OleDbParameter("@PageSize", OleDbType.Integer),
//					new OleDbParameter("@PageIndex", OleDbType.Integer),
//					new OleDbParameter("@IsReCount", OleDbType.Boolean),
//					new OleDbParameter("@OrderType", OleDbType.Boolean),
//					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
//					};
//			parameters[0].Value = "sRecords";
//			parameters[1].Value = "ScTime";
//			parameters[2].Value = PageSize;
//			parameters[3].Value = PageIndex;
//			parameters[4].Value = 0;
//			parameters[5].Value = 0;
//			parameters[6].Value = strWhere;	
//			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
//		}*/

//        #endregion  BasicMethod


//        #region  ExtensionMethod

//        #endregion  ExtensionMethod
//    }
//}

