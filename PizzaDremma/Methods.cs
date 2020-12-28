using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace PizzaDremma
{
    class Methods
    {
        
        double budget =0;
        double total = 0;
        ChoiceMenu choice = new ChoiceMenu();
        KeuzePizza pizzaMaker = new KeuzePizza();
        private Random budgetCard = new Random();
        public void Smile()
        {
            ConsoleHelper.SetCurrentFont("Consolas", 10);
            Console.WriteLine(" ►  Dit item is geselecteerd.\n    Dit item niet. ");
        
    }

        public static string FilePath(string addition = "")
        { string path = $"C:/Users/{Environment.UserName}/source/repos/PizzaDremma/PizzaDremma/";
            path += addition;
            return path;
        }
        public void CreatePizza()
        {
            throw new NotImplementedException();
        }

        public void PrintBanner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
 ██▓███   ██▓▒███████▒▒███████▒ ▄▄▄         ▓█████▄  ██▀███  ▓█████  ███▄ ▄███▓ ███▄ ▄███▓ ▄▄▄      
▓██░  ██▒▓██▒▒ ▒ ▒ ▄▀░▒ ▒ ▒ ▄▀░▒████▄       ▒██▀ ██▌▓██ ▒ ██▒▓█   ▀ ▓██▒▀█▀ ██▒▓██▒▀█▀ ██▒▒████▄    
▓██░ ██▓▒▒██▒░ ▒ ▄▀▒░ ░ ▒ ▄▀▒░ ▒██  ▀█▄     ░██   █▌▓██ ░▄█ ▒▒███   ▓██    ▓██░▓██    ▓██░▒██  ▀█▄  
▒██▄█▓▒ ▒░██░  ▄▀▒   ░  ▄▀▒   ░░██▄▄▄▄██    ░▓█▄   ▌▒██▀▀█▄  ▒▓█  ▄ ▒██    ▒██ ▒██    ▒██ ░██▄▄▄▄██ 
▒██▒ ░  ░░██░▒███████▒▒███████▒ ▓█   ▓██▒   ░▒████▓ ░██▓ ▒██▒░▒████▒▒██▒   ░██▒▒██▒   ░██▒ ▓█   ▓██▒
▒▓▒░ ░  ░░▓  ░▒▒ ▓░▒░▒░▒▒ ▓░▒░▒ ▒▒   ▓▒█░    ▒▒▓  ▒ ░ ▒▓ ░▒▓░░░ ▒░ ░░ ▒░   ░  ░░ ▒░   ░  ░ ▒▒   ▓▒█░
░▒ ░      ▒ ░░░▒ ▒ ░ ▒░░▒ ▒ ░ ▒  ▒   ▒▒ ░    ░ ▒  ▒   ░▒ ░ ▒░ ░ ░  ░░  ░      ░░  ░      ░  ▒   ▒▒ ░
░░        ▒ ░░ ░ ░ ░ ░░ ░ ░ ░ ░  ░   ▒       ░ ░  ░   ░░   ░    ░   ░      ░   ░      ░     ░   ▒   
          ░    ░ ░      ░ ░          ░  ░      ░       ░        ░  ░       ░          ░         ░  ░
"); 

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 ____                                                                                          ____   
/    \			                                                                      /    \	
  u  u|      _______                                                           _______       |u  u 
    \ |  .-''#%&#&%#``-.                                                   .-``#%&#&%#''-.   | /  
   = /  ((%&#&#&%&VK&%&))                                                ((%&#&#&%&VK&%&))    \ =   
    |    `-._#%&##&%_.-'                                                   '-._%&##&%#_.-`     |  
 /\/\`--.   `-.'''.-'                                                         '-.'''.-`    .--`/\/\ 
 |  |    \   /`./                                                                 \.`\   /     |  | 
 |\/|  \  `-'  /                                                                   \  '-`  /   |/\| 
 || |   \     /                                                                     \     /    | || 
            

");
           
        }
        
       /* public void ReviewOrder()
        {
            Console.WriteLine("Your order: ");
            foreach (var item in keuze.Cart)
            {
                Console.WriteLine($"\b{item.ID}: {item.Name} - {item.Price}\nCrust:{item.Crust} Size:{item.Size}\nCheese:{item.Cheesies[0]}, {item.Cheesies[1]}, {item.Cheesies[2]}, {item.Cheesies[3]}\nMeat: {item.Meaties[0]}, {item.Meaties[1]}, {item.Meaties[2]}, {item.Meaties[3]}\nVeggies: {item.Veggies[0]}, {item.Veggies[1]}, {item.Veggies[2]}, {item.Veggies[3]}");
                Console.ReadLine();
            }


            Console.WriteLine("Select the item number that you want to remove:");
            int remove = Convert.ToInt32(Console.ReadLine());
           
            keuze.Cart.Remove(keuze.Cart[remove]);

        }
        */
        public void Payment()
        {
           
            total = pizzaMaker.PizzaTotal();
            Console.WriteLine($"The total for you order is: \nExcl. 21% BTW: €{Math.Round(pizzaMaker.PizzaNoBTW(), 2)}\n21% BTW: €{Math.Round(pizzaMaker.PizzaBTW(), 2)}\nIncl. 21% BTW: €{pizzaMaker.PizzaTotal()}\n\nHow would you like to pay?\n1: cash \n2: card");
            string paymentChoice = Console.ReadLine();

            switch (paymentChoice)
            {
                case "1":
                    Console.WriteLine("Enter the amount you're paying with.");
                    budget = Convert.ToDouble(Console.ReadLine());
                    if (budget >= total)
                    {
                        budget = budget - total;
                        Console.WriteLine($"Your change is €{Math.Round(budget,2)}! Enjoy your fresh hot pizza!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You're too poor for this pizza, try somewhere else!");
                    }
                    break;
                case "2":
                    //budget = budgetCard.Next(10,200);
                    int test = budgetCard.Next(0,5);
                    if (test != 4)
                    {
                        budget = budget - total;
                        Console.Beep(5000, 500); Console.Beep(5000, 500); Thread.Sleep(250);
                        Console.WriteLine("Transaction passed! Enjoy your fresh hot pizza!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You're too poor for this pizza, try somewhere else!");
                        Console.ReadLine();
                    }
                    break;
                default:
                    break;
            }
            
            
        }
        

        public bool PizzariaMenu()
        {

            KeuzePizza keuze = new KeuzePizza();
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Choose a pizza");//standaard pizza's
            Console.WriteLine("2) Make your own pizza");//build a pizza from scratch
            Console.WriteLine("3) Review your order");//what did I order
            Console.WriteLine("4) Pay your order");//pay if I can
            Console.WriteLine("5) Show/update Inventory");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Convert.ToChar(Console.ReadLine()))
            {
                case '1':
                    //PizzaVeggie();
                                       
                     choice.PizzaChoice();
                    
                    return true;
                case '2':
                    pizzaMaker.PizzaCustomMade();
                    return true;
                case '3':
                    keuze.ReviewOrder2();
                    return true;
                case '4':
                    //PlayTetris();
                    Payment();
                    return true;
                case '5':
                    Ingredient.AddToInventory();
                    return true;
                case '6':
                    
                    return false;
               
                default:
                    return true;
            }
        }
        public void PlayTetris()
        {
            Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(250); Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(500); 
        }

    }
}
