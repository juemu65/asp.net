/**  版本信息模板在安装目录下，可自行修改。
* zt_chanpinbiao.cs
* model
* 功 能： N/A
* 类 名： zt_chanpinbiao
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/12/9   N/A    初版
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
	/// zt_chanpinbiao:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class zt_chanpinbiao
	{
		public zt_chanpinbiao()
		{}
		#region Model
		private int _Id;
		private string _企业标识代码;
		private string _产品名称;
		private string _单价;
		private string _数量;
		private string _单位;
		private string _图片;
		private string _状态;


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
		public string 产品名称
		{
			set{ _产品名称=value;}
			get{return _产品名称;}
		}
		/// <summary>
		///
		/// <summary>
		public string 单价
		{
			set{ _单价=value;}
			get{return _单价;}
		}
		/// <summary>
		///
		/// <summary>
		public string 数量
		{
			set{ _数量=value;}
			get{return _数量;}
		}
		/// <summary>
		///
		/// <summary>
		public string 单位
		{
			set{ _单位=value;}
			get{return _单位;}
		}
		/// <summary>
		///
		/// <summary>
		public string 图片
		{
			set{ _图片=value;}
			get{return _图片;}
		}
		/// <summary>
		///
		/// <summary>
		public string 状态
		{
			set{ _状态=value;}
			get{return _状态;}
		}

 
		#endregion Model

	}
}

