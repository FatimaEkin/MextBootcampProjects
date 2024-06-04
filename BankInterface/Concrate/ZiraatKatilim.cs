namespace BankInterface;

public class ZiraatKatilim : IGetCredit , ICSVConvertible
{
   public decimal Amount {get; set;}
   public decimal TotalAmount {get; set;}
   public decimal InterestRate {get; set;}
   public decimal Months {get; set;}


    public string CSV()
    {
        var TotalAmount = GetCredit();

      return $"{Amount}, {InterestRate}, {TotalAmount}";
    }

    public decimal GetCredit()
    {
         if(Months < 8)
         InterestRate += 5;
    
    else if (Months < 6)
       InterestRate += 4;
    
    else
        InterestRate += 2;

    var TotalAmount = (Amount/100) * (InterestRate/12) * 4;

    Console.WriteLine($"Ziraat Bank : {Amount} amount with {Months} months has {InterestRate} % interest rate. Total Amount {TotalAmount} monthly Amount {TotalAmount/Months}");

    return TotalAmount;
    }

}
