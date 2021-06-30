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

            MenuItem item4 = new MenuItem(category: "Dessert", price: 2.99, description: "Chocolate Fountain Cake");
            MenuItem item5 = new MenuItem(category: "Dessert", price: 1.99, description: "Cheesecake");

           
            Menu sandyBistro = new Menu();

            sandyBistro.AddMenuItem(item1);
            sandyBistro.AddMenuItem(item2);
            sandyBistro.AddMenuItem(item3);
            sandyBistro.AddMenuItem(item4);
            sandyBistro.AddMenuItem(item5);
            Console.WriteLine();
            sandyBistro.FullMenu();
            Console.WriteLine("\n");
            sandyBistro.RemoveMenuItem(item3);
            sandyBistro.FullMenu();
            Console.WriteLine("\n");
            sandyBistro.ShowMenuItem(item5);

            Console.WriteLine(sandyBistro.CompareMenuItems(item1, item1)); 
        }
    }
}
