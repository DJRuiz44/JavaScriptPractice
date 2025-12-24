// See https://aka.ms/new-console-template for more information
int hero = 10;
int villian = 10;
Random random = new Random();
int nextAttack = random.Next(0, 10);

do
{
    villian -= nextAttack;
    Console.WriteLine($"Villian takes {nextAttack} damage!  Ouch");
    nextAttack = random.Next(0, 10);
    hero -= nextAttack;
    Console.WriteLine($"Hero takes {nextAttack} damage! Ouch!!!");
    nextAttack = random.Next(0, 10);

    
} while(hero > 0 || villian > 0);

if(villian > 0)
{
    Console.WriteLine("OOOOOOOOoooooof Villian wins!!!");
} else
{
    Console.WriteLine("Another One for the Good Guys");
}