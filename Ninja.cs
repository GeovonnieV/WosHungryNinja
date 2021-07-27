using System;
using System.Collections.Generic;

namespace WosHungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            FoodHistory = new List<Food>()
                {
                    new Food("rice", 399, false, false),
                    new Food("cake", 799, true, false),
                    new Food("ice cream", 499, false, false)

                };

            calorieIntake = 0;
          
        }


        // eat
        public void Eat()
        {
            System.Console.WriteLine($"eat is running starting calories is {calorieIntake} ");
            calorieIntake += 1200;
            System.Console.WriteLine($"now calories are {calorieIntake} and Ninja is full");
            Random rand = new Random();
            int randomNum = rand.Next(0,3);
            System.Console.WriteLine(FoodHistory[randomNum].Name);
            System.Console.WriteLine(FoodHistory[randomNum].IsSpicy);
            System.Console.WriteLine(FoodHistory[randomNum].IsSweet);
        


        }



        // getter to see if ninja is full
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    System.Console.WriteLine("Ninja is to full to eat");
                    return true;

                }
                else
                {
                    Eat();
                    return false;
                }
            }
        }


    }

}