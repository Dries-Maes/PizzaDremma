using System;
using System.Collections.Generic;
using System.Text;
using PizzaDremma.enums;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PizzaDremma
{
    [Serializable()]
    public class Pizza : ISerializable
    {
        public NameOptions Name { get; set; }
        public SizeOptions Size {get; set; }
        public CrustOptions Crust { get; set; }
        public double Price { get; set; }
        public object[] Cheesies { get; set; }
        public object[] Meaties { get; set; }
        public object[] Veggies { get; set; }
        public bool Vegetarian { get; set; }

        private static int UID = 1;
        public int ID { get; set; }

        public Pizza()
        {
            Cheesies = new object[4] { CheesiesOptions.NoCheese, CheesiesOptions.NoCheese, CheesiesOptions.NoCheese, CheesiesOptions.NoCheese };
            Meaties = new object[4] { MeatiesOptions.NoMeat, MeatiesOptions.NoMeat, MeatiesOptions.NoMeat, MeatiesOptions.NoMeat };
            Veggies = new object[4]  { VeggieOptions.NoVegetables, VeggieOptions.NoVegetables, VeggieOptions.NoVegetables, VeggieOptions.NoVegetables };
            Name = NameOptions.Unknown;
            Size = SizeOptions.Small;
            Crust = CrustOptions.Classic;
            Price = 8.0;
            ID = UID++;
            Vegetarian = false;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            
        }

    }
}
