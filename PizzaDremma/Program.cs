using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class EnumUtil
{
    public static IEnumerable<T> GetValues<T>()
    {
        return Enum.GetValues(typeof(T)).Cast<T>();
    }
}

namespace PizzaDremma
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Methods methode = new Methods();

            Console.OutputEncoding = Encoding.UTF8;

            methode.PrintBanner();
            Console.ReadLine();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = methode.PizzariaMenu();
            }
        }
    }
}