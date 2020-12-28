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
        
        public static void AddToInventory()
        {
            string key;
            
            Console.Clear();
            Dictionary<string, int> currentInventoryDICT = Ingredient.ReadFromFile(Methods.FilePath("dictionary.bin"));
            Print.PrintInventory(currentInventoryDICT);

            Console.WriteLine("Enter 'Q' to return to the previous menu, any other key if you would like to add/remove items from your inventory.");
            key = Console.ReadLine().ToLower();
            if (key != "q")
            {

                do
                {
                    Console.Clear();


                    List<string> names = new List<string>();
                    List<int> amounts = new List<int>();
                    foreach (var item in currentInventoryDICT)
                    {

                        names.Add(item.Key);

                        amounts.Add(item.Value);
                    }

                    Print.PrintInventory(currentInventoryDICT);
                    Console.WriteLine("What ingredient would you like to change in the inventory?");
                    int toAdd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write '+/-' followed by the number you would like to add/remove.");
                    int amountAdd = Convert.ToInt32(Console.ReadLine());
                    currentInventoryDICT[names[toAdd - 1]] += amountAdd;
                    WriteToFile(currentInventoryDICT, Methods.FilePath("dictionary.bin"));
                    Console.Clear();
                    Console.WriteLine("Your updated inventory is:");
                    Print.PrintInventory(Ingredient.ReadFromFile(Methods.FilePath("dictionary.bin")));
                    Console.WriteLine("Enter Q to go back to the previous menu of any other key to add/remove another item.");

                    key = Console.ReadLine().ToLower();
                } while (key != "q");
            }

            Console.ResetColor();


        }
        public static void DeductFromInventory()
        { }
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
