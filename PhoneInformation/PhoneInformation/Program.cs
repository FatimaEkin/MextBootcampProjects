           
           using System;
using System.Collections.Generic;


           IPhoneService phoneService = new PhoneService();

            // iPhone 14 Pro Max için özellikler
            Battery battery1 = new Battery { Capacity = "4352mAh", Level = "100%", Type = "Li-Ion", Power = "20W" };
            Screen screen1 = new Screen { ScreenSize = "6.7 inch", Resolution = "1284x2778", Pixel = "458 ppi", Area = "109.6 cm²" };
            Camera camera1 = new Camera { Resolution = "12 MP", Aperture = "f/1.6", Features = "Autofocus, Night mode" };

            // iPhone 15 Pro için özellikler
            Battery battery2 = new Battery { Capacity = "4600mAh", Level = "98%", Type = "Li-Po", Power = "25W" };
            Screen screen2 = new Screen { ScreenSize = "6.9 inch", Resolution = "1440x3088", Pixel = "497 ppi", Area = "128.4 cm²" };
            Camera camera2 = new Camera { Resolution = "16 MP", Aperture = "f/1.4", Features = "Ultra wide-angle, HDR" };

            // iPhone 14 Pro Max ekleyelim
            phoneService.Add("Apple", 1299.99m, "iPhone 14 Pro Max", battery1, screen1, camera1);

            // iPhone 15 Pro ekleyelim
            phoneService.Add("Apple", 1499.99m, "iPhone 15 Pro", battery2, screen2, camera2);

            // Tüm telefonları listeleme
            List<Phone> phones = phoneService.GetAll();

            Console.WriteLine("List of Phones:");
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"Brand: {phone.Brand}, Model: {phone.Model}, Price: {phone.Price}");
                Console.WriteLine($"Battery: {phone.Battery.Capacity}, Screen: {phone.Screen.ScreenSize}, Camera: {phone.Camera.Resolution}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        