using System;

namespace WosHungryNinja
    {

        class Food
            {
                public string Name;
                public int Calories;
                // food can be spicy or sweet
                public bool IsSpicy;
                public bool IsSweet;

                // constructor that takes in the above vars
                public Food(string Name, int Calories, bool IsSpicy, bool IsSweet)
                    {
                        this.Name = Name;
                        this.Calories = Calories;
                        this.IsSpicy = IsSpicy;
                        this.IsSweet = IsSweet;
                    }


            }


    }