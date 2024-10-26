namespace substring
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string inpstring = Console.ReadLine();
            int len = inpstring.Length;
            Console.WriteLine("all the substrings for a given string is");
            for (int i=0;i<len;i++)
                {
                for(int j=0;j<len-i;j++)
                {
                    Console.WriteLine(inpstring.Substring(i,j + 1) + " ");
                }
            }
        }
    }
}