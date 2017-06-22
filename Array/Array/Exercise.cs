using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Exercise : IExercise
    {
        public void Execute()
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            Int32[] array = new Int32[size];

            bool isFilled = false;

            bool[] array2 = new bool[size];

            while (!isFilled)
            {
                Console.WriteLine("Enter number");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter index of array: ");
                int indexOfArray = int.Parse(Console.ReadLine());


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

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Here is your array: " + array[i]);
            }

            Console.ReadKey();
        }

        public string Description()
        {
            return "In this exercise we created array";
        }        
    }
}
