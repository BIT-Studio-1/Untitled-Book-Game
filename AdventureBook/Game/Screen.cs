using System;

using AdventureBook.GameObjects;

namespace AdventureBook.Game
{
    static class Screen
    {
        // static members

        private static int width, height;
        private static char[][] screen;


        /// <summary>
        /// sets the screen size and buffer to the console specifications
        /// </summary>
        public static void SetToConsole()
        {
            // update the size
            width   = Console.WindowWidth;
            height  = Console.WindowHeight;

            // create a new screen array
            char[][] newScreen = new char[width][];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++) newScreen[x] = new char[width];

            // set the screen to the new screen
            screen = newScreen;
        }


        /// <summary>
        /// sets the screen to ' ' characters
        /// </summary>
        public static void Clear() {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++) screen[x][y] = ' ';
        }


        // custom getters

        public static int GetWidth()    => width;
        public static int GetHeight()   => height;
        public static int GetCenterX()  => width / 2;
        public static int GetCenterY()  => height / 2;

        // calculations

        public static int CenterSpriteX(Sprite sprite) => GetCenterX() - sprite.GetWidth() / 2;
        public static int CenterSpriteY(Sprite sprite) => GetCenterY() - sprite.GetHeight() / 2;
    }
}
