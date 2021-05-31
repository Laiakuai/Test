package jmu.controller;

import jmu.po.Students;
import jmu.service.StudentsService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import javax.annotation.Resource;

@Controller
public class StudentsController {
    @Resource(name="studentsServiceImpl")
    private StudentsService studentsService;
    @RequestMapping(value="/findStuByStudentId.do")
    public String findStuByStudentId(String studentId, Model model) {
        Students stu = this.studentsService.findStuByStudentId(studentId);
        model.addAttribute("students", stu);
        return "stuShow";
    }
}