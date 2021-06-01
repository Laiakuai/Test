package jmu.jdbc;

import org.springframework.jdbc.core.BeanPropertyRowMapper;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

public class AccountDAOImpl implements AccountDAO{
    private JdbcTemplate jdbcTemplate;

    public void setJdbcTemplate(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    public int addAccount(Account account) {
        String sql = "insert into account(username,balance) value(?,?)";
        Object[] obj = new Object[] {account.getUsername(),account.getBalance()};
        int num = this.jdbcTemplate.update(sql, obj);
        return num;
    }

    public int updateAccount(Account account) {
        String sql = "update account set username=?,balance=? where id=?";
        Object[] params = new Object[] {account.getUsername(),account.getBalance(),account.getId()};
        int num = this.jdbcTemplate.update(sql, params);
        return num;
    }

    public int deleteAccount(int id) {
        String sql = "delete from account where id=?";
        int num = this.jdbcTemplate.update(sql, id);
        return num;
    }

    public Account findById(int id) {
        String sql = "select * from account where id=?";
        RowMapper<Account> rowMapper = new BeanPropertyRowMapper<Account>(Account.class);
        return this.jdbcTemplate.queryForObject(sql, rowMapper, id);
    }

    public List<Account> findAll() {
        String sql = "select * from account";
        RowMapper<Account> rowMapper = new BeanPropertyRowMapper<Account>(Account.class);
        return this.jdbcTemplate.query(sql, rowMapper);
    }
    @Transactional
    public void transfer(String outUser, String inUser, Double money) {
        //收款时，收款用户的余额=现有金额+所转金额
        this.jdbcTemplate.update("update account set balance=balance+? where username=?",money,inUser);
        //模拟系统运行时的突发问题
        //int i = 1 / 0 ;
        //转出时，汇款用户的余额=现有余额-所转金额
        this.jdbcTemplate.update("update account set balance=balance-? where username=?", money,outUser);

    }
}
