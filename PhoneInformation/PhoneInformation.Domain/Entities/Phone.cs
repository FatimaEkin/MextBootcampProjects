namespace PhoneInformation.Domain;

public class Phone
{
   public Guid Id {get; set;}
   public string Brand {get; set;}
   public decimal Price {get; set;}
   public string Model {get; set;}
   public Battery Battery {get; set;}
   public Screen Screen {get; set;}
   public Camera Camera {get; set;}
   
}
