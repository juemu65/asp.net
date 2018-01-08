<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="zxdmobile.mobile.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="javascript/css/themes/default/jquery.mobile-1.4.0.min.css"/>
    <script src="javascript/js/jquery.js"></script>
    <script src="javascript/js/jquery.mobile-1.4.0.min.js"></script>
  	<script type="text/javascript">

  	    $(document).ready(function () {
  	        $("#sub").click(function () {
  	            var options = {
  	                url: 'register.ashx',
  	                type: 'post',
  	                dataType: 'text',
  	                data: $("#myform").serialize(),
  	                success: function (data) {
  	                    alert(data);
  	                    $("#msg").html(data);

  	                    if (data == "注册成功")
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
            $("#fanhui").click(function () {
                window.location.href = "login.aspx";

            });
        });

        </script>
</head>
<body>
   <form action="register.ashx" id="myform" method="post">

        <div data-role="page" id="cpedit"  data-fullscreen="true">
            <div data-theme="a" data-role="header" style="display:inline-block; width:98%;">
                <a id="fanhui" class="ui-btn-left" data-transition="slide" data-direction="back">返回</a>  <h3> 手机用户注册页面
                </h3>
                
            </div>
            <div data-role="none"  >

                         <div id="divU"  >
                            <table cellpadding="0" cellspacing="0" border="0" style="padding: 0px; margin: 1px; width: 98%; border-spacing: 0px; table-layout: auto;">
                                 <tr>
                                    <th>
                                        用户名 <span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                         <input id="yonghuming" name="yonghuming" type="text"   />
                                    </td>

                                </tr>
                                <tr>
                                    <th>
                                        密码<span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="mima" name="mima" type="text" />
                                    </td>
                                </tr>
                                 <tr>
                                    <th>
                                        重复密码<span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="chongfumima" name="chongfumima" type="text" />
                                    </td>
                                </tr>
                                <tr>
                                    <th>
                                        联系方式<span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="lianxifangshi" name="lianxifangshi" type="text" />
                                    </td>
                                </tr>
                                <tr>
                                    <th>
                                        收货地址<span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="shouhuodizhi" name="shouhuodizhi" type="text" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                <br /><br />
                        <div   style="text-align: center; ">
                            &nbsp;&nbsp;&nbsp;
                           <div   id="sub"  style="text-align: center;vertical-align:middle;margin-top:10px; background-color: #b3cbed; font-weight: bold; color: #fff; height: 40px; font-size: 20px;">
                            <span     style="text-align: center;vertical-align:middle;margin-top:10px;height:50px "> &nbsp;  注册 &nbsp;</span>
                               
                        </div>
            </div>
        </div>


        


          
               
        </div>
    </form>
</body>
</html>
