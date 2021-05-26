using System;
using AdventureBook.Game;
using AdventureBook.GameObjects;

namespace AdventureBook.GameObjects
{
    public class UserInterface : Sprite
    {
        public UserInterface(string name, string pathToTextFile)
            : base(name, pathToTextFile)
        {  }

        /// <summary>
        /// Copies the inputed value to the User Interface::texture
        /// </summary>
        /// <typeparam name="Type">type of the element to copy, should be implicitably convertable to string</typeparam>
        /// <param name="element">element to copy</param>
        /// <param name="x">x postion on the user interface</param>
        /// <param name="y">y postion on the user interface</param>
        public void UpdateElement<Type> (Type element, int x, int y)
        {
            char[][] elementTexture = new char[1][] { element.ToString().ToCharArray() };
            Screen.JaggedCopy(elementTexture, textures[0], 0, elementTexture.Length, 0, 1, x, y, false);
        }
    }
}
