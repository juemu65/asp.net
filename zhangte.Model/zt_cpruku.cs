/**  版本信息模板在安装目录下，可自行修改。
* zt_cpruku.cs
* model
* 功 能： N/A
* 类 名： zt_cpruku
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/12/12   N/A    初版
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
	/// zt_cpruku:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class zt_cpruku
	{
		public zt_cpruku()
		{}
		#region Model
		private int _Id;
		private string _企业标识代码;
		private string _产品名称;
		private string _数量;
		private string _入库原因;
		private string _入库时间;


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
		public string 数量
		{
			set{ _数量=value;}
			get{return _数量;}
		}
		/// <summary>
		///
		/// <summary>
		public string 入库原因
		{
			set{ _入库原因=value;}
			get{return _入库原因;}
		}
		/// <summary>
		///
		/// <summary>
		public string 入库时间
		{
			set{ _入库时间=value;}
			get{return _入库时间;}
		}

 
		#endregion Model

	}
}

