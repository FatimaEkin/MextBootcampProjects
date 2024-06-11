namespace Productify.Domain;

public interface IProductService
{
   string GetAll();
   void Add (string name, string description, decimal price, int stock);
   void Delete ();

   //void Update(Guid Id, string Name, string Description, decimal Price, int Stock);
}
