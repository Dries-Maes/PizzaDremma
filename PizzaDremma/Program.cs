using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;

namespace PizzaDremma
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methode = new Methods();
            Console.OutputEncoding = Encoding.UTF8;

            methode.PrintBanner();
            //PizzariaMenu();

            methode.PlayTetris();
            methode.Payment();

            LogWriter.WriteLog(Console.ReadLine());
            Console.ReadLine();
            
        }
    }
}
