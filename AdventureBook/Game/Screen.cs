using System;
using System.Linq;

using AdventureBook.GameObjects;

//
//  Created by Aardhyn Lavender
//  20/05/2021
//

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
            height  = Console.WindowHeight - 1;

            // create a new screen array
            char[][] newScreen = new char[width][];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++) newScreen[y] = new char[width];

            // set the screen to the new screen
            screen = newScreen;
        }


        /// <summary>
        /// sets the screen to ' ' characters
        /// </summary>
        public static void Clear() {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++) screen[y][x] = ' '; // U+2001 not space
        }

        /// <summary>
        /// copies the characters in the screen buffer to the console
        /// </summary>
        public static void Render()
        {
            for (int row = 0; row < height; row++)
            {
                Console.SetCursorPosition(0, row);
                Console.WriteLine(new string(screen[row]));
            }
        }


        /// <summary>
        /// copies the 2d Jagged array to the Screen buffer for rendering
        /// </summary>
        /// <param name="texture">Texture to copy to the screen buffer</param>
        /// <param name="x">X location to place the texture</param>
        /// <param name="y">Y location to place the texture</param>
        public static void Print(char[][] texture, int srcX, int width, int height, int srcY, int desX, int desY)
            => JaggedCopy(texture, screen, srcX, srcY, width, height, desX, desY, true);


        // custom getters

        public static int GetWidth()    => width;
        public static int GetHeight()   => height;
        public static int GetCenterX()  => width / 2;
        public static int GetCenterY()  => height / 2;

        // calculations

        public static int CenterSpriteX(Sprite sprite) => GetCenterX() - sprite.GetWidth() / 2;
        public static int CenterSpriteY(Sprite sprite) => GetCenterY() - sprite.GetHeight() / 2;


        /// <summary>
        /// Copies a 2D jagged array data structure to another 2D jagged array at
        /// a specified cooordinate supporting transparancy on space characters
        /// </summary>
        /// <param name="source">Array to copy</param>
        /// <param name="destination">Array to paste</param>
        /// <param name="destX">X location on the destination to paste the source</param>
        /// <param name="destY">Y location on the destination to paste the source</param>
        /// <param name="replaceWhiteSpace">whether spaces should be treated as transparent characters</param>
        public static void JaggedCopy(
            char[][] source,
            char[][] destination,
            int srcX,
            int srcY,
            int width,
            int height,
            int destX,
            int destY,
            bool replaceWhiteSpace = true
            )
        {
            // make a copy of the source
            char[][] safeSource = source;

            // default width and height
            if (width <= 0) width   = source[0].Length;
            if (height <= 0) height = source.Length;

            for (int y = srcY; y < height; y++)
            {
                try
                {
                    // replace whitespace with 'see-through' of array 'below'
                    if (replaceWhiteSpace)
                    {
                        do
                        {
                            // find whitespace ' ' characters
                            int index = safeSource[y].ToList().IndexOf(' ');

                            // break if none found
                            if (index == -1) break;

                            // replace the whitespace character with whatever character is in
                            // this index in the desination array
                            safeSource[y][index] = destination[destY + y][destX + index];

                        } while (true);
                    }

                    // attempt to copy the array
                    try { Array.ConstrainedCopy(safeSource[y][srcX..(srcX + width)], 0, destination[destY + y], destX, source[y].Length); }
                    catch (Exception) { /* unhandled exception */ }
                }
                catch (System.ArgumentException) { /* unhandled exception */ }
            }
        }
    }
}
