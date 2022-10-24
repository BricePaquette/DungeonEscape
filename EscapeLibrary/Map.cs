namespace EscapeLibrary
{
    public class Map
    {
        //properties to set the bounderies of user play area
        public int Width { get; set; }
        public int Height { get; set; }

        public Map()
        {
            //all of the maps will have the same width / height
            Width = 50;
            Height = 31;
            //so the user cant see the cursor
            Console.CursorVisible = false;
        }//end ctor

        //Draw map in the console
        public void DrawMap()
        {
            Console.Clear();
            
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('#');
            }
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write('#');
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
            
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write('#');
            }
        }

    }
}