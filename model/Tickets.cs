using System;

namespace ticket_tracker.model
{
  public class Tickets
  {
    public string Title { get; set; }
    string Description { get; set; }



    public void PrintTicket()
    {

      Console.Write($@"{Title} {Description}");

    }
    public Tickets(string title, string description)
    {
      Title = title;
      Description = description;

    }

  }
}