using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> inputtedShoes = new List<int>();

            Console.WriteLine("Please enter your 20 shoe's sizes.");

            //Input the shoe sizes.
            for(int i = 0; i < 5; i++)
            {
                do
                {
                    try
                    {
                        inputtedShoes.Add(int.Parse(Console.ReadLine()));
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Incorrect value.");
                    }
                }
                while (true);
            }

            //Process the shoe sizes.

            //Finding the highest shoe size.
            int highestShoeSize = 0;

            for(int i = 0; i < inputtedShoes.Count(); i++)
            {
                if(inputtedShoes[i] > highestShoeSize)
                {
                    highestShoeSize = inputtedShoes[i];
                }
            }

            //Creating an area that can certainly fit the required shoes.
            int[] processedShoes = new int[highestShoeSize + 1];

            //Console.WriteLine("this shit " + processedShoes.GetLength(0));
            //Console.WriteLine("this shit " + processedShoes[processedShoes.GetLength(0) - 1]);

            //Sorting the shoes.
            for (int i = 0; i < inputtedShoes.Count(); i++)
            {

                processedShoes[inputtedShoes[i]]++;

            }

            //Printing sorted shoe sizes.
            for(int i = 0; i < processedShoes.GetLength(0); i++)
            {
                Console.WriteLine("Shoe size " + i + ": " + processedShoes[i]);
            }
            Console.ReadLine();
        }
    }
}
