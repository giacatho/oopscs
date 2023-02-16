using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC_Polymorphism_Shape
{
class Shape
{
   public virtual void Draw() { }
}
class Circle : Shape
{
   double radius;
   public Circle(double radius) {
      this.radius = radius;
   }
   public override void Draw() {
      Console.WriteLine("A triangle with radius {0} ", radius);
   }
}
class Square : Shape
{
   double length;
   public Square(double length) {
      this.length = length;
   }
   public override void Draw()
   {
      Console.WriteLine("A rectangle with length {0}", length);
   }
}
class Rectangle : Shape
{
   double width;
   double height;
   public Rectangle(double width, double height)
   {
      this.width = width;
      this.height = height;
   }
   public override void Draw()
   {
      Console.WriteLine("A rectangle with width {0}, height {1}", width, height);
   }
}

class Drawing
{
   List<Shape> allshapes =
         new List<Shape>();
   public void Add(Shape s)
   {
      allshapes.Add(s);
   }
   public void Draw()
   {
      for (int i = 0;
         i < allshapes.Count; i++)
      {
         Shape s = allshapes[i];
         s.Draw();
      }
   }
}

class Test
{
public static void Main()
{
   Drawing drawing = new Drawing();
   drawing.Add(new Circle(1));
   drawing.Add(new Rectangle(2, 3));
   drawing.Add(new Square(4));
   drawing.Add(new Circle(4.5));

   drawing.Draw();
}
}
}

