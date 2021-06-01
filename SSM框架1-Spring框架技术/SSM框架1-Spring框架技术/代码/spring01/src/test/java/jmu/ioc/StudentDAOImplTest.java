package jmu.ioc;

import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import static org.junit.Assert.*;

public class StudentDAOImplTest {
 @Test
    public void test1(){
      //1.初始化Sprinp容器，加载配置文件
      ApplicationContext app =
              new ClassPathXmlApplicationContext("applicationContext.xml");
      //2.通过容器，获取对象
      StudentDAO studentDAO = (StudentDAO) app.getBean("studentDAO");
      //3.对象调用say()方法
      studentDAO.say();
    }
}