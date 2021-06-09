using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet buffet1 = new Buffet();
            Ninja kris = new Ninja("Kris");
            while (!kris.isFull())
            {
            kris.Eat(buffet1.Serve());
            }
            Console.WriteLine("Too full!");
        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("Sushi", 1000, false, false),
            new Food("Pizza", 2000, false, false),
            new Food("Corn", 1500, false, true),
            new Food("Chicken", 6000, false, false),
            new Food("Pasta", 800, true, false),
            new Food("Pie", 2300, false, true),
            new Food("Burger", 3500, false, false)
        };
        }
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
    class Ninja
    {
        public int calorieIntake;
        public List<Food> FoodHistory;
        public string Name;

        // add a constructor
        public Ninja(string name)
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
            Name = name;
        }

        // add a public "getter" property called "IsFull"
        public bool isFull()
        {
            if(calorieIntake > 1200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Eat(Food item)
        {
            if (isFull())
            {
                Console.WriteLine("Can't Eat!");
            }
            else
            {
                this.calorieIntake += item.Calories;
                Console.WriteLine(item.Name);
                Console.WriteLine(calorieIntake);
                Console.WriteLine($"Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
            }
        }
    }
    }
