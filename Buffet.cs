using System;
using System.Collections.Generic;

namespace WosHungryNinja
{
    // List<string> bikes = new List<string>();

    class Buffet
    {
        // making a list of food called Menu
        public List<Food> Menu;

        public Buffet() // constructor 
        {
            Menu = new List<Food>();
            Menu.Add(new Food("rice", 100, false, true));
            Menu.Add(new Food("beans", 200, true, true));
            Menu.Add(new Food("chicken", 600, false, false));
            Menu.Add(new Food("steak", 700, true, false));

        }

        // serve food function
        public Food Serve()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0,4);
            System.Console.WriteLine(Menu[randomNumber].Name);
            System.Console.WriteLine(Menu[randomNumber].Calories);
            System.Console.WriteLine(Menu[randomNumber].IsSpicy);
            System.Console.WriteLine(Menu[randomNumber].IsSweet);
            return Menu[randomNumber];
        }

    }

}