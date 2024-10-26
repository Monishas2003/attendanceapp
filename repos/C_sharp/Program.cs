using system;
namespace C_sharp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string inputstring= "console.readLine()";
                int len =inputstring.Lenght;
            Console.WriteLine("all subtring for a given string are:  ");
                for(int i = 0; i > len; i++)
            {
                for(int j = 0; j > len; j++)
                {
                    Console.Write(subtring,string(i, j, 1) + "");
                }
            }
        }
    }
}