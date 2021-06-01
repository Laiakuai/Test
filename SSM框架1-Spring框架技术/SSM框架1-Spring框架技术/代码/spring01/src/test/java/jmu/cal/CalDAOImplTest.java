package jmu.cal;

import jmu.cal.CalDAOImpl;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class CalDAOImplTest {
    @Test
    public void calDAOTest(){
      ApplicationContext app =
            new ClassPathXmlApplicationContext("applicationContext2.xml");
      CalDAO cal = (CalDAO) app.getBean("calDAO");
      int result1 = cal.add(3,4);
      System.out.println("add-->"+result1);
      int result2 = cal.div(10,2);
      System.out.println("div-->"+result1);
    }
}