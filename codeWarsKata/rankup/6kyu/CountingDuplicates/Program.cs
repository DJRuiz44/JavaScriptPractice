 int DuplicateCount(string str)
{
    Dictionary<char, int> charCounter = new Dictionary<char, int>();
    str = str.ToLower();
    Console.WriteLine(str);
    foreach(char letter in str)
    {
        if (charCounter.ContainsKey(letter))
        {
            charCounter[letter] += 1;
        } else
        {
            charCounter.Add(letter, 1);
        }
    }
    int counter = 0;
    foreach(KeyValuePair<char, int> entry in charCounter)
    {
        if(entry.Value > 1)
        {
            counter++;
        } 
    }
    if (counter > 0)
    {
        return counter;
    }
    else
    {
        return 0;
    }
}

int result = DuplicateCount("DDAAbbbbbc");
Console.WriteLine(result);