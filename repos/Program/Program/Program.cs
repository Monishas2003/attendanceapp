using System;
class Complex
{
    int real;
    int img;
    public Complex()
    {
        this.real = 0;
        this.img = 0;
    }
    public Complex(int real,int img)
    {
        this.real = real;
        this.img = img;
    }
    public static Complex operator + (Complex obj1,Complex obj2)
    {
        Complex temp = new Complex();
        temp.real = obj1.real + obj2.real;
        temp.img= obj1.img + obj2.img;
        return temp;
    }
    public void display()
    {
        Console.WriteLine("{0}+{1}i", real, img);
    }
}
class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Enter first complex number:");
        Console.Write("real part:");
        int real1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("imaginary part:");
        int img1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second complex number:");
        Console.Write("real part:");
        int real2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("imaginary part:");
        int img2 = Convert.ToInt32(Console.ReadLine());
        Complex complex1 = new Complex(real1, img1);
        Complex complex2 = new Complex(real2, img2);
        Complex result = complex1 + complex2;
        Console.WriteLine("first complex number:");
        complex1.display();
        Console.WriteLine("second complex number:");
        complex2.display();
        Console.WriteLine("result:");
        result.display();
    }
}