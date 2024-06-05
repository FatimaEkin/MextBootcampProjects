namespace PaymentMethodsInterface;

public class CashPayment : IPayment, ICSVConvertible
{
    
        public string OdemeYapan { get; set; }

        public void OdemeYap(decimal tutar)
        {
            // Basit bir ödeme işlemi simülasyonu
            Console.WriteLine($"Nakit Ödeme: {tutar} TL ödendi. Ödeme Yapan: {OdemeYapan}");
        }

        public string CSV()
        {
            return $"{OdemeYapan}, Nakit";
        }
    
}
