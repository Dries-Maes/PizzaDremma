using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace PizzaDremma
{
    class Methods
    {
        
        double budget = 20.0;
        double total = 10.0;
        ChoiceMenu choice = new ChoiceMenu();
        KeuzePizza pizzaMaker = new KeuzePizza();

        public void Smile()
        {
            ConsoleHelper.SetCurrentFont("Consolas", 10);
            Console.WriteLine(" ►  Dit item is geselecteerd.\n    Dit item niet. ");
        
    }
        
        public void CreatePizza()
        {
            throw new NotImplementedException();
        }
        public void PizzaPrint()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string pizzaArt = @"
                    ████████                    
                  ██░░░░░░░░██                  
                ██░░░░░░░░██▒▒██                
              ██░░░░░░░░██░░▒▒░░██              
              ██░░░░░░██▒▒▒▒░░▒▒██              
            ██░░░░░░░░██▒▒▒▒▒▒▒▒▒▒██            
            ██░░░░░░░░██▒▒░░▒▒▒▒▒▒██            
          ██░░░░░░░░░░░░██▒▒▒▒░░██░░██          
          ██░░░░░░░░░░░░░░██████░░░░██          
        ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██        
        ██░░░░░░  ██░░░░░░  ██░░░░░░░░██        
      ██░░██░░░░████░░░░░░████░░░░░░░░░░██      
      ██▒▒▒▒██░░░░░░░░░░░░░░░░░░░░░░░░░░██      
    ██▒▒▒▒░░██░░░░░░████░░░░░░██████░░░░░░██    
  ████░░▒▒▒▒██░░░░░░░░░░░░░░██░░▒▒▒▒██░░░░████  
██▒▒░░██▒▒██░░░░░░░░░░░░░░░░██▒▒░░▒▒░░████░░▒▒██
██▒▒░░░░████░░░░░░░░░░░░░░░░██▒▒░░▒▒████░░░░▒▒██
██▒▒░░░░░░░░██████████████████████████░░░░░░▒▒██
██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒██
  ██▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒██  
    ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████    
        ████████████████████████████████  ";
            //ConsoleHelper.SetCurrentFont(pizzaArt, 2);
            Console.WriteLine(pizzaArt);
        
        }
        public void PrintBanner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string banner = @"
 ██▓███   ██▓▒███████▒▒███████▒ ▄▄▄         ▓█████▄  ██▀███  ▓█████  ███▄ ▄███▓ ███▄ ▄███▓ ▄▄▄      
▓██░  ██▒▓██▒▒ ▒ ▒ ▄▀░▒ ▒ ▒ ▄▀░▒████▄       ▒██▀ ██▌▓██ ▒ ██▒▓█   ▀ ▓██▒▀█▀ ██▒▓██▒▀█▀ ██▒▒████▄    
▓██░ ██▓▒▒██▒░ ▒ ▄▀▒░ ░ ▒ ▄▀▒░ ▒██  ▀█▄     ░██   █▌▓██ ░▄█ ▒▒███   ▓██    ▓██░▓██    ▓██░▒██  ▀█▄  
▒██▄█▓▒ ▒░██░  ▄▀▒   ░  ▄▀▒   ░░██▄▄▄▄██    ░▓█▄   ▌▒██▀▀█▄  ▒▓█  ▄ ▒██    ▒██ ▒██    ▒██ ░██▄▄▄▄██ 
▒██▒ ░  ░░██░▒███████▒▒███████▒ ▓█   ▓██▒   ░▒████▓ ░██▓ ▒██▒░▒████▒▒██▒   ░██▒▒██▒   ░██▒ ▓█   ▓██▒
▒▓▒░ ░  ░░▓  ░▒▒ ▓░▒░▒░▒▒ ▓░▒░▒ ▒▒   ▓▒█░    ▒▒▓  ▒ ░ ▒▓ ░▒▓░░░ ▒░ ░░ ▒░   ░  ░░ ▒░   ░  ░ ▒▒   ▓▒█░
░▒ ░      ▒ ░░░▒ ▒ ░ ▒░░▒ ▒ ░ ▒  ▒   ▒▒ ░    ░ ▒  ▒   ░▒ ░ ▒░ ░ ░  ░░  ░      ░░  ░      ░  ▒   ▒▒ ░
░░        ▒ ░░ ░ ░ ░ ░░ ░ ░ ░ ░  ░   ▒       ░ ░  ░   ░░   ░    ░   ░      ░   ░      ░     ░   ▒   
          ░    ░ ░      ░ ░          ░  ░      ░       ░        ░  ░       ░          ░         ░  ░
 ____                   
/    \			
  u  u|      _______    
    \ |  .-''#%&#&%#``-.   
   = /  ((%&#&#&%&VK&%&))  
    |    `-._#%&##&%_.-'   
 /\/\`--.   `-.'''.-'
 |  |    \   /`./          
 |\/|  \  `-'  /
 || |   \     /         
            ";
            Console.WriteLine(banner);
        }
        
       /* public void ReviewOrder()
        {
            Console.WriteLine("Your order: ");
            foreach (var item in keuze.Cart)
            {
                Console.WriteLine($"\b{item.ID}: {item.Name} - {item.Price}\nCrust:{item.Crust} Size:{item.Size}\nCheese:{item.Cheesies[0]}, {item.Cheesies[1]}, {item.Cheesies[2]}, {item.Cheesies[3]}\nMeat: {item.Meaties[0]}, {item.Meaties[1]}, {item.Meaties[2]}, {item.Meaties[3]}\nVeggies: {item.Veggies[0]}, {item.Veggies[1]}, {item.Veggies[2]}, {item.Veggies[3]}");
                Console.ReadLine();
            }
            //lukt het? :-) run maar hoor ik laat het weten nog lleeg nu komt hij er niet in, misschien readline nodig


            Console.WriteLine("Select the item number that you want to remove:");
            int remove = Convert.ToInt32(Console.ReadLine());
           
            keuze.Cart.Remove(keuze.Cart[remove]);

        }
        */
        public void Payment()
        {
            if(budget >= total)
            {
                budget += budget - total;
                Console.Beep(5000, 500); Console.Beep(5000, 500); Thread.Sleep(250);
                Console.WriteLine("Tranaction passed! Enjoy your fresh hot pizza!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You're too poor for this pizza, try somewhere else!");
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
            Console.WriteLine("5) Exit");
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
                    keuze.ReviewOrder2();//weg? ja, maar VS heeft moeite met bijbenen
                    return true;
                case '4':
                    PlayTetris();
                    Payment();
                    return true;
                case '5':

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
