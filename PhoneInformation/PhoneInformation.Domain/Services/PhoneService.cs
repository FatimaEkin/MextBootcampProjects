
namespace PhoneInformation.Domain;

public class PhoneService : IPhoneService
{   private List<Phone> _phones = new List<Phone>();
    private string _csvFilePath = "phones.csv"; 
    
    public void Add(string Brand, decimal Price, string Model, Battery Battery, Screen Screen, Camera Camera)
    {
       
    }

    public List<Phone> GetAll()
    {
        throw new NotImplementedException();
    }
}

