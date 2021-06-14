using System;

namespace GB__2___EX._2
{
    class Program
    {
        static void Main(string[] args)

        {
            int[,] Array = new int[5, 5];

            for (int i = 0; i < Array.GetLength(0); i++)
            {
               
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.WriteLine($"{new string(' ', i)}{new string(' ' , j)}{Array[i, j]}");
                    
                }
                
            }



        }


                

                

                


            }
        
        }

            
           
    

