using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeLibrary
{
    public class Obstical
    {
        public Position obsticalPosition = new Position();

        Random rand = new Random();
        Map map = new Map();
        public Obstical()
        {
            obsticalPosition.X = rand.Next(5, map.Width);
            obsticalPosition.Y = rand.Next(5, map.Height);
        }

        char[] obsticals = new char[]
        {
            'X',
            'X',
            'X',
            'X',
            'X',
            'X'
        };
        
        public void DrawObstical()
        {
            Random rand = new Random();
            foreach (char obstical in obsticals)
            {

                //Console.Set
                //set the "X" to a rando postion on the map
                //Console.SetCursorPosition(obsticalPosition.X = rand.Next(5, map.Width), obsticalPosition.Y = rand.Next(5, map.Height));
                Console.SetCursorPosition(obsticalPosition.X = 20, obsticalPosition.Y = 5);
                if (obsticalPosition.X >= map.Width && obsticalPosition.Y >= map.Height)
                {
                    Console.Write(obstical);

                }
                else
                {
                    obsticalPosition.X++;
                    obsticalPosition.Y++;
                }
                //Console.Read();
            }

        }
        public Position ObsticalLocation()
        {
            return obsticalPosition;
        }
        public void NewObsticalLocation()
        {
            obsticalPosition.X = rand.Next(5, map.Width);
            obsticalPosition.Y = rand.Next(5, map.Height);
        }


    }
}
