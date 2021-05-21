﻿using System;
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
                for (int y = 0; y < height; y++) screen[y][x] = ' '; // ' ' U+2001 not space
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
        public static void Print(char[][] texture, int desX, int desY)
        {
            int startX, endX, startY, endY;

            // is the texture off the edge of the screen
            if (desX < 0)
            {
                startX = Math.Abs(desX);
                endX = (startX + width > texture[0].Length - startX) ? width - 1 : desX + texture[0].Length;
                desX = 0;
            }
            else
            {
                startX = desX;
                endX = desX + texture[0].Length - 1;
                if (endX > width) endX = width;
            }

            if (desY < 0)
            {
                startY = Math.Abs(desY);
                endY = (startY + height > texture.Length - startY) ? height - 1 : desY + texture.Length;
                desY = 0;
            }
            else
            {
                startY = desY;
                endY = desY + texture.Length - 1;
                if (endY > height) endY = height;
            }

            JaggedCopy(texture, screen, startX, endX, startY, endY, desX, desY, true);
        }


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
            int startX,
            int endX,
            int startY,
            int endY,
            int destX = 0,
            int destY = 0,
            bool replaceWhiteSpace = true
            )
        {
            char[][] safeSource = source[startY .. endY];

            for (int y = 0; y < source.Length; y++)
            {
                try
                {
                    // replace whitespace with 'see-through' of matrix below
                    if (replaceWhiteSpace)
                    {
                        do
                        {
                            int index = safeSource[y].ToList().IndexOf(' ');
                            if (index == -1) break;

                            safeSource[y][index] = destination[destY + y][destX + index];
                        } 
                        while (true);
                    }

                    try { Array.ConstrainedCopy(safeSource[y][startX .. endX], 0, destination[destY + y], destX, source[y].Length); }
                    catch (Exception) { /* unhandled exception */ }
                }
                catch (System.ArgumentException) { return; }
            }
        }
    }
}
