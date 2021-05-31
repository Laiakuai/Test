package jmu.test;

import jmu.po.Students;
import jmu.service.StudentsService;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class StudentsTest {
    @Test
    public void findStuByStudentId() {
        ApplicationContext app = new ClassPathXmlApplicationContext("classpath:applicationContext.xml");
        StudentsService studentsService = (StudentsService)app.getBean("studentsServiceImpl");
        Students stu = studentsService.findStuByStudentId("2018130173");
        System.out.println(stu);
    }
}
