/**  版本信息模板在安装目录下，可自行修改。
* tb_navigation.cs
* model
* 功 能： N/A
* 类 名： tb_navigation
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
	/// tb_navigation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_navigation
	{
		public tb_navigation()
		{}
		#region Model
		private int _Id;
		private string _MenuName;
		private string _Pagelogo;
		private int _ParentId;
		private string _LinkAddress;
		private string _Icon;
		private int _Sort;
		private int _IsShow;


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
		public string MenuName
		{
			set{ _MenuName=value;}
			get{return _MenuName;}
		}
		/// <summary>
		///
		/// <summary>
		public string Pagelogo
		{
			set{ _Pagelogo=value;}
			get{return _Pagelogo;}
		}
		/// <summary>
		///
		/// <summary>
		public int ParentId
		{
			set{ _ParentId=value;}
			get{return _ParentId;}
		}
		/// <summary>
		///
		/// <summary>
		public string LinkAddress
		{
			set{ _LinkAddress=value;}
			get{return _LinkAddress;}
		}
		/// <summary>
		///
		/// <summary>
		public string Icon
		{
			set{ _Icon=value;}
			get{return _Icon;}
		}
		/// <summary>
		///
		/// <summary>
		public int Sort
		{
			set{ _Sort=value;}
			get{return _Sort;}
		}
		/// <summary>
		///
		/// <summary>
		public int IsShow
		{
			set{ _IsShow=value;}
			get{return _IsShow;}
		}

 
		#endregion Model

	}
}

