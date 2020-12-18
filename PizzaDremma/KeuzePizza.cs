using PizzaDremma.enums;
using System;
using System.Collections.Generic;

namespace PizzaDremma
{
     class KeuzePizza
    {
        public List<Pizza> Cart = new List<Pizza>();

        /* public string ObjectToString(object obj)
         {
             using (MemoryStream ms = new MemoryStream())
             {
                 new BinaryFormatter().Serialize(ms, obj);
                 return Convert.ToBase64String(ms.ToArray());
             }
         }

         public object StringToObject(string base64String)
         {
             byte[] bytes = Convert.FromBase64String(base64String);
             using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length))
             {
                 ms.Write(bytes, 0, bytes.Length);
                 ms.Position = 0;
                 return new BinaryFormatter().Deserialize(ms);
             }
         }
        */
        private Pizza pizza;

        public KeuzePizza()
        {
            pizza = new Pizza();
        }

        

        public void PizzaVeggie(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }

            pizza.Name = NameOptions.Veggie;
            pizza.Price = 10.00;
            pizza.Vegetarian = true;
            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Cheesies[1] = CheesiesOptions.Gorgonzola;
            pizza.Veggies[0] = VeggieOptions.Aubergines;
            pizza.Veggies[1] = VeggieOptions.Mushrooms;
            pizza.Veggies[2] = VeggieOptions.RedOnions;
            //to be added - add to shopping basket
            Console.WriteLine($"You selected a {pizza.Size} {pizza.Name} with a {pizza.Crust} crust.");

            Cart.Add(pizza);
            Console.WriteLine(Cart[0].Name);
            
            LogWriter.WriteLog($"{Convert.ToString(pizza.ID)}, {Convert.ToString(pizza.Name)}, {Convert.ToString(pizza.Price)}, {Convert.ToString(pizza.Vegetarian)}");
            Console.ReadLine();
        }

        public void PizzaMargarita(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }

            pizza.Name = NameOptions.Veggie;
            pizza.Price = 10.00;
            pizza.Vegetarian = true;

            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Cheesies[1] = CheesiesOptions.Gorgonzola;
            pizza.Veggies[0] = VeggieOptions.Aubergines;
            pizza.Veggies[1] = VeggieOptions.Mushrooms;
            pizza.Veggies[2] = VeggieOptions.RedOnions;
            //to be added - add to shopping basket
        }

        public void PizzaPepperoni(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }
            pizza.Name = NameOptions.Pepperoni;
            pizza.Price = 9.00;
            pizza.Vegetarian = false;
            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Veggies[0] = MeatiesOptions.SpicyPepperoni;
            //to be added - add to shopping basket
        }

        public void PizzaBBQ(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }

            pizza.Name = NameOptions.Veggie;
            pizza.Price = 10.00;
            pizza.Vegetarian = false;
            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Veggies[0] = VeggieOptions.Aubergines;
            pizza.Veggies[1] = VeggieOptions.Mushrooms;
            pizza.Veggies[2] = VeggieOptions.RedOnions;
            //to be added - add to shopping basket
        }

        public void PizzaSurfNTurf(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }

            pizza.Name = NameOptions.Veggie;
            pizza.Price = 10.00;
            pizza.Vegetarian = true;
            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Cheesies[1] = CheesiesOptions.Gorgonzola;
            pizza.Veggies[0] = VeggieOptions.Aubergines;
            pizza.Veggies[1] = VeggieOptions.Mushrooms;
            pizza.Veggies[2] = VeggieOptions.RedOnions;
            //to be added - add to shopping basket
        }

        public void PizzaHawaii(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }

            pizza.Name = NameOptions.Veggie;
            pizza.Price = 10.00;
            pizza.Vegetarian = true;
            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Cheesies[1] = CheesiesOptions.Gorgonzola;
            pizza.Veggies[0] = VeggieOptions.Aubergines;
            pizza.Veggies[1] = VeggieOptions.Mushrooms;
            pizza.Veggies[2] = VeggieOptions.RedOnions;
            //to be added - add to shopping basket
        }

        public void PizzaMeatballsSupreme(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }

            pizza.Name = NameOptions.Veggie;
            pizza.Price = 10.00;
            pizza.Vegetarian = true;
            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Cheesies[1] = CheesiesOptions.Gorgonzola;
            pizza.Veggies[0] = VeggieOptions.Aubergines;
            pizza.Veggies[1] = VeggieOptions.Mushrooms;
            pizza.Veggies[2] = VeggieOptions.RedOnions;
            //to be added - add to shopping basket
        }

        public void PizzaQuattroFromaggi(int size = 1, int crust = 4)
        {
            Console.WriteLine("Enter the size that you would like: \n1. Small\n2. Medium\n3. Large");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the crust that you would like: \n1. Pan\n2. Deep\n3. Cheese\n4. Classic");
            crust = Convert.ToInt32(Console.ReadLine());
            if (size == 1)
            {
                pizza.Size = SizeOptions.Small;
            }
            else if (size == 2)
            {
                pizza.Size = SizeOptions.Medium;
            }
            else
            {
                pizza.Size = SizeOptions.Large;
            }

            if (crust == 1)
            {
                pizza.Crust = CrustOptions.Pan;
            }
            else if (crust == 2)
            {
                pizza.Crust = CrustOptions.Deep;
            }
            else if (crust == 3)
            {
                pizza.Crust = CrustOptions.Cheese;
            }
            else
            {
                pizza.Crust = CrustOptions.Classic;
            }
            pizza.Name = NameOptions.QuattroFrommagi;
            pizza.Price = 10.00;
            pizza.Vegetarian = true;
            pizza.Cheesies[0] = CheesiesOptions.Mozarella;
            pizza.Cheesies[1] = CheesiesOptions.Gorgonzola;
            pizza.Cheesies[2] = CheesiesOptions.Parmezaan;
            pizza.Cheesies[3] = CheesiesOptions.Emmentaler;
            //to be added - add to shopping basket
        }
        public void ReviewOrder2()
        {
            Console.WriteLine("Your order: ");
            Console.WriteLine(Cart[0].Name);
            //foreach (var item in Cart)
            //{
            //    Console.WriteLine($"\b{item.ID}: {item.Name} - {item.Price}\nCrust:{item.Crust} Size:{item.Size}\nCheese:{item.Cheesies[0]}, {item.Cheesies[1]}, {item.Cheesies[2]}, {item.Cheesies[3]}\nMeat: {item.Meaties[0]}, {item.Meaties[1]}, {item.Meaties[2]}, {item.Meaties[3]}\nVeggies: {item.Veggies[0]}, {item.Veggies[1]}, {item.Veggies[2]}, {item.Veggies[3]}");
            //}
            Console.ReadLine();

        }
    }
}