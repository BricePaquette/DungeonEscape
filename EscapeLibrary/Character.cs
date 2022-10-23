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
            Y = 20;
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
        
        //where input is stored
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true); ;
                key = keyInfo.KeyChar;
            }
        }
        private void Direction()
        {
            //this is so you can only move up when we press w
            if (key == 'w' && direction != 'd')
            {
                direction = 'u';
            }
            //this is so you can only down up when we press s
            else if (key == 's' && direction != 'u')
            {
                direction = 'd';
            }
            //this is so you can only move right when we press d
            else if (key == 'd' && direction != 'l')
            {
                direction = 'r';

            }
            //this is so you can only move left when we press a
            else if (key == 'a' && direction != 'r')
            {
                direction = 'l';
            }

            //u = up, d = down, r = right, l = left
        }
        public void MoveCharacter()
        {
            Direction();//Made private to use here

            //Move the snake based on what direction the user pressed using the x and y props
            if (direction == 'u')
            {
                Y--;
            }
            else if (direction == 'd')
            {
                Y++;
            }
            else if (direction == 'l')
            {
                X--;
            }
            else if (direction == 'r')
            {
                X++;
            }
            //wont work with only one Character in the the  is in the same location so everytime we move we need to add the new x and y to the first index in the list 
            CharacterPhysicalScore.Add(new Position(X, Y));
            CharacterPhysicalScore.RemoveAt(0);//to give the illusion that the snbake is in fact moving
            Thread.Sleep(100);
        }
    }
}
