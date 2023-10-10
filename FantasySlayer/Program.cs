FantasySlayer.FantasySlayer fantasy = new(@"C:\git\FantasySlayer\FantasySlayer\teamConfig.json");

Console.WriteLine(fantasy);
Console.WriteLine("Probability of winning: " + fantasy.CalculateWinProbability());
Console.WriteLine("Suggested Changes: " + fantasy.SuggestedChanges());