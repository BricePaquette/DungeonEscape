using EscapeLibrary;
using System.Xml.Linq;

namespace Escape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Character player = new Character();
            bool exit = false;
            Score score = new Score();
            Console.WriteLine("\t\t\t PRESS ENTER");
            Console.Read();
            while (!exit)
            {
                try
                {

                    map.DrawMap();
                    Console.SetCursorPosition(51, 5);
                    Console.Write($"SCORE: {player.Score}");
                    player.Input();
                    score.DrawScore();
                    player.DrawCharacter();
                    player.MoveCharacter();
                    player.CollectScore(score.ScoreLocation(), score);
                    player.HitWall(map);
                    


                }

                catch (Exception e)
                {

                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Would you like to restart? y/n");
                    string userRestart = Console.ReadLine().ToLower().Trim();
                    switch (userRestart)
                    {
                        case "yes":
                        case "y":
                            //reset snake postion length and score
                            player.X = 10;
                            player.Y = 10;
                            player.Score = 0;

                            player.CharacterPhysicalScore.RemoveRange(0, player.CharacterPhysicalScore.Count - 1);
                            break;
                        case "n":
                        case "no":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
            }
    }
}