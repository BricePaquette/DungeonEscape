using EscapeLibrary;
namespace Escape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Character player = new Character();
            bool exit = false;
            Console.WriteLine("\t\t\t PRESS ENTER");
            Console.Read();

            while (!exit)
            {
                map.DrawMap();
                player.Input();
                player.DrawCharacter();
                player.MoveCharacter();
                //Console.Read();
            }
        }
    }
}