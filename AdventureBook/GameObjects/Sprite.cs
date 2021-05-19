using System;
using System.IO;

//
//  Created by Aardhyn Lavender
//  19/05/2021
//

namespace AdventureBook.GameObjects
{
    public abstract class Sprite
    {
        // MEMBERS /////////////////////////////////////////////////////////////

        private int width, height;
        private char[][] texture;

        public string Name { get; set; }

        // CONSTRUCTORS AND FINALISER //////////////////////////////////////////

        public Sprite(string name, string pathToTextFile)
        {
            Name = name;
            LoadTextureFromFile(pathToTextFile);
        }

        ~Sprite() => Console.WriteLine("Sprite object deconstructed!");

        // METHODS /////////////////////////////////////////////////////////////

        public int GetWidth()   => width;
        public int GetHeight()  => height;


        /// <summary>
        /// Loads the specified text file into a 2D jagged array returning true if the
        /// texture was successfully loaded
        /// </summary>
        /// <param name="path">relative filepath to the text file</param>
        /// <returns>True if the text file was correctly encoded into the array</returns>
        private bool LoadTextureFromFile(string path)
        {
            try
            {
                string[] file   = (string[])File.ReadLines(path);

                height          = file.Length;
                width           = file[0].Length;

                texture = new char[width][];

                for (int row = 0; row < width; row++) texture[row] = file[row].ToCharArray();

                return true;
            }
            catch (Exception) { return false; }
        }


        /// <summary>
        /// Prints the texture of this sprite to the screen
        /// </summary>
        /// <param name="x">x location to start printing the sprite</param>
        /// <param name="y">y location to start printing the sprite</param>
        public void PrintSprite(int x, int y)
        {
            for (int row = 0; row < height; row++)
            {
                try
                {
                    // TODO > Will implement transparancy on sprites

                    Console.SetCursorPosition(x + row, y);
                    Console.Write(texture[row].ToString());
                }
                catch (Exception) { throw new Exception("[ PrintSprite() ] Failed to print sprite to the screen!");  }
            }
        }
    }
}
