using PizzaDremma.enums;
using System;
using System.Collections.Generic;

namespace PizzaDremma
{
    public class KeuzePizza
    {
        private static List<Pizza> Cart = new List<Pizza>();

        public void PizzaEnd(Pizza pizza)
        {
            Console.Clear();
            Console.WriteLine($"You selected a {pizza.Size} {pizza.Name} pizza with a {pizza.Crust} crust.");
            Cart.Add(pizza);
            LogWriter.WriteLog($"{Convert.ToString(pizza.ID)}, {Convert.ToString(pizza.Name)}, {Convert.ToString(pizza.Price)}, {Convert.ToString(pizza.Vegetarian)}");
            Console.ReadLine();
        }

        public void CheeseAdd(Pizza pizza, Cheese option0 = Cheese.NoCheese, Cheese option1 = Cheese.NoCheese, Cheese option2 = Cheese.NoCheese, Cheese option3 = Cheese.NoCheese)
        {
            pizza.Cheesies[0] = option0;
            pizza.Cheesies[1] = option1;
            pizza.Cheesies[2] = option2;
            pizza.Cheesies[3] = option3;
        }

        public void MeatAdd(Pizza pizza, Meat option0 = Meat.NoMeat, Meat option1 = Meat.NoMeat, Meat option2 = Meat.NoMeat, Meat option3 = Meat.NoMeat)
        {
            pizza.Meaties[0] = option0;
            pizza.Meaties[1] = option1;
            pizza.Meaties[2] = option2;
            pizza.Meaties[3] = option3;
        }

        public void VeggAdd(Pizza pizza, Vegg option0 = Vegg.NoVegetables, Vegg option1 = Vegg.NoVegetables, Vegg option2 = Vegg.NoVegetables, Vegg option3 = Vegg.NoVegetables)
        {
            pizza.Veggies[0] = option0;
            pizza.Veggies[1] = option1;
            pizza.Veggies[2] = option2;
            pizza.Veggies[3] = option3;
        }

