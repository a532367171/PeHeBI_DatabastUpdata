using PeHeBI_DatabastUpdata.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.common
{
    public static class ModleHelper
    {

        public static pr_PeiHeBi_Model Sqlite_sRecords_Model_To_pr_PeiHeBi_Model(Sqlite_sRecords_Model sqlite_SRecords_Model)
        {
            pr_PeiHeBi_Model pr_Pei= new pr_PeiHeBi_Model();
            pr_Pei.cJBLnode = "01";
            pr_Pei.cjingshi = "";
            pr_Pei.nJianBan = 120m;
            pr_Pei.cManufacture = "中铁十四局福州管片厂";
            pr_Pei.cOrderCode = "";
            pr_Pei.cPHBnode = sqlite_SRecords_Model.Job_No;
            pr_Pei.cPHBUUID= System.Guid.NewGuid().ToString();
            pr_Pei.cXLDnode = sqlite_SRecords_Model.AttemperCode;
            pr_Pei.dCaiJI = sqlite_SRecords_Model.ScTime;
            pr_Pei.nFangLiang = (decimal)sqlite_SRecords_Model.Output_vol;
            pr_Pei.nFenMeiHu = (decimal)sqlite_SRecords_Model.CLZ_FLB2;
            pr_Pei.nFenMeiHu_SZ = (decimal)sqlite_SRecords_Model.MBZ_FLB2;
            pr_Pei.nKuangFen = (decimal)sqlite_SRecords_Model.CLZ_FLB1;
            pr_Pei.nKuangFen_SZ = (decimal)sqlite_SRecords_Model.MBZ_FLB1;
            pr_Pei.nSha1= (decimal)sqlite_SRecords_Model.CLZ_GL4;
            pr_Pei.nSha1_SZ = (decimal)sqlite_SRecords_Model.MBZ_GL4;
            pr_Pei.nShi1 = (decimal)sqlite_SRecords_Model.CLZ_GL1;
            pr_Pei.nShi1_SZ = (decimal)sqlite_SRecords_Model.MBZ_GL1;
            pr_Pei.nShi2 = (decimal)sqlite_SRecords_Model.CLZ_GL2;
            pr_Pei.nShi2_SZ= (decimal)sqlite_SRecords_Model.MBZ_GL2;
            pr_Pei.nShuii = (decimal)sqlite_SRecords_Model.CLZ_Shui1 + (decimal)sqlite_SRecords_Model.CLZ_Shui2;
            pr_Pei.nShuii_SZ = (decimal)sqlite_SRecords_Model.MBZ_Shui1 + (decimal)sqlite_SRecords_Model.MBZ_Shui2;
            pr_Pei.nShuiNi = (decimal)sqlite_SRecords_Model.CLZ_FLA1 + (decimal)sqlite_SRecords_Model.CLZ_FLA2 + (decimal)sqlite_SRecords_Model.CLZ_FLA3;
            pr_Pei.nShuiNi_SZ = (decimal)sqlite_SRecords_Model.MBZ_FLA1 + (decimal)sqlite_SRecords_Model.MBZ_FLA2 + (decimal)sqlite_SRecords_Model.MBZ_FLA3;
            pr_Pei.nWaiJiaJi1 = (decimal)sqlite_SRecords_Model.CLZ_WJA1;
            pr_Pei.nWaiJiaJi1_SZ = (decimal)sqlite_SRecords_Model.MBZ_WJA1;
            pr_Pei.nWaiJiaJi2 = (decimal)sqlite_SRecords_Model.CLZ_WJB1;
            pr_Pei.nWaiJiaJi2_SZ = (decimal)sqlite_SRecords_Model.MBZ_WJB1;
            return pr_Pei;
        }
    }
}
