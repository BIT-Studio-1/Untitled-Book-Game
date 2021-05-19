using System;
namespace AdventureBook.GameObjects
{
    public class Item : Sprite
    {
        // MEMBERS /////////////////////////////////////////////////////////////

        // CONSTRUCTORS AND FINALISER //////////////////////////////////////////

        public Item(string name, string pathToTexture, string onCollectionText = "")
            : base(name, pathToTexture)
        {
            // apply default onCollection text if left blank
            if (onCollectionText == string.Empty) onCollectionText = $"You picked up a '{name}'";
        }

        ~Item() => Console.WriteLine("Item object deconstructed!");

        // METHODS /////////////////////////////////////////////////////////////

        /// <summary>
        /// called when the protagonist picks up an instance of this item
        /// </summary>
        public virtual void OnCollection()
        {

        }

    }
}
