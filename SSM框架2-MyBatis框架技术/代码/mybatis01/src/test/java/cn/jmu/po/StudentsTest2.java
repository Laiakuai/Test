package cn.jmu.po;

import cn.jmu.utils.MyBatisUtils;
import org.apache.ibatis.session.SqlSession;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class StudentsTest2 {
    private SqlSession sqlSession;

    @Before
    public void setUp() throws Exception {
        this.sqlSession = MyBatisUtils.getSession();//获取sqlSession
    }

    @After
    public void tearDown() throws Exception {
        this.sqlSession.close();
    }

    @Test
    public void findStuById2() {
        Students stu = sqlSession.selectOne("cn.jmu.mapper.StudentsMapper.findStuById","2018110143");
        System.out.println(stu.toString());
    }

    @Test
    public void findStuByName2(){
        List<Students> all = sqlSession.selectList("cn.jmu.mapper.StudentsMapper.findStuByName","飞");
        for(Students stu:all){
            System.out.println(stu);
        }
    }

    @Test
    public void addStu(){
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
    }

    @Test
    public void updateStu(){
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
    }

    @Test
    public void deleteStu(){
        int rows=sqlSession.delete("cn.jmu.mapper.StudentsMapper.delStu", "2018110106");
        if(rows>0){
            System.out.println("您成功删除了 "+rows+"条数据！");
        }else{
            System.out.println("执行删除操作失败！");
        }
        sqlSession.commit();//提交事务
    }
}