using EscapeLibrary;
namespace Escape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            bool exit = false;

            while (!exit)
            {
                map.DrawMap();
                Console.Read();
            }
        }
    }
}