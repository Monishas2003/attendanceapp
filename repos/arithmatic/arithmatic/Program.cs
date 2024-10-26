using System;
namespace consoleapp12
{
    class program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.WriteLine("enter 1st no");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 2nd no");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter symbol(+,-,*,%,/):");
                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine(res);                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine(res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine(res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine(res);
                        break;
                    case "%":
                        res = num1 % num2;
                        Console.WriteLine(res);
                        break;
                    default:
                        Console.WriteLine("invalid operator");
                        break;
                }

                Console.WriteLine("do you want to continue(Y/n)");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");

        }
    }
}



                
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        
    

