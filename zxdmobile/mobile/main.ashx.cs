using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.SessionState;
using System.Web.UI;

namespace zxdmobile.mobile
{
    /// <summary>
    /// main1 的摘要说明
    /// </summary>
    public class main1 : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Request.QueryString["mblist"] != null)
            {
                string yonghuming = context.Session["用户名"].ToString();
                string str = readlist(yonghuming, context);

                context.Response.Write(str);
            }
            if (context.Request.QueryString["zllist"] != null)
            {
                string yonghuming = context.Session["用户名"].ToString();
                string str = readzl(yonghuming, context);

                context.Response.Write(str);
            }
            if (context.Request.QueryString["read"] != null)
            {
                string str = readlist1("", context);
                context.Response.Write(str);
            }
            if (context.Request.QueryString["searchmc"] != null)
            {
                string str = readlist1(context.Request.QueryString["searchmc"].ToString(), context);
                context.Response.Write(str);
            }
            if (context.Request.QueryString["mbedit"] != null)
            {
                string str = readedit(context.Request.QueryString["mbedit"].ToString(), context);
                context.Response.Write(str);
            }
            if (context.Request.QueryString["savecpid"] != null)
            {
                string str = savecp(context.Request.QueryString["savecpid"].ToString(), context);
                context.Response.Write(str);
            }
            if (context.Request.QueryString["zledit"] != null)
            {
                string str = readzl(context.Request.QueryString["zledit"].ToString(), context);
                context.Response.Write(str);
            }
            if (context.Request.QueryString["savezlid"] != null)
            {
                string str = savezl(context.Request.QueryString["savezlid"].ToString(), context);
                context.Response.Write(str);
            }
           

        }

        private string readedit(string dingdanbianhao, HttpContext context)
        {

            zhangte.BLL.zt_dingdan bll1 = new zhangte.BLL.zt_dingdan(context);
            zhangte.Model.zt_dingdan model1 = new zhangte.Model.zt_dingdan();

            DataSet ds1 = bll1.GetList(" Id = '" + dingdanbianhao + "'");

            string strif = " order by id desc";

            if (dingdanbianhao != "")
                strif = " where 订单编号 = " + dingdanbianhao + " order by id desc";

            string strret = "";
            if (ds1.Tables[0].Rows.Count > 0)
            {
                strret = ds1.Tables[0].Rows[0]["订单编号"].ToString() + "|" + ds1.Tables[0].Rows[0]["企业标识代码"].ToString() + "|" + ds1.Tables[0].Rows[0]["用户名"].ToString() + "|" + ds1.Tables[0].Rows[0]["产品名称"].ToString() + "|" + ds1.Tables[0].Rows[0]["单价"].ToString() + "|" + ds1.Tables[0].Rows[0]["数量"].ToString() + "|" + ds1.Tables[0].Rows[0]["总价"].ToString() + "|" + ds1.Tables[0].Rows[0]["订单时间"].ToString() + "|" + ds1.Tables[0].Rows[0]["收货地址"].ToString() + "|" + ds1.Tables[0].Rows[0]["联系方式"].ToString() + "|" + ds1.Tables[0].Rows[0]["订单状态"].ToString() + "|" ;
            }

            return strret;
        }

        private string readlist1(string chanpingmingcheng1 , HttpContext context)
        {
            zhangte.BLL.zt_chanpinbiao bll1 = new zhangte.BLL.zt_chanpinbiao(context);
            zhangte.Model.zt_chanpinbiao model1 = new zhangte.Model.zt_chanpinbiao();

            DataSet ds1 = bll1.GetList("产品名称 like '%" + chanpingmingcheng1 + "%'order by id desc");
           
         
            string strret = "<table cellspacing='0' cellpadding='4' id='GridView1' style='color:#333333;width:100%;border-collapse:collapse;'><tr style='color:White;background-color:#5D7B9D;font-weight:bold;'>\r\n";
            strret += "<th scope='col'>产品名称</th><th scope='col'>单价</th><th scope='col'>数量</th><th scope='col'>单位</th><th scope='col'>图片</th></tr>\r\n";

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                if (i % 2 == 0)
                    strret += "<tr align='center' style='color:#333333;background-color:#F7F6F3;'> <td>" + ds1.Tables[0].Rows[i]["产品名称"].ToString() + "</td> <td>" + ds1.Tables[0].Rows[i]["单价"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["数量"].ToString() + "</td>><td>" + ds1.Tables[0].Rows[i]["单位"].ToString() + "</td><td><img src='" + ds1.Tables[0].Rows[i]["图片"].ToString() + "' style=\"height: 150px; width: 150px\"/></td> </tr>\r\n";
                else
                    strret += "<tr align='center' style='color:#284775;background-color:White;'> <td>" + ds1.Tables[0].Rows[i]["产品名称"].ToString() + "</td> <td>" + ds1.Tables[0].Rows[i]["单价"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["数量"].ToString() + "</td> <td>" + ds1.Tables[0].Rows[i]["单位"].ToString() + "</td><td><img src='" + ds1.Tables[0].Rows[i]["图片"].ToString() + "' style=\"height: 150px; width: 150px\"/></td> </tr>\r\n";
            }
            strret += "</table>\r\n";
            return strret;
        }

        private string readlist(string yonghuming, HttpContext context)
        {

            zhangte.BLL.zt_dingdan bll1 = new zhangte.BLL.zt_dingdan(context);
            zhangte.Model.zt_dingdan model1 = new zhangte.Model.zt_dingdan();

            DataSet ds1 = bll1.GetList(" 用户名 = '" + yonghuming + "'");
            string strif = " order by id desc";
            if (yonghuming != "")
                strif = " where 用户名 like '%" + yonghuming + "%' order by id desc";

            string strret = "<table cellspacing='0' cellpadding='4' id='GridView1' style='color:#333333;width:100%;border-collapse:collapse;'><tr style='color:White;background-color:#5D7B9D;font-weight:bold;'>\r\n";
            strret += "<th scope='col'>订单编号</th><th scope='col'>企业标识代码</th><th scope='col'>用户名</th><th scope='col'>产品名称</th><th scope='col'>总价</th><th scope='col'>订单状态</th><th scope='col'>查看明细</th></tr>\r\n";

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {

                if (i % 2 == 0)
                    strret += "<tr align='center' style='color:#333333;background-color:#F7F6F3;'> <td>" + ds1.Tables[0].Rows[i]["订单编号"].ToString() + "</td> <td>" + ds1.Tables[0].Rows[i]["企业标识代码"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["用户名"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["总价"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["产品名称"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["订单状态"].ToString() + "</td><td><a onclick=\"mbedit('" + ds1.Tables[0].Rows[i]["id"].ToString() + "'); href='#cpedit'\">查看明细</a></td> </tr>\r\n";
                else
                    strret += "<tr align='center' style='color:#333333;background-color:#F7F6F3;'> <td>" + ds1.Tables[0].Rows[i]["订单编号"].ToString() + "</td> <td>" + ds1.Tables[0].Rows[i]["企业标识代码"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["用户名"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["总价"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["产品名称"].ToString() + "</td><td>" + ds1.Tables[0].Rows[i]["订单状态"].ToString() + "</td><td><a onclick=\"mbedit('" + ds1.Tables[0].Rows[i]["id"].ToString() + "'); href='#cpedit'\">查看明细</a></td> </tr>\r\n";
            }
            strret += "</table>\r\n";
            return strret;
        }

        private string savecp(string dingdanbianhao, HttpContext context)
        {
            zhangte.BLL.zt_dingdan bll22 = new zhangte.BLL.zt_dingdan(context);
            zhangte.Model.zt_dingdan model22 = new zhangte.Model.zt_dingdan();

            DataSet ds22 = bll22.GetList(" 订单编号 = '" + dingdanbianhao + "'");
            model22.Id = int.Parse(ds22.Tables[0].Rows[0]["id"].ToString());
            model22.订单编号 = ds22.Tables[0].Rows[0]["订单编号"].ToString();
            model22.企业标识代码 = ds22.Tables[0].Rows[0]["企业标识代码"].ToString();
            model22.用户名 = ds22.Tables[0].Rows[0]["用户名"].ToString();
            model22.产品名称 = ds22.Tables[0].Rows[0]["产品名称"].ToString();
            model22.单价 = ds22.Tables[0].Rows[0]["单价"].ToString();
            model22.数量 = ds22.Tables[0].Rows[0]["数量"].ToString();          
            model22.总价 = ds22.Tables[0].Rows[0]["总价"].ToString();
            model22.订单时间 = ds22.Tables[0].Rows[0]["订单时间"].ToString();
            model22.收货地址 = ds22.Tables[0].Rows[0]["收货地址"].ToString();
            model22.联系方式 = ds22.Tables[0].Rows[0]["联系方式"].ToString();
            model22.订单状态 = "已收货";

            bll22.Update1(model22);
            string strret = "OK";
            return strret;
        }

        private string readzl(string yonghuming, HttpContext context)
        {

            zhangte.BLL.zt_yonghubiao bll1 = new zhangte.BLL.zt_yonghubiao(context);
            zhangte.Model.zt_yonghubiao model1 = new zhangte.Model.zt_yonghubiao();
            yonghuming = context.Session["用户名"].ToString();
            DataSet ds1 = bll1.GetList(" 用户名 = '" + yonghuming + "'");

            string strif = " order by id desc";

            if (yonghuming != "")
                strif = " where 用户名 = " + yonghuming + " order by id desc";

            string strret = "";
            if (ds1.Tables[0].Rows.Count > 0)
            {
                strret = ds1.Tables[0].Rows[0]["用户名"].ToString() + "|" + ds1.Tables[0].Rows[0]["密码"].ToString() + "|" + ds1.Tables[0].Rows[0]["联系方式"].ToString() + "|" + ds1.Tables[0].Rows[0]["收货地址"].ToString() + "|";
            }

            return strret;
        }

        private string savezl(string yonghuming, HttpContext context)
        {

            string mima = context.Request.QueryString["mima"].ToString();
            string lianxifangshi1 = context.Request.QueryString["lianxifangshi1"].ToString();
            string shouhuodizhi1 = context.Request.QueryString["shouhuodizhi1"].ToString();

        
            zhangte.BLL.zt_yonghubiao bll1 = new zhangte.BLL.zt_yonghubiao();


         

            DataTable dt1 = bll1.GetList("用户名='" + yonghuming + "'").Tables[0];

            zhangte.Model.zt_yonghubiao md1 = new zhangte.Model.zt_yonghubiao();
            md1.Id = int.Parse(dt1.Rows[0]["id"].ToString());
            md1.用户名 = yonghuming;
            md1.密码 = mima;
            md1.联系方式 = lianxifangshi1;
            md1.收货地址 = shouhuodizhi1;
            bll1.Update1(md1);

           
            string strret = "OK";
            return strret;
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}