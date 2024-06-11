
namespace Productify.Domain;

public class ProductService : IProductService
{


    public void Add(string name, string description, decimal price, int stock)
    {
        string text = ($"{name}, {description}, {price}, {stock}");
        File.AppendAllText("/Users/fatimaekin/Productify/Productify.Domain/Data.txt", text);
    }

    public void Delete()
    {   
        File.Delete("/Users/fatimaekin/Productify/Productify.Domain/Data.txt");
    }

    public string GetAll()
    {
        string text =  File.ReadAllText("/Users/fatimaekin/Productify/Productify.Domain/Data.txt");
        return text;

    }

    // public void Update(Guid Id, string Name, string Description, decimal Price, int Stock)
    // {
    //     throw new NotImplementedException();
    // }
}
