/**  版本信息模板在安装目录下，可自行修改。
* zt_dingdan.cs
* model
* 功 能： N/A
* 类 名： zt_dingdan
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
	/// zt_dingdan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class zt_dingdan
	{
		public zt_dingdan()
		{}
		#region Model
		private int _Id;
		private string _订单编号;
		private string _企业标识代码;
		private string _用户名;
		private string _产品名称;
		private string _单价;
		private string _数量;
		private string _总价;
		private string _订单时间;
		private string _收货地址;
		private string _联系方式;
		private string _订单状态;


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
		public string 订单编号
		{
			set{ _订单编号=value;}
			get{return _订单编号;}
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
		public string 用户名
		{
			set{ _用户名=value;}
			get{return _用户名;}
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
		public string 总价
		{
			set{ _总价=value;}
			get{return _总价;}
		}
		/// <summary>
		///
		/// <summary>
		public string 订单时间
		{
			set{ _订单时间=value;}
			get{return _订单时间;}
		}
		/// <summary>
		///
		/// <summary>
		public string 收货地址
		{
			set{ _收货地址=value;}
			get{return _收货地址;}
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
		public string 订单状态
		{
			set{ _订单状态=value;}
			get{return _订单状态;}
		}

 
		#endregion Model

	}
}

