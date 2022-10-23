using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeLibrary
{
    public class Score
    {
        public Position scorePosition = new Position();
        Random rand = new Random();
        Map map = new Map();//so it knows to spawn on map
        public Score()
        {
            scorePosition.X = rand.Next(5, map.Width);
            scorePosition.Y = rand.Next(5, map.Height);
        }

        public void DrawScore()
        {
            Console.SetCursorPosition(scorePosition.X, scorePosition.Y); //set the "S" to a rando postion on the map
            Console.Write('S');
        }
        public Position ScoreLocation()
        {
            return scorePosition;
        }
        public void NewScoreLocation()
        {
            scorePosition.X = rand.Next(5, map.Width);
            scorePosition.Y = rand.Next(5, map.Height);
        }

    }
}
