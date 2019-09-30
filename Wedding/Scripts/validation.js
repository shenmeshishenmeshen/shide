function validateData(){
    $("#errInfo").html(""); //清空错误信息
    $("#errInfo2").html("");
    $("#errInfo1").html("");
    $("#errInfo3").html("");
    $("#errInfo").removeClass("errStyle"); //隐藏错误信息区域
    $("#errInfo2").removeClass("errStyle");
    $("#errInfo1").removeClass("errStyle");
    $("#errInfo3").removeClass("errStyle");
	var isValid = true;
    var Pwd = $("#Pwd").val();
    var txtPwd = $("#txtPwd").val();
    var email = $("#youxiang").val();
    var UserName = $("#UserName").val();
   
    var reg = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+((\.[a-zA-Z0-9_-]{2,3}){1,2})$/; //email的正则表达式
    var reg2 = /^[a-zA-Z0-9_-]{6,20}$/;//用户名正则
    var reg3 = /^[A-Za-z]+[0-9]+[A-Za-z0-9]*|[0-9]+[A-Za-z]+[A-Za-z0-9]*$/;//密码正则
    if (Pwd == null || Pwd == "") {
        $("#errInfo2").append("请输入密码！");
        $("#errInfo2").addClass("errStyle");
        isValid = false;

    }
    if (!reg3.test(Pwd)) {
        $("#errInfo2").append("密码不可用！");
        $("#errInfo2").addClass("errStyle");
        isValid = false;

    }
    if (UserName == null || UserName == "") {
        $("#errInfo1").append("请输入用户名！");
        $("#errInfo1").addClass("errStyle");
        isValid = false;

    }
    if (!reg2.test(UserName)) {
        $("#errInfo1").append("请输入正确的用户名！");
        $("#errInfo1").addClass("errStyle");
        isValid = false;

    }
    if (email == null || email == "") {
        $("#errInfo3").append("请输入邮箱！");
        $("#errInfo3").addClass("errStyle");
        isValid = false;

    }
	if(!reg.test(email)){
		$("#errInfo3").append("请输入正确的邮箱！");
		$("#errInfo3").addClass("errStyle");
		isValid = false;
	}
    if (txtPwd== null || txtPwd == "") {
        $("#errInfo").append(" 请输入密码！");
        $("#errInfo").addClass("errStyle");
        isValid = false;
    }
        if (txtPwd!=Pwd) {
            $("#errInfo").append(" 两次密码不一致！");
            $("#errInfo").addClass("errStyle");
            isValid = false;
        }
	return isValid;
}
