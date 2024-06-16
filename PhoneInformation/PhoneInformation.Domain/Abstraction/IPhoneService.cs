using System.Runtime.CompilerServices;

namespace PhoneInformation.Domain;

public interface IPhoneService
{
    void Add(string Brand, decimal Price, string Model, Battery Battery, Screen Screen, Camera Camera);
    List<Phone> GetAll();




}
