// See https://aka.ms/new-console-template for more information
//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A130";
//fraudulentOrderIDs[1] = "B352";
//fraudulentOrderIDs[2] = "C230";
//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//fraudulentOrderIDs[0] = "redo";
//Console.WriteLine($"Reassigning variable positions: {fraudulentOrderIDs[0]}");

//Console.WriteLine($"There are {fraudulentOrderIDs.Length} faulty orders to process !! zomgosh");

//foreach (string id in fraudulentOrderIDs)
//{
    //Console.WriteLine($"{id}");
//}

string[] fraudulentOrderIds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach(string order in fraudulentOrderIds)
{
    if(order[0] == 'B')
    {
        Console.WriteLine(order);
    }
    if(order.StartsWith('B'))
    {
        Console.WriteLine(order);
    }
}