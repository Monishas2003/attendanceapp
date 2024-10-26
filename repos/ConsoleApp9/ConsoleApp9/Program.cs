using System;
using System.ComponentModel.Design;

namespace Hi
{
    class hello
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("enter the value of n");
             n = Convert.ToInt32(Console.ReadLine());
            {
                if (n == 0)
                {
                    Console.WriteLine("The value is zero");
                    
                
                }
                else if (n > 0)
                {
                    Console.WriteLine("Positive number");

                }
                else
                {
                    Console.WriteLine("Negative number");
                }
            }
        }
    }
}