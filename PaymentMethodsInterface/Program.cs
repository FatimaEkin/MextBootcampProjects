using System;
using PaymentMethodsInterface;


class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment krediKartiOdeme = new()
            {
                KartNumarasi = "1234-5678-9012-3456",
                SonKullanmaTarihi = "12/25",
                KartSahibi = "Ali Veli"
            };

            krediKartiOdeme.OdemeYap(150.75m);
            Console.WriteLine(krediKartiOdeme.CSV());

            CashPayment nakitOdeme = new()
            {
                OdemeYapan = "Ayşe Yılmaz"
            };

            nakitOdeme.OdemeYap(200.00m);
            Console.WriteLine(nakitOdeme.CSV());
        }
    }

