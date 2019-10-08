using System;

namespace ticket_tracker.model
{
  public class App
  {
    TicketSystem ticketSystem;

    Boolean active;
    public void Run()
    {
      ticketSystem = new TicketSystem();
      active = true;
      Console.Clear();
      Console.WriteLine("Help Desk");
      ticketSystem.PrintAll();
      while (active)
      {
        Console.WriteLine("Please choose from the following. (view / new / quit)");
        string choice = Console.ReadLine();
        makeSelection(choice);
      }
    }
    public void makeSelection(string choice)
    {
      switch (choice.ToLower())
      {
        case "view":
          Console.Write("what ticket would you like?");
          string index = Console.ReadLine();
          Console.Clear();
          ticketSystem.ViewTicket(index);
          break;
        case "new":
          ticketSystem.NewTicket();
          break;
        case "quit":
          active = false;
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
    }
  }
}