<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="zxdmobile.mobile.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta name="viewport" content="width=device-width,initial-scale=1.0, maximum-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    
    <meta name="viewport" content="target-densitydpi=get-target-densitydpi, width=device-width, initial-scale=1, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0"/>

    <link rel="stylesheet" href="javascript/css/themes/default/jquery.mobile-1.4.0.min.css"/>
    <script src="javascript/js/jquery.js"></script>
    <script src="javascript/js/jquery.mobile-1.4.0.min.js"></script>
    <style> A {text-decoration: NONE} </style>
        <script>
            $(document).ready(function () {
                $("#sub").click(function () {
                    var options = {
                        url: 'login.ashx',
                        type: 'post',
                        dataType: 'text',
                        data: $("#myform").serialize(),
                        success: function (data) {
                            alert(data);
                            $("#msg").html(data);
                            if (data == "登录成功")
                                window.location.href = "main.aspx";
                            if (data == "用户名或密码错误")
                                window.location.href = "login.aspx";
                        }

                    };
                    $.ajax(options);
                    return false;
                });
            });

        </script>
     <script>
         $(document).ready(function () {
             $("#Span1").click(function () {
                 window.location.href = "register.aspx";
                
             });
         });

        </script>
   
</head>
<body>
     <form action="login.ashx" method="post" id="myform">
        <div data-role="page" id="geren"  style=" margin-left: auto; margin-right: auto;text-align:center;"  data-fullscreen="true">
            <div data-theme="a" data-role="header" style="display:inline-block; width:100%;">
                 <h3>手机用户登录页面</h3>
                
            </div>
            <div data-role="none"   style=" background-position: center center; width:100%;height:500px; background-image: none;">
                <br />
                         <div id="divU"    >
                            <table cellpadding="0" cellspacing="0" border="0" style="padding: 0px; margin: 1px; width: 78%; border-spacing: 0px; table-layout: auto;">
                                 <tr>
                                    <th>
                                        帐号 <span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="yonghuming" name="yonghuming"type="text" class="easyui-validatebox" validType='stuNumLength[11]'/>
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <th>
                                        密码 <span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="mima" name="mima" type="password"  />
                                    </td>
                                    
                                </tr>
                              <tr>
                                    <th >
                                          &nbsp;
                                    </th>
                                       <td>
                                          &nbsp;
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <th >
                                        <%--帐户保存：--%>
                                    </th>
                                       <td>
                                        <%--<input id="Checkbox1" value="帐户保存：" type="checkbox" checked="checked" />--%>
                                    </td>
                                    
                                </tr>
                            </table>
                        </div>
                <br /><br />
                        <div   id="sub"  style="text-align: center;vertical-align:middle;margin-top:10px; background-color: #b3cbed; font-weight: bold; color: #fff; height: 40px; font-size: 20px;">
                            <span     style="text-align: center;vertical-align:middle;margin-top:10px;height:50px "> &nbsp;  登录 &nbsp;</span>
                            
                        </div>
                <div   id="Span1"  style="text-align: center;vertical-align:middle;margin-top:20px; background-color: #b3cbed; font-weight: bold; color: #fff; height: 40px; font-size: 20px;">
                            <span     style="text-align: center;vertical-align:middle;margin-top:10px;height:50px "> &nbsp;  注册 &nbsp;</span>
                            
                        </div>
            </div>
        </div>
    </form>
</body>
</html>
