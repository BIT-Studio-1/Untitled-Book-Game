using System;
using System.Collections.Generic;

using AdventureBook.Game;

namespace AdventureBook.GameObjects
{
    public class Decision : UserInterface
    {
        private int selection = 0;
        private int[] selectionIndices;

        public int Selection
        {
            get => selection;
            set
            {
                if (value < 0)
                    selection = options.Keys.Count - 1;

                else if (value > options.Keys.Count - 1)
                    selection = 0;

                else
                    selection = value;
            }
        }

        private Dictionary<string, Action> options;
        private char[][] optionsTexture;
        private int optionsTextureX, optionsTextureY = 2;

        public Decision(string name, Dictionary<string, Action> options)
            : base(name, "Assets/UserInterface/Decision.txt")
        {
            this.options = options;

            int index = 0;
            int i = 0;
            selectionIndices = new int[options.Keys.Count * 2];
            string optionsString = string.Empty;

            foreach (string option in options.Keys)
            {
                selectionIndices[i++] = index += option.Length;
                optionsString += " " + option + "  ";
                index += 2;
            }

            optionsString = optionsString.TrimEnd();
            optionsString += " ";

            optionsTexture = new char[1][] { optionsString.ToCharArray() };
            optionsTextureX = width / 2 - optionsString.Length / 2;

            Update();
        }

        public void Update()
        {
            int start = selectionIndices[selection * 2],
                end = selectionIndices[selection * 2 + 1];

            optionsTexture[0][start] = '{';
            optionsTexture[0][end] = '}';
            Screen.JaggedCopy(optionsTexture, textures[0], 0, optionsTexture[0].Length, 0, 1, optionsTextureX, optionsTextureY, false);
        }
    }
}
