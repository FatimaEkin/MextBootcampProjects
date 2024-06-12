using Productify.Domain;

ProductService productService = new ProductService();

while (true)
{
    Console.WriteLine("1- Ürün Ekleme");
    Console.WriteLine("2- Ürün Okuma");
    Console.WriteLine("3- Ürün Silme");
    Console.WriteLine("Çıkmak için q'ya basın.");
    Console.Write("Bir seçenek girin: ");
    string choice = Console.ReadLine();

    if (choice == "q")
    {
        break;
    }


    if (choice == "1")
    {
        Console.Write("Ürün Adı: ");
        string name = Console.ReadLine();

        Console.Write("Ürün Açıklaması: ");
        string description = Console.ReadLine();

        Console.Write("Ürün Fiyatı: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.Write("Ürün Stoğu: ");
        int stock = int.Parse(Console.ReadLine());

        productService.Add(name, description, price, stock);
        Console.WriteLine("Ürün başarıyla eklendi..!");
    }


    else if (choice == "2")
    {
        var products = productService.GetAll();

        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Id} - Adı: {product.Name} - Açıklama: {product.Description} - Fiyat: {product.Price} - Stok: {product.Stock}");
        }
    }


    else if (choice == "3")
    {
        Console.Write("Silmek istediğiniz ürünün ID'sini girin: ");
        string id = Console.ReadLine();

        productService.Delete(id);
        Console.WriteLine("Ürün silindi....");
    }


    else
    {
        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin...");
    }
}

