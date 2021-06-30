using System;
namespace RestaurantMenu
{
    public class MenuItem
    {

        private string _description;
        public string Description { get { return _description; } set {LastUpdated = DateTime.Now; _description = value;} }

        private double _price;
        public double Price { get{ return _price;} set{LastUpdated = DateTime.Now; _price = value; } }

        private string _category;
        public string Category
        {
            get {return _category;}
            set
            {
                LastUpdated = DateTime.Now;
                var modifiedValue = value.ToLower();
                if (modifiedValue == "main" || modifiedValue == "main course" || modifiedValue == "maincourse")
                {
                    _category = "main";
                }
                else if(modifiedValue == "appetizer")
                {
                    _category = "appetizer";
                }
                else if (modifiedValue == "dessert")
                {
                    _category = "dessert";
                }
                else
                {
                    try
                    {
                        throw new ArgumentException("Please set a valid category \"Appetizer\",\"Main Course\",\"Dessert\"");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
   
        internal DateTime LastUpdated;
        internal DateTime TimeAddedToMenu;
        

        public MenuItem()
        {
        }

        public MenuItem(string category, string description, double price)
        {
            Category = category;
            Description = description;
            Price = price;
        }

        public MenuItem(string category, double price)
        {
            Price = price;
            Category = category;
        }
    }
}