        public void PickSizeCrust(Pizza pizza)
        {
            Console.Clear();
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            pizza.Size = (SizeOptions)(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            pizza.Crust = (CrustOptions)Convert.ToInt32(Console.ReadLine());
        }

        public void PizzaVeggie()
        {
            Pizza pizza = new Pizza(NameOptions.veggie, 9.95, true);
            PickSizeCrust(pizza);
            CheeseAdd(pizza, Cheese.Mozarella, Cheese.Gorgonzola);
            VeggAdd(pizza, Vegg.Aubergines, Vegg.Mushrooms, Vegg.RedOnions);
            PizzaEnd(pizza);
        }

        public void PizzaMargarita()
        {
            Pizza pizza = new Pizza(NameOptions.margarita, 8.95, true);
            PickSizeCrust(pizza);
            PizzaEnd(pizza);
        }

        public void PizzaPepperoni()
        {
            Pizza pizza = new Pizza(NameOptions.pepperoni, 9.95, false);
            PickSizeCrust(pizza);
            CheeseAdd(pizza, Cheese.Mozarella);
            MeatAdd(pizza, Meat.SpicyPepperoni);
            PizzaEnd(pizza);
        }

        public void PizzaBBQ()
        {
            Pizza pizza = new Pizza(NameOptions.BBQ, 10.95, false);
            PickSizeCrust(pizza);
            CheeseAdd(pizza, Cheese.Ricotta);
            MeatAdd(pizza, Meat.CrispyBacon, Meat.GrilledChicken, Meat.ItalianMeatballs);
            PizzaEnd(pizza);
        }

        public void PizzaSurfNTurf()
        {
            Pizza pizza = new Pizza(NameOptions.SurfNTurf, 10.95, false);
            PickSizeCrust(pizza);
            CheeseAdd(pizza, Cheese.Mozarella);
            MeatAdd(pizza, Meat.SmokedHam, Meat.GrilledChicken, Meat.SmokedSalmon, Meat.Tuna);
            PizzaEnd(pizza);
        }

        public void PizzaHawaii()
        {
            Pizza pizza = new Pizza(NameOptions.hawaii, 9.95, false);
            PickSizeCrust(pizza);
            CheeseAdd(pizza, Cheese.Emmentaler);
            MeatAdd(pizza, Meat.SmokedHam);
            VeggAdd(pizza, Vegg.Pineapple);
            PizzaEnd(pizza);
        }

        public void PizzaMeatballsSupreme()
        {
            Pizza pizza = new Pizza(NameOptions.MeatballSupreme, 10.95, false);
            PickSizeCrust(pizza);
            CheeseAdd(pizza, Cheese.Emmentaler, Cheese.Ricotta);
            MeatAdd(pizza, Meat.ItalianMeatballs, Meat.CrispyBacon);
            VeggAdd(pizza, Vegg.Sun_driedTomatoes, Vegg.CherryTomatoes);
            PizzaEnd(pizza);
        }

        public void PizzaQuattroFromaggi()
        {
            Pizza pizza = new Pizza(NameOptions.QuattroFrommagi, 10.95, true);
            PickSizeCrust(pizza);
            CheeseAdd(pizza, Cheese.Emmentaler, Cheese.Mozarella, Cheese.Gorgonzola, Cheese.Parmezaan);
            PizzaEnd(pizza);
        }

        public void PizzaCustomMade()
        {
            Pizza pizza = new Pizza(NameOptions.custom, 11.95, false);
            PickSizeCrust(pizza);

            int ID = 0;
            int ID2 = 0;
            do{
                Console.Clear();
                Console.WriteLine($"Please select veggie option {ID + 1}/4:");
                foreach (var item in EnumUtil.GetValues<Vegg>())
                {
                    Console.WriteLine($"{ID2++}: {Convert.ToString(item)}");
                }
                pizza.Veggies[ID] = (Vegg)Convert.ToUInt32(Console.ReadLine());
                            ID++;
                ID2 = 0;
            } while (ID < 4);
            ID = 0;
            do
            {
                
                Console.Clear();
                Console.WriteLine($"Please select meat option {ID + 1}/4:");
                foreach (var item in EnumUtil.GetValues<Meat>())
                {
                    Console.WriteLine($"{ID2++}: {Convert.ToString(item)}");
                }
                pizza.Meaties[ID] = (Meat)Convert.ToUInt32(Console.ReadLine());
                ID++;
                ID2 = 0;
            } while (ID < 4);
            ID = 0;
            do
            {
               
                Console.Clear();
                Console.WriteLine($"Please select cheese option {ID + 1}/4:");
                foreach (var item in EnumUtil.GetValues<Cheese>())
                {
                    Console.WriteLine($"{ID2++}: {Convert.ToString(item)}");
                }
                pizza.Cheesies[ID] = (Cheese)Convert.ToUInt32(Console.ReadLine());
                ID++;
                ID2 = 0;
            } while (ID < 4);
            PizzaEnd(pizza);
            
        }

        public void ReviewOrder2()
        {
            Console.Clear();
            Console.WriteLine("Your order: ");
                        foreach (var item in Cart)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"--------------------------------------------");
                Console.ResetColor();
                Console.WriteLine($"\b{item.ID}: Pizza {item.Name}: {item.Price} euro\nCrust: {item.Crust} Size: {item.Size}\nCheese: {item.Cheesies[0]}, {item.Cheesies[1]}, {item.Cheesies[2]}, {item.Cheesies[3]}\nMeat: {item.Meaties[0]}, {item.Meaties[1]}, {item.Meaties[2]}, {item.Meaties[3]}\nVeggies: {item.Veggies[0]}, {item.Veggies[1]}, {item.Veggies[2]}, {item.Veggies[3]}");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"--------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press 'D' to delete an item, any other key to return to the previous page:");
           
            if (Console.ReadKey().Key == ConsoleKey.D)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your order: ");
                foreach (var item in Cart)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"--------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine($"\b{item.ID}: Pizza {item.Name}: {item.Price} euro\nCrust: {item.Crust} Size: {item.Size}\nCheese: {item.Cheesies[0]}, {item.Cheesies[1]}, {item.Cheesies[2]}, {item.Cheesies[3]}\nMeat: {item.Meaties[0]}, {item.Meaties[1]}, {item.Meaties[2]}, {item.Meaties[3]}\nVeggies: {item.Veggies[0]}, {item.Veggies[1]}, {item.Veggies[2]}, {item.Veggies[3]}");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"--------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter the item number that you want to remove:");
                Cart.RemoveAt(Convert.ToInt32(Console.ReadLine())-1);
                Console.Clear();
                Console.WriteLine($"The item has been removed:");
                foreach (var item in Cart)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"--------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine($"\b{item.ID}: Pizza {item.Name}: {item.Price} euro\nCrust: {item.Crust} Size: {item.Size}\nCheese: {item.Cheesies[0]}, {item.Cheesies[1]}, {item.Cheesies[2]}, {item.Cheesies[3]}\nMeat: {item.Meaties[0]}, {item.Meaties[1]}, {item.Meaties[2]}, {item.Meaties[3]}\nVeggies: {item.Veggies[0]}, {item.Veggies[1]}, {item.Veggies[2]}, {item.Veggies[3]}");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"--------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadLine();
            }
           
           

        }
    }
}