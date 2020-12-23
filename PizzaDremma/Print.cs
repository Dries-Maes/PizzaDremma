using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDremma
{
    
    class Print
    {
  /*      
┌──────────────────────────────────┬─────────┬────────────────────────┬────────────────┐
│               Col1               │  Col2   │          Col3          │ Numeric Column │
├──────────────────────────────────┼─────────┼────────────────────────┼────────────────┤
│ Value 1                          │ Value 2 │ 123                    │           10.0 │
│ Separate                         │ cols    │ with a tab or 4 spaces │       -2,027.1 │
│ This is a row with only one cell │         │                        │                │
└──────────────────────────────────┴─────────┴────────────────────────┴────────────────┘
  */



        public static void PrintInventory(Dictionary<string, int> list)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("┌" + new string('─', 19) + "┬" + new string('─', 10) + "┬┬" + new string('─', 19) + "┬" + new string('─', 10) + "┬┬" + new string('─', 19) + "┬" + new string('─', 10) + "┐");
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{"  Ingrediënts".PadRight(17)}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("  │  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(("Stock ").PadRight(8));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("│");
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{"  Ingrediënts".PadRight(17)}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("  │  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(("Stock ").PadRight(8));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("│");
            Console.Write("│");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{"  Ingrediënts".PadRight(17)}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("  │  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(("Stock ").PadRight(8));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("│");
            Console.WriteLine("├" + new string('─', 19) + "┼" + new string('─', 10) + "┼┼" + new string('─', 19) + "┼" + new string('─', 10) + "┼┼" + new string('─', 19) + "┼" + new string('─', 10) + "┤");
            int loop = 0;
            int count = 0;
            foreach (KeyValuePair<string, Int32> ingredient in list)
            {
                count++;
                if (ingredient.Value == 0)
                {
                    if (loop < 2)
                    {
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"  {ingredient.Key.PadRight(17)}");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("│  ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write((" --- ").PadRight(8));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("│");
                        loop++;

                    }
                    else
                    {
                        if (count == list.Count)
                        {
                            Console.Write("│");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write($"  {ingredient.Key.PadRight(17)}");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("│  ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write((" --- ").PadRight(8));
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("│");
                            Console.WriteLine("└" + new string('─', 19) + "┴" + new string('─', 10) + "┴┴" + new string('─', 19) + "┴" + new string('─', 10) + "┴┴" + new string('─', 19) + "┴" + new string('─', 10) + "┘");
                            loop = 0;
                        }
                        else
                        {

                         Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"  {ingredient.Key.PadRight(17)}");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("│  ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write((" --- ").PadRight(8));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("│");
                        Console.WriteLine("├" + new string('─', 19) + "┼" + new string('─', 10) + "┼┼" + new string('─', 19) + "┼" + new string('─', 10) + "┼┼" + new string('─', 19) + "┼" + new string('─', 10)  + "┤");
                        loop = 0;
                        }
                    }





                }
                else
                {

                    if (loop < 2)
                    {
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"  {ingredient.Key.PadRight(17)}");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("│  ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write((ingredient.Value.ToString() + " left").PadRight(8));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("│");
                        loop++;

                    }
                    else
                    {
                        Console.Write("│");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"  {ingredient.Key.PadRight(17)}");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("│  ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write((ingredient.Value.ToString() + " left").PadRight(8));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("│");
                        Console.WriteLine("├" + new string('-', 94) +"┤");
                        loop = 0;
                    }
                }
            }
        }


    }
}
