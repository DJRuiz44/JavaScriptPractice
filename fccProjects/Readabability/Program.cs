/* This function does a bunch of cool stuff
for instance it takes ur bread and than takes ur job */
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}
string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");