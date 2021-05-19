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

        private int width, height, frames = 1, currentFrame = 0;
        private char[][][] textures;

        public string Name { get; set; }

        // CONSTRUCTORS AND FINALISER //////////////////////////////////////////

        public Sprite(string name, string pathToTextFile)
        {
            Name = name;
            LoadTextureFromFile(pathToTextFile);
        }

        public Sprite(string name, string[] pathToTextFiles)
        {
            Name = name;

            // load each frame into the texture
            frames = pathToTextFiles.Length;
            for (int frame = 0; frame < frames; frame++) LoadTextureFromFile(pathToTextFiles[frame], frame);
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
        /// <param name="frame">the frame index to load the texture into</param>
        /// <returns>True if the text file was correctly encoded into the array</returns>
        private bool LoadTextureFromFile(string path, int frame = 0)
        {
            try
            {
                string[] file   = (string[])File.ReadLines(path);

                height          = file.Length;
                width           = file[0].Length;

                textures[frame] = new char[width][];

                for (int row = 0; row < width; row++) textures[frame][row] = file[row].ToCharArray();

                return true;
            }
            catch (Exception) { return false; }
        }


        /// <summary>
        /// Prints the specified frame texture of this sprite to the screen
        /// </summary>
        /// <param name="x">x location to start printing the sprite</param>
        /// <param name="y">y location to start printing the sprite</param>
        /// <param name="frame">the specific frame of the sprite to print</param>
        public void PrintSprite(int x, int y, int frame = 0)
        {
            for (int row = 0; row < height; row++)
            {
                try
                {
                    // TODO > Will implement transparancy on sprites

                    Console.SetCursorPosition(x + row, y);
                    Console.Write(textures[frame][row].ToString());
                }
                catch (Exception) { throw new Exception("[ PrintSprite() ] Failed to print sprite to the screen!");  }
            }
        }
    }
}
