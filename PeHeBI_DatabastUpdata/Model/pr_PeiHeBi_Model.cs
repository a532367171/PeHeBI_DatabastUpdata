using PeHeBI_DatabastUpdata.common.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.Model
{


    [Serializable]
    [TableName("pr_PeiHeBi")]
    [Description("配合比表")]
    public class pr_PeiHeBi_Model
    {

        /// <summary>
        /// JBLpid
        /// </summary>		
        private int _jblpid;
        public int JBLpid
        {
            get { return _jblpid; }
            set { _jblpid = value; }
        }
        /// <summary>
        /// cJBLnode
        /// </summary>		
        private string _cjblnode;
        public string cJBLnode
        {
            get { return _cjblnode; }
            set { _cjblnode = value; }
        }
        /// <summary>
        /// cXLDnode
        /// </summary>		
        private string _cxldnode;
        public string cXLDnode
        {
            get { return _cxldnode; }
            set { _cxldnode = value; }
        }
        /// <summary>
        /// cPHBnode
        /// </summary>		
        private string _cphbnode;
        public string cPHBnode
        {
            get { return _cphbnode; }
            set { _cphbnode = value; }
        }
        /// <summary>
        /// nFangLiang
        /// </summary>		
        private decimal _nfangliang;
        public decimal nFangLiang
        {
            get { return _nfangliang; }
            set { _nfangliang = value; }
        }
        /// <summary>
        /// nShuiNi
        /// </summary>		
        private decimal _nshuini;
        public decimal nShuiNi
        {
            get { return _nshuini; }
            set { _nshuini = value; }
        }

        /// <summary>
        /// nShuiNi
        /// </summary>		
        private decimal _nshuini_SZ;
        public decimal nShuiNi_SZ
        {
            get { return _nshuini_SZ; }
            set { _nshuini_SZ = value; }
        }
        /// <summary>
        /// nFenMeiHu
        /// </summary>		
        private decimal _nfenmeihu;
        public decimal nFenMeiHu
        {
            get { return _nfenmeihu; }
            set { _nfenmeihu = value; }
        }

        /// <summary>
        /// nFenMeiHu_SZ
        /// </summary>		
        private decimal _nfenmeihu_SZ;
        public decimal nFenMeiHu_SZ
        {
            get { return _nfenmeihu_SZ; }
            set { _nfenmeihu_SZ = value; }
        }


        /// <summary>
        /// nKuangFen
        /// </summary>		
        private decimal _nkuangfen;
        public decimal nKuangFen
        {
            get { return _nkuangfen; }
            set { _nkuangfen = value; }
        }

        /// <summary>
        /// nKuangFen_SZ
        /// </summary>		
        private decimal _nkuangfen_SZ;
        public decimal nKuangFen_SZ
        {
            get { return _nkuangfen_SZ; }
            set { _nkuangfen_SZ = value; }
        }


        /// <summary>
        /// nShi1
        /// </summary>		
        private decimal _nshi1;
        public decimal nShi1
        {
            get { return _nshi1; }
            set { _nshi1 = value; }
        }

        /// <summary>
        /// nShi1_SZ
        /// </summary>		
        private decimal _nshi1_SZ;
        public decimal nShi1_SZ
        {
            get { return _nshi1_SZ; }
            set { _nshi1_SZ = value; }
        }

        /// <summary>
        /// nShi2
        /// </summary>		
        private decimal _nshi2;
        public decimal nShi2
        {
            get { return _nshi2; }
            set { _nshi2 = value; }
        }

        /// <summary>
        /// nShi2_SZ
        /// </summary>		
        private decimal _nshi2_SZ;
        public decimal nShi2_SZ
        {
            get { return _nshi2_SZ; }
            set { _nshi2_SZ = value; }
        }


        /// <summary>
        /// nSha1
        /// </summary>		
        private decimal _nsha1;
        public decimal nSha1
        {
            get { return _nsha1; }
            set { _nsha1 = value; }
        }

        /// <summary>
        /// nSha1_SZ
        /// </summary>		
        private decimal _nsha1_SZ;
        public decimal nSha1_SZ
        {
            get { return _nsha1_SZ; }
            set { _nsha1_SZ = value; }
        }

        /// <summary>
        /// nSha2
        /// </summary>		
        private decimal _nsha2;
        public decimal nSha2
        {
            get { return _nsha2; }
            set { _nsha2 = value; }
        }

        /// <summary>
        /// nSha2_SZ
        /// </summary>		
        private decimal _nsha2_SZ;
        public decimal nSha2_SZ
        {
            get { return _nsha2_SZ; }
            set { _nsha2_SZ = value; }
        }


        /// <summary>
        /// nWaiJiaJi1
        /// </summary>		
        private decimal _nwaijiaji1;
        public decimal nWaiJiaJi1
        {
            get { return _nwaijiaji1; }
            set { _nwaijiaji1 = value; }
        }

        /// <summary>
        /// nWaiJiaJi1_SZ
        /// </summary>		
        private decimal _nwaijiaji1_SZ;
        public decimal nWaiJiaJi1_SZ
        {
            get { return _nwaijiaji1_SZ; }
            set { _nwaijiaji1_SZ = value; }
        }


        /// <summary>
        /// nWaiJiaJi2
        /// </summary>		
        private decimal _nwaijiaji2;
        public decimal nWaiJiaJi2
        {
            get { return _nwaijiaji2; }
            set { _nwaijiaji2 = value; }
        }

        /// <summary>
        /// nWaiJiaJi2_SZ
        /// </summary>		
        private decimal _nwaijiaji2_SZ;
        public decimal nWaiJiaJi2_SZ
        {
            get { return _nwaijiaji2_SZ; }
            set { _nwaijiaji2_SZ = value; }
        }


        /// <summary>
        /// nWaiJiaJi3
        /// </summary>		
        private decimal _nwaijiaji3;
        public decimal nWaiJiaJi3
        {
            get { return _nwaijiaji3; }
            set { _nwaijiaji3 = value; }
        }

        /// <summary>
        /// nWaiJiaJi3_SZ
        /// </summary>		
        private decimal _nwaijiaji3_SZ;
        public decimal nWaiJiaJi3_SZ
        {
            get { return _nwaijiaji3_SZ; }
            set { _nwaijiaji3_SZ = value; }
        }

        /// <summary>
        /// nShuii
        /// </summary>		
        private decimal _nshuii;
        public decimal nShuii
        {
            get { return _nshuii; }
            set { _nshuii = value; }
        }

        /// <summary>
        /// nShuii_SZ
        /// </summary>		
        private decimal _nshuii_SZ;
        public decimal nShuii_SZ
        {
            get { return _nshuii_SZ; }
            set { _nshuii_SZ = value; }
        }

        /// <summary>
        /// nJianBan
        /// </summary>		
        private decimal _njianban;
        public decimal nJianBan
        {
            get { return _njianban; }
            set { _njianban = value; }
        }
        /// <summary>
        /// dCaiJI
        /// </summary>		
        private DateTime _dcaiji;
        public DateTime dCaiJI
        {
            get { return _dcaiji; }
            set { _dcaiji = value; }
        }
        /// <summary>
        /// cPHBUUID
        /// </summary>		
        private string _cphbuuid;
        public string cPHBUUID
        {
            get { return _cphbuuid; }
            set { _cphbuuid = value; }
        }
        /// <summary>
        /// cManufacture
        /// </summary>		
        private string _cmanufacture;
        public string cManufacture
        {
            get { return _cmanufacture; }
            set { _cmanufacture = value; }
        }
        /// <summary>
        /// cjingshi
        /// </summary>		
        private string _cjingshi;
        public string cjingshi
        {
            get { return _cjingshi; }
            set { _cjingshi = value; }
        }
        /// <summary>
        /// cOrderCode
        /// </summary>		
        private string _cordercode;
        public string cOrderCode
        {
            get { return _cordercode; }
            set { _cordercode = value; }
        }

    }
}
