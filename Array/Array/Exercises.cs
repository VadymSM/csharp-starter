using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Exercises
    {
        public void RunExercise1()
        {
            int[] array = CreateArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Here is your array: " + array[i]);
            }

            Console.ReadKey();
        }

        public void RunExercise2()
        {
            int[] array = CreateArray();
            int indexToInput = inputIndexToInsert();
            int valueToInput = inputValueToInsert();
           
            array = insertIntoArray(array, valueToInput, indexToInput);
            printArray(array);
        }

        private void printArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Here is your array: " + array[i]);
            }
            Console.ReadKey();
        }

        protected int inputIndexToInsert()
        {
            Console.WriteLine("Enter index of array: ");
            int indexOfArray = int.Parse(Console.ReadLine());
            return indexOfArray;
        }

        protected int inputValueToInsert()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        protected int[] insertIntoArray(int[] array, int value, int index)
        {
            int[] targetArray = new int[array.Length + 1];
            copyArrayHead(array, targetArray, index);
            setValueAtIndex(targetArray, value, index);
            copyArrayTail(array, targetArray, index);
            return targetArray;
        }

        private void copyArrayTail(int[] sourceArray, int[] targetArray, int index)
        {
            for (int i = index; i < sourceArray.Length; i++)
            {
                targetArray[i+1] = sourceArray[i];
            }
        }

        protected void copyArrayHead(int[] sourceArray, int[] targetArray, int endIndex)
        {
            
            for (int i = 0; i < endIndex; i++)
            {
                targetArray[i] = sourceArray[i];
            }
        }

        protected void setValueAtIndex(int[] array, int value, int index)
        {
            array[index] = value;
        }

        
        private int[] CreateArray()
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            Int32[] array = new Int32[size];

            bool isFilled = false;

            bool[] array2 = new bool[size];

            while (!isFilled)
            {

                int number = inputValueToInsert();
                int indexOfArray = inputIndexToInsert();

                array[indexOfArray] = number;
                array2[indexOfArray] = true;
                isFilled = true;

                for (int i = 0; i < array2.Length; i++)
                {
                    if (array2[i] == false)
                    {
                        isFilled = false;
                        break;
                    }
                }
            }

            return array;
        } 
    }
}
