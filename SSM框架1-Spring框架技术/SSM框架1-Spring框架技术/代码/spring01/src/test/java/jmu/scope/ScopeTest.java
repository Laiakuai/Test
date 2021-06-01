package jmu.scope;

import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import static org.junit.Assert.*;

public class ScopeTest {
    @Test
    public void scopeTest1(){
        //1.初始化Sprinp容器，加载配置文件
        ApplicationContext app =
                new ClassPathXmlApplicationContext("applicationContext.xml");
        //2.通过容器，获取对象
        Scope scopea = (Scope) app.getBean("scope1");
        Scope scopeb = (Scope) app.getBean("scope1");
        //3.对象调用方法
        System.out.println(scopea.toString());
        System.out.println(scopeb.toString());
    }
    @Test
    public void scopeTest2(){
        //1.初始化Sprinp容器，加载配置文件
        ApplicationContext app =
                new ClassPathXmlApplicationContext("applicationContext.xml");
        //2.通过容器，获取对象
        Scope scopea = (Scope) app.getBean("scope2");
        Scope scopeb = (Scope) app.getBean("scope2");
        //3.对象调用方法
        System.out.println(scopea.toString());
        System.out.println(scopeb.toString());
    }
}