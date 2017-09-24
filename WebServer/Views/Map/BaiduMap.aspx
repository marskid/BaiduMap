<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Global.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	BaiduMap
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ScriptHeader" runat="server">
	<script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=s3GCVjiafgN9mAoLU2UGmYpyVTWltG2R"></script>
    <script type="text/javascript" src="http://api.map.baidu.com/library/TextIconOverlay/1.2/src/TextIconOverlay_min.js"></script>
	<script type="text/javascript" src="http://api.map.baidu.com/library/MarkerClusterer/1.2/src/MarkerClusterer_min.js"></script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div id="cityNum">城市：<%= ViewData["CityNum"]%> / <%= ViewData["Cities"]%></div>
    <div id="baiduMap" style="height:100%;width:100%"></div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptContent" runat="server">
    <script type="text/javascript">
        // 百度地图API功能
        var map = new BMap.Map("baiduMap");    // 创建Map实例
        map.centerAndZoom(new BMap.Point(121.315538, 31.278899), 5);  // 初始化地图,设置中心点坐标和地图级别
        map.addControl(new BMap.MapTypeControl());   //添加地图类型控件
        map.centerAndZoom("上海", 12);          // 设置地图显示的城市 此项是必须设置的
        map.enableScrollWheelZoom(true);     //开启鼠标滚轮缩放

        $.getJSON("/Device", function (json) {
            if (json.state == "Success" && json.data) {
                var markers = [];
                $.each(json.data, function (index, point) {
                    markers.push(new BMap.Marker(
                        new BMap.Point(point.longitude, point.latitude)
                    ));
                });
                var markerClusterer = new BMapLib.MarkerClusterer(map, { markers: markers }); //点聚合
            }
        });
    </script>
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="StyleHeader" runat="server">
    <style type="text/css">  
        html{height:100%}  
        body{height:100%;margin:0px;padding:0px}
        #cityNum
        {
            position: absolute;
            top: 0;
            left: 0;
            z-index: 1000;
            background-color: white;
        }
    </style>
</asp:Content>
