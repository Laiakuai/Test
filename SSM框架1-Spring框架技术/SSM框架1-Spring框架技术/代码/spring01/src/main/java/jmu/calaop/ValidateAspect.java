package jmu.calaop;

import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;
import org.springframework.core.annotation.Order;
import org.springframework.stereotype.Component;

import java.util.Arrays;
@Order(1)
@Aspect
@Component
public class ValidateAspect {
    @Pointcut("execution(* jmu.calaop.CalDAO2Impl.*(..))")
    private void myPointCut() {}

    @Before("myPointCut()")
    public void validateArgs(JoinPoint joinPoint) {
        System.out.println("-->validate: "+ Arrays.asList(joinPoint.getArgs()));
    }
}
