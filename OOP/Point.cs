namespace OOP
{
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
}