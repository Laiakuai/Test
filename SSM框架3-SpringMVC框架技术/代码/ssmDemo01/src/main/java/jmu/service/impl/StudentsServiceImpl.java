package jmu.service.impl;

import jmu.mapper.StudentsMapper;
import jmu.po.Students;
import jmu.service.StudentsService;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import javax.annotation.Resource;

@Service
@Transactional
public class StudentsServiceImpl implements StudentsService {
    @Resource(name="studentsMapper")
    private StudentsMapper studentsMapper;

    public Students findStuByStudentId(String studentId) {
            return this.studentsMapper.findStuByStudentId(studentId);
    }
}
