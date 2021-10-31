namespace OOP
// virtual vs override
{
  public class Animal
  {
    public virtual void sound()
    {
      System.Console.WriteLine("some sound");
    }
  }
  public class Dog : Animal
  {
    public override void sound()
    {
      System.Console.WriteLine("bow wow");
    }
  }
  public class Cat : Animal
  {
    public override void sound()
    {
      System.Console.WriteLine("meow meow");
    }
  }
  public class Duck : Animal
  {
    public override void sound()
    {
      System.Console.WriteLine("quack quack");
    }
  }
}
//vd
// Animal[] animals = new Animal[4];
//       animals[0] = new Animal();
//       animals[1] = new Dog();
//       animals[2] = new Cat();
//       animals[3] = new Duck();
//       foreach (var item in animals)
//       {
//         item.sound();
//       }