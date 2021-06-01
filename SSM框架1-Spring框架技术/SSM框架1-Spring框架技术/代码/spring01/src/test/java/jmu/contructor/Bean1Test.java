package jmu.contructor;

import jmu.ioc.StudentDAO;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import static org.junit.Assert.*;

public class Bean1Test {
    @Test
    public void testBean1(){
        //1.初始化Sprinp容器，加载配置文件
        ApplicationContext app =
                new ClassPathXmlApplicationContext("applicationContext.xml");
        //2.通过容器，获取对象
        Bean1 bean1 = (Bean1) app.getBean("bean1");
        //3.对象调用方法
        System.out.println(bean1.toString());
    }
}