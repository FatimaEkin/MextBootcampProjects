
namespace PhoneInformation.Domain;

public class PhoneService : IPhoneService
{
    private List<Phone> _phones = new List<Phone>();
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


        SavePhonesToCsv();
    }

    public List<Phone> GetAll()
    {
        LoadPhonesFromCsv();
        return _phones;
    }

    private void SavePhonesToCsv()
    {

        foreach (var phone in _phones)
        {
            var csvLine = $"{phone.Id},{phone.Brand},{phone.Price},{phone.Model},{phone.Battery.Capacity},{phone.Battery.Level},{phone.Battery.Type},{phone.Battery.Power},{phone.Screen.ScreenSize},{phone.Screen.Resolation},{phone.Screen.Pixel},{phone.Screen.Area},{phone.Camera.Resolation},{phone.Camera.Distance}";


            File.AppendAllText(_csvFilePath, csvLine + "\n");
        }

    }

    private void LoadPhonesFromCsv()
    {
        if (!File.Exists(_csvFilePath))
            return;

        _phones.Clear();


        string[] lines = File.ReadAllLines(_csvFilePath);

        foreach (var line in lines)
        {
            string[] fields = line.Split(',');

            if (fields.Length < 15)
                continue;

            var phone = new Phone
            {
                Id = Guid.Parse(fields[0]),
                Brand = fields[1],
                Price = decimal.Parse(fields[2]),
                Model = fields[3],
                Battery = new Battery
                {
                    Capacity = fields[4],
                    Level = fields[5],
                    Type = fields[6],
                    Power = fields[7]
                },
                Screen = new Screen
                {
                    ScreenSize = fields[8],
                    Resolation = fields[9],
                    Pixel = fields[10],
                    Area = fields[11]
                },
                Camera = new Camera
                {
                    Resolation = fields[12],
                    Distance = fields[13],

                }
            };

            _phones.Add(phone);
        }
    }

}

