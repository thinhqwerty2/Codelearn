using System.Collections.Generic;
namespace OOP
{

  public class Line
  {
    Point begin;
    Point end;
    public Point Begin
    {
      set
      {
        begin = value;
      }
      get
      {
        return begin;
      }
    }
    public Point End
    {
      set
      {
        end = value;
      }
      get
      {
        return end;
      }
    }
    public Line(Point begin, Point end)
    {
      this.begin = begin;
      this.end = end;
    }

    public Line(int x1, int y1, int x2, int y2)
    {
      this.begin = new Point(x1, y1);
      this.end = new Point(x2, y2);
    }
    public double Length
    {
      get
      {
        return System.Math.Sqrt((End.X - Begin.X) * (End.X - Begin.X) + (End.Y - Begin.Y) * (End.Y - Begin.Y));
      }
    }

  }

  public class Point
  {
    int x;
    int y;
    public int X
    {
      set
      {
        x = value;
      }
      get
      {
        return x;
      }
    }
    public int Y
    {
      set
      {
        y = value;
      }
      get
      {
        return y;
      }
    }

    public Point()
    {
      x = 0;
      y = 0;
    }
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }
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