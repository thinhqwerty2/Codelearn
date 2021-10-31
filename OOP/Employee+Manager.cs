namespace OOP
{
  public class Employee : Person
  {
    int salary;
    public Employee(string name, string address, int salary) : base(name, address)
    {
      this.salary = salary;
    }

    public int Salary
    {
      set
      {
        salary = value;
      }
      get
      {
        return salary;
      }
    }
    public override void display()
    {
      System.Console.WriteLine($"Employee name: {Name}\nEmployee address: {Address}\nEmployee salary: {Salary}");
    }
  }

  public class Manager : Employee
  {
    int bonus;
    public Manager(string name, string address, int salary, int bonus) : base(name, address, salary)
    {
      this.bonus = bonus;
    }
    public int Bonus
    {
      set
      {
        bonus = value;
      }
      get
      {
        return bonus;
      }
    }

    public new void display()
    {
      System.Console.WriteLine($"Name: {Name}\nSalary: {Salary + bonus}");

    }
  }


}