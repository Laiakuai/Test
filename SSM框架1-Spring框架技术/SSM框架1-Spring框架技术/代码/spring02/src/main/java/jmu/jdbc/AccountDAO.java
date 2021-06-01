package jmu.jdbc;

import java.util.List;

public interface AccountDAO {
    public int addAccount(Account account);
    public int updateAccount(Account account);
    public int deleteAccount(int id);
    public Account findById(int id);
    public List<Account> findAll();
    public void transfer(String outUser, String inUser, Double money);
}
