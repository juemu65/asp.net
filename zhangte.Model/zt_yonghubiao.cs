/**  版本信息模板在安装目录下，可自行修改。
* zt_yonghubiao.cs
* model
* 功 能： N/A
* 类 名： zt_yonghubiao
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/12/16   N/A    初版
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
	/// zt_yonghubiao:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class zt_yonghubiao
	{
		public zt_yonghubiao()
		{}
		#region Model
		private int _Id;
		private string _用户名;
		private string _密码;
		private string _联系方式;
		private string _收货地址;


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
		public string 用户名
		{
			set{ _用户名=value;}
			get{return _用户名;}
		}
		/// <summary>
		///
		/// <summary>
		public string 密码
		{
			set{ _密码=value;}
			get{return _密码;}
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
		public string 收货地址
		{
			set{ _收货地址=value;}
			get{return _收货地址;}
		}

 
		#endregion Model

	}
}

