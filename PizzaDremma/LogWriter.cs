using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PizzaDremma
{
    class LogWriter
    {
        public static void WriteLog(string strLog )
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;

            string logFilePath = $"C:/Users/{Environment.UserName}/source/repos/PizzaDremma/PizzaDremma/";
            logFilePath = logFilePath + "PizzaLog-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(strLog);
            log.Close();
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
    }
}
