
CreditCardPayment creditCardPayment = new CreditCardPayment
        {
            TransactionId = "TXN12345",
            Amount = 100.50m,
            CardNumber = "1234-5678-9012-3456",
            CardHolderName = "Emre Demir",
            ExpiryDate = "12/25",
            CVV = "123"
        };
        creditCardPayment.ProcessPayment();
        Console.WriteLine();

        

        PayPalPayment payPalPayment = new PayPalPayment
        {
            TransactionId = "TXN67890",
            Amount = 75.25m,
            PayPalAccountEmail = "emre.demir@example.com"
        };
        payPalPayment.ProcessPayment();
        Console.WriteLine();

       
       
        BankTransferPayment bankTransferPayment = new BankTransferPayment
        {
            TransactionId = "TXN54321",
            Amount = 200.00m,
            BankAccountNumber = "9876543210",
            BankName = "Ziraat Katılım Bank"
        };
        bankTransferPayment.ProcessPayment();
        Console.WriteLine();
    


public abstract class PaymentMethod
{
    public string TransactionId { get; set; }
    public decimal Amount { get; set; }

    public abstract void ProcessPayment();

    public string GetPaymentDetails()
    {
        return $"Transaction ID: {TransactionId}, Amount: {Amount:C}";
    }
}

public class CreditCardPayment : PaymentMethod
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string ExpiryDate { get; set; }
    public string CVV { get; set; }

    public override void ProcessPayment()
    {
        
        Console.WriteLine("Processing credit card payment..");
        Console.WriteLine(GetPaymentDetails());
        Console.WriteLine($"Card Number: {CardNumber}, Card Holder: {CardHolderName}, Expiry Date: {ExpiryDate}, CVV:  {CVV}");
    }
}

public class PayPalPayment : PaymentMethod
{
    public string PayPalAccountEmail { get; set; }

    public override void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal payment..");
        Console.WriteLine(GetPaymentDetails());
        Console.WriteLine($"PayPal Account: {PayPalAccountEmail}");
    
    }
}

public class BankTransferPayment : PaymentMethod
{
    public string BankAccountNumber { get; set; }
    public string BankName { get; set; }

    public override void ProcessPayment()
    {
        Console.WriteLine("Processing bank transfer payment...");
        Console.WriteLine(GetPaymentDetails());
        Console.WriteLine($"Bank Account: {BankAccountNumber}, Bank: {BankName}");
    }
}