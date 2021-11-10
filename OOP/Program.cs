using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using AForge.Math;
using System.IO;
namespace OOP
{
  class Program
  {
    // enum feature
    // {
    //   Add = 1, Save = 2, Load = 3, Report = 4, Exit = 0
    // }

    public static void Main()
    {
      //Tao publisher
      Publisher publisher = new Publisher();
      //SubcriberA dang ki nhan event
      SubcriberA a = new SubcriberA();
      publisher.notifyme += (a).Print;
      //SubcriberB dang ki nhan event
      publisher.notifyme += (new SubcriberB()).Print;
      publisher.notifyme += a.Print;
      publisher.notifyme += (new SubcriberB()).Print;
      publisher.notifyme -= a.Print;
      //Publisher phat event
      publisher.notify();



    }
  }
}
