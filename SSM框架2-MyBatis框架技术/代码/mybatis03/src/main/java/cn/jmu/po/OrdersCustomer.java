package cn.jmu.po;

public class OrdersCustomer extends Orders {
    private String username;
    private String address;

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    @Override
    public String toString() {
        return "OrdersCustomer [username=" + username + ", address=" + address + ", 订单Id=" + getId()
                + ", 客户id=" + getUser_id() + ", 订单号=" + getNumber() + ", Createtime()="
                + getCreatetime() + "]";
    }
}
