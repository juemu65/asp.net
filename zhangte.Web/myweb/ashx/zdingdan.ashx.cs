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
    /// 文件说明：zt_dingdan
    /// 开发者：
    /// 最后编辑时间：
    /// 编辑说明：
    /// </summary>
    public class zdingdan : baseashxClass
    {
        
        public override void ProcessRequest(HttpContext context)
        {
            zhangte.BLL.zt_dingdan bll = new zhangte.BLL.zt_dingdan(context); 
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
                    string dingdanbianhao = context.Request.QueryString["dingdanbianhao"];
                    string qiyebiaoshiDM = context.Request.QueryString["qiyebiaoshiDM"];
                    string yonghuming = context.Request.QueryString["yonghuming"];
                    string chanpinmingcheng = context.Request.QueryString["chanpinmingcheng"];
                    string danjia = context.Request.QueryString["danjia"];
                    string shuliang = context.Request.QueryString["shuliang"];
                    string zongjia = context.Request.QueryString["zongjia"];
                    string dingdanshijian = context.Request.QueryString["dingdanshijian"];
                    string shouhuodizhi = context.Request.QueryString["shouhuodizhi"];
                    string lianxifangshi = context.Request.QueryString["lianxifangshi"];
                    string dingdanzhuangtai = context.Request.QueryString["dingdanzhuangtai"];

                
                if (context.Request.QueryString["Id"] != null && context.Request.QueryString["Id"] != "")
                {
                    bll.Update(context.Request.QueryString["Id"].ToString(),dingdanbianhao,qiyebiaoshiDM,yonghuming,chanpinmingcheng,danjia,shuliang,zongjia,dingdanshijian,shouhuodizhi,lianxifangshi,dingdanzhuangtai);
                }
                else
                {
                    bll.Add(dingdanbianhao,qiyebiaoshiDM,yonghuming,chanpinmingcheng,danjia,shuliang,zongjia,dingdanshijian,shouhuodizhi,lianxifangshi,dingdanzhuangtai);
                }

                context.Response.Write("true");
            }
            else if (Convert.ToString(context.Request.Form["action"]) == "query")
            {
                pagestrif = "企业标识代码=(select 企业标识代码 from zt_qiyebiao where 企业名称 ='" + HttpContext.Current.Session["account"].ToString() + "')";
                string strret = bll.GetListByPageColumns_tojson("Id,订单编号,企业标识代码,用户名,产品名称,单价,数量,总价,订单时间,收货地址,联系方式,订单状态", pagestrif, "Id");
                    context.Response.Write(strret);
                    return;
               
                   
            }
            else
            {
                
            }
        }         
    }
}