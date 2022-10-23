using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeLibrary
{
    public class Character
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();//To allow movement key to be stored
        char key = 'w';//Key to be pressed
        char direction = 'u';//To verifiy direction of movement
        public int X { get; set; }
        public int Y { get; set; }
        public int Score { get; set; }

        public List<Position> CharacterPhysicalScore { get; set; }

        public Character()
        {
            X = 5;
            Y = 1;
            Score = 0;

            //Make it like a snake so I can give a score
            CharacterPhysicalScore = new List<Position>();
            CharacterPhysicalScore.Add(new Position(X, Y));
        }

        public void DrawCharacter()
        {
            foreach (Position position in CharacterPhysicalScore)
            {
                Console.SetCursorPosition(position.X, position.Y);//Pull the postion from the list and put the below there
                Console.Write("■");
            }
        }


    }
}
