using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PizzaDremma
{

    class Ingredient
    {
        public Dictionary<string, int>  Inventory { get; set; }
        public int[] QuantityProp { get; set; }
        
        readonly string[] NameArray = new string[] { "Mozarella", "Gorgonzola", "Emmentaler", "Parmezaan", "Ricotta", "Feta", "VeganCheese", "Artichokes", "BlackOlives", "CherryTomatoes", "Garlic", "Basil", "GreenBellPeppers", "Jalapeños", "Mushrooms", "Oregano", "Pineapple", "RedOnions", "RedPeppers", "Spinach", "Aubergines", "Sun_driedTomatoes", "GreenOlives", "FriedOnions", "GrilledChicken", "ItalianMeatballs", "SpicyPepperoni", "Salami", "SmokedHam", "CrispyBacon", "Lardons", "SmokedSalmon", "Tuna" };


        Dictionary<string, int> Prop  = new Dictionary<string, int>();
        
        public Ingredient(Dictionary<string, int> lijst = null)
        {
            if (lijst == null)
            {
                Dictionary<string, int> Prop2 = new Dictionary<string, int>(); 
                Inventory = Prop2;
                foreach (var item in NameArray)
                {
                    Prop2.Add(item, 0);
                }
                
            }
            else { 

                Inventory = lijst;
            }
        }

       

        public static void PrintInventory(Dictionary<string, int> list)
        {
            Console.WriteLine("Inventory list:");
            foreach (KeyValuePair<string, Int32> ingredient in list)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                    ingredient.Key, ingredient.Value);
            }
        }
        public static void WriteToFile(Dictionary<string, int> dictionary, string file)
        {
            using (FileStream fs = File.OpenWrite(file))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                // Put count.
                writer.Write(dictionary.Count);
                // Write pairs.
                foreach (var pair in dictionary)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
            }
        }
        public static Dictionary<string, int> ReadFromFile(string file)
        {
            var result = new Dictionary<string, int>();
            using (FileStream fs = File.OpenRead(file))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                // Get count.
                int count = reader.ReadInt32();
                // Read in all pairs.
                for (int i = 0; i < count; i++)
                {
                    string key = reader.ReadString();
                    int value = reader.ReadInt32();
                    result[key] = value;
                }
                return result;
            }
        }
    }
}
