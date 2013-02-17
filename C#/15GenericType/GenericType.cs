//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.
//* Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class GenericType
    {
        static void Main()
        {
            Print(Max(6, 4.55m, 323333333333333.56m, 2, 1));
            Print(Min(6, 4, 3, 2, 1.66));
            Print(Average(6, 4.55, 323, 2, 1));
            Print(Sum(6, 4, 3, 2, 1, 3));
            Print(Product(6, 4.55, 32333, 2, 1));
        }
        static T Max<T>(params T[] sequence)
        {
            Console.Write("Max:");
            dynamic max = sequence[0];
            dynamic length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                if (sequence[i] > max)
                {
                    max = sequence[i];
                }
            }
            return max;
        }
        static T Min<T>(params T[] sequence)
        {
            Console.Write("Min:");
            dynamic min = int.MaxValue;
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                if (sequence[i] < min)
                {
                    min = sequence[i];
                }
            }
            return min;
        }
        static decimal Average<T>(params T[] sequence)
        {
            Console.Write("Avg:");
            dynamic average = 0;
            dynamic length = sequence.GetLength(0);
            average = Convert.ToDecimal(Sum(sequence)) / length;
            return average;
        }
        static T Sum<T>(params T[] sequence)
        {
            Console.Write("Sum:");
            dynamic sum = 0;
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                sum += sequence[i];
            }
            return sum;
        }
        static T Product<T>(params T[] sequence)
        {
            Console.Write("Product:");
            dynamic product = 1;
            int length = sequence.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                product*= sequence[i];
            }
            return product;
        }
        static void Print(object printer)
        {
            Console.WriteLine("{0:F}",printer);
        }

    }


    

