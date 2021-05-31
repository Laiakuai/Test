package jmu.mapper;

import jmu.vo.Students;

public interface StudentsMapper {
    public Students findStuByStudentId(String studentId);
}
