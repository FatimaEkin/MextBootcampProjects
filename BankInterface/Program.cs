using BankInterface;

GarantiBank Garanti = new();

Garanti.Amount = 100_000;
Garanti.InterestRate = 5;
Garanti.Months = 3;
Garanti.TotalAmount = 6;

Garanti.GetCredit();

ZiraatKatilim Ziraat = new();

Ziraat.Amount = 200_000;
Ziraat.InterestRate = 4;
Ziraat.Months = 2;
Ziraat.TotalAmount = 2;

 Ziraat.GetCredit();
