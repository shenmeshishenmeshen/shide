//function select(i)
//{
//    var box = document.getElementById("box");
//    if (i== 0) {
//        box.style.top = 0;
//    } else {
//        var pp = parseInt(box.style.top) || 0;
//        animate(box, { top: pp }, { top: (-i * 150) - pp }, 500, Quad);
//    }
//    //切换时 改变按钮颜色
//    //        先重置所有的按钮颜色
//    var lias = document.getElementsByTagName("li");
//    for (var j = 0; j < lias.length; j++) {
//        lias[j].style.background = "aquamarine";
//    }
//    document.getElementById("li_" + i).style.background = "#FF0";
//}
//自动切换
//function autoslect() {
//    var a = 0;
//    setInterval(function () {
//        select(a);
//        if (a < 4) {
//            a++;
//        } else {
//            a = 0;
//        }
//    }, 1000);
//}
//window.onload = function () {
//    autoslect();
//}
/*
 参数说明
 curTime:当前时间,即动画已经进行了多长时间,开始时间为0
 start:开始值
 dur:动画持续多长时间
 alter:总的变化量
 */
//left 从100 增加到150，增加了50
//function animate(o, start, alter, dur, fx) {
//    var curTime = 0;
//    var t = setInterval(function () {
//        if (curTime >= dur) clearInterval(t);
//        for (var i in start) {
//            o.style[i] = fx(start[i], alter[i], curTime, dur) + "px";
//        }
//        curTime += 50;

//    }, 50);
//}
//function Quad(start, alter, curTime, dur) {
//    return start + Math.pow(curTime / dur, 2) * alter;
//}

    var pageHeight = document.documentElement.clientHeight;    //获取可视区域的高度

    window.onscroll = function () {        //onscroll 事件在元素滚动时执行

        var backtop = $(document).scrollTop();
        //获取滚动条滚动的垂直距离
        if (backtop >=180) {

            $('#dtop').show();
            $('#searcht').show();
            //若滚动条滚动的垂直距离大于180px,则显示“回到顶部”链接,否则隐藏

        } else {

            $("#dtop").hide();
            $("#searcht").hide();

        }
    }
    $(function () {
        $("#dtop").click(function () {
            $("html,body").animate({ scrollTop: 0 }, 500);
        });
        $("#btn_open").click(function () {
            $('.searchmain').css({ 'display': 'inline-block', 'height': '600px' });
            $("#btn_open").hide();
        });
        $("#btn_close").click(function () {
            $(".searchmain").hide();
            $("#btn_open").show();
        });
       
});


