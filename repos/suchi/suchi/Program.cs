using System;
using System.IO;
namespace C_sharp
{
    class program
    {
         public static void Main(String[]args)
        {
            String file;

            Console.WriteLine("before copy:\n");
            file = File.ReadAllText("C:\\Users\\comp\\Desktop\\s.txt");
            Console.WriteLine("data in source file:\n"+file);

            file = File.ReadAllText("C:\\Users\\comp\\Desktop\\t.txt");
            Console.WriteLine("data in destination file:\n"+file+"\n\n\n");

            File.Copy("C:\\Users\\comp\\Desktop\\s.txt", "C:\\Users\\comp\\Desktop\\t.txt", true);

            Console.WriteLine("After copy:\n");
            file = File.ReadAllText("C:\\Users\\comp\\Desktop\\s.txt");
            Console.WriteLine("data in source file:\n"+file);

            file = File.ReadAllText("C:\\Users\\comp\\Desktop\\t.txt");
            Console.WriteLine("data in destination file:\n"+file+"\n\n\n");

        }
    }
}