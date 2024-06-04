using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace BankInterface;

public class GarantiBank : IGetCredit , ICSVConvertible
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
         if(Months < 6)
         InterestRate += 4;
    
    else if (Months < 4)
       InterestRate += 3;
    
    else
        InterestRate += 2;

    var TotalAmount = (Amount/100) * (InterestRate/12) * 4;

    Console.WriteLine($"Garanti Bank : {Amount} amount with {Months} months has {InterestRate} % interest rate. Total Amount {TotalAmount} monthly Amount {TotalAmount/Months}");
    
    return TotalAmount;

    }


}

// public decimal GetCredit();
// {
//     return (Amount/100) * (InterestRate/12) * 4;

//     //(Anapara / 100) x (Faiz Oranı / 12) x ay Sayısı​ 
// }
