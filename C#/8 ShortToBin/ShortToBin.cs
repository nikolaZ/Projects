//Write a program that shows the binary representation of 
//given 16-bit signed integer number (the C# type short).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ShortToBin
    {
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());
            Convert(number);
        }
        static void Convert(short number)
        {
            if (number>=0)
            {
                Positive(number);
            }
            else
            {
                Negative(number);
            }
        }
        static void Negative(short number)
        {
            string result = string.Empty;
            int remainder = 0;
            int max = short.MaxValue+1;
            int positive = max + number;
            while (positive != 0)
            {
                remainder = positive % 2;
                result = remainder + result;
                positive /= 2;
            }
            for (int i = result.Length; i < 15; i++)
            {
                result = "0" + result;
            }
            result = "1" + result;
            Console.WriteLine(result);
        }
        static void Positive(short number)
        {
            string result = string.Empty;
            int remainder = 0;
            while (number != 0)
            {
                remainder = number % 2;
                result = remainder + result;
                number /= 2;
            }
            for (int i = result.Length; i < 16; i++)
            {
                result = "0" + result;
            }
            Console.WriteLine(result);
        }
    }
