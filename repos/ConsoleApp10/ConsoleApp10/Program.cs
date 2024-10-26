using System;
class complex
{
    public int real, img;
    public complex()
    {
        this.real = 0;
        this.img = 0;
    }
    public complex(int real,int img)
    {
        this.real = real;
        this.img = img;
    }
    public static complex operator +(complex ob1,complex ob2)
    {
        complex temp = new complex();
        temp.real = ob1.real + ob2.real;
        temp.img = ob1.img + ob2.img;
        return temp;
    }
    public void display()
    {
        Console.WriteLine("{0}+{1}i", real, img);
    }
}
class program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("enter the first complex number:");
        Console.WriteLine("real part:");
        int real1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("imaginary part:");
        int imaginary1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n enter the second complex number:");
        Console.Write("real part:");
        int real2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("imaginary part:");
        int imaginary2= Convert.ToInt32(Console.ReadLine());
        complex complex1 = new complex(real1, imaginary1);
        complex complex2 = new complex(real2, imaginary2);
        complex result = complex1 + complex2;
        Console.WriteLine("\n first complex number:");
        complex1.display();
        Console.WriteLine("\n second complex number:");
        complex2.display();
        Console.WriteLine("\n result of addition:");
        result.display();
    }
}
