using System.Security.Principal;

namespace BankInterface;

public class GarantiBank : IGetCredit
{
   public decimal Amount {get; set;}
   public decimal TotalAmount {get; set;}
   public decimal InterestRate {get; set;}
   public decimal Months {get; set;}

    public void GetCredit()
    {
         if(Months < 6)
         InterestRate += 4;
    
    else if (Months < 4)
       InterestRate += 3;
    
    else
        InterestRate += 2;

    var TotalAmount = (Amount/100) * (InterestRate/12) * 4;

    Console.WriteLine($"Garanti Bank : {Amount} amount with {Months} months has {InterestRate} % interst rate. Total Amount{TotalAmount} monthly Amount {TotalAmount/Months}");
    }

}

// public decimal GetCredit();
// {
//     return (Amount/100) * (InterestRate/12) * 4;

//     //(Anapara / 100) x (Faiz Oranı / 12) x ay Sayısı​ 
// }
