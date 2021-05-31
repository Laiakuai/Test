package com.db;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ClassDB {
    public static String getClassName(int classId){
        ResultSet res = null;
        Connection con = null;
        PreparedStatement pStatement = null;
        String className = null;
        try{
            con = ConnectManage.getConnection();
            String strSql = "select * from classes where classId =?";
            pStatement = con.prepareStatement(strSql);
            pStatement.setInt(1,classId);
            res = pStatement.executeQuery();
            if(res.next()){
                className = res.getString("className");
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }finally {
            ConnectManage.closeResultSet(res);
            ConnectManage.closeStatement(pStatement);
            ConnectManage.closeConnect(con);
        }
        return className;
    }
    public static Map<Integer,String> getClassAll(){
        ResultSet res = null;
        Connection con = null;
        PreparedStatement pStatement = null;
        Map<Integer,String> classes = new HashMap<Integer,String>();
        try{
            con = ConnectManage.getConnection();
            String sqlStr = "select * from classes ";
            pStatement = con.prepareStatement(sqlStr);
            res = pStatement.executeQuery();
            while(res.next()){
                int classId = res.getInt(1);
                String className = res.getString(2);
                classes.put(classId,className);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }finally {
            ConnectManage.closeResultSet(res);
            ConnectManage.closeStatement(pStatement);
            ConnectManage.closeConnect(con);
        }
        return classes;
    }
}
