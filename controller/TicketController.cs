// using System;
// using ticket_tracker.services;

// namespace ticket_tracker.controller
// {
//   public class TicketController
//   {
//     private TicketService _ticketService = new TicketService();
//     public void Run()
//     {
//       while (true)
//       {
//         update();
//         GetUserInput();
//       }
//     }

//     private void update()
//     {
//       Console.Clear();
//       Console.WriteLine(_ticketService.GetTicketInfo());
//       Console.WriteLine("Current Tickets:");
//       foreach (string message in _ticketService.Messages)
//       {
//         Console.WriteLine("\t" + message);
//       }
//       _ticketService.Messages.Clear();
//     }
//     private void GetUserInput()
//     {
//       Console.WriteLine("Tickets :");
//       string input = Console.ReadLine().ToLower();
//       switch (input)
//       {
//                 case "q":
//                 case "quit":
//                 case "exit":
//                 case "close":
//                     Environment.Exit(0);
//         break;
//         default:
//                     _ticketService.GetTicketInfo(input);
//         break;
//       }
//     }

//   }
// }