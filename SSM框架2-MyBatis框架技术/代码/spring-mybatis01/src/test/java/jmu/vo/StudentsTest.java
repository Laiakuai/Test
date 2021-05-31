package jmu.vo;

import jmu.mapper.StudentsMapper;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import static org.junit.Assert.*;

public class StudentsTest {
    @Test
    public void findStuByIdTest(){
        ApplicationContext app =
                new ClassPathXmlApplicationContext("applicationContext.xml");
        StudentsMapper stuMapper = app.getBean(StudentsMapper.class);
        Students stu = stuMapper.findStuByStudentId("2018130173");
        System.out.println(stu.toString());
    }
}