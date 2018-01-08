using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace zhangte
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            string name = txtName.Text.Replace("'", "").Replace(" ", "");
            string pass = txtPass.Text.Replace("'", "").Replace(" ", "");
            string strwhere = "";
            string username = "";
            //pass = ljxpower.Common.DESEncrypt.Encrypt(pass);//

            #region  login ....


            ljxpower.BLL.com_user bll = new ljxpower.BLL.com_user();
            strwhere = "(企业标识代码='" + name + "'    ) and 登录密码='" + pass + "'";
                

                DataSet ds = ljxpower.Common.DbHelperMySQL.Query("select * from  zt_qiyebiao where " + strwhere);

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    lblName.Text = "用户名或密码错误";
                }
                else
                {
                //   ljxpower.Model.com_user usermodel = new ljxpower.Model.com_user();
                //   usermodel = bll.GetModel(int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()));
                //   ljxpower.BLL.com_loginlog lbll = new ljxpower.BLL.com_loginlog();
                //   ljxpower.Model.com_loginlog lmodel = new ljxpower.Model.com_loginlog();
                //   lmodel.LoginDate = DateTime.Now;
                //   lmodel.LoginIP = Page.Request.UserHostAddress;
                //   lmodel.Status = "0";
                //   lmodel.Userid = name;

                //   if (ds.Tables[0].Rows.Count > 0)
                //       username = ds.Tables[0].Rows[0]["企业名称"].ToString(); //登录用户姓名
                //   lmodel.username = username;
                //   lbll.Add1(lmodel);

                userinfo userobj = new userinfo();
                userobj.logincount = "admin";
                userobj.userid = "1";
                userobj.username = "admin";
                userobj.usertype = "1";
                userobj.orgid = "1100000000";
                userobj.logintime = DateTime.Now;//登录时间 

                Session["userobj"] = userobj;
                Session["lb"] = ds.Tables[0].Rows[0]["企业类别"].ToString();
                Session["xy"] = ds.Tables[0].Rows[0]["信用等级"].ToString();
                Session["account"] = ds.Tables[0].Rows[0]["企业名称"].ToString();
                Session["gongsibianhao"] = ds.Tables[0].Rows[0]["企业标识代码"].ToString();
                Response.Redirect("index.html?username="+ds.Tables[0].Rows[0]["企业名称"].ToString()+"&time=" + DateTime.Now.ToUniversalTime());

                }

              
 
            #endregion login....
        }
    }
}