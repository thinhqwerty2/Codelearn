using System;
namespace OOP
{
  public class Person
  {
    string name;
    int age;
    string address;
    protected Person(string name, int age, string address)
    {
      this.name = name;
      this.age = age;
      this.address = address;
    }
    protected Person(string name, string address)
    {
      this.name = name;
      this.address = address;
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

    public int Age
    {
      set
      {
        age = value;
      }
      get
      {
        return age;
      }
    }

    public string Address
    {
      set
      {
        address = value;
      }
      get
      {
        return address;
      }
    }

    public virtual void display()
    {
      Console.WriteLine($"Name: {name}\nAge: {age}\nAddress: {address}");
    }
  }
}