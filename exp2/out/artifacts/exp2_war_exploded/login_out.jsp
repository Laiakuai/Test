<%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/6
  Time: 21:13
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>注销页面</title>
</head>
<body>
    <%
        session.invalidate();
    %>
<h2> <a href="login_success.jsp"> 返回登入成功页面</a> </h2>
</body>
</html>
