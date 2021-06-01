package jmu.annotation;

import org.springframework.stereotype.Service;
import javax.annotation.Resource;

@Service("bookService")
public class BookServiceImpl implements BookService {
    @Resource(name="bookDAO")
    private BookDAO bookDAO;

    public void save() {
        this.bookDAO.save();
        System.out.println("bookDAO中的save()方法...");
    }
}
