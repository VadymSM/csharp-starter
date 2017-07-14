using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    // Notes: 
    // rename mothods according to conventions: ThisIsMyMethod
    // rename method inputIndexToInsert to GetInputIndex
    // rename method inputValueToInsert to GetInputValue
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
            Console.WriteLine();
            Console.WriteLine("Enter the new index of array, please.");
            int indexToInput = GetInputIndex();
            int valueToInput = GetInputValue();
           
            array = InsertIntoArray(array, valueToInput, indexToInput);
            printArray(array);
        }

        public void RunExercise3()
        {
            int[] array = CreateArray();
            int indexToInput = GetInputIndex();
            array = DeleteElementFromArray(array, indexToInput);
            printArray(array);

        }

        public void RunExercise4()
        {
            int min = 0;
            int max = 100;

            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            Int32[] array = new Int32[size];

            Random randNum = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(min, max);
            }

            Console.WriteLine();

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("Here is your array: " + array[j]);
            }

            

            for(int k = 0; k < array.Length; k++)
            {
                if(array[k] % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(array[k]);
                }
            }

            
            Console.ReadKey();
        }

        private int[] DeleteElementFromArray(int[] array, int indexOfRemoved)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = array.Length - 1, j = newArray.Length - 1; i >= 0; i--)
            {
                if (i == indexOfRemoved)
                {
                    continue;
                }
                newArray[j--] = array[i];
            }
            return newArray;
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

        protected int GetInputIndex()
        {
            Console.WriteLine("Enter index of array: ");
            int indexOfArray = int.Parse(Console.ReadLine());
            return indexOfArray;
        }

        protected int GetInputValue()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        protected int[] InsertIntoArray(int[] sourceArray, int value, int index)
        {
            int[] targetArray = new int[sourceArray.Length + 1];
            //copyArrayHead(array, targetArray, index);
            //setValueAtIndex(targetArray, value, index);
            //copyArrayTail(array, targetArray, index);
            for(int i = 0, j = 0; i < targetArray.Length; j++, i++)
            {

                if(i == index)
                {
                    targetArray[i] = value;
                    j--;
                }
                else
                {
                    targetArray[i] = sourceArray[j];
                }
            }
            return targetArray;
        }
        /*
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
        */

        private int[] CreateArray()
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            Int32[] array = new Int32[size];

            bool isFilled = false;

            bool[] array2 = new bool[size];

            while (!isFilled)
            {

                int number = GetInputValue();
                int indexOfArray = GetInputIndex();

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
