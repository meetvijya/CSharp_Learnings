using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Builder pattern aims to “Separate the construction of a complex object from its representation 
 so that the same construction process can create different representations.”
 It is used to construct a complex object step by step and the final step will return the object.
 The process of constructing an object should be generic so that it can be used to create different representations of the same object.
 */

namespace BuilderPattern
{
    class Program
    {
        //Builder Demo
        static void Main(string[] args)
        {
            MealBuilder mbObj = new MealBuilder();
            Console.WriteLine("*** Veg Meal ***");
            mbObj.PrepareVegMeal().ShowItems();
            mbObj.PrepareVegMeal().getCost();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*** NonVeg Meal ***");
            mbObj.PrepareNonVegMeal().ShowItems();
            mbObj.PrepareNonVegMeal().getCost();

            Console.ReadKey();
        }
        interface IPacking
        {
            string pack();
        }

        interface Item
        {
             string name();
            double price();
            IPacking packing();
        }

         class wrapper : IPacking
        {
            public string pack()
            {
                return "Wrapper";
            }
        }

         class Bottle : IPacking
        {
            public string pack()
            {
                return "Bottle";
            }
        }


        abstract class Burger : Item
        {
            public IPacking packing()
            {
                return new wrapper();
            }

            public abstract string name();
            public abstract double price();
        }

        abstract class ColdDrinks:Item
        {
            public IPacking packing()
            { return new Bottle(); }

            public abstract string name();
            public abstract double price(); 
        }


        class VegBurger:Burger
        {
            public override string name()
            {
                return "Veg Burger";
            }

            public override double price()
            {
                return 50.00;
            }
        }

     class ChickenBurger : Burger
     {
            public override string name()
            {
                return "chicken Burger";
            }

            public override double price()
            {
                return 100.00;
            }
      }

    class Coke :ColdDrinks
        {
            public override string name()
            {
                return "Coke";
            }

            public override double price()
            {
                return 12.00;
            }
        }

        class Pepsi : ColdDrinks
        {
            public override string name()
            {
                return "Pepsi";
            }

            public override double price()
            {
                return 15.00;
            }
        }
     class Meal
        {
            List<Item> Items = new List<Item>();

            public void AddItem(Item itm )
            {
                Items.Add(itm);
            }

            public double getCost()
            {
                double cost = 0.0;

                foreach(Item itm in Items)
                {
                    cost = cost + itm.price();
                }
                return cost;
            }

            public void ShowItems()
            {
                foreach (Item itm in Items)
                {
                    Console.WriteLine("Item name is: " + itm.name());
                    Console.WriteLine("Item packing is: " + itm.packing().pack());
                    Console.WriteLine("Item price is: " + itm.price());
                }
            }
        }

     class MealBuilder
     {
            public Meal PrepareVegMeal()
            {
                Meal m = new Meal();
                m.AddItem(new VegBurger());
                m.AddItem(new Coke());
                return m;
            }
            public Meal PrepareNonVegMeal()
            {
                Meal m = new Meal();
                m.AddItem(new ChickenBurger());
                m.AddItem(new Pepsi());

                return m;
            }

        }
    }
}
