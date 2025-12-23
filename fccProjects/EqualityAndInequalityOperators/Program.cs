//// See https://aka.ms/new-console-template for more information
//Console.WriteLine('a' == 'a');
//Console.WriteLine("A" == "a");


//Console.WriteLine("A       ".Trim().ToLower() == "a ".Trim().ToLower());

//string name = "Dan";
//string response = name == "Dan" ? "Hey thats my name" : "Thats not my name";
//Console.WriteLine(response);
Random generator = new Random();
int coin = generator.Next(2);
int headsCounter = 0;
int tailsCounter = 0;
int counter = 0;
Console.WriteLine("\t\tLet's see who gets to 5 first: Tails or Heads?");
while (headsCounter < 5 && tailsCounter < 5)
{
    Console.WriteLine(coin);
    if (coin == 1)
    {
        Console.WriteLine("heads:_");
        headsCounter += 1;
    }
    else
    {
        Console.WriteLine("Tails");
        tailsCounter += 1;
    }
    counter += 1;
    coin = generator.Next(2);
}
Console.WriteLine($"Heads:\t\t{headsCounter}");
Console.WriteLine($"Tails:\t\t{tailsCounter}");
Console.WriteLine("Thanks for playing!");