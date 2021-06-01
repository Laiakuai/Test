package jmu.assemble;

import java.util.List;

public class Student {
    private String studentId;
    private String studentName;
    private List<String> list;

    public void setStudentId(String studentId) {
        this.studentId = studentId;
    }

    public void setStudentName(String studentName) {
        this.studentName = studentName;
    }

    public void setList(List<String> list) {
        this.list = list;
    }

    public Student() {
        super();
    }

    public Student(String studentId, String studentName, List<String> list) {
        this.studentId = studentId;
        this.studentName = studentName;
        this.list = list;
    }

    @Override
    public String toString() {
        return "Student{" +
                "studentId='" + studentId + '\'' +
                ", studentName='" + studentName + '\'' +
                ", list=" + list +
                '}';
    }
}
