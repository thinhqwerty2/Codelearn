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
}