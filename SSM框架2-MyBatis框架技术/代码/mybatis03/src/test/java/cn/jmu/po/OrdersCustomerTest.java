package cn.jmu.po;

import cn.jmu.utils.MyBatisUtils;
import org.apache.ibatis.session.SqlSession;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

public class OrdersCustomerTest {
    private SqlSession sqlSession;

    @Before
    public void setUp() throws Exception {
        this.sqlSession = MyBatisUtils.getSession();
    }

    @After
    public void tearDown() throws Exception {
        this.sqlSession.close();
    }

    //一对一查询测试，查询订单关联的用户，使用resultType方法
    @Test
    public void findOrdersCustomer1Test(){
        List<OrdersCustomer> all =
                sqlSession.selectList("cn.jmu.mapper.OrdersMapperCustomer.findOrdersCustomer1");
        for(OrdersCustomer oc : all) {
            System.out.println(oc.toString());
        }
    }

    //一对一查询测试，查询订单关联的用户，使用resultMap方法
    @Test
    public void findOrdersCustomer2Test(){
        List<cn.jmu.po2.Orders> all =
                sqlSession.selectList("cn.jmu.mapper.OrdersMapperCustomer.findOrdersCustomer2");
        for(cn.jmu.po2.Orders oc : all) {
            System.out.println(oc.toString());
        }
    }

    //一对多查询测试，查询订单及关联订单详情，使用resultMap方法
    @Test
    public void findOrderAndDetailTest(){
        List<cn.jmu.po3.Orders> all =
                sqlSession.selectList("cn.jmu.mapper.OrdersMapperCustomer.findOrderAndDetail");
        for(cn.jmu.po3.Orders oc : all) {
            System.out.println(oc.toString());
        }
    }

    //多对多查询测试，查询用户及其购买商品详情，使用resultMap方法
    @Test
    public void findCustomerAndItemsTest(){
        List<cn.jmu.po4.Customer> all =
                sqlSession.selectList("cn.jmu.mapper.OrdersMapperCustomer.findCustomerAndItems");
        for(cn.jmu.po4.Customer oc : all) {
            System.out.println(oc.toString());
        }
    }
}