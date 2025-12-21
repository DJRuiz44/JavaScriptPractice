// See https://aka.ms/new-console-template for more information
Random dice = new();
int counter = 0;

int num1 = dice.Next(1, 4);
int num2 = dice.Next(1, 3);
int num3 = dice.Next(1, 3);
bool triple = false;

int total = num1 + num2 + num3;
do
{
    if (num1 == num2 || num2 == num3 || num3 == num1)
    {
        total += 2;
        Console.WriteLine("You rolled doubles!!! Plus 2 to total");
    }
    if (num1 == num2 && num2 == num3)
    {
        total += 5;
        Console.WriteLine("You rolled triples holy smokes!!!!!!!:) plus 5!!!");
        break;
    }
    
    Console.WriteLine($"{num1}: Roll1");
    Console.WriteLine($"{num2}: Roll2");
    Console.WriteLine($"{num3}: Roll3");
    Console.WriteLine(total);
    total = 0;
    counter += 1;
    num1 = dice.Next(1, 3);
    num2 = dice.Next(1, 3);
    num3 = dice.Next(1, 3);
} while (!(triple));
Console.WriteLine($"Loop ran {counter} times :O");
Console.WriteLine($"{total}: is the total of the rolls");
if (total > 5)
{
    Console.WriteLine($"You win! With {counter} loops");
}
else
{
    Console.WriteLine($"You lose! :()");
}