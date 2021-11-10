using System.Collections;
using System;
using System.Collections.Generic;

namespace OOP
{

  public interface IBook
  {
    string this[int index]
    {
      get;
      set;
    }
    string Title
    {
      get;
      set;
    }
    string Author
    {
      get;
      set;
    }
    string Publisher
    {
      get;
      set;
    }
    int Year
    {
      get;
      set;
    }
    string ISBN
    {
      get;
      set;
    }
    void Show();

  }
  public class Book : IBook, IComparable
  {
    string isbn;
    string title;
    string author;
    string publisher;
    int year;
    ArrayList chapter = new ArrayList();

    public string this[int index]
    {
      get
      {
        if (index >= 0 && index < chapter.Count)
          return (string)chapter[index];
        else
          throw new System.Exception("IndexOutOfRange");
      }
      set
      {
        if (index >= 0 && index < chapter.Count)
          chapter[index] = value;
        else if (index == chapter.Count)
          chapter.Add(value);
        else
          throw new System.Exception("IndexOutOfRange");
      }
    }
    public string Title
    {
      get
      {
        return title;
      }
      set
      {
        title = value;
      }
    }
    public string Author
    {
      get
      {
        return author;
      }
      set
      {
        author = value;
      }
    }
    public string Publisher
    {
      get
      {
        return publisher;
      }
      set
      {
        publisher = value;
      }
    }
    public int Year
    {
      get
      {
        return year;
      }
      set
      {
        year = value;
      }
    }
    public string ISBN
    {
      get
      {
        return isbn;
      }
      set
      {
        isbn = value;
      }
    }

    public void Show()
    {
      Console.WriteLine("----------------------------------");
      Console.WriteLine("Title: " + title);
      Console.WriteLine("Author: " + author);
      Console.WriteLine("Publisher: " + publisher);
      Console.WriteLine("Year: " + year);
      Console.WriteLine("ISBN: " + isbn);
      Console.WriteLine("Chapter: ");
      for (int i = 0; i < chapter.Count; i++)
      {
        Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
      }
      Console.WriteLine("----------------------------------");
    }
    public void Input()
    {
      Console.WriteLine("Title: ");
      title = Console.ReadLine();
      Console.WriteLine("Author: ");
      author = Console.ReadLine();
      Console.WriteLine("Publisher: ");
      publisher = Console.ReadLine();
      Console.WriteLine("ISBN: ");
      isbn = Console.ReadLine();
      Console.WriteLine("Year: ");
      year = int.Parse(Console.ReadLine());
      Console.WriteLine("Input chapter (finished with empty string)");
      string s;
      do
      {
        s = Console.ReadLine();
        if (s.Length > 0)
          chapter.Add(s);

      } while (s.Length > 0);

    }

    public int CompareTo(object obj)
    {
      Book b = (Book)obj;
      return (this.Title).CompareTo(b.Title);
    }
    public class SortByTitle : IComparer
    {
      public int Compare(object x, object y)
      {
        Book book1 = (Book)x;
        Book book2 = (Book)y;
        return book1.Title.CompareTo(book2.Title);
      }
    }
    public class SortByAuthor : IComparer
    {
      public int Compare(object x, object y)
      {
        Book book1 = (Book)x;
        Book book2 = (Book)y;
        return book1.Author.CompareTo(book2.Author);
      }
    }
    public class SortByYear : IComparer
    {
      public int Compare(object x, object y)
      {
        Book book1 = (Book)x;
        Book book2 = (Book)y;
        return book1.Year.CompareTo(book2.Year);
      }
    }
  }



  public class BookList
  {

    ArrayList BookLists = new ArrayList();

    public void AddBook()
    {
      Book b = new Book();
      b.Input();
      BookLists.Add(b);
    }
    public void ShowList()
    {
      foreach (Book item in BookLists)
      {
        item.Show();
      }
    }
    public void InputList()
    {
      Console.WriteLine("Amount of books: ");
      int n = int.Parse(Console.ReadLine());
      while (n > 0)
      {
        AddBook();
        n--;
      }
    }
    public void SortBy(Comparer comparer)
    {
      switch (comparer)
      {
        case Comparer.SortByAuthor:
          BookLists.Sort(new Book.SortByAuthor());
          break;
        case Comparer.SortByTitle:
          BookLists.Sort(new Book.SortByTitle());
          break;
        case Comparer.SortByYear:
          BookLists.Sort(new Book.SortByYear());
          break;
        default:
          Console.WriteLine("Comparer don't exist");
          break;
      }

    }
    public void SortBy()
    {
      BookLists.Sort();
    }

  }
  public enum Comparer
  {
    SortByAuthor,
    SortByTitle,
    SortByYear,

  }
  //   string choice;
  //   AccountList al = new AccountList();
  //   bool exit = false;
  //   do
  //   {
  //     Console.WriteLine();
  //     Console.WriteLine("*******************************************");
  //     Console.WriteLine("1.Add");
  //     Console.WriteLine("2.Save");
  //     Console.WriteLine("3.Load");
  //     Console.WriteLine("4.Report");
  //     Console.WriteLine("5.Exit");
  //     choice = Console.ReadLine();
  //     switch (choice)
  //     {
  //       case "Add":
  //         al.NewAccount();
  //         break;
  //       case "Save":
  //         al.SaveFile();
  //         break;
  //       case "Load":
  //         al.LoadFile();
  //         break;
  //       case "Report":
  //         al.Report();
  //         break;
  //       case "Exit":
  //         exit = true;
  //         break;
  //       default:
  //         Console.WriteLine("Nhap sai roi nhap lai di!!");
  //         break;
  //     }

  //     if (exit == false)
  //     {
  //       Console.WriteLine("Press any key to continue");
  //       Console.ReadLine();
  //     }
  //     else continue;


  //   } while (!exit);
  // }
}