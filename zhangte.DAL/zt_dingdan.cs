﻿/**  版本信息模板在安装目录下，可自行修改。
* zt_dingdan.cs
* dal
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
using System.Data;
using System.Text;
using zhangte.Common;//Please add references
using MySql.Data.MySqlClient;

namespace zhangte.DAL
{
	/// <summary>
	/// 数据访问类:zt_dingdan
	/// </summary>
	public partial class zt_dingdan
	{
        public zt_dingdan()
		{}

		#region  add update del

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(zhangte.Model.zt_dingdan model)
		{
			StringBuilder strSql=new StringBuilder();
         
			strSql.Append("insert into zt_dingdan(");
			strSql.Append("订单编号,企业标识代码,用户名,产品名称,单价,数量,总价,订单时间,收货地址,联系方式,订单状态)  values (");
			strSql.Append("@订单编号,@企业标识代码,@用户名,@产品名称,@单价,@数量,@总价,@订单时间,@收货地址,@联系方式,@订单状态)");
			strSql.Append(";");
			MySqlParameter[] parameters = {
					new MySqlParameter("@订单编号", MySqlDbType.VarChar,255),
					new MySqlParameter("@企业标识代码", MySqlDbType.VarChar,255),
					new MySqlParameter("@用户名", MySqlDbType.VarChar,255),
					new MySqlParameter("@产品名称", MySqlDbType.VarChar,255),
					new MySqlParameter("@单价", MySqlDbType.VarChar,255),
					new MySqlParameter("@数量", MySqlDbType.VarChar,255),
					new MySqlParameter("@总价", MySqlDbType.VarChar,255),
					new MySqlParameter("@订单时间", MySqlDbType.VarChar,255),
					new MySqlParameter("@收货地址", MySqlDbType.VarChar,255),
					new MySqlParameter("@联系方式", MySqlDbType.VarChar,255),
					new MySqlParameter("@订单状态", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.订单编号;
			parameters[1].Value = model.企业标识代码;
			parameters[2].Value = model.用户名;
			parameters[3].Value = model.产品名称;
			parameters[4].Value = model.单价;
			parameters[5].Value = model.数量;
			parameters[6].Value = model.总价;
			parameters[7].Value = model.订单时间;
			parameters[8].Value = model.收货地址;
			parameters[9].Value = model.联系方式;
			parameters[10].Value = model.订单状态;


			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return rows;
			}
			else
			{
				return 0;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(zhangte.Model.zt_dingdan model)
		{
			StringBuilder strSql=new StringBuilder();

            strSql.Append("update zt_dingdan set ");
            strSql.Append("订单编号=@订单编号,");
            strSql.Append("企业标识代码=@企业标识代码,");
            strSql.Append("用户名=@用户名,");
            strSql.Append("产品名称=@产品名称,");
            strSql.Append("单价=@单价,");
            strSql.Append("数量=@数量,");
            strSql.Append("总价=@总价,");
            strSql.Append("订单时间=@订单时间,");
            strSql.Append("收货地址=@收货地址,");
            strSql.Append("联系方式=@联系方式,");
            strSql.Append("订单状态=@订单状态");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@订单编号", MySqlDbType.VarChar,255),
					new MySqlParameter("@企业标识代码", MySqlDbType.VarChar,255),
					new MySqlParameter("@用户名", MySqlDbType.VarChar,255),
					new MySqlParameter("@产品名称", MySqlDbType.VarChar,255),
					new MySqlParameter("@单价", MySqlDbType.VarChar,255),
					new MySqlParameter("@数量", MySqlDbType.VarChar,255),
					new MySqlParameter("@总价", MySqlDbType.VarChar,255),
					new MySqlParameter("@订单时间", MySqlDbType.VarChar,255),
					new MySqlParameter("@收货地址", MySqlDbType.VarChar,255),
					new MySqlParameter("@联系方式", MySqlDbType.VarChar,255),
					new MySqlParameter("@订单状态", MySqlDbType.VarChar,255),
					new MySqlParameter("@Id", MySqlDbType.Int16,6)};
			parameters[0].Value = model.订单编号;
			parameters[1].Value = model.企业标识代码;
			parameters[2].Value = model.用户名;
			parameters[3].Value = model.产品名称;
			parameters[4].Value = model.单价;
			parameters[5].Value = model.数量;
			parameters[6].Value = model.总价;
			parameters[7].Value = model.订单时间;
			parameters[8].Value = model.收货地址;
			parameters[9].Value = model.联系方式;
			parameters[10].Value = model.订单状态;
			parameters[11].Value = model.Id;

			 

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from zt_dingdan ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySql.Data.MySqlClient.MySqlDbType.Int16,11)
			};
            parameters[0].Value = Id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from zt_dingdan ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion add update del              

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        public zhangte.Model.zt_dingdan GetModel(int Id)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select   * from zt_dingdan ");
            strSql.Append(" where Id=@Id LIMIT 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySql.Data.MySqlClient.MySqlDbType.Int16,11)
			};
            parameters[0].Value = Id;

            zhangte.Model.zt_dingdan model = new zhangte.Model.zt_dingdan();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zhangte.Model.zt_dingdan DataRowToModel(DataRow row)
		{
			zhangte.Model.zt_dingdan model=new zhangte.Model.zt_dingdan();
			if (row != null)
			{
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["订单编号"] != null )
                {
                    model.订单编号 = row["订单编号"].ToString();
                }
                if (row["企业标识代码"] != null )
                {
                    model.企业标识代码 = row["企业标识代码"].ToString();
                }
                if (row["用户名"] != null )
                {
                    model.用户名 = row["用户名"].ToString();
                }
                if (row["产品名称"] != null )
                {
                    model.产品名称 = row["产品名称"].ToString();
                }
                if (row["单价"] != null )
                {
                    model.单价 = row["单价"].ToString();
                }
                if (row["数量"] != null )
                {
                    model.数量 = row["数量"].ToString();
                }
                if (row["总价"] != null )
                {
                    model.总价 = row["总价"].ToString();
                }
                if (row["订单时间"] != null )
                {
                    model.订单时间 = row["订单时间"].ToString();
                }
                if (row["收货地址"] != null )
                {
                    model.收货地址 = row["收货地址"].ToString();
                }
                if (row["联系方式"] != null )
                {
                    model.联系方式 = row["联系方式"].ToString();
                }
                if (row["订单状态"] != null )
                {
                    model.订单状态 = row["订单状态"].ToString();
                }

				
			}
			return model;
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM zt_dingdan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
                ///根据要读取的字段列表和条件 获得数据列表
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄 </param>
        /// <param name="strWhere">条件或排序，如：年龄>12 and 性别='女' order by Id desc </param>
        /// <returns></returns>
        public DataSet GetList(string columslist,string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + columslist  );
            strSql.Append(" FROM zt_dingdan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        /// <param name="Top">前几行，如：10</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <returns></returns>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
 
			strSql.Append(" * ");
			strSql.Append(" FROM zt_dingdan ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  LIMIT 0," + Top.ToString());
            }

			return DbHelperMySQL.Query(strSql.ToString());
		}
 
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        /// <param name="Top">前几行，如：10</param>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <returns></returns>
        public DataSet GetList(int Top, string columslist, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");

            strSql.Append(" " + columslist + " ");
            strSql.Append(" FROM zt_dingdan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  LIMIT 0," + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得表中的某一个值
        /// </summary>
        /// <param name="columnname">字段，如：姓名</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <returns>如果读取不到值，则返回 空字符串</returns>
        public string GetValue(string columnname, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
 
            strSql.Append(" " + columnname + " ");
            strSql.Append(" FROM zt_dingdan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DataSet ds = new DataSet();
            ds =  DbHelperMySQL.Query(strSql.ToString());
            string tempstr = "";
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                tempstr = ds.Tables[0].Rows[0][0].ToString();

            return tempstr;
        }

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM zt_dingdan ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}


        /// <summary>
        /// 根据条件和排序，开始位置和结束位置 分页获取数据列表
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        private DataSet GetListByPage(string columslist, string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("SELECT " + columslist + " FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from zt_dingdan T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

        /// <summary>
        /// 根据字段列表，条件，排序，每页记录数，页码（从1开始），分页读取记录
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <param name="PageSize">每页记录数，如：30</param>
        /// <param name="PageIndex">页码，如：2</param>
        /// <returns>返回组装好的json字符串</returns>
        public string GetListByPageColumns_tojson(string columslist, string strWhere, string orderby, int PageSize, int PageIndex)
        {
            string str = DbHelperMySQL.GetListByPageColumns_tojson(columslist, strWhere, orderby, PageSize, PageIndex, "zt_dingdan");

            return str;
        }

        /// <summary>
        /// 根据字段列表，条件，排序，读取记录
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <returns>返回组装好的json字符串</returns>
        public string GetListByColumns_tojson(string columslist, string strWhere, string orderby)
        {
            string str = DbHelperMySQL.GetListByColumns_tojson(columslist, strWhere, orderby, "zt_dingdan");

            return str;
        }


        /// <summary>
        /// 根据字段列表，条件，排序，每页记录数，页码（从1开始），分页读取记录
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <param name="PageSize">每页记录数，如：30</param>
        /// <param name="PageIndex">页码，如：2</param>
        /// <returns></returns>
        public DataSet GetListByPageColumns(string columslist, string strWhere, string orderby, int PageSize, int PageIndex)
        {
            string strsql = DbHelperMySQL.GetListByPageColumns(columslist, strWhere, orderby, PageSize, PageIndex, "zt_dingdan");
            return DbHelperMySQL.Query(strsql);
        }

        #region 根据sql语句分页函数


        /// <summary>
        /// 根据sqlstr 语句，页号和每页记录数 返回表格中一页的数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="PageSize">每页的记录数</param>
        /// <param name="PageIndex">页号，第一页是1</param>
        /// <returns>读取结果的数据集</returns>
        public DataSet GetListByPageofSql(string sql, int PageSize, int PageIndex)
        {

            int pagenum = PageIndex;
            int pagerecord = PageSize;

            DataSet ds = new DataSet();
 
            string strsql = sql;
            strsql = DbHelperMySQL.createsql(sql, pagenum, pagerecord);
            ds = DbHelperMySQL.Query(strsql);
 
            return ds;
        }
        #endregion
	}
}

