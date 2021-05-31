package jmu.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@Controller
@RequestMapping(value="/abc")
public class SecondController {
    @RequestMapping(value="/secondController.do")
    public String handleRequest(HttpServletRequest request,
                                HttpServletResponse response,
                                Model model)throws Exception{
        //向模型对象中添加数据
        model.addAttribute("msg", "Hello the second Spring MVC page!");
        return "mysecond";//返回视图页面
    }
}
