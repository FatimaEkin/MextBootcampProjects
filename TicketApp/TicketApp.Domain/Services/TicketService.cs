namespace TicketApp.Domain;

public class TicketService
{
   public void SaveTicketToTextFile (string ownerNameSurname, decimal price, string seatCode, int Date)
   {
    Random random = new();

        Ticket ticket = new()
        {
            Id = $"{random.Next(1, 1000)}",
            OwnerNameSurname = ownerNameSurname,
            Price = price,
            SeatCode = seatCode,
            
        };

    string ticketInfo =$"{ticket.Id}{ticket.OwnerNameSurname},{ticket.Price},{ticket.SeatCode},{ticket.Date}\n";
    File.AppendAllText("/Users/fatimaekin/TicketApp/TicketApp.Domain/Ticket.txt", ticketInfo);
   }

}
