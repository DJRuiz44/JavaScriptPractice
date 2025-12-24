Random random = new Random();
int roll = random.Next(0, 7);
do
{
    roll = random.Next(0, 7);
    Console.WriteLine($"You rolled a {roll}! try again");
} while(roll != 6);
Console.WriteLine("You crit! GG");