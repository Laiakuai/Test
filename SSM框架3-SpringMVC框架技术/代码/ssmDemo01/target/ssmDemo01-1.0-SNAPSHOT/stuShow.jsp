<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>学生信息页面</title>
</head>
<body>
<table border="1">
    <tr><th>学号</th><th>姓名</th><th>密码</th><th>性别</th><th>班级号</th></tr>
    <tr>
        <td>${students.studentId}</td>
        <td>${students.studentName}</td>
        <td>${students.studentPwd}</td>
        <td>${students.sex}</td>
        <td>${students.classId}</td>
    </tr>
</table>
</body>
</html>
