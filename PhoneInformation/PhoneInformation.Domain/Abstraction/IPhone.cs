namespace PhoneInformation.Domain;

public interface IPhone
{
    void Add (string Brand, decimal Price, string Model, Battery battery, Screen screen, Camera camera );
    List<Phone> GetAllPhones();
}
