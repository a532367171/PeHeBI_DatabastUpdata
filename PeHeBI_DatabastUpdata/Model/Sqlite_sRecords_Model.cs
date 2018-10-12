using PeHeBI_DatabastUpdata.common.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.Model
{
    [Serializable]
    [TableName("sRecords")]
    [Description("配合比表")]
    public class Sqlite_sRecords_Model
    {
        public Sqlite_sRecords_Model()
            {}
        #region Model
        private int _keyid;

        private string _State;
        private string _DatabaseName;

        private int _id;
    private DateTime _sctime;
    private double? _output_vol;
    private string _nam_gl1;
    private double? _mbz_gl1;
    private double? _clz_gl1;
    private double? _jdz_gl1;
    private double? _xdz_gl1;
    private double? _hsl_gl1;
    private string _nam_gl2;
    private double? _mbz_gl2;
    private double? _clz_gl2;
    private double? _jdz_gl2;
    private double? _xdz_gl2;
    private double? _hsl_gl2;
    private string _nam_gl3;
    private double? _mbz_gl3;
    private double? _clz_gl3;
    private double? _jdz_gl3;
    private double? _xdz_gl3;
    private double? _hsl_gl3;
    private string _nam_gl4;
    private double? _mbz_gl4;
    private double? _clz_gl4;
    private double? _jdz_gl4;
    private double? _xdz_gl4;
    private double? _hsl_gl4;
    private string _nam_gl5;
    private double? _mbz_gl5;
    private double? _clz_gl5;
    private double? _jdz_gl5;
    private double? _xdz_gl5;
    private double? _hsl_gl5;
    private string _nam_gl6;
    private double? _mbz_gl6;
    private double? _clz_gl6;
    private double? _jdz_gl6;
    private double? _xdz_gl6;
    private double? _hsl_gl6;
    private string _nam_gl7;
    private double? _mbz_gl7;
    private double? _clz_gl7;
    private double? _jdz_gl7;
    private double? _xdz_gl7;
    private double? _hsl_gl7;
    private string _nam_gl8;
    private double? _mbz_gl8;
    private double? _clz_gl8;
    private double? _jdz_gl8;
    private double? _xdz_gl8;
    private double? _hsl_gl8;
    private string _nam_fla1;
    private double? _mbz_fla1;
    private double? _clz_fla1;
    private double? _jdz_fla1;
    private double? _xdz_fla1;
    private string _nam_fla2;
    private double? _mbz_fla2;
    private double? _clz_fla2;
    private double? _jdz_fla2;
    private double? _xdz_fla2;
    private string _nam_fla3;
    private double? _mbz_fla3;
    private double? _clz_fla3;
    private double? _jdz_fla3;
    private double? _xdz_fla3;
    private string _nam_fla4;
    private double? _mbz_fla4;
    private double? _clz_fla4;
    private double? _jdz_fla4;
    private double? _xdz_fla4;
    private string _nam_flb1;
    private double? _mbz_flb1;
    private double? _clz_flb1;
    private double? _jdz_flb1;
    private double? _xdz_flb1;
    private string _nam_flb2;
    private double? _mbz_flb2;
    private double? _clz_flb2;
    private double? _jdz_flb2;
    private double? _xdz_flb2;
    private string _nam_flb3;
    private double? _mbz_flb3;
    private double? _clz_flb3;
    private double? _jdz_flb3;
    private double? _xdz_flb3;
    private string _nam_flc1;
    private double? _mbz_flc1;
    private double? _clz_flc1;
    private double? _jdz_flc1;
    private double? _xdz_flc1;
    private string _nam_flc2;
    private double? _mbz_flc2;
    private double? _clz_flc2;
    private double? _jdz_flc2;
    private double? _xdz_flc2;
    private string _nam_wja1;
    private double? _mbz_wja1;
    private double? _clz_wja1;
    private double? _jdz_wja1;
    private double? _xdz_wja1;
    private double? _hgl_wja1;
    private string _nam_wja2;
    private double? _mbz_wja2;
    private double? _clz_wja2;
    private double? _jdz_wja2;
    private double? _xdz_wja2;
    private double? _hgl_wja2;
    private string _nam_wja3;
    private double? _mbz_wja3;
    private double? _clz_wja3;
    private double? _jdz_wja3;
    private double? _xdz_wja3;
    private double? _hgl_wja3;
    private string _nam_wja4;
    private double? _mbz_wja4;
    private double? _clz_wja4;
    private double? _jdz_wja4;
    private double? _xdz_wja4;
    private double? _hgl_wja4;
    private string _nam_wjb1;
    private double? _mbz_wjb1;
    private double? _clz_wjb1;
    private double? _jdz_wjb1;
    private double? _xdz_wjb1;
    private double? _hgl_wjb1;
    private string _nam_wjb2;
    private double? _mbz_wjb2;
    private double? _clz_wjb2;
    private double? _jdz_wjb2;
    private double? _xdz_wjb2;
    private double? _hgl_wjb2;
    private string _nam_wjb3;
    private double? _mbz_wjb3;
    private double? _clz_wjb3;
    private double? _jdz_wjb3;
    private double? _xdz_wjb3;
    private double? _hgl_wjb3;
    private string _nam_wjb4;
    private double? _mbz_wjb4;
    private double? _clz_wjb4;
    private double? _jdz_wjb4;
    private double? _xdz_wjb4;
    private double? _hgl_wjb4;
    private string _nam_wjc1;
    private double? _mbz_wjc1;
    private double? _clz_wjc1;
    private double? _jdz_wjc1;
    private double? _xdz_wjc1;
    private double? _hgl_wjc1;
    private string _nam_wjc2;
    private double? _mbz_wjc2;
    private double? _clz_wjc2;
    private double? _jdz_wjc2;
    private double? _xdz_wjc2;
    private double? _hgl_wjc2;
    private string _nam_wjc3;
    private double? _mbz_wjc3;
    private double? _clz_wjc3;
    private double? _jdz_wjc3;
    private double? _xdz_wjc3;
    private double? _hgl_wjc3;
    private string _nam_wjc4;
    private double? _mbz_wjc4;
    private double? _clz_wjc4;
    private double? _jdz_wjc4;
    private double? _xdz_wjc4;
    private double? _hgl_wjc4;
    private string _nam_shui1;
    private double? _mbz_shui1;
    private double? _clz_shui1;
    private double? _jdz_shui1;
    private double? _xdz_shui1;
    private string _nam_shui2;
    private double? _mbz_shui2;
    private double? _clz_shui2;
    private double? _jdz_shui2;
    private double? _xdz_shui2;
    private string _job_no;
    private string _prop_no;
    private string _cust_nm;
    private string _proj_nm;
    private string _location;
    private string _site_no;
    private string _contr_no;
    private string _tech_req;
    private string _delivery_mode;
    private string _remark;
    private string _truck_no;
    private string _driver;
    private string _strength;
    private string _recordremark;
    private string _synchremark;
    private int? _sajiangsymbol = 0;
    private int? _readstate = 0;
    private string _operator;
    private string _attempercode;
    private string _produceline;
    private string _const_unit;
    private double? _truck_vol;
    private string _kangshenlevel;
    private string _taluodu;
    private double? _operationstate;
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
    public DateTime ScTime
    {
        set { _sctime = value; }
        get { return _sctime; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? Output_vol
    {
        set { _output_vol = value; }
        get { return _output_vol; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL1
    {
        set { _nam_gl1 = value; }
        get { return _nam_gl1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL1
    {
        set { _mbz_gl1 = value; }
        get { return _mbz_gl1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL1
    {
        set { _clz_gl1 = value; }
        get { return _clz_gl1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL1
    {
        set { _jdz_gl1 = value; }
        get { return _jdz_gl1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL1
    {
        set { _xdz_gl1 = value; }
        get { return _xdz_gl1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL1
    {
        set { _hsl_gl1 = value; }
        get { return _hsl_gl1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL2
    {
        set { _nam_gl2 = value; }
        get { return _nam_gl2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL2
    {
        set { _mbz_gl2 = value; }
        get { return _mbz_gl2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL2
    {
        set { _clz_gl2 = value; }
        get { return _clz_gl2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL2
    {
        set { _jdz_gl2 = value; }
        get { return _jdz_gl2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL2
    {
        set { _xdz_gl2 = value; }
        get { return _xdz_gl2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL2
    {
        set { _hsl_gl2 = value; }
        get { return _hsl_gl2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL3
    {
        set { _nam_gl3 = value; }
        get { return _nam_gl3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL3
    {
        set { _mbz_gl3 = value; }
        get { return _mbz_gl3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL3
    {
        set { _clz_gl3 = value; }
        get { return _clz_gl3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL3
    {
        set { _jdz_gl3 = value; }
        get { return _jdz_gl3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL3
    {
        set { _xdz_gl3 = value; }
        get { return _xdz_gl3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL3
    {
        set { _hsl_gl3 = value; }
        get { return _hsl_gl3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL4
    {
        set { _nam_gl4 = value; }
        get { return _nam_gl4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL4
    {
        set { _mbz_gl4 = value; }
        get { return _mbz_gl4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL4
    {
        set { _clz_gl4 = value; }
        get { return _clz_gl4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL4
    {
        set { _jdz_gl4 = value; }
        get { return _jdz_gl4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL4
    {
        set { _xdz_gl4 = value; }
        get { return _xdz_gl4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL4
    {
        set { _hsl_gl4 = value; }
        get { return _hsl_gl4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL5
    {
        set { _nam_gl5 = value; }
        get { return _nam_gl5; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL5
    {
        set { _mbz_gl5 = value; }
        get { return _mbz_gl5; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL5
    {
        set { _clz_gl5 = value; }
        get { return _clz_gl5; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL5
    {
        set { _jdz_gl5 = value; }
        get { return _jdz_gl5; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL5
    {
        set { _xdz_gl5 = value; }
        get { return _xdz_gl5; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL5
    {
        set { _hsl_gl5 = value; }
        get { return _hsl_gl5; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL6
    {
        set { _nam_gl6 = value; }
        get { return _nam_gl6; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL6
    {
        set { _mbz_gl6 = value; }
        get { return _mbz_gl6; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL6
    {
        set { _clz_gl6 = value; }
        get { return _clz_gl6; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL6
    {
        set { _jdz_gl6 = value; }
        get { return _jdz_gl6; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL6
    {
        set { _xdz_gl6 = value; }
        get { return _xdz_gl6; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL6
    {
        set { _hsl_gl6 = value; }
        get { return _hsl_gl6; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL7
    {
        set { _nam_gl7 = value; }
        get { return _nam_gl7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL7
    {
        set { _mbz_gl7 = value; }
        get { return _mbz_gl7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL7
    {
        set { _clz_gl7 = value; }
        get { return _clz_gl7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL7
    {
        set { _jdz_gl7 = value; }
        get { return _jdz_gl7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL7
    {
        set { _xdz_gl7 = value; }
        get { return _xdz_gl7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL7
    {
        set { _hsl_gl7 = value; }
        get { return _hsl_gl7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_GL8
    {
        set { _nam_gl8 = value; }
        get { return _nam_gl8; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_GL8
    {
        set { _mbz_gl8 = value; }
        get { return _mbz_gl8; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_GL8
    {
        set { _clz_gl8 = value; }
        get { return _clz_gl8; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_GL8
    {
        set { _jdz_gl8 = value; }
        get { return _jdz_gl8; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_GL8
    {
        set { _xdz_gl8 = value; }
        get { return _xdz_gl8; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HSL_GL8
    {
        set { _hsl_gl8 = value; }
        get { return _hsl_gl8; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLA1
    {
        set { _nam_fla1 = value; }
        get { return _nam_fla1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLA1
    {
        set { _mbz_fla1 = value; }
        get { return _mbz_fla1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLA1
    {
        set { _clz_fla1 = value; }
        get { return _clz_fla1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLA1
    {
        set { _jdz_fla1 = value; }
        get { return _jdz_fla1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLA1
    {
        set { _xdz_fla1 = value; }
        get { return _xdz_fla1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLA2
    {
        set { _nam_fla2 = value; }
        get { return _nam_fla2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLA2
    {
        set { _mbz_fla2 = value; }
        get { return _mbz_fla2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLA2
    {
        set { _clz_fla2 = value; }
        get { return _clz_fla2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLA2
    {
        set { _jdz_fla2 = value; }
        get { return _jdz_fla2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLA2
    {
        set { _xdz_fla2 = value; }
        get { return _xdz_fla2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLA3
    {
        set { _nam_fla3 = value; }
        get { return _nam_fla3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLA3
    {
        set { _mbz_fla3 = value; }
        get { return _mbz_fla3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLA3
    {
        set { _clz_fla3 = value; }
        get { return _clz_fla3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLA3
    {
        set { _jdz_fla3 = value; }
        get { return _jdz_fla3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLA3
    {
        set { _xdz_fla3 = value; }
        get { return _xdz_fla3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLA4
    {
        set { _nam_fla4 = value; }
        get { return _nam_fla4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLA4
    {
        set { _mbz_fla4 = value; }
        get { return _mbz_fla4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLA4
    {
        set { _clz_fla4 = value; }
        get { return _clz_fla4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLA4
    {
        set { _jdz_fla4 = value; }
        get { return _jdz_fla4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLA4
    {
        set { _xdz_fla4 = value; }
        get { return _xdz_fla4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLB1
    {
        set { _nam_flb1 = value; }
        get { return _nam_flb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLB1
    {
        set { _mbz_flb1 = value; }
        get { return _mbz_flb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLB1
    {
        set { _clz_flb1 = value; }
        get { return _clz_flb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLB1
    {
        set { _jdz_flb1 = value; }
        get { return _jdz_flb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLB1
    {
        set { _xdz_flb1 = value; }
        get { return _xdz_flb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLB2
    {
        set { _nam_flb2 = value; }
        get { return _nam_flb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLB2
    {
        set { _mbz_flb2 = value; }
        get { return _mbz_flb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLB2
    {
        set { _clz_flb2 = value; }
        get { return _clz_flb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLB2
    {
        set { _jdz_flb2 = value; }
        get { return _jdz_flb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLB2
    {
        set { _xdz_flb2 = value; }
        get { return _xdz_flb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLB3
    {
        set { _nam_flb3 = value; }
        get { return _nam_flb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLB3
    {
        set { _mbz_flb3 = value; }
        get { return _mbz_flb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLB3
    {
        set { _clz_flb3 = value; }
        get { return _clz_flb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLB3
    {
        set { _jdz_flb3 = value; }
        get { return _jdz_flb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLB3
    {
        set { _xdz_flb3 = value; }
        get { return _xdz_flb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLC1
    {
        set { _nam_flc1 = value; }
        get { return _nam_flc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLC1
    {
        set { _mbz_flc1 = value; }
        get { return _mbz_flc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLC1
    {
        set { _clz_flc1 = value; }
        get { return _clz_flc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLC1
    {
        set { _jdz_flc1 = value; }
        get { return _jdz_flc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLC1
    {
        set { _xdz_flc1 = value; }
        get { return _xdz_flc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_FLC2
    {
        set { _nam_flc2 = value; }
        get { return _nam_flc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_FLC2
    {
        set { _mbz_flc2 = value; }
        get { return _mbz_flc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_FLC2
    {
        set { _clz_flc2 = value; }
        get { return _clz_flc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_FLC2
    {
        set { _jdz_flc2 = value; }
        get { return _jdz_flc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_FLC2
    {
        set { _xdz_flc2 = value; }
        get { return _xdz_flc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJA1
    {
        set { _nam_wja1 = value; }
        get { return _nam_wja1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJA1
    {
        set { _mbz_wja1 = value; }
        get { return _mbz_wja1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJA1
    {
        set { _clz_wja1 = value; }
        get { return _clz_wja1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJA1
    {
        set { _jdz_wja1 = value; }
        get { return _jdz_wja1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJA1
    {
        set { _xdz_wja1 = value; }
        get { return _xdz_wja1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJA1
    {
        set { _hgl_wja1 = value; }
        get { return _hgl_wja1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJA2
    {
        set { _nam_wja2 = value; }
        get { return _nam_wja2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJA2
    {
        set { _mbz_wja2 = value; }
        get { return _mbz_wja2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJA2
    {
        set { _clz_wja2 = value; }
        get { return _clz_wja2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJA2
    {
        set { _jdz_wja2 = value; }
        get { return _jdz_wja2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJA2
    {
        set { _xdz_wja2 = value; }
        get { return _xdz_wja2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJA2
    {
        set { _hgl_wja2 = value; }
        get { return _hgl_wja2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJA3
    {
        set { _nam_wja3 = value; }
        get { return _nam_wja3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJA3
    {
        set { _mbz_wja3 = value; }
        get { return _mbz_wja3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJA3
    {
        set { _clz_wja3 = value; }
        get { return _clz_wja3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJA3
    {
        set { _jdz_wja3 = value; }
        get { return _jdz_wja3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJA3
    {
        set { _xdz_wja3 = value; }
        get { return _xdz_wja3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJA3
    {
        set { _hgl_wja3 = value; }
        get { return _hgl_wja3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJA4
    {
        set { _nam_wja4 = value; }
        get { return _nam_wja4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJA4
    {
        set { _mbz_wja4 = value; }
        get { return _mbz_wja4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJA4
    {
        set { _clz_wja4 = value; }
        get { return _clz_wja4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJA4
    {
        set { _jdz_wja4 = value; }
        get { return _jdz_wja4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJA4
    {
        set { _xdz_wja4 = value; }
        get { return _xdz_wja4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJA4
    {
        set { _hgl_wja4 = value; }
        get { return _hgl_wja4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJB1
    {
        set { _nam_wjb1 = value; }
        get { return _nam_wjb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJB1
    {
        set { _mbz_wjb1 = value; }
        get { return _mbz_wjb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJB1
    {
        set { _clz_wjb1 = value; }
        get { return _clz_wjb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJB1
    {
        set { _jdz_wjb1 = value; }
        get { return _jdz_wjb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJB1
    {
        set { _xdz_wjb1 = value; }
        get { return _xdz_wjb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJB1
    {
        set { _hgl_wjb1 = value; }
        get { return _hgl_wjb1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJB2
    {
        set { _nam_wjb2 = value; }
        get { return _nam_wjb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJB2
    {
        set { _mbz_wjb2 = value; }
        get { return _mbz_wjb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJB2
    {
        set { _clz_wjb2 = value; }
        get { return _clz_wjb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJB2
    {
        set { _jdz_wjb2 = value; }
        get { return _jdz_wjb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJB2
    {
        set { _xdz_wjb2 = value; }
        get { return _xdz_wjb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJB2
    {
        set { _hgl_wjb2 = value; }
        get { return _hgl_wjb2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJB3
    {
        set { _nam_wjb3 = value; }
        get { return _nam_wjb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJB3
    {
        set { _mbz_wjb3 = value; }
        get { return _mbz_wjb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJB3
    {
        set { _clz_wjb3 = value; }
        get { return _clz_wjb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJB3
    {
        set { _jdz_wjb3 = value; }
        get { return _jdz_wjb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJB3
    {
        set { _xdz_wjb3 = value; }
        get { return _xdz_wjb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJB3
    {
        set { _hgl_wjb3 = value; }
        get { return _hgl_wjb3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJB4
    {
        set { _nam_wjb4 = value; }
        get { return _nam_wjb4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJB4
    {
        set { _mbz_wjb4 = value; }
        get { return _mbz_wjb4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJB4
    {
        set { _clz_wjb4 = value; }
        get { return _clz_wjb4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJB4
    {
        set { _jdz_wjb4 = value; }
        get { return _jdz_wjb4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJB4
    {
        set { _xdz_wjb4 = value; }
        get { return _xdz_wjb4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJB4
    {
        set { _hgl_wjb4 = value; }
        get { return _hgl_wjb4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJC1
    {
        set { _nam_wjc1 = value; }
        get { return _nam_wjc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJC1
    {
        set { _mbz_wjc1 = value; }
        get { return _mbz_wjc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJC1
    {
        set { _clz_wjc1 = value; }
        get { return _clz_wjc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJC1
    {
        set { _jdz_wjc1 = value; }
        get { return _jdz_wjc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJC1
    {
        set { _xdz_wjc1 = value; }
        get { return _xdz_wjc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJC1
    {
        set { _hgl_wjc1 = value; }
        get { return _hgl_wjc1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJC2
    {
        set { _nam_wjc2 = value; }
        get { return _nam_wjc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJC2
    {
        set { _mbz_wjc2 = value; }
        get { return _mbz_wjc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJC2
    {
        set { _clz_wjc2 = value; }
        get { return _clz_wjc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJC2
    {
        set { _jdz_wjc2 = value; }
        get { return _jdz_wjc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJC2
    {
        set { _xdz_wjc2 = value; }
        get { return _xdz_wjc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJC2
    {
        set { _hgl_wjc2 = value; }
        get { return _hgl_wjc2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJC3
    {
        set { _nam_wjc3 = value; }
        get { return _nam_wjc3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJC3
    {
        set { _mbz_wjc3 = value; }
        get { return _mbz_wjc3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJC3
    {
        set { _clz_wjc3 = value; }
        get { return _clz_wjc3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJC3
    {
        set { _jdz_wjc3 = value; }
        get { return _jdz_wjc3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJC3
    {
        set { _xdz_wjc3 = value; }
        get { return _xdz_wjc3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJC3
    {
        set { _hgl_wjc3 = value; }
        get { return _hgl_wjc3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_WJC4
    {
        set { _nam_wjc4 = value; }
        get { return _nam_wjc4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_WJC4
    {
        set { _mbz_wjc4 = value; }
        get { return _mbz_wjc4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_WJC4
    {
        set { _clz_wjc4 = value; }
        get { return _clz_wjc4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_WJC4
    {
        set { _jdz_wjc4 = value; }
        get { return _jdz_wjc4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_WJC4
    {
        set { _xdz_wjc4 = value; }
        get { return _xdz_wjc4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? HGL_WJC4
    {
        set { _hgl_wjc4 = value; }
        get { return _hgl_wjc4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_Shui1
    {
        set { _nam_shui1 = value; }
        get { return _nam_shui1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_Shui1
    {
        set { _mbz_shui1 = value; }
        get { return _mbz_shui1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_Shui1
    {
        set { _clz_shui1 = value; }
        get { return _clz_shui1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_Shui1
    {
        set { _jdz_shui1 = value; }
        get { return _jdz_shui1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_Shui1
    {
        set { _xdz_shui1 = value; }
        get { return _xdz_shui1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAM_Shui2
    {
        set { _nam_shui2 = value; }
        get { return _nam_shui2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? MBZ_Shui2
    {
        set { _mbz_shui2 = value; }
        get { return _mbz_shui2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? CLZ_Shui2
    {
        set { _clz_shui2 = value; }
        get { return _clz_shui2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? JDZ_Shui2
    {
        set { _jdz_shui2 = value; }
        get { return _jdz_shui2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? XDZ_Shui2
    {
        set { _xdz_shui2 = value; }
        get { return _xdz_shui2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Job_No
    {
        set { _job_no = value; }
        get { return _job_no; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Prop_No
    {
        set { _prop_no = value; }
        get { return _prop_no; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Cust_Nm
    {
        set { _cust_nm = value; }
        get { return _cust_nm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Proj_Nm
    {
        set { _proj_nm = value; }
        get { return _proj_nm; }
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
    public string Site_No
    {
        set { _site_no = value; }
        get { return _site_no; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Contr_No
    {
        set { _contr_no = value; }
        get { return _contr_no; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Tech_Req
    {
        set { _tech_req = value; }
        get { return _tech_req; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Delivery_Mode
    {
        set { _delivery_mode = value; }
        get { return _delivery_mode; }
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
    public string Truck_No
    {
        set { _truck_no = value; }
        get { return _truck_no; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Driver
    {
        set { _driver = value; }
        get { return _driver; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Strength
    {
        set { _strength = value; }
        get { return _strength; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string RecordRemark
    {
        set { _recordremark = value; }
        get { return _recordremark; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string SynchRemark
    {
        set { _synchremark = value; }
        get { return _synchremark; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? SaJiangSymbol
    {
        set { _sajiangsymbol = value; }
        get { return _sajiangsymbol; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? ReadState
    {
        set { _readstate = value; }
        get { return _readstate; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string Operator
    {
        set { _operator = value; }
        get { return _operator; }
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
    public string ProduceLine
    {
        set { _produceline = value; }
        get { return _produceline; }
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
    public double? Truck_vol
    {
        set { _truck_vol = value; }
        get { return _truck_vol; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string KangShenLevel
    {
        set { _kangshenlevel = value; }
        get { return _kangshenlevel; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string TaLuoDu
    {
        set { _taluodu = value; }
        get { return _taluodu; }
    }
    /// <summary>
    /// 
    /// </summary>
    public double? OperationState
    {
        set { _operationstate = value; }
        get { return _operationstate; }
    }

        public string State { get => _State; set => _State = value; }
        public string DatabaseName { get => _DatabaseName; set => _DatabaseName = value; }
        public int Keyid { get => _keyid; set => _keyid = value; }
        #endregion Model


    }
}
