namespace TicketApp.Domain;

public class Ticket
{
    public string Id {get; set; }
    public string OwnerNameSurname {get; set; }
    public decimal Price {get; set; }
    public string SeatCode {get; set; }
    public int Date {get; set; }
}
