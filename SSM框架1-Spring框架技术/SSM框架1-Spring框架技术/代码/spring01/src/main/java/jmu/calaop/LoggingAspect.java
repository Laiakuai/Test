package jmu.calaop;

import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.*;
import org.springframework.core.annotation.Order;
import org.springframework.stereotype.Component;

import java.util.Arrays;
@Order(2)
@Aspect
@Component
public class LoggingAspect {
    @Pointcut("execution(* jmu.calaop.CalDAO2Impl.*(..))")
    private void myPointCut() {}

    @Before("myPointCut()")
    public void beforeMethod(JoinPoint joinPoint) {
        String methodName = joinPoint.getSignature().getName();
        Object[] args = joinPoint.getArgs();
        System.out.println("The method "+methodName+" begin with "+ Arrays.asList(args));
    }

    @After("myPointCut()")
    public void afterMethod(JoinPoint joinPoint) {
        String methodName = joinPoint.getSignature().getName();
        System.out.println("The method "+methodName+" ends. ");
    }

    @AfterReturning(value="myPointCut()", returning = "result")
    public void afterReturning(JoinPoint joinPoint, Object result) {
        String methodName = joinPoint.getSignature().getName();
        System.out.println("The method "+methodName+" end with "+result);
    }

    @AfterThrowing(value="myPointCut()", throwing = "e")
    public void afterThrowing(JoinPoint joinPoint,Exception e) {
        String methodName = joinPoint.getSignature().getName();
        System.out.println("The method "+methodName+" occurs exception "+e);
    }

    public Object aroundMethod(ProceedingJoinPoint pjd) {
        Object result = null;
        String methodName = pjd.getSignature().getName();
        try {
            //前置通知
            System.out.println("The method "+methodName+" begin with "+Arrays.asList(pjd.getArgs()));
            result = pjd.proceed();
            //返回通知
            System.out.println("The method "+methodName+" end with "+result);
        }catch(Throwable e){
            //异常通知
            System.out.println("The method "+methodName+" occurs exception "+e);
            throw new RuntimeException(e);
        }
        //后置通知
        System.out.println("The method "+methodName+" ends. ");
        return result;
    }
}
