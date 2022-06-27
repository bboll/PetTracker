using System;
using System.Collections.Generic;
using System.Text;

namespace BADI
{
    internal abstract class Animal : Food
    {
        //SCHEMA: My vision here is to have general feeding notes and then implement individual Diet<FoodItem> notes in 
        //******* the FoodItem class. These notes would be general, like "separate from others before feeding",
        //******* "only feed a small amount, recommended {FoodItem.portion} per meal", etc.
        public String Species { get; set; }
        public String Name { get; set; }
        public Int16 Temperature { get; set; }
        public String AirCirculationNotes { get; set; }
        public String Activity { get; set; } //Nocturnal/Diurnal?

        //SCHEMA: Derived classes implement additional notes. 
        public String Notes { get; set; }
        public String EnclosureNotes { get; set; }
        public String FeedingNotes { get; set; } 
        public String FeedingSchedule { get; set; }


        //TODO: Eventually implement a FoodItems derived from Animal class, as food and the care for live food varies
        //****  and is actually very in-depth as a hobby in its own right.
        //public IList<String> Diet { get; set; }
        internal IList<Food> Diet = new List<Food>();

        //Methods

    }
}
