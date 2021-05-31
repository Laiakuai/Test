<%@ page import="com.db.StudentsDB" %>
<%@ page import="com.value.Students" %>
<%@ page import="com.db.ClassDB" %>
<%@ page import="java.util.Map" %>
<%@ page import="java.util.Iterator" %><%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/4/10
  Time: 18:48
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>修改学生信息页面</title>

</head>
<body>
<%
    request.setCharacterEncoding("utf-8");
    String studentId = request.getParameter("studentId");
    System.out.println(studentId);
    Students stu = StudentsDB.getStuById(studentId);
%>
<table border="1" cellpadding="2" cellspacing="0" align="center">
    <caption><h2>学生信息修改页面</h2></caption>
    <form action="doUpdateStudents.jsp" method="post">
        <tr>
            <th>学号:</th>
            <td><input type="hidden" name = "studentId" value=<%=stu.getStudentId()%>><%=stu.getStudentId()%></td>
        </tr>

        <tr>
            <th>姓名:</th>
            <td><input type="text" name = "studentName" value=<%=stu.getStudentName()%>></td>
        </tr>

        <tr>
            <th>密码:</th>
            <td><input type="password" name = "studentPwd" value=<%=stu.getStudentPwd()%>></td>
        </tr>

        <tr>
            <th>性别:</th>
            <%
                if(stu.getSex().equals("男")){

            %>
            <td>
                <input type = "radio" name = "sex" value="男" checked>男
                <input type = "radio" name = "sex" value="女">女
            </td>
            <%
                }else{
            %>
            <td>
                <input type = "radio" name = "sex" value="男">男
                <input type = "radio" name = "sex" value="女" checked>女
            </td>
            <%
                }
            %>
        </tr>


        <tr>
            <th>班级</th>
            <td>
                <select name = "classId">
<%--                    <option><%=ClassDB.getClassName(stu.getClassId())%></option>--%>
<%--                    <option value = 10201841>智科1811</option>--%>
<%--                    <option value = 10201842>智科1812</option>--%>
<%--                    <option value = 10201821>软件1811</option>--%>
<%--                    <option value = 10201822>软件1812</option>--%>
<%--                    <option value = 10201811>计算1811</option>--%>
<%--                    <option value = 10201831>网络1811</option>--%>
<%--                    <option value = 10201832>网络1812</option>--%>
                        <%
                            Map<Integer,String> classes = ClassDB.getClassAll();
                        %>
                        <option value = <%=stu.getClassId()%>><%=classes.get(stu.getClassId())%></option>
                        <%
                            classes.remove(stu.getClassId());
                            Iterator<Map.Entry<Integer,String>> it = classes.entrySet().iterator();
                            while(it.hasNext()){
                                Map.Entry<Integer,String> entry= it.next();
                                int classId = entry.getKey();
                                String className = entry.getValue();
                        %>
                                <option value=<%=classId%>><%=className%></option>
                        <%
                            }
                        %>
                </select>
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <input type="submit" name = "submit" value="提交修改">
            </td>
        </tr>
    </form>
</table>
</body>
</html>
