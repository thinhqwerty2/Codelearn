using System.Text;
using System;
namespace OOP
{
  class Account
  {
    int id;
    string name;
    int balance;
    public Account(int id, string name)
    {
      this.id = id;
      this.name = name;

    }
    public Account(int id, string name, int balance)
    {
      this.id = id;
      this.name = name;
      this.balance = balance;

    }
    public int Id
    {
      get
      {
        return id;
      }
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


    public int Balance
    {
      get
      {
        return balance;
      }
    }

    public void deposit(int amount)
    {
      this.balance = this.balance + amount;
    }

    public void withdraw(int amount)
    {
      if (this.balance - amount > 0)
        this.balance = this.balance - amount;
      else System.Console.WriteLine("That amount exceeds your current balance.");
    }

    public void display()
    {
      Console.WriteLine($"ID: {Id}\nName: {Name}\nBalance: {Balance}");
    }
  }
}