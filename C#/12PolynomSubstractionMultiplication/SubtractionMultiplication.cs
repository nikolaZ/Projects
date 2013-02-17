//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5  5 0 1
//Extend the program to support also subtraction and multiplication of polynomials.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubtractionMultiplication
{
    static void Main()
    {
        int[] a = new int[] { 2,- 5};//{ 2, 0, 6 };
        int[] b = new int[] { 2, 5,6 }; //{ 2, 5, };
        Console.Write("Polynom A:               ");
        Print(ReverseInput(a));
        Console.Write("Polynom B:               ");
        Print(ReverseInput(b));
        Console.Write("Polynom A + B:           ");
        Print(Add(ReverseInput(a), ReverseInput(b)));
        Console.Write("Polynom A - B:           ");
        Print(Subtraction(ReverseInput(a), ReverseInput(b)));
        Console.Write("Polynom A * B:           ");
        Print(Multiplication(ReverseInput(a), ReverseInput(b)));
    }
    static int[] Add(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];
        int i = 0;
        if (a.Length > b.Length)
        {
            return Add(b, a);
        }
        for (; i < a.Length; i++)
        {
            result[i] = a[i] + b[i];
        }
        for (; i < b.Length; i++)
        {
            result[i] = b[i];
        }
        return result;
    }
    static int[] Subtraction(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];
        int i = 0;
        if (a.Length > b.Length)
        {
            for (; i < b.Length; i++)
            {
                result[i] = a[i] - b[i];
            }
            for (; i < a.Length; i++)
            {
                result[i] = a[i];
            }
            return result;
        }
        for (; i < a.Length; i++)
        {
            result[i] = a[i] - b[i];
        }
        for (; i < b.Length; i++)
        {
            result[i] = b[i]*-1;
        }
        return result;
    }
    static int[] Multiplication(int[] a, int[] b)
    {
        int[] result = new int[a.Length* b.Length];
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                result[i+j] += (a[i] * b[j]);
            }
        }
        return result;
    }
    static void Print(int[] polynom)
    {
        int notFirstX = 0;   
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            if (i != polynom.Length - 1 && polynom[i] != 0)
            {
                if (polynom[i] > 0 && notFirstX > 0)
                {
                    Console.Write("+");
                }
            }
            if (polynom[i] != 0 && i != 0)
            {
                Console.Write("{0}x^{1}", polynom[i], i);
                notFirstX++;
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynom[i]);
                notFirstX++;
            }
            
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
}

