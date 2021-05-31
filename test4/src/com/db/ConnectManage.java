package com.db;

import javax.xml.transform.Result;
import java.sql.*;

public class ConnectManage {
    private static final String DRIVER_CLASS = "com.mysql.cj.jdbc.Driver";
    private static final String DATABASE_URL="jdbc:mysql://127.0.0.1:3306/test? useSSL=false & serverTimezone=UTC";
    private static final String DATABASE_USER = "root";
    private static final String DATABASE_PASSWORD="070101";
//    返回连接方法
    public static Connection getConnection(){
        Connection dbConnection = null;
        try{
            Class.forName(DRIVER_CLASS);
            dbConnection = DriverManager.getConnection(DATABASE_URL,DATABASE_USER,DATABASE_PASSWORD);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return dbConnection;
    }
//    关闭连接方法
    public static void closeConnect(Connection dbConnection){
        try{
            if(dbConnection!=null&&(!dbConnection.isClosed())){
                dbConnection.close();
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }
//    关闭结果集
    public static void closeResultSet(ResultSet res){
        try{
            if(res !=null){
                res.close();
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }
//    关闭语句
    public static void closeStatement(PreparedStatement pStatement){
        try{
            if(pStatement!=null){
                pStatement.close();
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }
    public static void closeStatement(Statement pStatement){
        try{
            if(pStatement!=null){
                pStatement.close();
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }
}
