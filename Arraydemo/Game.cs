using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a function that prints the array
 * Write a function that lets the user enter 5 values into an array
 * Write a function that prints the sum of the elements in an interger array
 * Write a function that prints the hightest integer in an array
 * Write a function that prints the lowest integer in an array
 * Write a function that prints the array in reverse order
 */
namespace Arraydemo
{
    internal class Game
    {
        public void Run()
        {   // Get value
            int[] ints = GetValues();
            // Print array
            PrintArray(ints);
            Console.ReadKey();
            Console.WriteLine();
            // Print array in reverse
            PrintReverse(ints);
            Console.ReadKey();
            Console.WriteLine();
            // Print Sum of array
            Console.WriteLine(PrintSum(ints));
            Console.WriteLine();
            // Print Biggest number
            Console.WriteLine(PrintHighest(ints));
            Console.WriteLine();
            // Print Smallest number
            Console.WriteLine(PrintLowest(ints));

        }
        int[] GetValues()
        {
            
            int[] array = new int[5];
            //Int32.Parse()
            Console.WriteLine("Input 5 Numbers");
            Console.WriteLine("");
            string playerinput = "";
            int numberfrominput = 0;
            int i = 0;
            while (i != array.Length)
            {
                playerinput = Console.ReadLine();
                
                if (Int32.TryParse(playerinput, out int num))
                {

                  numberfrominput = num;
    
                }
                array[i] = numberfrominput;
                i++;



            }
            return array;
        }
        int[] PrintArray(int[] array)
        {

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
            return array;
        }
        int PrintSum(int[] array)
        {
            int sum;

            sum = array[0] + array[1] + array[2] + array[3] + array[4];

            return sum;
        }
        int PrintHighest(int[] array)
        {
            int highest = array[0];
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] > highest)
                {
                    highest = array[i];
                }




            }
         



            return highest;
        }
        int PrintLowest(int[] array)
        {
        
            int lowest = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < lowest)
                {
                    lowest = array[i];
                }




            }
            return lowest;
        }
        int[] PrintReverse(int[] array)
        {
            int reverse = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[reverse]);
                reverse -= 1;

            }
            return array;
        }


        

    }
}
