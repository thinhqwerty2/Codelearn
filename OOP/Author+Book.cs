using System.Collections.Generic;
using System.Text;
namespace OOP
{
  public class Author
  {
    string name;
    string email;
    public Author(string name, string email)
    {
      this.name = name;
      this.email = email;
    }

    public string Name
    {
      set
      {
        name = value;
      }
      get
      {
        return name;
      }
    }
    public string Email
    {
      set
      {
        email = value;
      }
      get
      {
        return email;
      }
    }
  }
  public class Booka
  {
    string name;
    List<Author> authors;
    double price;
    public Booka(string name, List<Author> authors, double price)
    {
      this.name = name;
      this.price = price;
      this.authors = authors;
    }
    public string Name
    {
      set
      {
        name = value;
      }
      get
      {
        return name;
      }
    }
    public double Price
    {
      set
      {
        price = value;
      }
      get
      {
        return price;
      }
    }
    public string Authors
    {
      get
      {
        string s = "";
        foreach (Author x in authors)
        {
          s += (x.Name + ", ");
        }
        return s;
      }
    }
  }
}