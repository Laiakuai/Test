package jmu.assemble;

import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import static org.junit.Assert.*;

public class StudentTest {
    @Test
    public void stuTest1(){
        //1.初始化Sprinp容器，加载配置文件
        ApplicationContext app =
                new ClassPathXmlApplicationContext("applicationContext.xml");
        //2.通过容器，获取对象
        Student stu1 = (Student) app.getBean("stu1");
        Student stu2 = (Student) app.getBean("stu2");
        //3.对象调用方法
        System.out.println(stu1.toString());
        System.out.println(stu1.toString());
    }
}