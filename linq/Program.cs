// See https://aka.ms/new-console-template for more information
// Specify the data source.
// int[] scores = [97, 92, 81, 60];
List<int> scores = [97, 92, 81, 60];//syntactical sugar

for (int i = 0; i < scores.Count; i++)
{
    if(scores[i]>80){
        Console.WriteLine($"Found a score over {scores[i]}");
    }
}

return;

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81
