using System;

namespace GB__2___EX._2
{
    class Program
    {


        static void Main(string[] args)
        {
            int summOfNumbers;

            Console.WriteLine("Введите числа разделенные пробелом:");
            string s = Console.ReadLine();
            summOfNumbers = Summ(s);
            Console.WriteLine($"Сумма введенных чисел: {summOfNumbers.ToString()}");
        }

        static int Summ(string stringOfNumbers)
        {
            char symbolOfSplit = ' ';
            int summ = 0;
            string[] words = stringOfNumbers.Split(symbolOfSplit);
            foreach (string s in words)
            {
                summ = summ + Convert.ToInt32(s);
            }
            return summ;
        }




    }
}





        


                

                

                


            
        
        

            
           
    

