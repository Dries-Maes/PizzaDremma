using System;
using System.Collections.Generic;
using System.Text;
using PizzaDremma.enums;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PizzaDremma
{
    
    public class Pizza 
    {
        public NameOptions Name { get; set; }
        public SizeOptions Size {get; set; }
        public CrustOptions Crust { get; set; }
        public double Price { get; set; }
        public object[] Cheesies { get; set; }
        public object[] Meaties { get; set; }
        public object[] Veggies { get; set; }
        public bool Vegetarian { get; set; }

        private int PID = 1;
        public int ID { get; set; }
      

        public Pizza(NameOptions test = NameOptions.unknown, double price = 0, bool veggie = false)
        {
            Cheesies = new object[4] { Cheese.NoCheese, Cheese.NoCheese, Cheese.NoCheese, Cheese.NoCheese };
            Meaties = new object[4] { Meat.NoMeat, Meat.NoMeat, Meat.NoMeat, Meat.NoMeat };
            Veggies = new object[4]  { Vegg.NoVegetables, Vegg.NoVegetables, Vegg.NoVegetables, Vegg.NoVegetables };
            Name = test;
            Price = price;
            Vegetarian = veggie;
            Size = SizeOptions.small;
            Crust = CrustOptions.classic;
            ID = PID++ ;
        }
        


    }
}
