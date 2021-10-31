using System.Collections.Generic;
namespace OOP
{
  public class Card
  {
    string nameBook;
    string nameAuthor;
    int numberBook;
    public Card()
    {

    }
    public Card(string nameBook, string nameAuthor, int numberBook)
    {
      this.nameBook = nameBook;
      this.nameAuthor = nameAuthor;
      this.numberBook = numberBook;
    }
    public void display()
    {
      System.Console.WriteLine($"Name Book: {nameBook}\nName Author: {nameAuthor}\nNumber Book: {numberBook}");
    }
    public int NumBook
    {
      get
      {
        return numberBook;
      }
    }
    public static void sortCard(List<Card> card)
    {

      card.Sort(
          (p1, p2) =>
          {
            if (p1.numberBook == p2.numberBook) return 0;
            if (p1.numberBook < p2.numberBook) return -1;
            return 1;
          }
      );
    }
  }
}