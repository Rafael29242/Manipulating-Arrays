using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //Write a Method that accepts an array of ints as a parameter,
            //and returns the sum of all of the values in that array.
            //The return type should be an int.

            int SumA = 0;
            int SumB = 0;
            int SumC = 0;

            Array.ForEach(ArrayA, i => SumA += i);
            Array.ForEach(ArrayB, i => SumB += i);
            Array.ForEach(ArrayC, i => SumC += i);

            
            Console.WriteLine($"Array A is: {PrintArray(ArrayA)}\n\nArray B is: {PrintArray(ArrayB)}\n\nArray C is: {PrintArray(ArrayC)}\n\n"); //Array A,B,C Printed

            Console.WriteLine($"Sum of Array A is: {SumA}\n\nSum of Array B is: {SumB}\n\nSum of Array C is: {SumC}\n\n");          //Sum of Array A,B,C

            Console.WriteLine($"Average of Array A : {Average(ArrayA)}. \n\nAverage of Array B : {Average(ArrayB)}. \n\nAverage of Array C : {Average(ArrayC)}.\n\n");  //Average of Array A,B,C

            Console.WriteLine($"Array A reversed : {PrintArray(Reverse(ArrayA))}.\n\nArray B reversed : {PrintArray(Reverse(ArrayB))}.\n\nArray C reversed : {PrintArray(Reverse(ArrayC))}.\n\n"); //Array A,B,C Reversed order

            //Write a Method that takes an array of ints as a parameter, and returns the largest value in that array. The return type should be an int.
            Console.WriteLine($"Largest Value of Array A: {ArrayA.Max()} \n\nLargest Value of Array B: {ArrayB.Max()} \n\nLargest Value of Array C: {ArrayC.Max()} \n\n");

            Console.WriteLine($"Array A rotated two places to the left: {Rotate("left", 2, ArrayA)}.\n\nArray B rotated two places to the left: {Rotate("left", 2, ArrayB)}.\n\nArray C rotated two places to the left: {Rotate("left", 2, ArrayC)}.\n\n"); //Array A,B,C Rotated

            Console.WriteLine($"Array A sorted from least to greatest: {PrintArray(Sort(ArrayA))}.\n\nArray B sorted from least to greatest: {PrintArray(Sort(ArrayB))}.\n\nArray C sorted from least to greatest: {PrintArray(Sort(ArrayC))}.\n\n"); //Array A,B,C Sorted

        }

        public static string PrintArray(int[] array)
        {
            string PrintResult = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    PrintResult += $"{array[i]},";
                }

                else
                {
                    PrintResult += $"{array[i]}";
                }
            }

            return PrintResult;
        }

        //Write a Method that takes an array of ints as a parameter,
        //and returns the average of all of the values in that array.
        //The return type should be a double.

        public static double Average(int[] array)
        {
            int sum = 0;
            double average = 0.0;

            for (int i = 0; i < array.Length; i++) sum += array[i];

            average = (double)sum / (double)array.Length;
            return average;
        }

        //Write a Method that accepts an array of ints as a parameter,
        //and prints out the values in that array in reverse order.
        //The return type should be void.

        public static int[] Reverse(int [] array)
        {
            int[] reverse = new int[array.Length];
            int count = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse[count] = array[i];
                count++;
            }
            return reverse;
        }

        //Write a Method that accepts two parameters,
        //an array, and the number of places to rotate that array to the left.
        //This Method will print out the rotated array.
        //This Method will return void.

        public static string Rotate(string direction, int number, int[] array)
        {
            int[] result = new int[array.Length];
            int arrayBack = result.Length - number;
            int arrayFront = 0;
            int arrayNum = number;

            if(direction == "left")
            {
                for(int i = 0; i < number; i++)
                {
                    result[arrayBack] = array[i];
                    arrayBack++;
                }

                for(int i = number; i < array.Length; i++)
                {
                    result[arrayFront] = array[i];
                    arrayFront++;
                }

                return PrintArray(result);
            }

            else if(direction == "right")
            {
                for(int i = array.Length - number; i < array.Length; i++)
                {
                    result[arrayFront] = array[i];
                    arrayFront++;
                }

                for(int i = 0; i < array.Length - number; i++)
                {
                    result[arrayNum] = array[i];
                    arrayNum++;
                }
                return PrintArray(result);
            }

            else
            {
                return "Please rotate array's direction to \"left\" or \"right\".";
            }
        }

        //Write a Method that takes an unsorted array of ints as it's one parameter,
        //and prints out all of the numbers in that array in sorted order.

        public static int[] Sort(int[] array)
        {
            int count;
            do
            {
                count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        count += 1;
                    }
                }
            }

            while (count > 0);

            return array;
        }



    }
}
