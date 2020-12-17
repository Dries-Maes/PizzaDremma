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
        Toppings keuze = new Toppings();
        
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
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Choose a pizza");
            Console.WriteLine("2) Make your own pizza");
            Console.WriteLine("3) Pay your order");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Convert.ToChar(Console.ReadLine()))
            {
                case '1':
                    keuze.PizzaChoice();
                    return true;
                case '2':
                    CreatePizza();
                    return true;
                case '3':
                    PlayTetris();
                    Payment();
                    return true;
                case '4':
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
