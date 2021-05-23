using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace AdventureBook.Game
{
    public class StoryComponent
    {
        // STATIC MEMEBERS /////////////////////////////////////////////////////

        public static StoryComponent ActiveStoryComponent = null;

        // Global Story data

        public static bool      isBattling              = false;                // is the protagonist currently in a battle

        public static bool[]    foundChests             = new bool[6];          // the chests the protagonist has found
        public static bool[]    defeatedBosses          = new bool[16];         // the bosses the protagonist has defeated

        public static int       timesSearchedInTrees    = 0;                    // times the protagonist searched in the trees outside the cavern - 5 yields blunt sword, 10 yeilds bent key
        public static int       timesClimbedWall        = 0;                    // times the protagonist attempted to climb out of the pit - has to be 30 to escpace
        public static int       timesSearchedInCavern   = 0;                    // times the protagonist searched the cavern - 10 times for a treasure chest

        public static StoryComponent onDeathGoto;                               // on death, run this story component.

        // MEMBERS /////////////////////////////////////////////////////////////

        public string Name { get; set; }

        public StoryComponent[] parentComponant;
        public Dictionary<string, StoryComponent> StoryComponents = new Dictionary<string, StoryComponent>();
        public Dictionary<string, Action> Actions = new Dictionary<string, Action>();

        // CONSTRUCTOR /////////////////////////////////////////////////////////

        public StoryComponent(string name)
        {
            Name = name;

            Actions.Add("EXIT", () =>
            {
                // is this the topmost component
                if (parentComponant == null) return;

                // travel up the component train, overide to change the index of the parent
                ActiveStoryComponent = parentComponant[0];
                parentComponant[0].RunAction("START");
            });
        }

        // give the component a starting point
        public void SetStart(Action onStart) => Actions.Add("START", onStart);

        // METHODS /////////////////////////////////////////////////////////////


        /// <summary>
        /// Adds a new nested component to be run.
        /// </summary>
        /// <param name="component"></param>
        /// <param name="Index">the parent index</param>
        /// 
        public void AddStoryComponent(ref StoryComponent component)
        {
            component.parentComponant[component.parentComponant.Length] = this;
            StoryComponents.Add(component.Name, component);
        }

        /// <summary>
        /// runs the given components START action
        /// </summary>
        /// <param name="name">components name</param>
        /// <returns>did the component run</returns>
        public bool RunStoryComponent(string name)
        {
            if (StoryComponents.ContainsKey(name))
            {
                ActiveStoryComponent = StoryComponents[name];
                StoryComponents[name].RunAction("START");
                return true;
            }
            return false;
        }


        /// <summary>
        /// define a new action for the component
        /// </summary>
        /// <param name="name">name of the action</param>
        /// <param name="action">what to do when run</param>
        public void AddAction(string name, Action action)
            => Actions.Add(name, action);


        /// <summary>
        /// runs the given action of the story component
        /// </summary>
        /// <param name="name">the action to run</param>
        /// <returns>did the action run successfully</returns>
        public bool RunAction(string name)
        {
            if (Actions.ContainsKey(name))
            {
                Actions[name]();
                return true;
            }
            return false;
        }
    }
}
