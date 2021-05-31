<%--
  Created by IntelliJ IDEA.
  User: 彭浩
  Date: 2021/3/25
  Time: 23:41
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
  <head>
    <title>99乘法表</title>
  </head>
  <body>
  <table align="cecnter" border = "1">
  <%
    for(int i = 1;i<=9;i++){
  %>
    <tr>
    <%
      for(int j = 1;j<=i;j++){
    %>
      <td>
        <%=i+" * "+j+" = "+(i*j)%>
      </td>
      <%}%>
    </tr>
  <%}%>
  </table>
  </body>
</html>
