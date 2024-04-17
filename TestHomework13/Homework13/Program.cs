namespace Homework13;

public interface I_A
{
    public int f8(int x);
}

public class A : I_A
{
    public static int f1(int x)
    {
        x = x + 1;
        return x;
    }
    
    internal static int f2(int x)
    {
        x = x + 2;
        return x;
    }
    
    protected static int f3(int x)
    {
        x = x + 3;
        return x;
    }
    
    private static int f4(int x)
    {
        x = x + 4;
        return x;
    }
    
    public static double f5(int x,int y)
    {
        return x/y;
    }
    
    public static int f6(int x)
    {
        if(x < 0)
        {
            throw new Exception("x can't be negative");
        }
        
        return x + 5;
    }
    
    public static string f7(string s)
    {
        var ss = s + " more stuff";
        return ss;
    }
    
    public int f8(int x)
    {
        // Assume this calls a sql database such as "selct * from where something = x"
        return x + 8;
    }
}

internal class B
{
    internal static int g1(int x, I_A a)
    {
        return a.f8(x);
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        var v1 = A.f1(1);
        var v2 = A.f2(2); 
        var v5 = A.f5(5,2);
        var v6 = A.f6(3);
        var v7 = A.f7("hello");
        var a = new A();
        var v8 = B.g1(1,a);
    }
}