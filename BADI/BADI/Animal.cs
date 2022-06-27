using System;
using System.Collections.Generic;
using System.Text;

namespace BADI
{
    internal abstract class Animal : Food
    {
        public enum WaterType {
            Tap,
            DechlorinatedTap,
            Spring,
            RO, //Reverse Osmosis
            Distilled,
            Salt,
            None
        }

        //SCHEMA: My vision here is to have general feeding notes and then implement individual Diet<FoodItem> notes in 
        //******* the FoodItem class. These notes would be general, like "separate from others before feeding",
        //******* "only feed a small amount, recommended {FoodItem.portion} per meal", etc.
        //******* Note to flesh out these properties more and naturally they will change
        internal String Species { get; set; }
        internal String Name { get; set; }
        internal short Temperature { get; set; }
        internal String AirCirculationNotes { get; set; }
        internal String SleepActivity { get; set; } //Nocturnal/Diurnal

        //SCHEMA: Derived classes implement additional notes. 
        internal String Notes { get; set; } //General notes, perhaps an unneeded property
        internal String EnclosureNotes { get; set; }
        internal String EnclosureSize { get; set; }
        internal String FeedingNotes { get; set; } 
        internal String FeedingSchedule { get; set; }
        internal String Light { get; set; }

        //TODO: Heating elements, should that be implemented here. Ways it differs from Temperature for fish.


        //TODO: Eventually implement a FoodItems derived from Animal class, as food and the care for live food varies
        //****  and is actually very in-depth as a hobby in its own right.
        //public IList<String> Diet { get; set; }
        internal IList<Food> Diet = new List<Food>();

        //Methods

    }
}
