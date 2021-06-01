package jmu.annotation;

import org.springframework.stereotype.Controller;
import javax.annotation.Resource;
@Controller("bookController")
public class BookController {
    @Resource(name="bookService")
    private BookService bookService;
    public void save(){
        this.bookService.save();
        System.out.println("bookController中的save()方法...");
    }
}
