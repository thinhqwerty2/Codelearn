using System.Text;
using System;
using System.Collections.Generic;
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
      Console.WriteLine("Amount of accounts: ");
      int n = int.Parse(Console.ReadLine());
      for (int i = 0; i < n; i++)
      {
        Account acc = new Account();
        acc.FillInfo();
        accounts.Add(acc);
      }
      foreach (Account acc in accounts)
      {
        acc.Querry();
      }
    }

  }
}