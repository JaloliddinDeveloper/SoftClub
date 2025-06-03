//Mahkamov Jaloliddin
//Data: 03.06.2025
//Task 1: Bank

class Program
{
    static void Main()
    {
        Console.Write("First deposit: ");
        decimal firstDeposit = decimal.Parse(Console.ReadLine());
        Console.Write("Second deposit: ");
        decimal secondDeposit = decimal.Parse(Console.ReadLine());
        Console.Write("Third deposit: ");
        decimal thirdDeposit = decimal.Parse(Console.ReadLine());

        decimal firstInterest = CalculateInterest(firstDeposit);
        decimal secondInterest = CalculateInterest(secondDeposit);
        decimal thirdInterest = CalculateInterest(thirdDeposit);

        Console.WriteLine($"First deposit interest: {firstInterest:F2}");
        Console.WriteLine($"Second deposit interest: {secondInterest:F2}");
        Console.WriteLine($"Third deposit interest: {thirdInterest:F2}");
    }

    static decimal CalculateInterest(decimal amount)
    {
        decimal interestRate;

        if (amount < 100)
        {
            interestRate = 0.05m;
        }
        else if (amount <= 200)
        {
            interestRate = 0.07m;
        }
        else
        {
            interestRate = 0.10m;
        }

        return amount * interestRate;
    }
}
