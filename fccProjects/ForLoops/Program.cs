for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

string[] names = ["Daniel", "Dan", "Danny boy"];
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

//Fizz Buzz
/*
    % 3 = "Fizz";
    % 5 = "Buzz";
    % 3 && 5 = "Fizz Buzz"
*/
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} Fizz Buzz :_)");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

   if(i == 69)
    {
        Console.WriteLine($"{i} NIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIICEEEEEEEEEEE");
    } 
    
}