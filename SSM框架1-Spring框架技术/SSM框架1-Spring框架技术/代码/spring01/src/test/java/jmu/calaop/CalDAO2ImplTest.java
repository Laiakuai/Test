package jmu.calaop;

import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import static org.junit.Assert.*;

public class CalDAO2ImplTest {
    @Test
    public void cal2Test(){
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext2.xml");
        CalDAO2 cal2 = (CalDAO2)app.getBean("cal2");
        cal2.add(3,4);
        cal2.div(10,2);
    }
}