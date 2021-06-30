using System;
using System.Collections.Generic;
namespace RestaurantMenu
{
    public class Menu
    {
        readonly List<MenuItem> MenuItems = new List<MenuItem>();

        //Compares menu Items
        public bool CompareMenuItems(MenuItem item1, MenuItem item2)
        {
            bool result = item1.Equals(item2);
            return result;
        }

        //Displays specified item
        public void ShowMenuItem(MenuItem item)
        {
            if (MenuItems.Contains(item))
            {
                Console.WriteLine($"Selection {item.Description} was added to the menu {item.TimeAddedToMenu} and was last updated {item.LastUpdated}\nCurrent Price:${item.Price}");
            }
        }

        //Displays when the menu was last updated
        public DateTime CurrentMenuDate()
        {
            DateTime current = DateTime.Now;
            foreach(var item in MenuItems)
            {
                current = item.LastUpdated;
            }
            Console.WriteLine(current);
            return current;
            
        }

        //Add an item to the menu
        internal void AddMenuItem(MenuItem item)
        {
            item.TimeAddedToMenu = DateTime.Now;
            MenuItems.Add(item);
        }

        //Removes item from the menu
        internal void RemoveMenuItem(MenuItem item)
        {
            if (item.Category == "appetizer")
            {
                MenuItems.Remove(item);
            }
            else if (item.Category == "main")
            {
                MenuItems.Remove(item);
            }
            else if (item.Category == "dessert")
            {
                MenuItems.Remove(item);
            }
        }

        //Method to display the full menu 
        public void FullMenu()
        {
            bool appmenu = true;
            bool mainmenu = true;
            bool dessert = true; 
            foreach(var item in MenuItems)
            {
                if (item.Category == "appetizer")
                {
                    if(appmenu)
                    {
                        Console.WriteLine($"------------Appetizer Menu----------------\nLast Updated: {CurrentMenuDate()}");
                    }
                    if (item.TimeAddedToMenu > DateTime.Today.AddDays(-7))
                    {
                        Console.WriteLine($"${item.Price} : {item.Description} \"New Menu Item\"");
                    }
                    else
                    {
                        Console.WriteLine(item.Description);
                    }
                    appmenu = false;
                }
                if (item.Category == "main")
                {
                    if (mainmenu)
                    {
                        Console.WriteLine($"------------Main Courses----------------\nLast Updated: {CurrentMenuDate()}");
                    }
                    if (item.TimeAddedToMenu > DateTime.Today.AddDays(-7))
                    {
                        Console.WriteLine($"${item.Price} : {item.Description} \"New Menu Item\"");
                    }
                    else
                    {
                        Console.WriteLine($"${item.Price} : {item.Description}");
                    }
                    mainmenu = false;
                }
                if (item.Category == "dessert")
                {
                    if (dessert)
                    {
                        Console.WriteLine($"------------Dessert Menu----------------\nLast Updated: {CurrentMenuDate()}");
                    }
                    if (item.TimeAddedToMenu < DateTime.Today.AddDays(-7))
                    {
                        Console.WriteLine($"${item.Price} : {item.Description} \"New Menu Item\"");
                    }
                    else
                    {
                        Console.WriteLine($"${item.Price} : {item.Description}");
                    }
                    dessert = false;
                }
            }

        }

        //Method to display Appetizers
        public void AppetizerMenu()
        {
            Console.WriteLine($"------------Appetizers----------------\nLast Updated: {CurrentMenuDate()}");
            foreach (var item in MenuItems)
            {
                if (item.Category == "appetizer")
                {
                    if (item.TimeAddedToMenu > DateTime.Today.AddDays(-7))
                    {
                        Console.WriteLine($"${item.Price} : {item.Description} \"New Menu Item\"");
                    }
                    else
                    {
                        Console.WriteLine(item.Description);
                    }
                }
            }
        }       

        //Method to display MainCourse
        public void MainCourseMenu()
        {
            Console.WriteLine($"------------Main Courses----------------\nLast Updated: {CurrentMenuDate()}");
            foreach (var item in MenuItems)
            {
                if (item.Category == "main")
                {
                    if (item.TimeAddedToMenu > DateTime.Today.AddDays(-7))
                    {
                        Console.WriteLine($"${item.Price} : {item.Description} \"New Menu Item\"");
                    }
                    else
                    {
                        Console.WriteLine($"${item.Price} : {item.Description}");
                    }
                }
            }
        }

        //Method to display Desserts
        public void DessertMenu()
        {
            Console.WriteLine($"------------Dessert----------------\nLast Updated: {CurrentMenuDate()}");
            foreach (var item in MenuItems)
            {
                if (item.Category == "dessert")
                {
                    if (item.TimeAddedToMenu < DateTime.Today.AddDays(-7))
                    {
                        Console.WriteLine($"${item.Price} : {item.Description} \"New Menu Item\"");
                    }
                    else
                    {
                        Console.WriteLine($"${item.Price} : {item.Description}");
                    }
                }
            }

        }

        public Menu()
        {
        }
    }
}
