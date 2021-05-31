package com.db;

import com.value.Students;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class StudentsDB {
    public  static List<Students> getAllStudents(){
        List<Students> student = new ArrayList<Students>();
        Connection con = null;
        PreparedStatement pStatement = null;
        ResultSet res = null;
        try{
            con = ConnectManage.getConnection();
            String sql = "select * from students";
            pStatement = con.prepareStatement(sql);
            res = pStatement.executeQuery();
            while(res.next()){
                String studentId = res.getString(1);
                String studentName = res.getString(2);
                String studentPwd = res.getString(3);
                String sex = res.getString(4);
                int classId = res.getInt(5);
                Students stu = new Students(studentId,studentName,studentPwd,sex,classId);
                student.add(stu);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }finally {
            ConnectManage.closeResultSet(res);
            ConnectManage.closeStatement(pStatement);
            ConnectManage.closeConnect(con);
        }
        return student;
    }
    public  static int  deleteStudent(String studentId){
        Connection con = null;
        PreparedStatement pStatement = null;
        int row = 0;
        try{
            con = ConnectManage.getConnection();
            String strSql = "delete from students where studentId=?";
            pStatement = con.prepareStatement(strSql);
            pStatement.setString(1,studentId);
            row = pStatement.executeUpdate();
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }finally {
             ConnectManage.closeStatement(pStatement);
             ConnectManage.closeConnect(con);
        }
        return row;
    }
    public static int insertStudent(Students stu){
        Connection con = null;
        PreparedStatement pStatement = null;
        int flag = 1;
        try{
            String strSql = "insert into students values(?,?,?,?,?)";
            con = ConnectManage.getConnection();
            pStatement = con.prepareStatement(strSql);
            pStatement.setString(1,stu.getStudentId());
            pStatement.setString(2,stu.getStudentName());
            pStatement.setString(3, stu.getStudentPwd());
            pStatement.setString(4, stu.getSex());
            pStatement.setInt(5,stu.getClassId());
            pStatement.executeUpdate();
        } catch (SQLException throwables) {
            throwables.printStackTrace();
            flag = 0;
        }finally {
            ConnectManage.closeStatement(pStatement);
            ConnectManage.closeConnect(con);
        }
        return flag;
    }
    public static int updateStudents(Students stu){
        Connection con = null;
        PreparedStatement pStatement = null;
        int row = 0;
        try{
            con = ConnectManage.getConnection();
            String strSql = "update students set studentName=?,studentPwd=?,sex=?,classId=? where studentId=?";
            pStatement=con.prepareStatement(strSql);
            pStatement.setString(1,stu.getStudentName());
            pStatement.setString(2,stu.getStudentPwd());
            pStatement.setString(3,stu.getSex());
            pStatement.setInt(4,stu.getClassId());
            pStatement.setString(5,stu.getStudentId());
            row = pStatement.executeUpdate();

        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }finally {
            ConnectManage.closeStatement(pStatement);
            ConnectManage.closeConnect(con);
        }
        return row;
    }
    public static Students getStuById(String stuId){
        Connection con = null;
        PreparedStatement pStatement = null;
        ResultSet res = null;
        Students stu = null;
        try{
            con = ConnectManage.getConnection();
            String strSql = "select * from students where studentId=?";
            pStatement = con.prepareStatement(strSql);
            pStatement.setString(1,stuId);
            res = pStatement.executeQuery();
            if(res.next()){
                String studentId = res.getString("studentId");
                String studentName = res.getString("studentName");
                String studentPwd = res.getString("studentPwd");
                String sex = res.getString("sex");
                int classId = res.getInt("classId");
                 stu = new Students(studentId,studentName,studentPwd,sex,classId);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }finally {
            ConnectManage.closeResultSet(res);
            ConnectManage.closeStatement(pStatement);
            ConnectManage.closeConnect(con);
        }
        return stu;
    }
    public static List<Students> getStudentsLike(String str) {
        Connection con = null;
        PreparedStatement pStatement = null;
        ResultSet res = null;
        String strsql = null;
        List<Students> student = new ArrayList<Students>();
        try {
            con = ConnectManage.getConnection();
            strsql = "select * from students where studentId like ? or studentName like ? or sex like ? or classId like ?";
            pStatement = con.prepareStatement(strsql);
            pStatement.setString(1, '%' + str + '%');
            pStatement.setString(2, '%' + str + '%');
            pStatement.setString(3, '%' + str + '%');
            pStatement.setString(4, '%' + str + '%');
            res = pStatement.executeQuery();
            while (res.next()) {
                String studentId = res.getString(1);
                String studentName = res.getString(2);
                String studentPwd = res.getString(3);
                String sex = res.getString(4);
                int classId = res.getInt(5);
                Students stu = new Students(studentId, studentName, studentPwd, sex, classId);
                student.add(stu);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        } finally {
            ConnectManage.closeResultSet(res);
            ConnectManage.closeStatement(pStatement);
            ConnectManage.closeConnect(con);
        }
        return student;
    }
}
