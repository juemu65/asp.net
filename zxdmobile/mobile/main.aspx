<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="zxdmobile.mobile.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>手机端网页测试</title>
    <meta name="viewport" content="target-densitydpi=get-target-densitydpi, width=device-width, initial-scale=1, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0"/>

    <link rel="stylesheet" href="javascript/css/themes/default/jquery.mobile-1.4.0.min.css"/>
    <script src="javascript/js/jquery.js"></script>
    <script src="javascript/js/jquery.mobile-1.4.0.min.js"></script>
        <script>
            function msgShow(title, msgString, msgType) {
                $.messager.alert(title, msgString, msgType);
            }
            $(document).on('pageinit', '#home', function () {


            });
            $(document).on('pageinit', '#cplist', function () {
           
                var url = "main.ashx?mblist=init";
                $.post(url, function (msg) {

                    $('#cplistdiv').html(msg);

                });

            });
            $(document).on('pageinit', '#zledit', function () {

                var url = "main.ashx?zllist=init";
                $.get(url, function (msg) {
                    console.log(msg)
                    var str = msg.split('|');
                    console.log(str)
                    $('#yonghuming1').val(str[0]);
                    $('#mima').val(str[1]);
                    $('#lianxifangshi1').val(str[2]);
                    $('#shouhuodizhi1').val(str[3]);
                    //$('#div1').html(msg);

                });

            });
            $(document).on('pageinit', '#cpsearch', function () {
                var url = "main.ashx?read=init";
                $.post(url, function (msg) {

                    $('#cplistsearchdiv').html(msg);

                });
            });
            function searhlist() {
                var mingcheng = $('#chanpinmingcheng1').val();
                var url = "main.ashx?searchmc=" + encodeURI(mingcheng);
            
                $.post(url, function (msg) {
                
                    $('#cpsearchdiv').html(msg);

                });
            }
            $(document).ready(function () {
                $("#fanhui").click(function () {
                    window.location.href = "main.aspx";

                });
            });
            $(document).ready(function () {
                $("#A1").click(function () {
                    window.location.href = "main.aspx";

                });
            });
            $(document).ready(function () {
                $("#A2").click(function () {
                    window.location.href = "main.aspx";

                });
            });
            $(document).ready(function () {
                $("#A3").click(function () {
                    window.location.href = "main.aspx";

                });
            });
            $(document).ready(function () {
                $("#A4").click(function () {
                    window.location.href = "main.aspx";

                });
            });
            function mbedit(dingdanbianhao) {
                var url = "main.ashx?mbedit=" + encodeURI(dingdanbianhao);
                $('#dingdanbianhao').val(dingdanbianhao);
               
                $.post(url, function (msg) {
                    var str = msg.split('|');
                    $('#dingdanbianhao').val(str[0]);
                    $('#qiyebiaoshidaima').val(str[1]);
                    $('#yonghuming').val(str[2]);
                    $('#chanpinmingcheng').val(str[3]);
                    $('#danjia').val(str[4]);
                    $('#shuliang').val(str[5]);
                    $('#zongjia').val(str[6]);
                    $('#dingdanshijian').val(str[7]);
                    $('#shouhuodizhi').val(str[8]);
                    $('#lianxifangshi').val(str[9]);
                    $('#dingdanzhuangtai').val(str[10]);
                  
                });
            }

            function savecp() {

                $.post('main.ashx?savecpid=' + encodeURI($('#dingdanbianhao').val())
                + '&qiyebiaoshidaima=' + encodeURI($('#qiyebiaoshidaima').val())
                + '&yonghuming=' + encodeURI($('#yonghuming').val())
                + '&chanpinmingcheng=' + encodeURI($('#chanpinmingcheng').val())
                + '&danjia=' + encodeURI($('#danjia').val())
                + '&shuliang=' + encodeURI($('#shuliang').val())               
                + '&zongjai=' + encodeURI($('#zongjai').val())
                + '&dingdanshijian=' + encodeURI($('#dingdanshijian').val())
                + '&shouhuodizhi=' + encodeURI($('#shouhuodizhi').val())
                + '&lianxifangshi=' + encodeURI($('#lianxifangshi').val())
                + '&zhuangtai=' + encodeURI($('#zhuangtai').val()),

                function (msg) {
                    alert('收货成功 ！');
                }
           );
            }
            function zledit(yonghuming) {
                var url = "main.ashx?zledit=" + encodeURI(yonghuming);
                $('#yonghuming').val(yonghuming);

                $.post(url, function (msg) {
                    var str = msg.split('|');
                    $('#yonghuming').val(str[0]);
                    $('#mima').val(str[1]);
                    $('#lianxifangshi').val(str[2]);
                    $('#shouhuodizhi').val(str[3]);

                }); 
            }
            function savezl() {
              
                console.log('main.ashx?savezlid=' + encodeURI($('#yonghuming1').val())
                + '&mima=' + encodeURI($('#mima').val())
                + '&lianxifangshi1=' + encodeURI($('#lianxifangshi1').val())                      
                + '&shouhuodizhi1=' + encodeURI($('#shouhuodizhi1').val()))

                $.post('main.ashx?savezlid=' + encodeURI($('#yonghuming1').val())
                + '&mima=' + encodeURI($('#mima').val())
                + '&lianxifangshi1=' + encodeURI($('#lianxifangshi1').val())                      
                + '&shouhuodizhi1=' + encodeURI($('#shouhuodizhi1').val()),

                function (msg) {
                    alert('修改成功！');
                }
           );
            }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 151px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <input id="hid" type="hidden" />
      <div data-role="page" id="home" style=" margin-left: auto; margin-right: auto;text-align:center;"  data-fullscreen="true">
            <div data-theme="a" data-role="header" >
                <a href="login.aspx?logout=ljxlogout"  target="_self"  class="ui-btn-left" data-transition="slide" data-direction="back">退出</a>
                <h3>个人信息管理
                </h3>
            </div>
            <div data-role="content">
                <div class="example-wrapper"  style=" margin-left: auto; margin-right: auto;text-align:center;" >
                    <table cellpadding="10" cellspacing="10" border="0" style="padding: 10px; margin:auto;  height: 400px; border-spacing: 0px; table-layout: auto;">
                        <tr>
                            <td class="auto-style3">
                                <a href="#cplist"  data-transition="slide" data-direction="reverse" style="font-weight: bold; color: #666666">
                                    <img alt="" src="images/cp2.jpg"  style="height: 110px; width: 110px" /><br /></a>
                                <a href="#cplist">查看订单</a>
                            </td>
                            <td class="auto-style3">
                                <a href="#cpsearch"  data-transition="slide" data-direction="reverse" style="font-weight: bold; color: #666666">
                                    <img alt="" src="images/cp2.jpg"  style="height: 110px; width: 110px" /><br /></a>
                                <a href="#cpsearch">产品查询</a>
                            </td>
                            <td class="auto-style3">
                                <a href="#zledit"  data-transition="slide" data-direction="reverse" style="font-weight: bold; color: #666666">
                                    <img alt="" src="images/cp2.jpg"  style="height: 110px; width: 110px" /><br /></a>
                                <a href="#zledit">资料修改</a>
                            </td>
                        </tr>
                        
                       
                       
                    </table>
                </div>
            </div>
            <div data-theme="a" data-role="footer">
                
            </div>
        </div>

        <div data-role="page" id="cpedit"  data-fullscreen="true">
            <div data-theme="a" data-role="header" style="display:inline-block; width:98%;">
                <a id="fanhui" class="ui-btn-left" data-transition="slide" data-direction="back">返回</a>  <h3> 订单明细
                </h3>
                
            </div>
            <div data-role="none"  >

                         <div id="divU"  >
                            <table cellpadding="0" cellspacing="0" border="0" style="padding: 0px; margin: 1px; width: 98%; border-spacing: 0px; table-layout: auto; height: 192px;">
                                  <tr>
                                    <th>
                                       订单编号<span style="font-size: large; font-weight: bold; color: #FF3300"></span>
                                    </th>
                                    <td>
                                        <input id="dingdanbianhao" type="text" readonly="ture" />
                                    </td>
                                    <th>
                                        企业标识代码
                                    </th>
                                    <td class="auto-style1">
                                        <input id="qiyebiaoshidaima" type="text" readonly="ture"/>
                                    </td>


                                </tr>
                                <tr>
                                    <th>
                                        客户账号<span style="font-size: large; font-weight: bold; color: #FF3300"></span>
                                    </th>
                                    <td>
                                        <input id="yonghuming" type="text" readonly="ture" />
                                    </td>
                                    <th>
                                        产品名称
                                    </th>
                                    <td class="auto-style1">
                                        <input id="chanpinmingcheng" type="text" readonly="ture"/>
                                    </td>
                                </tr>
                                 
                            </table>
                        </div>
                            <table cellpadding="0" cellspacing="0" border="0" style="padding: 0px; margin: 1px; width: 98%; border-spacing: 0px; table-layout: auto; height: 192px;">
                                 <tr>
                                    <th>
                                        单价 <span style="font-size: large; font-weight: bold; color: #FF3300"></span>
                                    </th>
                                    <td>
                                         <input id="danjia" type="text"  readonly="ture" />
                                    </td>
                                    <th>
                                        数量<span style="font-size: large; font-weight: bold; color: #FF3300"></span>
                                    </th>
                                    <td>
                                        <input id="shuliang" type="text" readonly="ture" />
                                    </td>
                                </tr>
                                <tr>
                                    
                                    <th>
                                        总价
                                    </th>
                                    <td>
                                        <input id="zongjia" type="text" readonly="ture" />
                                    </td>
                                    <th>
                                        订单时间 <span style="font-size: large; font-weight: bold; color: #FF3300"></span>
                                    </th>
                                    <td>
                                         <input id="dingdanshijian" type="text" readonly="ture"  />
                                    </td>

                                </tr>
                                 
                            </table>
                            <table cellpadding="0" cellspacing="0" border="0" style="padding: 0px; margin: 1px; width: 98%; border-spacing: 0px; table-layout: auto; height: 192px;">
                                 <tr>
                                    
                                    <th>
                                        收货地址<span style="font-size: large; font-weight: bold; color: #FF3300"></span>
                                    </th>
                                    <td>
                                        <input id="shouhuodizhi" type="text" readonly="ture" />
                                    </td> 
                                     <th>
                                        联系方式<span style="font-size: large; font-weight: bold; color: #FF3300"></span>
                                    </th>
                                    <td>
                                        <input id="lianxifangshi" type="text" readonly="ture"/>
                                    </td>
                                </tr>
                                <tr>
                                   
                                    <th>
                                        订单状态
                                    </th>
                                    <td>
                                        &nbsp;<input id="dingdanzhuangtai" type="text" readonly="ture" /></td>

                                    
                                </tr>
                               
                            </table>
                     <table>
                        <div   style="text-align: center; ">
                            <caption style="width: 332px">
                            &nbsp;&nbsp;&nbsp;
                            <a id="queren" class="easyui-linkbutton" onclick="savecp();href='#home' "   href="javascript:void(0)">
                                确认收货</a>&nbsp;   
                        </div></table>
            </div>
        </div>

        
         <div data-role="page" id="cplist"  data-fullscreen="true">
            <div data-theme="a" data-role="header">
               <a id="A1" class="ui-btn-left" data-transition="slide" data-direction="back">返回</a> 
                <h3>订单列表
                </h3>
            </div>
            <div data-role="content">
                <div class="example-wrapper" data-iscroll>
                   
                    <div id="cplistdiv">
                     
                     </div>
                </div>
            </div>
            <div data-theme="a" data-role="footer">
               
            </div>
        </div>

        <div data-role="page" id="cpsearch">
            <div data-theme="a" data-role="header">
                <a id="A2" class="ui-btn-left" data-transition="slide" data-direction="back">返回</a>
                <h3>产品查询
                </h3>
            </div>
            <div data-role="content">
                <div class="example-wrapper" data-iscroll>
                    <div>
                       <table><tr><td> 产品名称:</td><td> <input id="chanpinmingcheng1" type="text" style="width: 151px"  /> </td><td>  <a    onclick="searhlist();">查找</a></td></tr></table>

                    </div>
                    <div id="cpsearchdiv">
                     
                     </div>
                </div>
            </div>
            <div data-theme="a" data-role="footer">
               
            </div>
        </div>

         <div data-role="page" id="zledit"  data-fullscreen="true">
            <div data-theme="a" data-role="header" style="display:inline-block; width:98%;">
                <a id="A4" class="ui-btn-left" data-transition="slide" data-direction="back">返回</a>  <h3> 资料修改
                </h3>
                
            </div>
            <div data-role="none"  >

               <div id="div1"  >
                            <table cellpadding="0" cellspacing="0" border="0" style="padding: 0px; margin: 1px; width: 98%; border-spacing: 0px; table-layout: auto;">
                                 <tr>
                                    <th>
                                        用户名 <span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                         <input id="yonghuming1" name="yonghuming" type="text" readonly="ture"  />
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
                                        联系方式<span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="lianxifangshi1" name="lianxifangshi" type="text" />
                                    </td>
                                </tr>
                                <tr>
                                    <th>
                                        收货地址<span style="font-size: large; font-weight: bold; color: #FF3300">*</span>
                                    </th>
                                    <td>
                                        <input id="shouhuodizhi1" name="shouhuodizhi" type="text" />
                                    </td>
                                </tr>
                            
                            </table>
                   <div   style="text-align: center; ">
                            <caption style="width: 332px">
                            &nbsp;&nbsp;&nbsp;
                            <a id="xiugai" class="easyui-linkbutton" onclick="savezl(); "   href="javascript:void(0)">
                                确认修改</a>&nbsp;   
                               
                        </div>
            </div>
        </div>
      
    </form>
</body>

</html>
