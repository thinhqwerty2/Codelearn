using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
namespace OOP
{
  class Account
  {
    int accountId;
    string firstName;
    string lastName;
    double balance;
    public Account()
    {

    }
    public Account(int id, string firstName, string lastName)
    {
      this.accountId = id;
      this.firstName = firstName;
      this.lastName = lastName;

    }
    public Account(int id, string firstName, string lastName, int balance)
    {
      this.accountId = id;
      this.lastName = lastName;
      this.firstName = firstName;
      this.balance = balance;

    }
    public int AccountId
    {
      get
      {
        return accountId;
      }
    }
    public string FirstName
    {
      set
      {
        firstName = value;
      }
      get
      {
        return firstName;
      }
    }
    public string LastName
    {
      set
      {
        lastName = value;
      }
      get
      {
        return lastName;
      }
    }


    public double Balance
    {
      set
      {
        balance = value;
      }
      get
      {
        return balance;
      }
    }
    public void FillInfo()
    {
      Console.WriteLine("--------------------------------------");
      Console.WriteLine("Account ID: ");
      accountId = int.Parse(Console.ReadLine());
      Console.WriteLine("First Name: ");
      firstName = Console.ReadLine();
      Console.WriteLine("Last Name: ");
      lastName = Console.ReadLine();
      Console.WriteLine("Balance: ");
      balance = double.Parse(Console.ReadLine());
      Console.WriteLine("--------------------------------------");
    }




    public void Querry()
    {
      Console.WriteLine($"ID: {accountId}\nFirst Name: {firstName}\nLast Name: {lastName}\nBalance: {Balance}");
    }
  }
  public class AccountList
  {
    List<Account> accounts = new List<Account>();
    public void NewAccount()
    {
      Account acc = new Account();
      acc.FillInfo();
      accounts.Add(acc);

    }
    public void SaveFile()
    {
      Console.WriteLine("Input file name: ");
      string path = Console.ReadLine() + ".txt";

      foreach (Account acc in accounts)
      {
        string s = "--------------------------------------"
        + $"\nID: {acc.AccountId}\nFirst Name: {acc.FirstName}\nLast Name: {acc.LastName}\nBalance: {acc.Balance}\n";


        if (!File.Exists(path))
          File.AppendAllText("listFile.txt", path + "\n");
        File.AppendAllText(path, s);

      }

    }
    public void LoadFile()
    {
      Console.WriteLine("Input file name: ");
      string path = Console.ReadLine() + ".txt";
      Console.WriteLine(File.ReadAllText(path));
    }
    public void Report()
    {
      string[] arrs = File.ReadAllLines("listFile.txt");
      foreach (var item in arrs)
      {
        Console.WriteLine(item);
        Console.WriteLine(File.ReadAllText(item));
      }
    }


  }
}