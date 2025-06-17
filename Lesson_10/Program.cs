using System;
using System.Collections.Generic;
using System.Linq;

List<string> fructes = new List<string>();

fructes.Add("Apple");
fructes.Add("Banana");
fructes.Add("Cherry");
fructes.Add("Date");

Console.WriteLine(fructes[1]);

foreach(var fruit in fructes)
{
    Console.WriteLine(fruit);
}

fructes.Remove("Banana");

string isAppleInList = fructes.FirstOrDefault("Apple");

fructes.Clear();

List<string> vegetables = new List<string>();
fructes.AddRange(vegetables);

fructes.Insert(0, "Orange");
fructes.Insert(1, "Grapes");

fructes.Remove("Banana");
fructes.RemoveAt(0); 

//fructes=null; 
if(fructes.Count > 0)
{
    Console.WriteLine("List is not empty");
}
else
{
    Console.WriteLine("List is empty");
}

fructes.Sort();

fructes.Reverse();

List<string> newList = new List<string>();

newList.AddRange(fructes);


if (fructes[0]== "Apple")
{
    Console.WriteLine("First element is Apple");
}
else
{
    Console.WriteLine("First element is not Apple");
}

foreach (var fruit in fructes)
{
    if(fruit.Length > 5)
        fructes.Remove(fruit);
}

foreach (var fruit in fructes)
{
    if(fruit.StartsWith("a"))
        Console.WriteLine(fruit);
}

fructes.Reverse();

string k="";

foreach (var item in fructes)
{
     k=k+item;
}







