<%@ page import="com.value.Students" %>
<%@ page import="com.db.StudentsDB" %><%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/10
  Time: 18:48
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>处理修改页面</title>
</head>
<body>
    <%
        request.setCharacterEncoding("utf-8");
        String studentId =request.getParameter("studentId");
        String studentName = request.getParameter("studentName");
        String studentPwd = request.getParameter("studentPwd");
        String sex = request.getParameter("sex");
        int classId = Integer.parseInt(request.getParameter("classId"));
        Students stu = new Students(studentId,studentName,studentPwd,sex,classId);
        System.out.println(stu.toString());
        int flag = StudentsDB.updateStudents(stu);
        if(flag!=0){
    %>
            <h3>修改成功</h3>
    <%
        }else{
    %>
            <h3>修改失败</h3>
    <%
        }
    %>
    <h3>点击此处返回<a href="showStudents.jsp">学生查看信息</a>页面</h3>
</body>
</html>
