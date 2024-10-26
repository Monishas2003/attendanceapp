using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApllication11
    {
    class P5
{
    public static void Main(string[] args)
    {
        int a,b,Sum = 0;
        Console.WriteLine("enter two numbers");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Sum = multif(a,b);
        Console.WriteLine("sum of two numbers(using function):" + Sum);
        multis(a,b);
        Console.ReadLine();
    }
    static int multif(int x, int y)
    {
        return x * y;
    }
    static void multis(int x, int y)
    {
        Console.Write("sum of two number(using subroutines):" + (x * y));
    }
}
}
