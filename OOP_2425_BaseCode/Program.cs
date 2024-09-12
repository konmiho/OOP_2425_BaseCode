using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2425_BaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[0];
            Random rnd = new Random();

            DisplayArray(list);

            //for (int x = 0; x < 100; x++)
            //{
            //    list = AddToArray(list, 1);
            //    DisplayArray(list);
            //}
            list = AddToArray(list, 1);
            list = AddToArray(list, 2);
            list = AddToArray(list, 3);
            list = AddToArray(list, 4);
            list = AddToArray(list, 5);
            list = AddToArray(list, 6);
            list = AddToArray(list, 7);
            DisplayArray(list);
            Console.WriteLine(contains(list,5));
            Console.WriteLine(find(list, 5));
            DisplayArray(removeAt(list, 5));
            DisplayArray(remove(list, 5));

            Console.ReadKey();
        }

        /// <summary>
        /// This should be the only method used to display the array
        /// </summary>
        /// <param name="array"></param>
        static void DisplayArray(int[] array)
        {
            Console.WriteLine("The current length of the array is " + array.Length);
            Console.WriteLine("It contains the following values:");

            foreach (int i in array)
                Console.Write(i + "\t");

            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// This method a value into the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>returns the array with the added value</returns>
        static int[] AddToArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for (int x = 0; x < array.Length; x++)
                newArray[x] = array[x];

            newArray[array.Length] = value;

            return newArray;
        }

        static bool contains(int[] array, int value)
        {
            bool result = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    result = true;
                    break;
                }   
            }
            return result;
        }

        static int find(int[] array, int find)
        {
            int found = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == find)
                {
                    found = i;
                    break;
                }
            }
            return found;
        }

        static int[] removeAt(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                    newArray[i] = array[i];
                else if (i >= index)
                    newArray[i] = array[i+1];
            }
            return newArray;
        }

        static int[] remove(int[] array, int value)
        {
            return removeAt(array,find(array,value));
        }

    }
}
