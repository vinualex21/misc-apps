using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSplit
{
    public class SplitTeam
    {
        public void ShuffleSplitTeams(string[] players, int teamSize)
        {
            foreach (var player in players)
                Console.Write($"{player} ");

            Random random = new Random();
            players = players.OrderBy(shuffle => random.Next()).ToArray();
            Console.WriteLine("\n\nTeams\n");

            int i = 0, j = 0;
            int extraMembers = 0;
            while (i < players.Length)
            {
                //Cannot be divided equally
                extraMembers = (players.Length - i) % teamSize;
                if (extraMembers != 0)
                {
                    //Last team
                    if ((players.Length - i) / teamSize == 0)
                    {
                        DisplayTeams(players[i..], i / teamSize + 1);
                        break;
                    }
                    //extra members are small compared to team size, distribute them among other teams
                    else if (extraMembers < teamSize / 2)
                    {
                        DisplayTeams(players[i..(i + teamSize + 1)], i / teamSize + 1);
                        i += teamSize + 1;
                    }
                    //extra members are more than half of team size, let them remain as a team
                    else
                    {
                        DisplayTeams(players[i..(i + teamSize)], i / teamSize + 1);
                        i += teamSize;
                    }
                }
                else
                {
                    DisplayTeams(players[i..(i + teamSize)], i / teamSize + 1);
                    i += teamSize;
                }
            }
        }
        
        private void DisplayTeams(string[] team, int teamNumber)
        {
            Console.Write($"Team {teamNumber}: ");
            int i = 0;
            if (team.Count()>2)
            {
                for(i = 0; i < team.Length-2; i++)
                {
                    Console.Write($"{team[i]}, ");

                }
            }
            Console.WriteLine($"{team[i]} and {team[i+1]}.");

        }
    }
}
