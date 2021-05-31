package cn.jmu.po3;

import java.util.Date;
import java.util.List;

public class Orders {
    private Integer id;
    private Integer user_id;
    private String number;
    private Date createtime;
    private Customer customer;
    private List<Orderdetail> orderdetailList;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public Integer getUser_id() {
        return user_id;
    }

    public void setUser_id(Integer user_id) {
        this.user_id = user_id;
    }

    public String getNumber() {
        return number;
    }

    public void setNumber(String number) {
        this.number = number;
    }

    public Date getCreatetime() {
        return createtime;
    }

    public void setCreatetime(Date createtime) {
        this.createtime = createtime;
    }

    public Customer getCustomer() {
        return customer;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
    }

    public List<Orderdetail> getOrderdetailList() {
        return orderdetailList;
    }

    public void setOrderdetailList(List<Orderdetail> orderdetailList) {
        this.orderdetailList = orderdetailList;
    }
    public String toString() {
        return "Orders [id=" + id + ", number=" + number
                + ", username=" + customer.getUsername()
                + ", orderdetailList=" + orderdetailList + "]";
    }
}
