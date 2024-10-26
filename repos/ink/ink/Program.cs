using System;
class P2
{
    public static void Main()
    {
        int i, j;
        Console.WriteLine("for loop statement");
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("nested loop statement");
        for (i = 1; i < 3; i++)
        {
            Console.WriteLine("outer:" + i);
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine("inner:" +j);
            }
        }
        i = 0;
        Console.WriteLine("while loop statement");
        {
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        Console.WriteLine("do while statement");
        i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i < 10);
        
    }
}



            