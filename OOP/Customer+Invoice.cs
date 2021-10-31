namespace OOP
{
  public class Customer
  {
    int id;
    string name;
    int discount;
    public Customer()
    {
    }
    public Customer(int id, string name, int discount)
    {
      this.id = id;
      this.name = name;
      this.discount = discount;
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
    public int Discount
    {
      set
      {
        discount = value;
      }
      get
      {
        return discount;
      }
    }
  }

  class Invoice
  {
    int id;
    Customer customer;
    double amount;
    public Invoice(int id, Customer customer, double amount)
    {
      this.id = id;
      this.customer = customer;
      this.amount = amount;
    }
    public Customer Customer
    {
      set
      {
        customer = value;
      }
      get
      {
        return customer;
      }
    }
    public string CustomerName
    {
      get
      {
        return customer.Name;
      }
    }
    public double AmountAfterDiscount
    {
      get
      {
        return amount * (1 - customer.Discount / 100.0);
      }
    }
  }
}