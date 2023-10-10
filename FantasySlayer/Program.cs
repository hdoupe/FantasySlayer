FantasySlayer.FantasySlayer fantasy = new(@"C:\git\FantasySlayer\FantasySlayer\exampleTeamConfig.json");

Console.WriteLine(fantasy);
Console.WriteLine("Probability of winning: " + fantasy.CalculateWinProbability());
Console.WriteLine("Suggested Changes: " + fantasy.SuggestedChanges());