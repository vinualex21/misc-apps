using TeamSplit;

Console.Write("Enter member names separated by comma: ");
var userInput = Console.ReadLine();

Console.Write("Enter team size: ");
var size = Console.ReadLine();

var members = userInput?.Split(',').Select(x => x.Trim()).ToArray();

if (int.TryParse(size, out int team) && team > 0 && !(members?.Any(m=>string.IsNullOrEmpty(m))??true))
{
    SplitTeam split = new();
    
    split.ShuffleSplitTeams(members, team);
}
else
{
    Console.WriteLine("Invalid input! Try again.");
}


