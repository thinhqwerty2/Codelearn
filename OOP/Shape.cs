namespace OOP
{
  abstract public class Shape
  {
    public abstract double getArea();
    public abstract double getPerimeter();
  }
  public class Rectangle : Shape
  {
    double length;
    double width;
    public Rectangle(double length, double width)
    {
      this.length = length;
      this.width = width;
    }
    public override double getArea()
    {
      return length * width;
    }
    public override double getPerimeter()
    {
      return (length + width) * 2;
    }
  }
  public class Circle : Shape
  {
    double radius;
    public Circle(double radius)
    {
      this.radius = radius;
    }
    public override double getArea()
    {
      return System.Math.PI * radius * radius;
    }
    public override double getPerimeter()
    {
      return System.Math.PI * radius * 2;
    }
  }
}