﻿/**  版本信息模板在安装目录下，可自行修改。
* tb_navigation.cs
* bll
* 功 能： N/A
* 类 名： tb_navigation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/12/9   N/A    初版
*
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：宁波大学科技学院小鹿工作室 　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using zhangte.Model;
using System.Web;

namespace zhangte.BLL
{
	/// <summary>
	/// tb_navigation
	/// </summary>
    public partial class tb_navigation : System.Web.UI.Page
    {
        private readonly zhangte.DAL.tb_navigation dal = new zhangte.DAL.tb_navigation();
 
        private string strifofpage = "";
        HttpContext thiscontext;
        public tb_navigation()
        {

        }
        public tb_navigation(HttpContext context)
        {
            thiscontext = context;
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (Session["tb_navigation"] != null)
                strifofpage = Session["tb_navigation"].ToString();
        }
        #region  add update del

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add( string MenuName, string Pagelogo, string ParentId, string LinkAddress, string Icon, string Sort, string IsShow)
        {
            zhangte.Model.tb_navigation model = new zhangte.Model.tb_navigation();
                    model.MenuName = MenuName;
                    model.Pagelogo = Pagelogo;
                    model.ParentId = int.Parse(ParentId);
                    model.LinkAddress = LinkAddress;
                    model.Icon = Icon;
                    model.Sort = int.Parse(Sort);
                    model.IsShow = int.Parse(IsShow);

            return dal.Add(model);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add1(zhangte.Model.tb_navigation model)
        {
             
            return dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string Id, string MenuName, string Pagelogo, string ParentId, string LinkAddress, string Icon, string Sort, string IsShow)
        {
            

            zhangte.Model.tb_navigation model = new zhangte.Model.tb_navigation();
            model = dal.GetModel(int.Parse(Id));
            //对于传入的model如果其中属性已经更改，则更改，否则保留原数据库中的数据。
                    model.MenuName = MenuName;
                    model.Pagelogo = Pagelogo;
                    model.ParentId = int.Parse(ParentId);
                    model.LinkAddress = LinkAddress;
                    model.Icon = Icon;
                    model.Sort = int.Parse(Sort);
                    model.IsShow = int.Parse(IsShow);


            return dal.Update(model);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update1(zhangte.Model.tb_navigation model)
        {

            return dal.Update(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {
            return dal.Delete(Id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

                
        #endregion add update del              

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public zhangte.Model.tb_navigation GetModel(int Id)
        {
            return dal.GetModel(Id);
        }
        /// <summary>
        /// 得到一个对象值系列
        /// </summary>
        public string Geteditdata(string Id)
        {
            zhangte.Model.tb_navigation model = new zhangte.Model.tb_navigation();
            model = dal.GetModel(int.Parse( Id));
            string retstr = "";

            retstr +=model.Id+"|";
            retstr +=model.MenuName+"|";
            retstr +=model.Pagelogo+"|";
            retstr +=model.ParentId+"|";
            retstr +=model.LinkAddress+"|";
            retstr +=model.Icon+"|";
            retstr +=model.Sort+"|";
            retstr +=model.IsShow+"|";

            return retstr;
        }
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public zhangte.Model.tb_navigation GetModelByCache(int Id)
        {

            string CacheKey = "tb_navigationModel-" + Id;
            object objModel = zhangte.Common.DbHelperMySQL.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Id);
                    if (objModel != null)
                    {
                        int ModelCache = zhangte.Common.DbHelperMySQL.GetConfigInt("ModelCache");
                        zhangte.Common.DbHelperMySQL.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (zhangte.Model.tb_navigation)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            if (strWhere != "" && strifofpage!="")
                strWhere = "(" + strWhere + " and " + strifofpage+") ";
            return dal.GetList(strWhere);
        }

        /// <summary>
                ///根据要读取的字段列表和条件 获得数据列表
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄 </param>
        /// <param name="strWhere">条件 ，如：年龄>12 and 性别='女'   </param>
        /// <param name="strWhere"> 排序，如：   Id desc 或  </param>   
        /// <returns></returns>
        public DataSet GetList(string columslist,string strWhere,string orderstr)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";
            if (orderstr != "")
                strWhere +=" order by "+  orderstr;
            return dal.GetList(columslist,strWhere);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        /// <param name="Top">前几行，如：10</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <returns></returns>
        public DataSet GetList(int Top, string strWhere, string orderstr)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";
 
            return dal.GetList(Top, strWhere, orderstr);
        }

                
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        /// <param name="Top">前几行，如：10</param>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <returns></returns>
        public DataSet GetList(int Top, string columslist, string strWhere, string orderstr)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            return dal.GetList(Top, columslist, strWhere, orderstr);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<zhangte.Model.tb_navigation> GetModelList(string strWhere)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<zhangte.Model.tb_navigation> DataTableToList(DataTable dt)
        {
            List<zhangte.Model.tb_navigation> modelList = new List<zhangte.Model.tb_navigation>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                zhangte.Model.tb_navigation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    DataRow row = dt.Rows[n];
                    model = dal.DataRowToModel(row);

                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            string strWhere = "";
            if (strifofpage != "")
                strWhere = " (" + strifofpage + ") ";

            return GetList(strWhere);
        }

        
        /// <summary>
        /// 根据条件获得表中的某一个值
        /// </summary>
        /// <param name="columnname">字段，如：姓名</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <returns>如果读取不到值，则返回 空字符串</returns>
        public string GetValue(string columnname, string strWhere)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            return dal.GetValue(columnname, strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            return dal.GetRecordCount(strWhere);
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
        public DataSet GetListByPageColumns(string columslist, string strWhere, string orderstr, int PageSize, int PageIndex)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            return dal.GetListByPageColumns(columslist, strWhere, orderstr, PageSize, PageIndex);
        }

        /// <summary>
        /// 根据字段列表，条件，排序，分页读取记录
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <returns>返回组装好的json字符串</returns>
        public string GetListByPageColumns_tojson(string columslist, string strWhere, string orderstr)
        {
            int PageIndex = 1;
            int PageSize = 20;
            if (thiscontext != null)
            {
                PageIndex = thiscontext.Request.Form["page"] != "" ? Convert.ToInt32(thiscontext.Request.Form["page"]) : 0;
                PageSize = thiscontext.Request.Form["rows"] != "" ? Convert.ToInt32(thiscontext.Request.Form["rows"]) : 0;
                string sort = thiscontext.Request.Form["sort"] != "" ? thiscontext.Request.Form["sort"] : "";
                string order = thiscontext.Request.Form["order"] != "" ? thiscontext.Request.Form["order"] : "";
                if (PageIndex < 1) PageIndex = 1;
                if (PageSize < 1) PageSize = 20;

                string strif1 = zhangte.Common.DbHelperMySQL.GetWhere(thiscontext);
                if (strif1 != "" && strif1 != null)
                {
                    if (strWhere.Trim() != "")
                        strWhere = strWhere + " and " + strif1;
                    else
                        strWhere = strif1;
                }
            }
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            return GetListByPageColumns_tojson(columslist, strWhere, orderstr, PageSize, PageIndex);
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
        public string GetListByPageColumns_tojson(string columslist, string strWhere, string orderstr, int PageSize, int PageIndex)
        {
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            return dal.GetListByPageColumns_tojson(columslist, strWhere, orderstr, PageSize, PageIndex);
        }
        /// <summary>
        /// 根据字段列表，条件，排序，
        /// </summary>
        /// <param name="columslist">字段列表，如：Id,姓名,性别,年龄</param>
        /// <param name="strWhere">条件，如：年龄>12 and 性别='女'</param>
        /// <param name="filedOrder">排序，如： Id desc </param>
        /// <returns>返回组装好的json字符串</returns>
        public string GetListByColumn_tojson(string columslist, string strWhere, string orderstr)
        {
            if (thiscontext != null)
            {
                string strif1 = zhangte.Common.DbHelperMySQL.GetWhere(thiscontext);
                if (strif1 != "" && strif1 != null)
                {
                    if (strWhere.Trim() != "")
                        strWhere = strWhere + " and " + strif1;
                    else
                        strWhere = strif1;
                }
            }
            if (strWhere != "" && strifofpage != "")
                strWhere = "(" + strWhere + " and " + strifofpage + ") ";

            return dal.GetListByColumns_tojson(columslist, strWhere, orderstr);
        }
        /// <summary>
        /// 根据sqlstr 语句，页号和每页记录数 返回表格中一页的数据
        /// </summary>
        /// <param name="strsql">sql语句</param>
        /// <param name="PageSize">每页的记录数</param>
        /// <param name="PageIndex">页号，第一页是1</param>
        /// <returns>读取结果的数据集</returns>
        public DataSet GetListByPageofSql(string strsql, int PageSize, int PageIndex)
        {
            return dal.GetListByPageofSql(strsql, PageSize, PageIndex);
        }
    }
}

