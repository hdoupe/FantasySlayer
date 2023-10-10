FantasySlayer.FantasySlayer fantasy = new(@"C:\git\FantasySlayer\FantasySlayer\exampleTeamConfig.json");

Console.WriteLine(fantasy);
Console.WriteLine("Probability of winning: " + fantasy.CalculateWinProbability());

List<string> suggestedChanges = fantasy.SuggestedChanges();
Console.WriteLine("Suggested Changes:\n\t" + string.Join("\n\t", suggestedChanges));