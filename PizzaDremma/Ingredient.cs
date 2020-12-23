using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDremma
{
    class Ingredient
    {
        public string name { get; set; }
        public int quantity { get; set; }
        //  mozarella,Gorgonzola
        //  5, 7


        //      lijn1 van stock.txt -> array (string[] name)
        //      lijn2 van stock.txt -> array (double[] quantity)
        //       Ingredient currentStock = new Ingredient(name[], quantity[]);
        //      Ingredient usedstock = new Ingredient();
        //     currentstock.name > lijn1 van stock.txt
        //     currentstock.quantity - usedstock.quantity > lijn2 van stock.txt

        public static string[] nametest = {"Mozarella","Gorgonzola","Emmentaler","Parmezaan","Ricotta","Feta","VeganCheese","Artichokes","BlackOlives","CherryTomatoes","Garlic","Basil","GreenBellPeppers","Jalapeños","Mushrooms","Oregano","Pineapple","RedOnions","RedPeppers","Spinach","Aubergines","Sun_driedTomatoes","GreenOlives","FriedOnions","GrilledChicken","ItalianMeatballs","SpicyPepperoni","Salami","SmokedHam","CrispyBacon","Lardons","SmokedSalmon","Tuna"};
        
        string namelist =  "test";
        int[] quantitytest = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0 };
        string test = nametest[0];
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        public Ingredient(string name = "default", int quantity = 0)//constructor
        {
             string[] nametest = new string[]{"Mozarella","Gorgonzola","Emmentaler","Parmezaan","Ricotta","Feta","VeganCheese","Artichokes","BlackOlives","CherryTomatoes","Garlic","Basil","GreenBellPeppers","Jalapeños","Mushrooms","Oregano","Pineapple","RedOnions","RedPeppers","Spinach","Aubergines","Sun_driedTomatoes","GreenOlives","FriedOnions","GrilledChicken","ItalianMeatballs","SpicyPepperoni","Salami","SmokedHam","CrispyBacon","Lardons","SmokedSalmon","Tuna"};
            int[] quantitytest = new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0 };
            //name = Convert.ToString(nametest[12]);
            //Console.WriteLine(name);
            //Console.ReadLine();
        }

        public void PrintIngredient()
        {
            name = Convert.ToString(nametest[12]);
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
