// See https://aka.ms/new-console-template for more information


using System.Net.WebSockets;

List<int> scores = [56, 70, 81, 87, 100, 123];//this doesn't change

//using linq
IEnumerable<int> scoreQuery = 
    from score in scores
    where score>80
    orderby score descending
    select score;

//using method
var scoreQuery2 = scores.Where(s => s > 80).OrderByDescending(s => s);//from and select is implicit

List<int> myScores = [.. scoreQuery];//or scoreQuery.ToList()

foreach (var item in myScores)
{ 
    Console.WriteLine(item);
}



