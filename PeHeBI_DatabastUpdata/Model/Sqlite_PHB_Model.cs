using System.Collections.Generic;
using System;

using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.Model
{
    [Serializable]

    public partial class Sqlite_PHB_Model
    {
        public Sqlite_PHB_Model()
        { }
        #region Model
        private string _State;
        private string _Date_Name;
        private int _id;
        private string _sctime;
        private string _output_vol;

        private string _设定值_大石;
        private string _测量值_大石;

        private string _设定值_小石;
        private string _测量值_小石;

        private string _设定值_沙1;
        private string _测量值_沙1;

        private string _设定值_沙2;
        private string _测量值_沙2;

        private string _设定值_水泥1;
        private string _测量值_水泥1;

        private string _设定值_水泥2;
        private string _测量值_水泥2;

        private string _设定值_水泥3;
        private string _测量值_水泥3;


        private string _设定值_矿粉;
        private string _测量值_矿粉;

        private string _设定值_粉灰;
        private string _测量值_粉灰;

        private string _设定值_外加剂1;
        private string _测量值_外加剂1;

        private string _设定值_外加剂2;
        private string _测量值_外加剂2;


        private string _设定值_za474tta;
        private string _测量值_za474tta;

        private string _设定值_unlink;
        private string _测量值_unlink;

        private string _设定值_水m1;
        private string _测量值_水m1;

        private string _设定值_水m2;
        private string _测量值_水m2;

        private string _location;

        private string _remark;

        private string _attempercode;
        private string _const_unit;
        private string _truck_vol;


        public string Date_Name
        {
            set { _Date_Name = value; }
            get
            { return _Date_Name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ScTime
        {
            set { _sctime = value; }
            get { return _sctime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Output_vol
        {
            set { _output_vol = value; }
            get { return _output_vol; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MBZ_GL1
        {
            set { _设定值_大石 = value; }
            get { return _设定值_大石; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_GL1
        {
            set { _测量值_大石 = value; }
            get { return _测量值_大石; }
        }



        /// <summary>
        /// 
        /// </summary>
        public string MBZ_GL2
        {
            set { _设定值_小石 = value; }
            get { return _设定值_小石; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_GL2
        {
            set { _测量值_小石 = value; }
            get { return _测量值_小石; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string MBZ_GL3
        {
            set { _设定值_沙1 = value; }
            get { return _设定值_沙1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_GL3
        {
            set { _测量值_沙1 = value; }
            get { return _测量值_沙1; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string MBZ_GL4
        {
            set { _设定值_沙2 = value; }
            get { return _设定值_沙2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_GL4
        {
            set { _测量值_沙2 = value; }
            get { return _测量值_沙2; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string MBZ_FLA1
        {
            set { _设定值_水泥1 = value; }
            get { return _设定值_水泥1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_FLA1
        {
            set { _测量值_水泥1 = value; }
            get { return _测量值_水泥1; }
        }
        /// <summary>
        /// 
        /// </summary>

        /// <summary>
        /// 
        /// </summary>
        public string MBZ_FLA2
        {
            set { _设定值_水泥2 = value; }
            get { return _设定值_水泥2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_FLA2
        {
            set { _测量值_水泥2 = value; }
            get { return _测量值_水泥2; }
        }




        /// <summary>
        /// 
        /// </summary>
        public string MBZ_FLA3
        {
            set { _设定值_水泥3 = value; }
            get { return _设定值_水泥3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_FLA3
        {
            set { _测量值_水泥3 = value; }
            get { return _测量值_水泥3; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string MBZ_FLB1
        {
            set { _设定值_矿粉 = value; }
            get { return _设定值_矿粉; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_FLB1
        {
            set { _测量值_矿粉 = value; }
            get { return _测量值_矿粉; }
        }
        /// <summary>
        /// 
        /// </summary>

        /// <summary>
        /// 
        /// </summary>
        public string MBZ_FLB2
        {
            set { _设定值_粉灰 = value; }
            get { return _设定值_粉灰; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_FLB2
        {
            set { _测量值_粉灰 = value; }
            get { return _测量值_粉灰; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string MBZ_WJA1
        {
            set { _设定值_外加剂1 = value; }
            get { return _设定值_外加剂1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_WJA1
        {
            set { _测量值_外加剂1 = value; }
            get { return _测量值_外加剂1; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string MBZ_WJA2
        {
            set { _设定值_外加剂2 = value; }
            get { return _设定值_外加剂2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_WJA2
        {
            set { _测量值_外加剂2 = value; }
            get { return _测量值_外加剂2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MBZ_WJB4
        {
            set { _设定值_za474tta = value; }
            get { return _设定值_za474tta; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_WJB4
        {
            set { _测量值_za474tta = value; }
            get { return _测量值_za474tta; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MBZ_WJC4
        {
            set { _设定值_unlink = value; }
            get { return _设定值_unlink; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_WJC4
        {
            set { _测量值_unlink = value; }
            get { return _测量值_unlink; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MBZ_Shui1
        {
            set { _设定值_水m1 = value; }
            get { return _设定值_水m1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_Shui1
        {
            set { _测量值_水m1 = value; }
            get { return _测量值_水m1; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MBZ_Shui2
        {
            set { _设定值_水m2 = value; }
            get { return _设定值_水m2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLZ_Shui2
        {
            set { _测量值_水m2 = value; }
            get { return _测量值_水m2; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Location
        {
            set { _location = value; }
            get { return _location; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AttemperCode
        {
            set { _attempercode = value; }
            get { return _attempercode; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Const_Unit
        {
            set { _const_unit = value; }
            get { return _const_unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Truck_vol
        {
            set { _truck_vol = value; }
            get { return _truck_vol; }
        }

        public string State
        {
            set { _State = value; }
            get { return _State; }
        }


        #endregion Model

    }

}
