using System;
using System.Collections.Generic;
namespace RestaurantMenu
{
    public class Menu
    {
        internal protected List<MenuItem> Appetizers = new List<MenuItem>();
        internal protected List<MenuItem> MainCourse = new List<MenuItem>();
        internal protected List<MenuItem> Dessert = new List<MenuItem>();

        internal void AddAppetizer(MenuItem item)
        {
            item.TimeStamp = DateTime.Now;
            Appetizers.Add(item); 
        }
        internal void AddMainCourse(MenuItem item)
        {
            item.TimeStamp = DateTime.Now;
            this.MainCourse.Add(item);
        }
        internal void AddDessert(MenuItem item)
        {
            item.TimeStamp = DateTime.Now;
            this.Dessert.Add(item);
        }

        internal void RemoveMenuItem(MenuItem item)
        {
            if(item.Description == "Appetizer")
            {
                Appetizers.Remove(item);
            }
            else if (item.Description == "Main Course")
            {
                MainCourse.Remove(item);
            }
            else if (item.Description == "Dessert")
            {
                Dessert.Remove(item);
            }
        }

        //Method to display the full menu 
        public void FullMenu()
        {
            Console.WriteLine("------------Appetizer Menu----------------");
            for (int i = 0; i < Appetizers.Count; i++)
            {
                Console.WriteLine(Appetizers[i].Description);
                if (i == Appetizers.Count - 1)
                {
                    Console.Write($"\n\"NEW ITEM: {Appetizers[i].Description}\"\n");
                }
            }
            Console.WriteLine("\n\n------------Main Course Menu----------------");
            for (int i = 0; i < MainCourse.Count; i++)
            {
                Console.WriteLine(MainCourse[i].Description);
                if (i == MainCourse.Count - 1)
                {
                    Console.Write($"\n\"NEW ITEM: {MainCourse[i].Description}\"\n");
                }
            }
            Console.WriteLine("\n\n------------Dessert Menu----------------");
            for (int i = 0; i < Dessert.Count; i++)
            {
                Console.WriteLine(Dessert[i].Description);
                if (i == Dessert.Count - 1)
                {
                    Console.Write($"\n\"NEW ITEM: {Dessert[i].Description}\"\n");
                }
            }
        }

        //Method to display Appetizers
        public void AppetizerMenu()
        {
            Console.WriteLine("------------Appetizer Menu----------------");
            for (int i = 0; i < Appetizers.Count; i++)
            {
                Console.WriteLine(Appetizers[i].Description);
                if (i == Appetizers.Count -1)
                {
                    Console.Write($"\n\"NEW ITEM: {Appetizers[i].Description}\"");
                }
            }
        }


        //Method to display MainCourse
        public void MainCourseMenu()
        {
            Console.WriteLine("\n\n------------Main Course Menu----------------");
            for (int i = 0; i < MainCourse.Count; i++)
            {
                Console.WriteLine(MainCourse[i].Description);
                if (i == MainCourse.Count - 1)
                {
                    Console.Write($"\n\"NEW ITEM: {MainCourse[i].Description}\"");
                }
            }
        }


        //Method to display Desserts
        public void DessertMenu()
        {
            Console.WriteLine("\n\n------------Dessert Menu----------------");
            for (int i = 0; i < Dessert.Count; i++)
            {
                Console.WriteLine(Dessert[i].Description);
                if (i == Dessert.Count - 1)
                {
                    Console.Write($"\n\"NEW ITEM: {Dessert[i].Description}\"");
                }
            }

        }



        public Menu()
        {
        }
    }
}
