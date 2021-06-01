package jmu.annotation;

import com.sun.source.tree.LambdaExpressionTree;
import jmu.assemble.Student;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import static org.junit.Assert.*;

public class BookControllerTest {
    @Test
    public void bookTest(){
        //1.初始化Sprinp容器，加载配置文件
        ApplicationContext app =
                new ClassPathXmlApplicationContext("applicationContext2.xml");
        //2.通过容器，获取对象
        BookController bookController =(BookController) app.getBean("bookController");
        //3.对象调用方法
        bookController.save();
    }
}