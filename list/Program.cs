// See https://aka.ms/new-console-template for more information

using System.Net.WebSockets;
using System.Reflection.Metadata;
//list of strings 
var names = new List<string> {"siddharth", "Ana", "Felipe"};
foreach(var name in names){
    Console.WriteLine($"Hello {name.ToUpper()}");
}
//Add and Remove function in list
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");

//using Count and ToUpper() method
foreach(var name in names){
    Console.WriteLine($"Hello {name.ToUpper()}");
}

Console.WriteLine($"My name is {names[0]}");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

Console.WriteLine($"The list has {names.Count} people in it.");

//using indexOf method
Console.WriteLine();
var index = names.IndexOf("Felipe");
if(index != -1){
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf will return {notFound}");

//after sorting
Console.WriteLine();
names.Sort();
foreach(var name in names){
    Console.WriteLine($"Hello {name.ToUpper()}");
}

//fibonacci numbers
var fibonacciNumbers = new List<int> {1,1};

// for(int i =3; i<21; i++){
//     var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
//     var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

//     fibonacciNumbers.Add(previous+previous2);
// }

while(fibonacciNumbers.Count<20){
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous+previous2);
}

foreach(var item in fibonacciNumbers){
    Console.WriteLine(item);
}


