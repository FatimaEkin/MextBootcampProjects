namespace PaymentMethodsInterface;

public class CreditCardPayment : IPayment, ICSVConvertible
{

    public string KartNumarasi { get; set; }
    public string SonKullanmaTarihi { get; set; }
    public string KartSahibi { get; set; }

    public void OdemeYap(decimal tutar)
        {
            // Basit bir ödeme işlemi simülasyonu
            Console.WriteLine($"Kredi Kartı ile Ödeme: {tutar} TL ödendi. Kart Sahibi: {KartSahibi}");
        }

    public string CSV()
    {
        return $"{KartSahibi}, {KartNumarasi}, {SonKullanmaTarihi}";
    }
}
