using System;

namespace StarBuzz
{
    abstract class Beverage
    {
        public String Description = "Unknown Beverage";

        public String GetDesription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
