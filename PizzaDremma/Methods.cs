﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDremma
{
    class Methods
    {
        public void Smile()
        {
            ConsoleHelper.SetCurrentFont("Consolas", 10);
            Console.WriteLine(" ►  Dit item is geselecteerd.\n    Dit item niet. ");
        }
        public void LogPizza()
        {
            string pizza = "1, Funghi, 9.00, [Tomaat, Mozzarella, Salami, Champignons, Zure room]";
            string[] pizzaElements = pizza.Split(',');

            int id = Convert.ToInt32(pizzaElements[0]);
            string name = pizzaElements[1];
            double price = Convert.ToDouble(pizzaElements[2]);

            int index = pizza.IndexOf('[');

            string ingredients = pizza.Substring(index + 1);
            string[] ingredientsArray = ingredients.Split(',');
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
        public void Payment(int var1, int var2)
        {
            Console.Beep(var1, var2);
        }
        public void PlayTetris()
        {
            Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(250); Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(500); 
        }

    }
}