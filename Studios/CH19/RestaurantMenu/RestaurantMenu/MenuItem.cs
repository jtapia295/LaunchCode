using System;
namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Category { get; set ; }

        public double Price { get; set; }

        public string Description { get; set; }

        internal DateTime LastUpdated;
        internal DateTime TimeStamp;
        

        public MenuItem()
        {
        }
    }
}
