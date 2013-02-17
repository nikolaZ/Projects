//Write a program to convert from any numeral system of given base s 
//to any other numeral system of base d (2 ≤ s, d ≤  16).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BaseToBase
{
    static void Main()
    {
        Menu();
    }
    static char ToChar(int i)
    {
        if (i > 9)
        {
            return (char)(i + 55);
        }
        else
        {
            return (char)(i + '0');
        }
    }
    static int SetNumber(string number, int i)
    {
        if (number[i] >= 'A')
        {
            return number[i] - 55;
        }
        else
        {
            return number[i] - '0';
        }
    }
    static string DecToX(int decNumber, int baseOfSystem)
    {
        string number = string.Empty;
        for (; decNumber!=0;decNumber /= baseOfSystem)
        {
            number = ToChar(decNumber % baseOfSystem)+number;
        }
        return number;
    }
    static int XtoDec(string number, int baseOfSystem)
    {
        int sum = 0;
        int power = 1;
        for (int i = number.Length - 1; i >= 0; i--, power *= baseOfSystem)
        {
            sum += SetNumber(number, i) * power;
        }
        return sum;
    }
    static string BaseSToBaseD(string number, int s, int d)
    {
        return DecToX(XtoDec(number, s), d);
    }
    static void Menu()
    {
        Console.Write("Enter number:");
        string number = Console.ReadLine();
        number=number.ToUpper();
        Console.Write("Number is in system:");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Number will be converted to system:");
        int d = int.Parse(Console.ReadLine());
        string result = string.Empty;
        result = BaseSToBaseD(number, s, d);
        Console.WriteLine(result);
    }

}

