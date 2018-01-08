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
    /// login1 的摘要说明
    /// </summary>
    public class login1 : IHttpHandler, System.Web.SessionState.IRequiresSessionState 
    {

        public void ProcessRequest(HttpContext context)
        {
            zhangte.BLL.zt_yonghubiao bll1 = new zhangte.BLL.zt_yonghubiao();
            string yonghuming = context.Request.Form["yonghuming"].ToString().Trim();
            string mima = context.Request.Form["mima"].ToString().Trim();
            zhangte.BLL.zt_yonghubiao bll = new zhangte.BLL.zt_yonghubiao();
            DataTable dt = bll.GetList("用户名='" + yonghuming + "' and 密码='" + mima + "'").Tables[0];
            if (dt.Rows.Count <= 0)
            {
                context.Response.Write("用户名或密码错误");
                return;
            }
            else
            {
                zhangte.BLL.zt_yonghubiao b22 = new zhangte.BLL.zt_yonghubiao();
                DataSet ds22 = b22.GetList(" 用户名 = '" + yonghuming + "'");               
                context.Session["用户名"] = ds22.Tables[0].Rows[0]["用户名"].ToString();                
                context.Response.Write("登录成功");
                return;
            }
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