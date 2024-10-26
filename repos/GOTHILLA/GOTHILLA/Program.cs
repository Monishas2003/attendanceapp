using System;
namespace Boss
{
    internal class GOTHILLA
    {
        public static void Main(String[] args)
        {
            int a;
            int b;
            char op;
            int Result;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    {
                        Result = a + b;
                        Console.WriteLine(Result);
                    }
                    break;
                case '-':
                    {
                        Result = a - b;
                        Console.WriteLine(Result);
                    }
                    break;
                case '*':
                    {
                        Result = a * b;
                        Console.WriteLine(Result);
                    }
                    break;
                case '/':
                    {
                        Result = a / b;
                        Console.WriteLine(Result);
                    }
                    break;
                case '%':
                    {
                        Result = a % b;
                        Console.WriteLine(Result);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Operator");
                    }
                    break;
            }


        }
    }
}

