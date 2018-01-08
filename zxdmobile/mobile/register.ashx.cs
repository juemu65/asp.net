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
    /// register1 的摘要说明
    /// </summary>
    public class register1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
          
            string yonghuming = context.Request.Form["yonghuming"].ToString().Trim();
            string mima = context.Request.Form["mima"].ToString();
            string chongfumima = context.Request.Form["chongfumima"].ToString();
            string lianxifangshi = context.Request.Form["lianxifangshi"].ToString();
            string shouhuodizhi = context.Request.Form["shouhuodizhi"].ToString();

            if (mima.Equals(chongfumima) == false)
            {
                context.Response.Write("两次密码不一致");
                return;
            }
            if (yonghuming == "" || mima == "" || chongfumima == "" || lianxifangshi == "" || shouhuodizhi == "")
            {
                context.Response.Write("还有信息未填写");
                return;
            }
            zhangte.BLL.zt_yonghubiao bll1 = new zhangte.BLL.zt_yonghubiao();


            DataTable dt1 = bll1.GetList("用户名='" + yonghuming + "'").Tables[0];
            if (dt1.Rows.Count > 0)
            {
                context.Response.Write("用户名已存在");
                return;
            }
            zhangte.Model.zt_yonghubiao md1 = new zhangte.Model.zt_yonghubiao();

            md1.用户名 = yonghuming;
            md1.密码 = mima;
            md1.联系方式 = lianxifangshi;
            md1.收货地址 = shouhuodizhi;
            bll1.Add1(md1);

            context.Response.Write("注册成功");
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