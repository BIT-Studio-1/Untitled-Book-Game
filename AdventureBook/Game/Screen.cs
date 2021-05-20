using System;

using AdventureBook.GameObjects;

namespace AdventureBook.Game
{
    static class Screen
    {
        private static int width, height;
        private static char[][] screen;

        public static void SetToConsole()
        {
            width   = Console.WindowWidth;
            height  = Console.WindowHeight;

            screen = new char[width][];
            for (int x = 0; x < width; x++) for (int y = 0; y < height; y++) screen[x][y] = ' ';
        }

        public static int GetWidth()    => width;
        public static int GetHeight()   => height;
        public static int GetCenterX()  => width / 2;
        public static int GetCenterY()  => height / 2;


        public static int CenterSpriteX(Sprite sprite) => GetCenterX() - sprite.GetWidth() / 2;
        public static int CenterSpriteY(Sprite sprite) => GetCenterY() - sprite.GetHeight() / 2;
    }
}
