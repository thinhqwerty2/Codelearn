using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using AForge.Math;

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
      // BookList bl = new BookList();
      // bl.InputList();
      // bl.ShowList();
      string choice;
      AccountList al = new AccountList();
      bool exit = false;
      do
      {
        Console.WriteLine();
        Console.WriteLine("*******************************************");
        Console.WriteLine("1.Add");
        Console.WriteLine("2.Save");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Report");
        Console.WriteLine("5.Exit");
        choice = Console.ReadLine();
        switch (choice)
        {
          case "Add":
            al.NewAccount();
            break;
          case "Save":
            al.SaveFile();
            break;
          case "Load":
            al.LoadFile();
            break;
          case "Report":
            al.Report();
            break;
          case "Exit":
            exit = true;
            break;
          default:
            Console.WriteLine("Nhap sai roi nhap lai di!!");
            break;
        }

        if (exit == false)
        {
          Console.WriteLine("Press any key to continue");
          Console.ReadLine();
        }
        else continue;


      } while (!exit);
    }





  }
}

