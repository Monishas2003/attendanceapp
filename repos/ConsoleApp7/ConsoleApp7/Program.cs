using System;
public class Animal
{
    public void eat()
    {
        Console.WriteLine("eating");

    }
    public class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }
    class Inheritance
    {
        public static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.eat();
            obj.Bark();
        }
    }
}
