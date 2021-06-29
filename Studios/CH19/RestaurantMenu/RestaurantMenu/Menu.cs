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
            Appetizers.Add(item);
        }
        internal void AddMainCourse(MenuItem item)
        {
            this.MainCourse.Add(item);
        }
        internal void AddDessert(MenuItem item)
        {
            this.Dessert.Add(item);
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
                    Console.Write($"\n\"NEW ITEM: {Appetizers[i].Description}\"");
                }
            }
            Console.WriteLine("\n\n------------Main Course Menu----------------");
            for (int i = 0; i < MainCourse.Count; i++)
            {
                Console.WriteLine(MainCourse[i].Description);
                if (i == MainCourse.Count - 1)
                {
                    Console.Write($"\n\"NEW ITEM: {MainCourse[i].Description}\"");
                }
            }
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
