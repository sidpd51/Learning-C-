// See https://aka.ms/new-console-template for more information

//1.Data source/ Specify the data source.
// int[] scores = [97, 92, 81, 60];


List<int> scores = [97, 100, 92, 81, 60];//syntactical sugar

// for (int i = 0; i < scores.Count; i++)
// {
//     if(scores[i]>80){
//         Console.WriteLine($"Found a score over {scores[i]}");
//     }
// }

// return;

//2. Define the query expression/ query creation.
// IEnumerable<string> scoreQuery =
//     from score in scores
//     where score > 80
//     orderby score descending //sorting using linq
//     select $"The score is {score}";

var highScoreCount = (
    from score in scores
    where score > 80
    select score
);//can use max min 

Console.WriteLine(highScoreCount.Count());

return;

// Console.WriteLine(scoreQuery.Count());
//3. Execute the query/query execution.
// foreach (var s in scoreQuery)
// {
//     Console.WriteLine(s + " ");
// }

// Output: 97 92 81



// Console.WriteLine(highScoreCount);

// IEnumerable<int> highScoresQuery3 =
//     from score in scores
//     where score > 80
//     select score;

// var scoreCount = highScoresQuery3.Count();


// Console.WriteLine(ScoreCount);
