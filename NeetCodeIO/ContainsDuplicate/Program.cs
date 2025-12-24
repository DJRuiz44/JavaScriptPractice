// See https://aka.ms/new-console-template for more information
bool hasDuplicate(int[] num)
{
    HashSet<int> seen = new HashSet<int>();
    foreach(int number in num)
    {
        if (!seen.Add(number)){
            return true;
        }
    }
    return false;
}
    //sort first//
    //Array.Sort(num);
    //for(int i = 1; i < num.Length; i++)
    //{
       //if(num[i] == num[i-1])
        //{
            //return true;
        //} 
    //}
    //return false;
    //}
    /* Given constraint on element size < array.length
    int max = num[0];
  for(int i = 0; i < num.Length; i++)
    {
       if(num[i] > max)
        {
            max = num[i];
        }
    }  
    Console.WriteLine(max);
    int[] occurs = new int[max];
    Console.WriteLine(occurs.Length);
   for(int i = 0; i < num.Length; i++)
    {
       if(occurs[num[i] - 1] > 0)
        {
           return true; 
        } else
        {
            occurs[num[i] - 1] += 1;
        }
    }  
    Console.WriteLine(string.Join(", ", occurs));
    return false; 
}

/*Brute Force O^2 solution
{
    for(int i = 0; i < num.Length; i++)
    {
        for(int j = i + 1; j < num.Length; j++)
        {
            if(num[j] == num[i])
            {
                Console.WriteLine(num[j]);
                Console.WriteLine(num[i]);
                return true;
            }
        }
    }
    return false;
}
*/
int[] testNums = [1, 2, 4, 5];
Console.WriteLine(hasDuplicate(testNums));