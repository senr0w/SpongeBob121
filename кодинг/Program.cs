using System;

class program
{
    static void Main(string[] args)
    {
        double amount = 1;
        double exchangeRate= 101.6;
        string dollar = "USD";
        string rubl = "RUB";
        double convertamount = ConvertCurrency(amount, dollar, rubl, exchangeRate);
        Console.WriteLine($"{amount} {dollar} равно {convertamount} {rubl}.");
    }
    static double ConvertCurrency(double amount, string dollar, string rubl, double exchangeRate)
    {
        if (dollar == rubl)
        {
            return amount;
        }
        double convertamount = amount * exchangeRate;
        return convertamount;
    }
}
