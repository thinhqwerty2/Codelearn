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
      BookList bl = new BookList();
      bl.InputList();
      bl.ShowList();
    }
  }
}
