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
        {
            int[] ints = GetValues();
            PrintArray(ints);
            Console.ReadKey();
            Console.WriteLine();
            PrintReverse(ints);
            Console.ReadKey();
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);

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
            return 0;
        }
        int[] PrintHighest(int[] array)
        {

            return null;
        }
        int[] PrintLowest(int[] array)
        {
            return null;
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
