using System;
using System.Collections.Generic;

namespace AdventureBook.GameObjects
{
    public static class Protagonist
    {
        // MEMBERS /////////////////////////////////////////////////////////////

        static private int healthMax                = 100;
        static private int powerMax                 = 100;

        static private int health                   = healthMax;
        static private int attack                   = 30;
        static private int power                    = powerMax;

        static private int inventorySize            = 5;
        static private List<Item> inventory         = new List<Item>();

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
            if (health <= 0)
            {
                health = 0;
                return true;
            }
            return false;
        }


        /// <summary>
        /// Called to give the protagonist health by the given amount
        /// </summary>
        /// <param name="amount">The amount of health the protagonist regains</param>
        public static void RegainHeatlth(int amount)
        {
            // increment the health, removing overflow
            health += amount;
            if (health > healthMax) health = healthMax;
        }


        /// <summary>
        /// The protagonist looses power by this ammount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>True if the protagonist looses all his power else false</returns>
        public static bool LosePower(int amount)
        {
            power -= amount;
            if (power < 0)
            {
                power = 0;
                return true;
            }
            return false;
        }


        /// <summary>
        /// The protagonist gains power by amount
        /// </summary>
        /// <param name="amount">ammount of power to gain</param>
        public static void GainPower(int amount)
        {
            power += amount;
            if (power > powerMax) power = powerMax;
        }


        // Update the protagonists stats – supports negitive increments

        public static void IncreaseHealthMax(int amount)        => healthMax += amount;
        public static void IncreasePowerMax(int amount)         => powerMax += amount;
        public static void IncreaseInventorySize(int amount)    => inventorySize += amount;

        public static void IncreaseAttack(int amount)           => attack += amount;
        public static void SetAttack(int newAttack)             => attack = newAttack;


        /// <summary>
        /// Adds an item to the protagonists inventory
        /// </summary>
        /// <param name="item">The item to be picked up</param>
        /// <param name="amount">The amount of this item to be picked up</param>
        /// <returns>True if the item was picked up, else false</returns>
        public static bool PickUpItem(Item item)
        {
            if (inventory.Count > inventorySize) return false;

            // Add the item and call its onCollection() handler
            inventory.Add(item);
            item.OnCollection();

            return true;
        }
    }
}
