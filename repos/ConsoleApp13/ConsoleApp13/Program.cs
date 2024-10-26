using System;
using System.IO;
namespace Filetext
{
    class Text
    {
        public static void Main(String[] args)
        {
            String file;

            Console.WriteLine("before copy:\n");
            file = File.ReadAllText("C:\\Users\\comp\\source\\repos\\t.txt");
            Console.WriteLine("data in source file:\n" + file);

            file = File.ReadAllText("C:\\Users\\comp\\source\\repos\\s.txt");
            Console.WriteLine("data in destination file:\n" + file + "\n\n\n");

            File.Copy("C:\\Users\\comp\\source\\repos\\t.txt", "C:\\Users\\comp\\source\\repos\\s.txt", true);

            Console.WriteLine("After copy:\n");
            file = File.ReadAllText("C:\\Users\\comp\\source\\repos\\