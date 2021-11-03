using System.Collections;
using System;
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
  public class Book : IBook
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
    public static bool operator <(Book book1, Book book2)
    {
      if (book1.Title.CompareTo(book2.Title) < 0) return true;
      else return false;
    }

    public static bool operator >(Book book1, Book book2)
    {
      if (book1.Title.CompareTo(book2.Title) > 0) return true;
      else return false;
    }
    public int Compare(Book book1, Book book2)
    {
      return 1;
    }
  }
  public class BookList
  {
    ArrayList list = new ArrayList();
    public void AddBook()
    {
      Book b = new Book();
      b.Input();
      list.Add(b);
    }
    public void ShowList()
    {
      foreach (Book item in list)
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



  }
}