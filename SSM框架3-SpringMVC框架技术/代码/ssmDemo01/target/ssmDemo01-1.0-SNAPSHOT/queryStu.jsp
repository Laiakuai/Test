<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>查询学生</title>
</head>
<body>
<h2>查询学生——输入学号查询</h2>
   <form action="${pageContext.request.contextPath}/findStuByStudentId.do" method="post">
    学号：<input type="text" name="studentId"/>
    <input type="submit" value="查询"/>
   </form>
</body>
</html>
