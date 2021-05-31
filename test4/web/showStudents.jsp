<%@ page import="com.value.Students" %>
<%@ page import="java.util.List" %>
<%@ page import="java.util.ArrayList" %>
<%@ page import="com.db.StudentsDB" %><%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/9
  Time: 8:59
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>显示所有学生信息</title>
</head>
<body>
    <div align="center">
        <form action="doSearch.jsp" method="post" >
            <tr>
                <td>
                    <input type="text" name="search">
                </td>
                <td>
                    <input type = "submit" value="提交">
                </td>
            </tr>
        </form>
    </div>


    <table border="2" align="center">
        <caption>显示所有学生信息</caption>
        <tr><th>学号</th><th>姓名</th><th>密码</th><th>性别</th><th>班级号<th>修改</th><th>删除</th></tr>
        <%
            List<Students> student = new ArrayList<Students>();
            student = StudentsDB.getAllStudents();
            if(student.size()!=0){
                for(int i = 0;i < student.size();i++){
                    Students stu = (Students) student.get(i);
        %>
        <tr>
            <td><%=stu.getStudentId()%></td>
            <td><%=stu.getStudentName()%></td>
            <td><%=stu.getStudentPwd()%></td>
            <td><%=stu.getSex()%></td>
            <td><%=stu.getClassId()%></td>
            <td><a href="updateStudents.jsp?studentId=<%=stu.getStudentId()%>">修改</a></td>
            <td><a href="deleteStudents.jsp?studentId=<%=stu.getStudentId()%>">删除</a></td>
        <tr/>
        <%
                }
            }
        %>
    </table>
    <p align="center"><a href="insertStudents.jsp"> 插入一个学生信息</a></p>
</body>
</html>
