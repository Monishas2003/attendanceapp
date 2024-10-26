using System;
namespace postive_negative
{
    class program
    {
        public static void Main(String[] args)
        {
            int a;
            a=Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("positve" + a);
            }
            else if (a == 0)
            {
                Console.WriteLine("zero" {0});
            }
            else
            {
                Console.WriteLine("negative" + a);
            }
        }

    }
}