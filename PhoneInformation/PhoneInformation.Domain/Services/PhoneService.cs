
namespace PhoneInformation.Domain;

public class PhoneService : IPhoneService
{   private List<Phone> _phones = new List<Phone>();
    private string _csvFilePath = "phones.csv"; 

    public void Add(string Brand, decimal Price, string Model, Battery Battery, Screen Screen, Camera Camera)
    {
       var phone = new Phone
            {
                Id = Guid.NewGuid(),
                Brand = Brand,
                Price = Price,
                Model = Model,
                Battery = Battery,
                Screen = Screen,
                Camera = Camera
            };

            _phones.Add(phone);

            // Telefonu CSV dosyasına kaydet
            SavePhoneToCsv(phone);
    }

    public List<Phone> GetAll()
    {
        return _phones;
    }
    
}

