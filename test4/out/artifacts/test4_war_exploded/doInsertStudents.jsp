<%@ page import="com.value.Students" %>
<%@ page import="com.db.StudentsDB" %><%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/10
  Time: 16:32
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>处理插入学生的信息</title>
</head>
<body>
    <%
        request.setCharacterEncoding("utf-8");
        String studentId = request.getParameter("studentId");
        String studentName = request.getParameter("studentName");
        String studentPwd = request.getParameter("studentPwd");
        String sex = request.getParameter("sex");
        int classId = Integer.parseInt(request.getParameter("classId"));
        Students stu = new Students(studentId,studentName,studentPwd,sex,classId);
        System.out.println(stu.toString());
        int flag = StudentsDB.insertStudent(stu);
        if(flag!=0){

    %>
            <h2>插入学生信息成功</h2>
    <%
        }else{
    %>
            <h2>插入学生信息失败</h2>
    <%
        }
    %>
<h2>点击此返回查看<a href="showStudents.jsp">学生信息</a>页面</h2>
</body>
</html>
