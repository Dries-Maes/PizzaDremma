using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDremma
{
    class Inventory
    {
        public object[] CheesiesStock { get; set; }
        public object[] MeatiesStock { get; set; }
        public object[] VeggiesStock { get; set; }
        public static string Name { get; set; }
        public static int Quantity { get; set; }
        

        private static List<Ingredient> Stock = new List<Ingredient>();
        Ingredient ingredient = new Ingredient(Name, Quantity);
        private void CreateUsedStock()
        {
             //Ingredient usedstock =  new Ingredient();
        }
        private void StockIngredients()
        {
             
            
            // print alle stock.txt items met aantallen
            LogWriter.StockLog($"{Convert.ToString(ingredient.name)}, {Convert.ToString(ingredient.quantity)}");
            Console.ReadLine();
        }

        private void BuyMoreIngredients()
        {
        //Voeg items toe aan stock
        }

        private void CheckStock()
        {
        // tel alle ingredienten uit Cart en kijk of deze passen in Stock
        }
        private void UpdateStock()
        {
        // trek alle ingredienten uit Cart af van Stock
        }
    }
}
