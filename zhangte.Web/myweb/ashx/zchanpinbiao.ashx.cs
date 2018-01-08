using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Web.SessionState;

namespace zhangte.ashx
{
    /// <summary>
    /// 生成代码时间： ljxtime
    /// 文件说明：zt_chanpinbiao
    /// 开发者：
    /// 最后编辑时间：
    /// 编辑说明：
    /// </summary>
    
    
    public class zchanpinbiao : baseashxClass
    {
        string ztai;
        public override void ProcessRequest(HttpContext context)
        {
            zhangte.BLL.zt_chanpinbiao bll = new zhangte.BLL.zt_chanpinbiao(context); 
            base.ProcessRequest(context);
            context.Response.ContentType = "text/plain";

            

            mycommonClass mycommonClassobj = new mycommonClass();
            context.Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            if (context.Request.QueryString["type"] == "edit")//获取编辑信息
            {
                if (context.Request.QueryString["Id"] != null)
                {
                    string strret = bll.Geteditdata(context.Request.QueryString["Id"].ToString());//aa1
                    context.Response.Write(strret);
                }
            }
            else if (context.Request.QueryString["type"] == "del")//删除信息
            {
                if (context.Request.QueryString["Id"] == null)
                    return;
                string Id = context.Request.QueryString["Id"].ToString();                
                bll.Delete(int.Parse(Id));               
            }
            else if (context.Request.QueryString["type"] == "combox")//保存修改或添加 信息 aa2
            {

            }

            else if (context.Request.QueryString["type"] == "bh")
            {

                string a = HttpContext.Current.Session["gongsibianhao"].ToString();
                context.Response.Write(a);


            }




            else if (context.Request.QueryString["type"] == "save")//保存修改或添加 
            {
                    string qiyebiaoshiDM = context.Request.QueryString["qiyebiaoshiDM"];
                    string chanpinmingcheng = context.Request.QueryString["chanpinmingcheng"];
                    string danjia = context.Request.QueryString["danjia"];
                    string shuliang = context.Request.QueryString["shuliang"];
                    string danwei = context.Request.QueryString["danwei"];
                    string tupian = context.Request.QueryString["tupian"];
                    string zhuangtai = context.Request.QueryString["zhuangtai"];
                string a = HttpContext.Current.Session["gongsibianhao"].ToString();
                
                if(a!="admin1")
                {
                    zhuangtai = "未审核";
                }


                if (context.Request.QueryString["Id"] != null && context.Request.QueryString["Id"] != "" )
                {
                    bll.Update(context.Request.QueryString["Id"].ToString(),qiyebiaoshiDM,chanpinmingcheng,danjia,shuliang,danwei,tupian,zhuangtai);
                }
                else
                {
                    bll.Add(qiyebiaoshiDM,chanpinmingcheng,danjia,shuliang,danwei,tupian,zhuangtai);
                }

                context.Response.Write("true");
            }
            else if (Convert.ToString(context.Request.Form["action"]) == "query")
            {
                string a = "管理员";
                if (a != HttpContext.Current.Session["account"].ToString())
                {
                    //string strret = bll.GetListByPageColumns_tojson("id,产品名称,产品数量,产品规格,备注", "1=1", "产品数量"); 加权限, 1=1 改为:部门编号 like '1010%'
                    pagestrif = "企业标识代码=(select 企业标识代码 from zt_qiyebiao where 企业名称 ='" + HttpContext.Current.Session["account"].ToString() + "')";
                
                
                string strret = bll.GetListByPageColumns_tojson("Id,企业标识代码,产品名称,单价,数量,单位,图片,状态", pagestrif, "Id");
                context.Response.Write(strret);
                return;
                }
                else
                {
                    string strret = bll.GetListByPageColumns_tojson("Id,企业标识代码,产品名称,单价,数量,单位,图片,状态", pagestrif, "Id");
                    context.Response.Write(strret);
                    return;
                }
                    
            }
            //else if(context.Request.QueryString["type"]) == "bh")
            //{
            //    context.Response.Write(HttpContext.Current.Session["gongsibianhao"].ToString());
            //}
        }         
    }
}