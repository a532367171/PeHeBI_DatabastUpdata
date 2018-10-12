//using System;
//using System.Data;
//using System.Collections.Generic;
//using PeHeBI_DatabastUpdata.Model;
//using System.Collections;

//namespace PeHeBI_DatabastUpdata.BLL
//{
//   /// <summary>
//   /// sRecords
//   /// </summary>
//    public partial class Access_sRecords_BLL
//    {
//        private readonly PeHeBI_DatabastUpdata.DAL.Access_sRecords_DAL1 dal = new PeHeBI_DatabastUpdata.DAL.Access_sRecords_DAL1();
//        public Access_sRecords_BLL()
//        { }
//        #region  BasicMethod
//        /// <summary>
//        /// 是否存在该记录
//        /// </summary>
//        public bool Exists(string id)
//        {
//            return dal.Exists(id);

//        }

//        /// <summary>
//        /// 增加一条数据
//        /// </summary>
//        public bool Add(PeHeBI_DatabastUpdata.Model.Access_sRecords_Model model)
//        {
//            return dal.Add(model);
//        }

//        /// <summary>
//        /// 更新一条数据
//        /// </summary>
//        public bool Update(PeHeBI_DatabastUpdata.Model.Access_sRecords_Model model)
//        {
//            return dal.Update(model);
//        }

//        /// <summary>
//        /// 删除一条数据
//        /// </summary>
//        public bool Delete(DateTime ScTime)
//        {

//            return dal.Delete(ScTime);
//        }
//        /// <summary>
//        /// 删除一条数据
//        /// </summary>
//        public bool DeleteList(string ScTimelist)
//        {
//            return dal.DeleteList(ScTimelist);
//        }

//        /// <summary>
//        /// 得到一个对象实体
//        /// </summary>
//        public PeHeBI_DatabastUpdata.Model.Access_sRecords_Model GetModel(int Id)
//        {

//            return dal.GetModel(Id);
//        }

//        public ArrayList GetModels(int StartId, int lastId)
//        {

//            return dal.GetModels(StartId, lastId);
//        }

//        /// <summary>
//        /// 得到一个对象实体，从缓存中
//        /// </summary>
//        //public PeHeBI_DatabastUpdata.Model.Access_sRecords_Model GetModelByCache(DateTime ScTime)
//        //{

//        //    string CacheKey = "sRecordsModel-" + ScTime;
//        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
//        //    if (objModel == null)
//        //    {
//        //        try
//        //        {
//        //            objModel = dal.GetModel(ScTime);
//        //            if (objModel != null)
//        //            {
//        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
//        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
//        //            }
//        //        }
//        //        catch { }
//        //    }
//        //    return (PeHeBI_DatabastUpdata.Model.Access_sRecords_Model)objModel;
//        //}

//        /// <summary>
//        /// 获得数据列表
//        /// </summary>
//        public DataSet GetList(string strWhere)
//        {
//            return dal.GetList(strWhere);
//        }
//        /// <summary>
//        /// 获得数据列表
//        /// </summary>
//        public List<PeHeBI_DatabastUpdata.Model.Access_sRecords_Model> GetModelList(string strWhere)
//        {
//            DataSet ds = dal.GetList(strWhere);
//            return DataTableToList(ds.Tables[0]);
//        }
//        /// <summary>
//        /// 获得数据列表
//        /// </summary>
//        //public List<PeHeBI_DatabastUpdata.Model.Access_sRecords_Model> DataTableToList(DataTable dt)
//        //{
//        //    List<PeHeBI_DatabastUpdata.Model.Access_sRecords_Model> modelList = new List<PeHeBI_DatabastUpdata.Model.Access_sRecords_Model>();
//        //    int rowsCount = dt.Rows.Count;
//        //    if (rowsCount > 0)
//        //    {
//        //        PeHeBI_DatabastUpdata.Model.Access_sRecords_Model model;
//        //        for (int n = 0; n < rowsCount; n++)
//        //        {
//        //            model = dal.DataRowToModel(dt.Rows[n]);
//        //            if (model != null)
//        //            {
//        //                modelList.Add(model);
//        //            }
//        //        }
//        //    }
//        //    return modelList;
//        //}

//        /// <summary>
//        /// 获得数据列表
//        /// </summary>
//        public DataSet GetAllList()
//        {
//            return GetList("");
//        }

//        /// <summary>
//        /// 分页获取数据列表
//        /// </summary>
//        public int GetRecordCount(string strWhere)
//        {
//            return dal.GetRecordCount(strWhere);
//        }
//        /// <summary>
//        /// 分页获取数据列表
//        /// </summary>
//        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
//        {
//            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
//        }
//        /// <summary>
//        /// 分页获取数据列表
//        /// </summary>
//        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
//        //{
//        //return dal.GetList(PageSize,PageIndex,strWhere);
//        //}

//        #endregion  BasicMethod
//        #region  ExtensionMethod

//        #endregion  ExtensionMethod
//    }
//}
