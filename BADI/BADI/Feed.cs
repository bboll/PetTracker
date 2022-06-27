using System;
using System.Collections.Generic;
using System.Text;

namespace BADI
{
    internal class Feed : Food
    {
        //SCHEMA: Feed is a class for non-living feed such as pellets/plants, obviously wouldn't derive 
        //******  from Animal class as it does not eat or share much of the same requirements.
        //******  That being said, things like Humidity, Temperature might still be implemented separately
        //******  here as useful attributes in regards to storage. Also, shelf-life, maybe estimated cost, etc.

    }
}
