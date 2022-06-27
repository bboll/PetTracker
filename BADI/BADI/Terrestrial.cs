using System;
using System.Collections.Generic;
using System.Text;

namespace BADI
{
    internal class Terrestrial : Animal
    {
        //For Terrestrial creatures, ex: salamanders, beardies, pythons, etc.
        //Thinking about whether or not to structure (and how to structure) Arboreal creatures like tree frogs
        private short Humidity { get; set; }

        //Does it need a soaking dish? What type of water? What type for drinking?
        private WaterType NeedsBath { get => NeedsBath; set => NeedsBath = WaterType.None; } 
        private WaterType DrinkingWater { get => DrinkingWater; set => DrinkingWater = WaterType.None; }

        //Some species such as some tortoises need to hibernate
        private int HibernationPeriod { get => HibernationPeriod; set => HibernationPeriod = 0; } //Default 0; unit of weeks otherwise

    }
}
