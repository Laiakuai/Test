<%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/1
  Time: 11:45
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>成功登入页面</title>
</head>
<body>
<%
    if(session.getAttribute("flag")!= null){
%>
    <h2>成功登入</h2>
    <%
        String name = (String)session.getAttribute("name");
        String id = (String)session.getAttribute("id");
        String age = (String)session.getAttribute("age");
//        String name = request.getParameter("name");
//        String id = request.getParameter("id");
//        String age = request.getParameter("name");

    %>
    <span style="color:blue">
        <%= "欢迎"+age+"的id为"+id+"的"+name+"光临本站"%>
    </span>
    <%
        Object count = application.getAttribute("count");
        if(count == null){
            application.setAttribute("count",1);
    %>
        <h3>自从服务器启动后已经有<%= 1%>个人访问了登入成功页面</h3>
    <%
        }else{
            int co = Integer.parseInt(count.toString());
    %>
    <h3>自从服务器启动后已经有<%= ++co%>个人访问了登入成功页面</h3>
    <%
            application.setAttribute("count",co);
        }
    %>
    <h2> <a href="login_out.jsp">注销</a> </h2>
<%
    }else{
        response.setHeader("refresh","5;URL=login.html");
%>
<h2>您还未登入，五秒后自动跳转到登入页面或者点击<a href="login.html">这里</a>马上跳转</h2>
<%
    }
%>
</body>
</html>
