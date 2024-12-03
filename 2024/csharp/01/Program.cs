// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var input = File.ReadLines("./input.txt");

var listOne = new List<int>() {};
var listTwo = new List<int>() {};

foreach (var line in input) 
{
    var ids = line.Split("   ");

    for (int i = 0; i > Int32.Parse(ids[0]) ; i++)
    {
        if()
        listOne.Insert(i);
        
    }
    listOne.Add(ids[0]);
    listTwo.Add(ids[1]);
}

Console.ReadLine();