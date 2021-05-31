package cn.jmu.po;

import cn.jmu.utils.MyBatisUtils;
import org.apache.ibatis.session.SqlSession;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class StudentsTest {
    private SqlSession sqlSession;
    @Before
    public void setUp() throws Exception {
        this.sqlSession = MyBatisUtils.getSession();
    }
    @After
    public void tearDown() throws Exception {
        this.sqlSession.close();
    }

    @Test
    public void findStuByNameAndSexTest(){
        Students stu = new Students();
        stu.setStudentName("林");
        stu.setSex("男");
        List<Students> list = sqlSession.selectList("cn.jmu.mapper.StudentsMapper.findStuByNameAndSex", stu);
        for(Students ss : list) {
            System.out.println(ss);
        }
    }

    @Test
    public void findStuByNameOrClassId(){
        Students stu = new Students();
        stu.setStudentName("林");
        //stu.setClassId(10201841);
        List<Students> list =
                sqlSession.selectList("cn.jmu.mapper.StudentsMapper.findStuByNameOrClassId", stu);
        for(Students ss : list) {
            System.out.println(ss);
        }
    }

    @Test
    public void updateStu2Test(){
        Students stu = new Students();
        stu.setStudentId("2018110116");
        stu.setStudentName("谢菲菲");
        stu.setSex("女");
        int rows = sqlSession.update("cn.jmu.mapper.StudentsMapper.updateStu2", stu);
        if(rows>0){
            System.out.println("您成功修改了 "+rows+"条数据！");
        }else{
            System.out.println("执行修改操作失败！");
        }
        sqlSession.commit();//提交事务
    }

    @Test
    public void findStuByClassIdsTest(){
        List<Integer> classIds = new ArrayList<Integer>();
        classIds.add(10201821);
        classIds.add(10201841);
        List<Students> all =
                sqlSession.selectList("cn.jmu.mapper.StudentsMapper.findStuByClassIds", classIds);
        for(Students stu: all) {
            System.out.println(stu);
        }
    }
}