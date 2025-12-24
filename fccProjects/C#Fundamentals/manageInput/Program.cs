//Console.Write("Please enter a number: ");
//string readResult = Console.ReadLine();
//int x = 0;
//bool validNumber = false;

////validNumber = int.TryParse(readResult, out x);
////Console.WriteLine($"{x + 5} ayo");

//int input = 0;
//bool validInput = false;

//do
//{
    //Console.WriteLine("Enter a number between 5 and 10 please");
    //validInput = int.TryParse(Console.ReadLine(), out input);
    //if (!validInput)
    //{
        //Console.WriteLine("Enter a number you jack wagon");
    //}
    
//} while (input < 5 || input > 10);

//string stringInput = "";
//Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//stringInput = Console.ReadLine().Trim().ToLower();

//while (stringInput != "Administrator".ToLower() && stringInput != "Manager".ToLower() && stringInput != "User".ToLower())
//{
    //Console.WriteLine("Please Enter a valid role >:<");
    //stringInput = Console.ReadLine().Trim().ToLower();
//}
//Console.WriteLine($"Your input value ({stringInput}) has been accepted.");

//string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

//int periodLocation = 0;
//int counter = 0;
//foreach(string sentence in myStrings)
//{
    //periodLocation = sentence.IndexOf(".");
    //if(sentence.IndexOf(".") != -1)
    //{
        //do
        //{
            //if (sentence[counter] != '.') 
            //{
                //Console.Write(sentence[counter]);
                //counter++;
            //} 
            //counter++;
        //} while(counter < sentence.Length);
        //counter = 0;
        //Console.Write("\n");
    //} else
    //{
        //Console.WriteLine(sentence);
    //}
//}
string sentence = "Daniel go to lab.  He get smarter.  He speaks more eloquently";
int periodLocation = sentence.IndexOf(".");
string newSentence = "";
while(periodLocation != -1)
{
    newSentence += sentence.Remove(periodLocation);
    sentence = sentence.Substring(periodLocation + 1);
    periodLocation = sentence.IndexOf(".");
}
Console.WriteLine(newSentence);