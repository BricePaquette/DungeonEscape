using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeLibrary
{
    public class Position
    {
        //Created so i can add to a list for a score tracker
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;

        }
        public Position()
        {

        }
    }
}
