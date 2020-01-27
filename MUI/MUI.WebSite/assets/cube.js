$(function () {
    //图片跟随鼠标预览功能
    $(".div_image").hover(function () {
        // over
        //鼠标移入当前列透明度为1 其他列为0.5
        //$(this).css("opaacity", "1").siblings("li").addClass("opacity_li");

        var $imgsrc = $(this).attr("src");
        var $div = "<div class='div_image_append'><img style='width: 500px; height: 400px;' src='" + $imgsrc + "'/></div>";
        $("#div_footer").append($div);
        //$("div img").attr("src", $imgsrc);
    }, function () {
        // out
        //鼠标移出的时候把其他列透明度去掉
        //$(this).siblings().removeClass("opacity_li");
        $(".div_image_append").remove();
    }).mousemove(function (e) {
        var wh = $(window).height();
        var ph = e.pageY;
        var diff = wh - ph;
        var offset = 10;
        if (diff < 420) offset = diff - 450;
        //console.log("wh:" + wh + " ph:" + ph + " diff:" + diff + " offset:" + offset);
        $(".div_image_append").css({
            position: "absolute",
            left: e.pageX + 10,
            top: e.pageY + offset
        }); //设置div绝对定位 坐标就是距离鼠标当前的位置 
    });
    //panel显示
    $(".panel_show").click(function () {
        var id = $(this).data("id");
        var url = $(this).data("url");
        //console.log("id:" + id + " url:" + url);
        query_data(id, url);

    });
    function query_data(id, url) {
        //var act = "/Sale/SalesPay/Query_SalesPay";
        $.ajax({
            url: url,
            data: { id: id },
            success: function (data) {
                $("#kt_quick_panel_content").html(data);
                $("#kt_quick_panel_toggler_btn").trigger("click");
            }
        });
    }
    //弹出提示对话框
    $('.swal_tip').click(function (e) {
        var title = $(this).data("title");
        var url = $(this).data("url");
        var type = $(this).data("type");

        swal.fire({
            title: title,
            type: type,
            showCancelButton: true,
            buttonsStyling: false,
            confirmButtonClass: "btn btn-brand",
            cancelButtonClass: "btn btn-secondary",
            confirmButtonText: "<i class='la la-check'></i>确 认  ",
            cancelButtonText: "<i class='la la-close'></i>取 消  "
        }).then(function (result) {
            if (result.value) {
               //确认
                window.location.href = url;
            } else if (result.dismiss === 'cancel') {
               //取消
            }
        });
    });
});