package jmu.cal;

import org.springframework.stereotype.Component;

@Component("calDAO")
public class CalDAOImpl implements CalDAO {
    public int add(int i, int j) {
        System.out.println("The method add begins with ["+i+", "+j+"]");
        int result = i + j;
        System.out.println("The method add ends with "+result);
        return result;
    }

    public int sub(int i, int j) {
        System.out.println("The method sub begins with ["+i+", "+j+"]");
        int result = i - j;
        System.out.println("The method sub ends with "+result);
        return result;
    }

    public int mul(int i, int j) {
        System.out.println("The method mul begins with ["+i+", "+j+"]");
        int result = i * j;
        System.out.println("The method mul ends with "+result);
        return result;
    }

    public int div(int i, int j) {
        System.out.println("The method div begins with ["+i+", "+j+"]");
        int result = i / j;
        System.out.println("The method div ends with "+result);
        return result;
    }
}
