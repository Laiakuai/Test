package cn.jmu.po;

import cn.jmu.utils.MyBatisUtils;
import org.apache.ibatis.session.SqlSession;
import org.junit.Test;
import java.util.List;
import static org.junit.Assert.*;

public class StudentsTest {
    //根据学生Id获取学生信息
    @Test
    public void findStuById() {
        SqlSession sqlSession = MyBatisUtils.getSession();//获取sqlSession
        //sqlSession执行查询操作
        Students stu = sqlSession.selectOne("cn.jmu.mapper.StudentsMapper.findStuById","2018110143");
        System.out.println(stu.toString());
        sqlSession.close();
    }

    //根据学生姓名模糊查询学生信息列表
    @Test
    public void findStuByName(){
        SqlSession sqlSession = MyBatisUtils.getSession();//获取sqlSession
        List<Students> all = sqlSession.selectList("cn.jmu.mapper.StudentsMapper.findStuByName","飞");
        for(Students stu:all){
            System.out.println(stu);
        }
        sqlSession.close();
    }

    //添加学生信息
    @Test
    public void addStu(){
        SqlSession sqlSession = MyBatisUtils.getSession();//获取sqlSession
        //创建学生对象
        Students s=new Students();
        s.setStudentId("2018110106");
        s.setStudentName("李萌萌");
        s.setStudentPwd("123");
        s.setSex("女");
        s.setClassId(10201821);
        int rows = sqlSession.insert("cn.jmu.mapper.StudentsMapper.addStu", s);
        if(rows > 0) {
            System.out.println("您成功插入了 "+rows+"条数据！");
        }else {
            System.out.println("执行插入操作失败！");
        }
        sqlSession.commit();	//提交事务
        sqlSession.close();
    }

    //更新学生信息
    @Test
    public void updateStu(){
        SqlSession sqlSession=MyBatisUtils.getSession();//获取SqlSession
        //创建学生对象
        Students s=new Students();
        s.setStudentId("2018110106");
        s.setStudentName("李小萌");
        s.setStudentPwd("123");
        s.setSex("男");
        s.setClassId(10201822);
        //
        int rows=sqlSession.insert("cn.jmu.mapper.StudentsMapper.updateStu",s);
        if(rows>0){
            System.out.println("您成功修改了 "+rows+"条数据！");
        }else{
            System.out.println("执行修改操作失败！");
        }
        sqlSession.commit();//提交事务
        sqlSession.close();//关闭SqlSession
    }

    //删除指定学生Id的学生信息
    @Test
    public void deleteStu(){
        SqlSession sqlSession=MyBatisUtils.getSession();//获取SqlSession
        int rows=sqlSession.delete("cn.jmu.mapper.StudentsMapper.delStu", "2018110106");
        if(rows>0){
            System.out.println("您成功删除了 "+rows+"条数据！");
        }else{
            System.out.println("执行删除操作失败！");
        }
        sqlSession.commit();//提交事务
        sqlSession.close();//关闭SqlSession
    }
}