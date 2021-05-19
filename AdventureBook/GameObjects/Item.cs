using System;
namespace AdventureBook.GameObjects
{
    public class Item : Sprite
    {
        // MEMBERS /////////////////////////////////////////////////////////////

        private Action effect;
        private string collectionMessage;

        // CONSTRUCTORS AND FINALISER //////////////////////////////////////////

        public Item(string name,                    // name of item
                    string pathToTexture,           // path to texture
                    Action effect,                  // effect called onCollection()
                    string onCollectionText = ""    // message printed when collected
            )
            : base(name, pathToTexture)
        {
            // apply default onCollection text if left blank
            if (onCollectionText == string.Empty)
            {
                collectionMessage = $"You picked up a '{name}'";
            }
            else
            {
                collectionMessage = onCollectionText;
            }

            this.effect = effect;
        }

        ~Item() => Console.WriteLine("Item object deconstructed!");

        // METHODS /////////////////////////////////////////////////////////////

        /// <summary>
        /// called when the protagonist picks up an instance of this item
        /// </summary>
        public virtual void OnCollection()
        {
            Console.WriteLine(collectionMessage);
            effect();
        }
        
    }
}
