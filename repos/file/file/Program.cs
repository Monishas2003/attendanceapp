using System;
using System.IO;
    namespace cshape
{
    class program
    {
        public static void Main(string[] args)
        {
            string file;
            Console.WriteLine("before.copy:\n");
            file = File.ReadAllText("Hamsa.text");


            Console.WriteLine("date in soure file:\n+file");
            file = File.ReadAllText("kavana.text");
            Console.WriteLine("date is determine file:\n" + file +"\n\n\n");
            File.Copy("hamsa.text", "kavana.text", true);
            Console.WriteLine("after.copy:\n");
            file = File.ReadAllText("Hamsa.text");     
            Console.WriteLine("Date in soure file:\n+file");
            file = File.ReadAllText("kavana.text");
            Console.WriteLine("Date is determine file:\n" + file + "\n\n\n");
        }
    }
}


        
    



        
    
