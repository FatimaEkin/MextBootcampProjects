
using SwitchExamples;

//Derece hesaplama
int temprature  = 20;

if (temprature < -10)
   Console.WriteLine("inanılmaz soğuk bir hava var");
else if (temprature <0)
    Console.WriteLine("Çok soğuk bir hava var.");
else if (temprature <10)
    Console.WriteLine("soğuk bir hava var.");
else if (temprature <20)
    Console.WriteLine("Ilık bir hava var.");
    else if (temprature <30)
    Console.WriteLine("Sıcak bir hava var.");
else 
    Console.WriteLine("Çok sıcak bir hava var.");



//Geçişm izni kontrol
Console.Write("Please enter you name: ");
    string name1 = Console.ReadLine();
    switch (name1)
    {
        case "Hakan":
          Console.WriteLine("Geçiş izni verildi.");
          break;
    case "Ahmet":
          Console.WriteLine("Kısmi izin verildi.");
          break;
    default:
            Console.WriteLine("Geçiş izni verilmedi.");
          break;
    }


//Ürün stok kontrolü
Product product = new()
{
    Name = "Laptop",
    Price = 5000,
    State = ProductState.Discontinued
};

    switch (product.State)
  {
    case ProductState.InStock:
          Console.WriteLine("Ürün Stokta");
          break;
    case ProductState.OutOfStock:
          Console.WriteLine("ürün stokta değil.");
          break;
    case ProductState.Discontinued:
          Console.WriteLine("ürün satıştan kaldırıldı.");
          break;
  }


//Yeni müşteri ekleyip, Müşteri tipine göre mesaj yazdırmak
List<Musteri> musteriler = new();

        Console.Write("Müşteri adı: ");
        string ad = Console.ReadLine();
        
        Console.Write("Müşteri soyadı: ");
        string soyad = Console.ReadLine();
        
        Console.Write("Telefon numarası: ");
        int telefonNumarasi = int.Parse(Console.ReadLine());

        Console.WriteLine("Müşteri tipi seçiniz (0: Normal, 1: Premium, 2: VIP): ");
        MusteriTipi musteriTipi = (MusteriTipi)int.Parse(Console.ReadLine());

        Musteri yeniMusteri = new Musteri
        {
            Ad = ad,
            Soyad = soyad,
            TelefonNumarasi = telefonNumarasi,
            MusteriTipi = musteriTipi
        };

        musteriler.Add(yeniMusteri);

        foreach (var musteri in musteriler)
        {
            switch (musteri.MusteriTipi)
            {
                case MusteriTipi.Normal:
                    Console.WriteLine($"{musteri.Ad} {musteri.Soyad} normal bir müşteri.");
                    break;
                case MusteriTipi.Premium:
                    Console.WriteLine($"{musteri.Ad} {musteri.Soyad} premium bir müşteri.");
                    break;
                case MusteriTipi.VIP:
                    Console.WriteLine($"{musteri.Ad} {musteri.Soyad} VIP bir müşteri.");
                    break;
                default:
                    Console.WriteLine($"{musteri.Ad} {musteri.Soyad} bilinmeyen müşteri tipi.");
                    break;
            }
        }
    








// List<int> tempratures = new () {-5, 0, 10,15, 25,35};

// foreach (var temprature in tempratures)

// {
//     if (temprature < -10)
//        Console.WriteLine("İnanılmaz soğuk bir hava var");
//     else if (temprature < 0)
//        Console.WriteLine("Çok soğuk bir hava var");
//     else if (temprature < 10)
//        Console.WriteLine("Soğuk bir hava var");
//     else if (temprature < 20)
//        Console.WriteLine("Ilık bir hava var");
//     else if (temprature < 30)
//        Console.WriteLine("Sıcak bir hava var");
//     else
//     Console.WriteLine("Çok Sıcak bir hava var");
// }

// List<Product> products = new()
// {
//   new Product {Name = "Laptop", Price = 5000, State=ProductState.InStock },
//   new Product {Name = "Mouse", Price = 50, State=ProductState.OutOfStock },
//   new Product {Name = "Keyboard", Price = 100, State=ProductState.Discontinued },
// };

// foreach (var product in products)
// {
//    if (product.State ==ProductState.InStock)
//       Console.WriteLine($"{product.Name} ürünü stokta");
//    else if (product.State ==ProductState.OutOfStock)
//       Console.WriteLine($"{product.Name} ürünü stokta yok");
//}


// List<Musteri> musteriler = new()
//         {
//             new Musteri { Ad = "Ahmet", Soyad = "Yılmaz", TelefonNumarasi = 1234567890, MusteriTipi = MusteriTipi.Normal },
//             new Musteri { Ad = "Mehmet", Soyad = "Kaya", TelefonNumarasi = 1234567891, MusteriTipi = MusteriTipi.Premium },
//             new Musteri { Ad = "Ayşe", Soyad = "Demir", TelefonNumarasi = 1234567892, MusteriTipi = MusteriTipi.VIP },
//         };

//         foreach (var musteri in musteriler)
//         {
//             switch (musteri.MusteriTipi)
//             {
//                 case MusteriTipi.Normal:
//                     Console.WriteLine($"{musteri.Ad} {musteri.Soyad} normal bir müşteri.");
//                     break;
//                 case MusteriTipi.Premium:
//                     Console.WriteLine($"{musteri.Ad} {musteri.Soyad} premium bir müşteri.");
//                     break;
//                 case MusteriTipi.VIP:
//                     Console.WriteLine($"{musteri.Ad} {musteri.Soyad} VIP bir müşteri.");
//                     break;
//                 default:
//                     Console.WriteLine($"{musteri.Ad} {musteri.Soyad} bilinmeyen müşteri tipi.");
//                     break;
//             }
//         }
    


