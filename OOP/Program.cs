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
    public static void Main()
    {
      Console.WriteLine("Nhap so luong khach");
      int n = int.Parse(Console.ReadLine());
      Hanhkhach[] hanhkhachs = new Hanhkhach[n];
      for (int i = 0; i < n; i++)
      {
        hanhkhachs[i] = new Hanhkhach();
        Hanhkhach.NhapHK(hanhkhachs[i]);



      }
      foreach (var hanhkhach in hanhkhachs)
      {
        Console.WriteLine(hanhkhach);
        Console.WriteLine(hanhkhach.tongtien());
      }
    }
  }
}