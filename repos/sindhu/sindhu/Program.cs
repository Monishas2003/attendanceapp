using System;
using System.Threading;
class P4
{
    public static void Main(string[] args)
    {
        Method1();
        Method2();
        Console.Read();
    }
    static void Method1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("method1:" + i);
        }
    }
    static void Method2()
    {
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("method2:" + i);
        }
    }
}