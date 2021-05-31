<%@ page import="java.util.List" %>
<%@ page import="com.value.Students" %>
<%@ page import="java.util.ArrayList" %>
<%@ page import="com.db.StudentsDB" %><%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/16
  Time: 8:04
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>模糊查询</title>
</head>
<body>
    <%
        request.setCharacterEncoding("utf-8");
        String str= request.getParameter("search");
        List<Students> student;
        student = StudentsDB.getStudentsLike(str);
    %>
    <table border="1" align="center">
        <caption>显示模糊查询学生信息</caption>
        <tr><th>学号</th><th>姓名</th><th>密码</th><th>性别</th><th>班级号<th>修改</th><th>删除</th></tr>
        <%
            if(student.size()!=0){
                for (int i = 0;i<student.size();i++){
                    Students stu = student.get(i);

        %>
        <tr>
            <td><%=stu.getStudentId()%></td><td><%=stu.getStudentName()%></td><td><%=stu.getStudentPwd()%></td><td><%=stu.getSex()%></td><td><%=stu.getClassId()%></td>
        </tr>
        <%
                }
            }
        %>
    </table>
    <h3>点击此处返回<a href="showStudents.jsp">学生信息</a>页面 </h3>
</body>
</html>
