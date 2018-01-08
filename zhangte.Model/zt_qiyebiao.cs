/**  版本信息模板在安装目录下，可自行修改。
* zt_qiyebiao.cs
* model
* 功 能： N/A
* 类 名： zt_qiyebiao
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/12/27   N/A    初版
*
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：宁波大学科技学院 　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace zhangte.Model
{
	/// <summary>
	/// zt_qiyebiao:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class zt_qiyebiao
	{
		public zt_qiyebiao()
		{}
		#region Model
		private int _Id;
		private string _企业标识代码;
		private string _登录密码;
		private string _企业名称;
		private string _企业类别;
		private string _联系方式;
		private string _发货地址;
		private string _信用等级;


		/// <summary>
		///
		/// <summary>
		public int Id
		{
			set{ _Id=value;}
			get{return _Id;}
		}
		/// <summary>
		///
		/// <summary>
		public string 企业标识代码
		{
			set{ _企业标识代码=value;}
			get{return _企业标识代码;}
		}
		/// <summary>
		///
		/// <summary>
		public string 登录密码
		{
			set{ _登录密码=value;}
			get{return _登录密码;}
		}
		/// <summary>
		///
		/// <summary>
		public string 企业名称
		{
			set{ _企业名称=value;}
			get{return _企业名称;}
		}
		/// <summary>
		///
		/// <summary>
		public string 企业类别
		{
			set{ _企业类别=value;}
			get{return _企业类别;}
		}
		/// <summary>
		///
		/// <summary>
		public string 联系方式
		{
			set{ _联系方式=value;}
			get{return _联系方式;}
		}
		/// <summary>
		///
		/// <summary>
		public string 发货地址
		{
			set{ _发货地址=value;}
			get{return _发货地址;}
		}
		/// <summary>
		///
		/// <summary>
		public string 信用等级
		{
			set{ _信用等级=value;}
			get{return _信用等级;}
		}

 
		#endregion Model

	}
}

