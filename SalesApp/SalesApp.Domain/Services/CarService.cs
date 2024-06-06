
using SalesApp.Domain.Entities;

namespace SalesApp.Domain.Services;

public class CarService

{
   private static List<Car> cars = new();
   public void Add(Car car)
   {
       cars.Add(car);
   }
   public void PrintConsole()
   {
    foreach(var car in cars)
    {
       Console.WriteLine($"Modeli: {car.Model}, Markası: {car.Model }, Renk : {car.Color}");
    }
   } 

   public List<Car> GetAll()
   {
      return cars;
   }

    public void Update(Guid Id, string color, int year)
   {
      foreach(var car in cars)
        {
            if(car.Id == Id)
            {
               car.Color = color;
               car.Year = year;

               break;
            }
       }
   }
   
   public void Remove(Guid Id)
   {
      foreach(var car in cars)
        {
            if(car.Id == Id)
            {
               cars.Remove(car);
               break;
            }
        }
   }

}
