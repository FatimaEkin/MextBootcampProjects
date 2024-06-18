using System;

using PhoneInformation.Domain;

IPhoneService phoneService = new PhoneService();


Battery battery1 = new Battery { Capacity = "4352mAh", Level = "100%", Type = "Li-Ion", Power = "20W" };
Screen screen1 = new Screen { ScreenSize = "6.7 inch", Resolation = "1284x2778", Pixel = "458 ppi", Area = "109.6 cm²" };
Camera camera1 = new Camera { Resolation = "12 MP", Distance = "f/1.6" };


Battery battery2 = new Battery { Capacity = "4600mAh", Level = "98%", Type = "Li-Po", Power = "25W" };
Screen screen2 = new Screen { ScreenSize = "6.9 inch", Resolation = "1440x3088", Pixel = "497 ppi", Area = "128.4 cm²" };
Camera camera2 = new Camera { Resolation = "16 MP", Distance = "f/1.4" };


phoneService.Add("Apple", 1299.99m, "iPhone 14 Pro Max", battery1, screen1, camera1);


phoneService.Add("Apple", 1499.99m, "iPhone 15 Pro", battery2, screen2, camera2);


List<Phone> phones = phoneService.GetAll();

Console.WriteLine("List of Phones:");
foreach (Phone phone in phones)
{
    Console.WriteLine($"Brand: {phone.Brand}, Model: {phone.Model}, Price: {phone.Price}");
    Console.WriteLine($"Battery: {phone.Battery.Capacity}, Screen: {phone.Screen.ScreenSize}, Camera: {phone.Camera.Resolation}");
    Console.WriteLine();
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

