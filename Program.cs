using System;

namespace GB__2___EX._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число [0-255]");
            byte inputNumber = Convert.ToByte(Console.ReadLine());
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine($"Число {inputNumber} четное");
            }
            else
            {
                Console.WriteLine($"Число {inputNumber} нечетное");
            }

        }
    }
}





        


                

                

                


            
        
        

            
           
    

