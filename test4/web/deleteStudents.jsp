<%@ page import="com.db.StudentsDB" %><%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/10
  Time: 15:08
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>删除学生信息</title>
</head>
<body>
    <%
        String studentId = (String)request.getParameter("studentId");
        System.out.println(studentId);
        if (StudentsDB.deleteStudent(studentId)!=0){

    %>
        <h2>成功删除学号为：<%=studentId%>的学生记录</h2>
    <%
        }else{
    %>
        <h2>不存在学生学号为：<%=studentId%>的学生记录</h2>
    <%
        }
    %>
    <br>
    <h2>点此返回<a href="showStudents.jsp">学生信息</a>页面</h2>
</body>
</html>
