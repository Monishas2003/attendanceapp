using System;
class shape
{
    public virtual void draw()
    {
        Console.WriteLine("drawing a shape");
    }
    public virtual void erase()
    {
        Console.WriteLine("eraseing a shape");
    }
}
class circle : shape
{
    public override void draw()
    {
        Console.WriteLine("drawing a circle.");
    }
    public override void erase()
    {
        Console.WriteLine("eraseing a circle.");
    }
}
class triangle: shape
{
    public override void draw()
    {
        Console.WriteLine("drawing a triangle");
    }
    public override void erase()
    {
        Console.WriteLine("eraseing a triangle");
    }
}
class square : shape
{
    public override void draw()
    {
        Console.WriteLine("drawing a square");
    }
    public override void erase()
    {
        Console.WriteLine("eraseing a square");
    }
}
class program
{
    static void Main()
    {
        shape c = new circle();
        shape t = new triangle();
        shape s = new square();
        c.draw();
        c.erase();
        t.draw();
        t.erase();
        s.draw();
        s.erase();
    }
}