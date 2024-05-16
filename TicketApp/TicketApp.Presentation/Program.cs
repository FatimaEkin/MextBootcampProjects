// See https://aka.ms/new-console-template for more information
using TicketApp.Domain;

TicketService ticketService = new();


ticketService.SaveTicketToTextFile("Hakan Öztürk", 100, "BC", 06092024);

Console.WriteLine("Ticket saved to text file.");

