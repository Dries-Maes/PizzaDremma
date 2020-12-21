using System;

namespace PizzaDremma
{
    internal class ChoiceMenu
    {
        public bool PizzaChoice()
        {
            KeuzePizza pizzaMaker = new KeuzePizza();
            Console.Clear();
            Console.WriteLine("Choose a pizza:");
            Console.WriteLine("1) Veggie");
            Console.WriteLine("2) Margarita");
            Console.WriteLine("3) Pepperoni");
            Console.WriteLine("4) BBQ");
            Console.WriteLine("5) Surf 'N Turf");
            Console.WriteLine("6) Hawaii");
            Console.WriteLine("7) Meatballs Supreme");
            Console.WriteLine("8) QuattroFromaggi");
            Console.Write("\r\nSelect an option: ");

            switch (Convert.ToChar(Console.ReadLine()))
            {
                case '1':
                    pizzaMaker.PizzaVeggie();
                    return true;

                case '2':
                    pizzaMaker.PizzaMargarita();
                    return true;

                case '3':
                    pizzaMaker.PizzaPepperoni();
                    return true;

                case '4':
                    pizzaMaker.PizzaBBQ();
                    return true;

                case '5':
                    pizzaMaker.PizzaSurfNTurf();
                    return true;

                case '6':
                    pizzaMaker.PizzaHawaii();
                    return true;

                case '7':
                    pizzaMaker.PizzaMeatballsSupreme();
                    return true;

                case '8':
                    pizzaMaker.PizzaQuattroFromaggi();
                    return true;

                default:
                    return true;
            }
        }
    }
}