namespace OOP
//Inheritance
{
  public class Student : Person
  {
    double gpa;
    public Student(string name, int age, string address, double gpa) : base(name, age, address)
    {
      this.gpa = gpa;
    }
    public double Gpa
    {
      set
      {
        gpa = value;
      }
      get
      {
        return gpa;
      }
    }
    public new void display()
    {
      base.display();
      System.Console.WriteLine($"GPA={Gpa}");
    }
  }

  public class Teacher : Person
  {
    int salary;
    public Teacher(string name, int age, string address, int salary) : base(name, age, address)
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
    public new void display()
    {
      base.display();
      System.Console.WriteLine($"Salary: {Salary}");
    }
  }

}