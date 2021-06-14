using System;

namespace GB__2___EX._2
{
    class Program
    {
        static void Main(string[] args)

        {

            var contacts = new string[5, 2]
           {
               {"Artem", "artem11@yandex.ru"},
                {"Nina", "+7 515 243 89 01"},
                {"Alexey", "Alex.ey@gmail.com"},
                {"Maria", " + 8 921 78 88" },
                {"Peter", "+6 611 999 76 63"},
           };

            for (var i = 0; i < contacts.GetLength(0); i++)
            {
                for (var j = 0; j < contacts.GetLength(1); j++)
                    Console.Write(contacts[i, j] + " ");
                Console.WriteLine();
            }
        }





        }


                

                

                


            }
        
        

            
           
    

