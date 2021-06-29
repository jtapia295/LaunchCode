using System;

namespace RestaurantMenu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MenuItem item1 = new MenuItem();
            item1.Category = "Appetizer";
            item1.Price = 4.99;
            item1.Description = "Fried Calamari";

            MenuItem item2 = new MenuItem();
            item2.Category = "Appetizer";
            item2.Price = 2.99;
            item2.Description = "Buttered Buns";

            MenuItem item3 = new MenuItem();
            item3.Category = "Appetizer";
            item3.Price = 6.99;
            item3.Description = "Mozzarella Sticks";

            Menu sandyBistro = new Menu();

            sandyBistro.AddAppetizer(item1);
            sandyBistro.AddAppetizer(item2);
            sandyBistro.AddAppetizer(item3);
            sandyBistro.AppetizerMenu();




           

        }
    }
}
