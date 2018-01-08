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
    /// 文件说明：zt_qiyebiao
    /// 开发者：
    /// 最后编辑时间：
    /// 编辑说明：
    /// </summary>
    public class zqiyebiao : baseashxClass
    {
        
        public override void ProcessRequest(HttpContext context)
        {
            zhangte.BLL.zt_qiyebiao bll = new zhangte.BLL.zt_qiyebiao(context); 
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
             
            else if (context.Request.QueryString["type"] == "save")//保存修改或添加 
            {
                    string qiyebiaoshiDM = context.Request.QueryString["qiyebiaoshiDM"];
                    string denglumima = context.Request.QueryString["denglumima"];
                    string qiyemingcheng = context.Request.QueryString["qiyemingcheng"];
                    string qiyeleibie = context.Request.QueryString["qiyeleibie"];
                    string lianxifangshi = context.Request.QueryString["lianxifangshi"];
                    string fahuodizhi = context.Request.QueryString["fahuodizhi"];
                    string xinyongdengji = HttpContext.Current.Session["xy"].ToString();
                string a = "管理者";

                if (context.Request.QueryString["Id"] != null && context.Request.QueryString["Id"] != "")
                {
                    bll.Update(context.Request.QueryString["Id"].ToString(),qiyebiaoshiDM,denglumima,qiyemingcheng,qiyeleibie,lianxifangshi,fahuodizhi,xinyongdengji);
                }
                else if (a == HttpContext.Current.Session["lb"].ToString())
                {
                    bll.Add(qiyebiaoshiDM, denglumima, "管理员", "管理者", lianxifangshi, fahuodizhi,"1");
                    //string a = "管理员";
                    //if (a == HttpContext.Current.Session["lb"].ToString())
                    //{
                    //    bll.Add(qiyebiaoshiDM,denglumima,qiyemingcheng,qiyeleibie,lianxifangshi,fahuodizhi);
                    //}

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
                    string strret = bll.GetListByPageColumns_tojson("Id,企业标识代码,登录密码,企业名称,企业类别,联系方式,发货地址", pagestrif, "Id");
                    context.Response.Write(strret);
                    return;
                }
                else
                {
                    string strret = bll.GetListByPageColumns_tojson("Id,企业标识代码,登录密码,企业名称,企业类别,联系方式,发货地址", pagestrif, "Id");
                    context.Response.Write(strret);
                    return;
                }
            }
            else
            {
                
            }
        }         
    }
}