namespace PhoneInformation.Domain;

public class Phone
{
   public Guid Id {get; set;}
   public string Brand {get; set;}
   public decimal Price {get; set;}
   public string Model {get; set;}
   public Battery battery {get; set;}
   public Screen screen {get; set;}
   public Camera camera {get; set;}
   
}
