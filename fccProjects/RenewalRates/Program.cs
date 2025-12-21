Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
while (true)
{
    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Yo time is up dawg");
        break;
    }
    if (daysUntilExpiration <= 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}!");
    }
    else if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires within 5 days!\nRenew now and save {discountPercentage}!");
    }
    else if (daysUntilExpiration < 10)
    {

        Console.WriteLine("Your subscription will expire soon. Renew now!");

    }
    Console.WriteLine(daysUntilExpiration);
    daysUntilExpiration = random.Next(0, 10);
}
