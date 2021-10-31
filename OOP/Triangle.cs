
namespace OOP
{
  public class Triangle
  {
    Point vertice1;
    Point vertice2;
    Point vertice3;
    public Triangle(Point vertice1, Point vertice2, Point vertice3)
    {
      this.vertice1 = vertice1;
      this.vertice2 = vertice2;
      this.vertice3 = vertice3;
    }
    public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
    {
      vertice1 = new Point(x1, y1);
      vertice2 = new Point(x2, y2);
      vertice3 = new Point(x3, y3);
    }
    public double Perimeter
    {
      get
      {
        return (new Line(vertice1, vertice2)).Length +
        (new Line(vertice3, vertice2)).Length +
        (new Line(vertice1, vertice3)).Length;
      }
    }
  }
}