using System.Collections.Generic;
namespace OOP
{
  public class PolyLine
  {
    List<Point> points;
    public PolyLine()
    {
      points = new List<Point>();
    }
    public PolyLine(List<Point> points)
    {
      this.points = points;
    }
    public void appendPoint(Point point)
    {
      points.Add(point);
    }
    public void appendPoint(int x, int y)
    {
      points.Add(new Point(x, y));
    }
    public double Length
    {
      get
      {
        double rs = 0;
        for (int i = 0; i < points.Count - 1; i++)
        {
          rs += (new Line(points[i], points[i + 1])).Length;
        }
        return rs;
      }
    }
  }

}