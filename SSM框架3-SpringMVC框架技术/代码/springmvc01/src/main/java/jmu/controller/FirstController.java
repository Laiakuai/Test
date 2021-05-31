package jmu.controller;

import org.springframework.web.servlet.ModelAndView;
import org.springframework.web.servlet.mvc.Controller;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class FirstController implements Controller {
    @Override
    public ModelAndView handleRequest(HttpServletRequest httpServletRequest,
                                      HttpServletResponse httpServletResponse) throws Exception {
        //1.创建ModelAndView对象
        ModelAndView mv = new ModelAndView();
        //2.向模型对象中添加数据
        mv.addObject("msg","Hello my first Spring MVC!");
        //3.设置逻辑视图名
        mv.setViewName("myfirst");
        return mv;
    }
}
