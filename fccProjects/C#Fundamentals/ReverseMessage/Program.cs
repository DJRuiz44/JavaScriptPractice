// See https://aka.ms/new-console-template for more information
string pangram = "The quick brown fox jumps over the lazy dog";
int start = 0;
string[] pangramArray = pangram.Split(" ");
int end = pangramArray.Length - 1;
string temp = "";
Console.WriteLine($"{start} and {end}");
string preSorted = string.Join(", ", pangramArray);
Console.WriteLine(preSorted);
while(start != end){
  temp = pangramArray[start]; 
  pangramArray[start] = pangramArray[end];
  pangramArray[end] = temp;
  start++;
  end--;
  Console.WriteLine(start);
  Console.WriteLine(end);
}
Console.WriteLine(pangramArray);
string result = string.Join(", ", pangramArray);
Console.WriteLine(result);

Console.WriteLine("Reversing it by the letters pendejo");
char Temp;
start = 0;
end = pangram.Length - 1;
char[] pangramChars = pangram.ToCharArray();
while(start != end){
  Temp = pangramChars[start];
  pangramChars[start] = pangramChars[end];
  pangramChars[end] = Temp;
  start++;
  end--;
}
string reversedHopefully = new string(pangramChars);
Console.WriteLine(reversedHopefully);
