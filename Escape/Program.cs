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

            while (!exit)
            {
                map.DrawMap();
                player.DrawCharacter();
                Console.Read();
            }
        }
    }
}