namespace PracticingAbstraction;

class Program
{
    static void Main(string[] args)
    {
        var sbiRateOfInterest = new SBI_7_();

        var pnbRateOfInterest = new PNB_5_();
        
        Console.WriteLine(sbiRateOfInterest.GetRateOfInterest());
        Console.WriteLine(pnbRateOfInterest.GetRateOfInterest());
    }
}