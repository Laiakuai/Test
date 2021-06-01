package jmu.jdbc;

import org.junit.jupiter.api.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.jdbc.core.JdbcTemplate;

import java.util.List;

public class JdbcTest {
    @Test
    public void mainTest() {
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext.xml");
        JdbcTemplate jdTemplate = (JdbcTemplate) app.getBean("jdbcTemplate");
        jdTemplate.execute("create table account("
                + "id int primary key auto_increment, "
                + "username varchar(50),"
                + "balance double)");
        System.out.println("账户表 account 创建成功！ ");
    }

    @Test
    public void addAccountTest() {
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext.xml");
        AccountDAO accountDAO = (AccountDAO)app.getBean("accountDAO");
        Account acc = new Account();
        acc.setUsername("Tom");
        acc.setBalance(1000.00);
        int num = accountDAO.addAccount(acc);
        if(num > 0) {
            System.out.println("成功插入了"+num+"条数据！");
        }else {
            System.out.println("插入操作执行失败！");
        }
    }

    @Test
    public void updateAccountTest() {
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext.xml");
        AccountDAO accountDAO = (AccountDAO)app.getBean("accountDAO");
        Account acc = new Account();
        acc.setId(1);
        acc.setUsername("Tom");
        acc.setBalance(2000.00);
        int num = accountDAO.updateAccount(acc);
        if(num > 0) {
            System.out.println("成功修改了"+num+"条数据！");
        }else {
            System.out.println("修改操作执行失败！");
        }3



    }

    @Test
    public void deleteAccountTest() {
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext.xml");
        AccountDAO accountDAO = (AccountDAO)app.getBean("accountDAO");
        int num = accountDAO.deleteAccount(1);
        if(num > 0) {
            System.out.println("成功删除了"+num+"条数据！");
        }else {
            System.out.println("删除操作执行失败！");
        }
    }

    @Test
    public void findAccountByIdTest() {
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext.xml");
        AccountDAO accountDAO = (AccountDAO)app.getBean("accountDAO");
        Account acc = accountDAO.findById(3);
        System.out.println(acc);
    }

    @Test
    public void findAccountAll() {
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext.xml");
        AccountDAO accountDAO = (AccountDAO)app.getBean("accountDAO");
        List<Account> list = accountDAO.findAll();
        for(Account acc:list) {
            System.out.println(acc);
        }
    }
    @Test
    public void transTest() {
        ApplicationContext app = new ClassPathXmlApplicationContext("applicationContext.xml");
        AccountDAO accountDAO = (AccountDAO)app.getBean("accountDAO");
        accountDAO.transfer("Bill","Mary", 100.0);
        System.out.println("转账成功！");
    }
}
