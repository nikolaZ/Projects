//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NFactoriel
    {
        static void Main()
        {
            int[] factoriel = new int[] { 0 };
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter n to calculate n!:");
                factoriel[i] = int.Parse(Console.ReadLine());
            } 
            int y = factoriel[0];
            for (int i = 1; i < y; i++)
            {
                factoriel = Multiply(factoriel, i);
            }
                Print(ReverseInput(factoriel));
            
            
        }
        //Using task 8 from the same homework - Methods:
        static int[] Add(int[] a, int[] b)
        {
            List<int> result = new List<int>(b.Length + 1);
            int sum = 0;
            int convey = 0;
            int loop = 0;
            if (a.Length > b.Length)
            {
                return Add(b, a);
            }
            for (; loop < a.Length; loop++)
            {
                sum = a[loop] + b[loop] + convey;
                convey = sum / 10;
                sum %= 10;
                result.Add(sum);
            }
            for (; loop < b.Length; loop++)
            {
                sum = b[loop] + convey;
                convey = sum / 10;
                sum %= 10;
                result.Add(sum);
            }
            if (convey > 0)
            {
                result.Add(convey);
            }
            return result.ToArray();
        }
        static void Print(int[] result)
        {
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static int[] ReverseInput(int[] c)
        {
            int[] reversed = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                reversed[c.Length - i - 1] = c[i];
            }
            return reversed;
        }
        //Using addition for multiplication:
        static int[] Multiply(int[] factoriel, int y)
        {
            int[] result =new int[]{0};

            for (int i = 0; i < y; i++)
            {
                result = Add(result, factoriel);
            }

            return result;
        }


    }

