package cn.jmu.po;

import cn.jmu.utils.MyBatisUtils;
import org.apache.ibatis.session.SqlSession;
import org.junit.Test;
import java.util.List;

import static org.junit.Assert.*;

public class UserTest {
    @Test
    public void findAllUser() {
        SqlSession sqlSession = MyBatisUtils.getSession();//获取SqlSession
        List<User> list = sqlSession.selectList("cn.jmu.mapper.UserMapper.findAllUser");
        for(User u:list) {
            System.out.println(u);
        }
        sqlSession.close();//关闭SqlSession
    }
}