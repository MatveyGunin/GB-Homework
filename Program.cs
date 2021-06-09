using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)

        {
            string NameOfStore;
            int a = 20, b = 35, c = 45, NameOfProduct, aa;

            Console.WriteLine("Введите название магазина");
            NameOfStore = Console.ReadLine();

            
            
            Console.WriteLine("Выберите товар, который хотите купить");
            Console.WriteLine("1. Тетрадь школьная 18 листов - " + a + "рублей");
            Console.WriteLine("2. Тетрадь школьная 24 листа - " + b + "рублей");
            Console.WriteLine("3. Тетрадь школьная 36 листов - " + c + "рублей");
            NameOfProduct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество покупаемого товара");
            aa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ООО " + NameOfStore);
            Console.WriteLine(DateTime.Now);



            if (NameOfProduct == 1) 
                {
                    
                    Console.WriteLine("Тетрадь школьная 18 листов - " + aa + " штук " + a * aa + " руб.");
               


                }
               if (NameOfProduct == 2)
            {
                   
                    Console.WriteLine("Тетрадь школьная 24 листа - " + aa + " штук " + b * aa + " руб.");

                }
                if (NameOfProduct == 3) 
                {
                   
                    Console.WriteLine("Тетрадь школьная 36 листов - " + aa + " штук " + c * aa + " руб.");

                }
            











            }








 }
    }



























    
   
            
            
           

        




























        

