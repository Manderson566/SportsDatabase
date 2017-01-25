using SportsDatabase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SportStatsContext())
            {

                Player danMarino = new Player
                {
                    Name = "Dan Marino",
                    Position = "Quarterback",
                    YearsPlayedForTeam = 16,
                    College = "Pittsburgh"


                };

                Player drewBrees = new Player
                {
                    Name = "Drew Brees",
                    Position = "Quarterback",
                    YearsPlayedForTeam = 10,
                    College = "Purdue"
                };

                Stats danMarinoStatsMia = new Stats
                {
                    Touchdowns = 242,
                    PassingYards = 61631,
                    RushingYards = 301,
                    Compleations = 4967,
                    CompleationPercentage = 59,
                    Interceptions = 252

                };
                Stats drewBreesStatsNor = new Stats
                {
                    Touchdowns = 465,
                    PassingYards = 66111,
                    RushingYards = 724,
                    Compleations = 5836,
                    CompleationPercentage = 66,
                    Interceptions = 220

                };

                Team mia = new Team
                {
                    TeamName = "Miami Dolphins",
                    YearFounded = 1966,
                   

                };
                Team nor = new Team
                {
                    TeamName = "New Orleans Saints",
                    YearFounded = 1966,
                    

                };
                Console.WriteLine("Would you like to create a Team, or Player? please type which you would like, or type any key to exit.");
                bool optionCK = true;
                while (optionCK)
                {
                    string chooseAnOption = Console.ReadLine();

                    if (chooseAnOption.ToUpper() == "TEAM")
                    {
                        Console.Write("Please enter the name of your team:");
                        string teamName = Console.ReadLine();
                        Console.Write("Please enter the year the team was founded");
                        string teamYear = Console.ReadLine();
                        int teamYearInt = int.Parse(teamYear);

                        Team newTeam = new Team
                        {
                            TeamName = teamName,
                            YearFounded = teamYearInt,
                        };
                        db.Team.Add(newTeam);

                        optionCK = true;
                    }
                    else if (chooseAnOption.ToUpper() == "PLAYER")
                    {
                        Console.Write("Please enter the name of your player.");
                        string playerName = Console.ReadLine();
                        Console.Write($"Please enter the position {playerName} plays.");
                        string playerPos = Console.ReadLine();
                        Console.Write($"Please enter the years {playerName} has played pro.");
                        string playerPlayedPro = Console.ReadLine();
                        int playerPlayedProInt = int.Parse(playerPlayedPro);
                        Console.Write($"Please enter the college {playerName} went to.");
                        string playerCollege = Console.ReadLine();

                        optionCK = true;

                        Player newPlayer = new Player
                        {

                            Name = playerName,
                            Position = playerPos,
                            YearsPlayedForTeam = playerPlayedProInt,
                            College = playerCollege

                        };
                        db.Player.Add(newPlayer);
                    }
                    else
                    {
                        optionCK = false;
                    }
                }
               

                
                //db.Team.Add(newTeam);
                //db.Player.Add(newPlayer);
                //db.Stats.Add(drewBreesStatsNor);
                db.SaveChanges();
            }

        }
    }
}
