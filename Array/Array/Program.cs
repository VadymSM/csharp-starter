using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {        
        static void Main(string[] args)
        {
            Exercises exercises = new Exercises();
            //exercises.RunExercise2();
            //exercises.RunExercise3();
            //exercises.RunExercise4();
            int[] number = new int[10];
            Console.WriteLine(exercises.RunExercise5(number));
            //Console.WriteLine(exercises.RunExersice6(5));
            //Console.WriteLine(exercises.RunExersice7(5));

            Console.ReadKey();

        }
    }
}
