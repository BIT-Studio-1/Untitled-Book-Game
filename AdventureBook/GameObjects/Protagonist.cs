using System;
using System.Collections.Generic;

namespace AdventureBook.GameObjects
{
    public static class Protagonist
    {
        // MEMBERS /////////////////////////////////////////////////////////////

        static private int healthMax            = 100;
        static private int powerMax             = 100;

        static private int health               = healthMax;
        static private int attack               = 30;
        static private int power                = powerMax;

        static private int inventorySize        = 5;
        static private List<Item> inventory     = new List<Item>();

        // METHODS /////////////////////////////////////////////////////////////

        public static int GetHealth()               => health;
        public static int GetPower()                => power;

        public static List<Item> GetInventory()     => inventory;
        public static Item GetInventory(int index)  => inventory[(index < inventorySize - 1 && index > -1) ? index : inventorySize - 1];

        /// <summary>
        /// called to take health off the player in a battle or by other story twists
        /// </summary>
        /// <param name="damage">The amount of damage to deal the protagonist</param>
        /// <returns>returns true if this damage will kill the player else false</returns>
        public static bool TakeDamage(int damage)
        {
            health -= damage;
            return (health <= 0);
        }


        /// <summary>
        /// called to give the protagonist health by the given ammount
        /// </summary>
        /// <param name="amount">The ammount of health the protagonist regains</param>
        public static void RegainHeatlth(int amount)
        {
            // increment the health, removing overflow
            health += amount;
            if (health > healthMax) health = healthMax;
        }

        // update the protagonists stats – supports negitive increments
        public static void increaseHealthMax(int ammount)       => healthMax += ammount;
        public static void increasePowerMax(int ammount)        => powerMax += ammount;
        public static void increaseInventorySize(int ammount)   => inventorySize += ammount;
        public static void increaseAttack(int ammount)          => attack += ammount;      

        /// <summary>
        /// Adds an item to the protagonists inventory
        /// </summary>
        /// <param name="item">the item to be picked up</param>
        /// <param name="amount">the amount of this item to be picked up</param>
        /// <returns></returns>
        public static bool PickUpItem(Item item)
        {
            if (inventory.Count > inventorySize) return false;

            // add  the item and call its onCollection() handler
            inventory.Add(item);
            item.OnCollection();

            return true;
        }
    }
}
