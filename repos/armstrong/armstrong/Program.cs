using System;
 namespace ArmStrong_number
{
    class program
    {
        public static void Main(string[] args)
        {
            int temp, sum, rem;
            Console.WriteLine("enter starting number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ending number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Armstrong no in the given range are");
            for(int i=num1;i<=num2;i++)
            {
                temp = i;
                sum = 0;
                while(temp!=0)
                {
                    rem = temp % 10;
                    sum = sum + (rem * rem * rem);
                    temp = temp / 10;
                }
                if (sum == i)
                    Console.WriteLine(" {0} ", i);
            }
        }
    }
}
