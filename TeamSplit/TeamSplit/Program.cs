

using TeamSplit;

string[] players =
            {
                "Adrian", "Aja", "Apshan", "Carl", "Eman", "Franco", "Hayley", "Ia", "Namita", "Nolan", "Sam",
                "Shannon", "Sherry", "Vahid", "Vijay", "Vinu", "Naunidh"
            };

SplitTeam split = new();
split.ShuffleSplitTeams(players, 6);
