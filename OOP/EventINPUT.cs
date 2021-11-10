using System;
namespace OOP
{
  public delegate void notify();
  public class Publisher
  {
    public event notify notifyme;
    public void notify()
    {
      Console.WriteLine("Raise event");
      notifyme?.Invoke();
    }

  }
  public class SubcriberA
  {
    public void Sub(Publisher p)
    {
      p.notifyme += Print;
    }
    public void Print()
    {
      Console.WriteLine("A nhan dc event");
    }
  }
  public class SubcriberB
  {
    public void Sub(Publisher p)
    {
      p.notifyme += Print;
    }
    public void Print()
    {
      Console.WriteLine("B nhan duoc event");
    }
  }

}