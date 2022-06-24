using System;
using System.Collections.Generic;
using System.Text;

namespace BADI
{
    abstract class Animal
    {
        //Terrestrial Fields: Nocturnal/Diurnal? Humidity?

        //Accessors
        public String Species { get; set; }
        public String Name { get; set; }
        public Int16 Temperature { get; set; }

        //TODO: Eventually implement a food/diet class, as food and the care for live food varies
        //****  and is actually very in-depth as a hobby in its own right.
        public IList<String> Diet { get; set; }

        //Methods

    }
}
