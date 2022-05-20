using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSplit
{
    public class SplitTeam
    {
        public void ShuffleSplitTeams(string[] members, int teamSize)
        {
            Random random = new();
            members = members.OrderBy(shuffle => random.Next()).ToArray();
            Console.WriteLine("\n\nTeams\n");

            int i = 0, j = 0;
            int remainingExtraMembers = 0;
            int numberOfPerfectTeams = members.Length / teamSize;
            int extraMembers = members.Length % teamSize;

            //split equally
            if(extraMembers == 0)
            {
                while (i < members.Length)
                {
                    DisplayTeams(members[i..(i + teamSize)], i / teamSize + 1);
                    i += teamSize;
                }
            }
            //Cannot be split equally
            else
            {
                while (i < members.Length)
                {
                    remainingExtraMembers = (members.Length - i) % teamSize;
                    //Last team
                    if ((members.Length - i) / teamSize == 0)
                    {
                        DisplayTeams(members[i..], i / teamSize + 1);
                        break;
                    }
                    //few extra members and space in other teams, distribute them
                    else if (remainingExtraMembers <= teamSize / 2 && numberOfPerfectTeams > extraMembers)
                    {
                        DisplayTeams(members[i..(i + teamSize + 1)], i / teamSize + 1);
                        i += teamSize + 1;
                    }
                    //too many extra members or not enough teams to distribute, remain as is
                    else
                    {
                        DisplayTeams(members[i..(i + teamSize)], i / teamSize + 1);
                        i += teamSize;
                    }
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
