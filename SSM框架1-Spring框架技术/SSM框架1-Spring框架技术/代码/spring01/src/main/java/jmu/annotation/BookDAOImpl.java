package jmu.annotation;

import org.springframework.stereotype.Repository;

@Repository("bookDAO")
public class BookDAOImpl implements BookDAO{

    public void save() {
        System.out.println("bookDAO中的save()方法...");
    }
}
