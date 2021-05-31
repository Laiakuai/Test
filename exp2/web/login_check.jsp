<%@ page import="java.sql.*" %><%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/1
  Time: 10:19
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>login_check</title>
</head>
<body>
<!-- 获取密码和账号-->
    <%
    request.setCharacterEncoding("utf-8");
    String name = request.getParameter("name");
    String id = request.getParameter("id");
    %>
    <%!public static final String DBDRIVER = "com.mysql.cj.jdbc.Driver";
        public static final String DBURL = "jdbc:mysql://127.0.0.1:3306/test? characterEncoding=utf8 & useSSL=false & serverTimezone=UTC & rewriteBatchedStatements=true";
        public static final String DBUSER = "root";
        public static final String DBPASS = "070101";
    %>
    <%
        Connection coon = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        boolean flag = false;
        String age = null;
    %>
    <%
        request.setCharacterEncoding("utf-8");
        try{
            Class.forName(DBDRIVER);
            coon = DriverManager.getConnection(DBURL,DBUSER,DBPASS);
            String sql="select name from t_person where name=? and id=?";
            pstmt = coon.prepareStatement(sql);
            pstmt.setString(1,name);
            pstmt.setString(2,id);
            rs = pstmt.executeQuery();
            if(rs.next()){
                age = rs.getString(1);
                flag = true;
            }
        }catch(Exception e){
            System.out.println(e);
        }finally {
            rs.close();
            pstmt.close();
            coon.close();
        }
    %>
    <%if(flag){%>
<% session.setAttribute("name",name);%>
<% session.setAttribute("id",id);%>
<% session.setAttribute("age",age);%>
<%
  session.setAttribute("flag","OK");
%>
<%
    response.sendRedirect("login_success.jsp");
%>
<%}else{
        response.sendRedirect("login_fail.jsp");
%>
<%}%>
</body>
</html>
