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
    /// 文件说明：zt_chuku
    /// 开发者：
    /// 最后编辑时间：
    /// 编辑说明：
    /// </summary>
    public class zchuku : baseashxClass
    {
        
        public override void ProcessRequest(HttpContext context)
        {
            zhangte.BLL.zt_chuku bll = new zhangte.BLL.zt_chuku(context);
            zhangte.Model.zt_chuku model = new Model.zt_chuku();
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

                model = bll.GetModel(int.Parse(Id));
                string chanpinmingcheng = model.产品名称;
                string shuliang = model.数量;

                zhangte.BLL.zt_chanpinbiao kcbll = new BLL.zt_chanpinbiao();
                zhangte.Model.zt_chanpinbiao kcmodel = new Model.zt_chanpinbiao();
                DataSet kcds = kcbll.GetList("产品名称='" + chanpinmingcheng + "'");

                if (kcds.Tables[0].Rows.Count > 0)
                {
                    string cpmc = kcds.Tables[0].Rows[0][0].ToString();
                    string kcnum = kcds.Tables[0].Rows[0][4].ToString();
                    string num = (int.Parse(kcnum) + int.Parse(shuliang)).ToString();

                    kcmodel = kcbll.GetModel(int.Parse(cpmc));
                    kcmodel.数量 = num;
                    kcbll.Update1(kcmodel);

                }



                bll.Delete(int.Parse(Id));               
            }


            else if (context.Request.QueryString["type"] == "combox")//保存修改或添加 信息 aa2
            {
                if (context.Request.QueryString["comboxname"] == "cpbh")
                {
                    zhangte.BLL.zt_chanpinbiao bllzd = new zhangte.BLL.zt_chanpinbiao();
                    string a = HttpContext.Current.Session["gongsibianhao"].ToString();
                    string strret = bllzd.GetListByColumn_tojson("Id,企业标识代码,产品名称", "企业标识代码='" + a + "'", "");
                    context.Response.Write(strret);
                }
            }
            else if (context.Request.QueryString["type"] == "bh")
            {

                string a = HttpContext.Current.Session["gongsibianhao"].ToString();
                context.Response.Write(a);


            }

            else if (context.Request.QueryString["type"] == "time")
            {

                DateTime t = DateTime.Now;
                context.Response.Write(t.ToString());


            }

            else if (context.Request.QueryString["type"] == "save")//保存修改或添加 
            {
                    string qiyebiaoshiDM = context.Request.QueryString["qiyebiaoshiDM"];
                    string chanpinmingcheng = context.Request.QueryString["chanpinmingcheng"];
                    string shuliang = context.Request.QueryString["shuliang"];
                    string chukuyuanyin = context.Request.QueryString["chukuyuanyin"];
                    string chukushijian = context.Request.QueryString["chukushijian"];

                
                if (context.Request.QueryString["Id"] != null && context.Request.QueryString["Id"] != "")
                {
                    bll.Update(context.Request.QueryString["Id"].ToString(),qiyebiaoshiDM,chanpinmingcheng,shuliang,chukuyuanyin,chukushijian);
                }
                else
                {
                    bll.Add(qiyebiaoshiDM,chanpinmingcheng,shuliang,chukuyuanyin,chukushijian);
                    zhangte.BLL.zt_chanpinbiao kcbll = new BLL.zt_chanpinbiao();
                    zhangte.Model.zt_chanpinbiao kcmodel = new Model.zt_chanpinbiao();
                    DataSet kcds = kcbll.GetList("产品名称='" + chanpinmingcheng + "'");

                    if(kcds.Tables[0].Rows.Count>0)
                    {
                        string cpmc = kcds.Tables[0].Rows[0][0].ToString();
                        string kcnum = kcds.Tables[0].Rows[0][4].ToString();
                        string num = (int.Parse(kcnum) - int.Parse(shuliang)).ToString();

                        kcmodel = kcbll.GetModel(int.Parse(cpmc));
                        kcmodel.数量 = num;
                        kcbll.Update1(kcmodel);

                    }



                }

                context.Response.Write("true");
            }
            else if (Convert.ToString(context.Request.Form["action"]) == "query")
            {
                //string strret = bll.GetListByPageColumns_tojson("id,产品名称,产品数量,产品规格,备注", "1=1", "产品数量"); 加权限, 1=1 改为:部门编号 like '1010%'
                pagestrif = "企业标识代码=(select 企业标识代码 from zt_qiyebiao where 企业名称 ='" + HttpContext.Current.Session["account"].ToString() + "')";
                string strret = bll.GetListByPageColumns_tojson("Id,企业标识代码,产品名称,数量,出库原因,出库时间", pagestrif, "Id");
                context.Response.Write(strret);
                return;
            }
            else
            {
                
            }
        }         
    }
}