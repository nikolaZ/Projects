//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//	0  "Zero"
//	273  "Two hundred seventy three"
//	400  "Four hundred"
//	501  "Five hundred and one"
//	711  "Seven hundred and eleven"
using System;
using System.Text;
class NumberText
{
    static void Main()
    {
        Console.Write("Enter a number in the interval [0...999]: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 999)
        {
            Console.WriteLine("Entered Number is not in the correct interval!");
        }
        else
        {


            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            //int units = ((number % 100) % (tens*10));
            //int realUnits = units % (tens*10);
            //Console.WriteLine(tens);
            //Console.WriteLine(units);
            //Console.WriteLine(realUnits);
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            if (hundreds > 0)
            {
                switch (hundreds)
                {
                    case 1: Console.Write("one hundred"); break;
                    case 2: Console.Write("two hundred"); break;
                    case 3: Console.Write("three hundred"); break;
                    case 4: Console.Write("four hundred"); break;
                    case 5: Console.Write("five hundred"); break;
                    case 6: Console.Write("six hundred"); break;
                    case 7: Console.Write("seven hundred"); break;
                    case 8: Console.Write("eight hundred"); break;
                    case 9: Console.Write("nine hundred"); break;
                }
                if (tens > 1)
                {
                    switch (tens)//defines tens
                    {
                        case 2: Console.Write(" twenty"); break;
                        case 3: Console.Write(" thirty"); break;
                        case 4: Console.Write(" fourty"); break;
                        case 5: Console.Write(" fifty"); break;
                        case 6: Console.Write(" sixty"); break;
                        case 7: Console.Write(" seventy"); break;
                        case 8: Console.Write(" eighty"); break;
                        case 9: Console.Write(" ninety"); break;
                    }
                    int units = ((number % 100) % (tens * 10));//defines units
                    switch (units)
                    {
                        case 1: Console.Write(" one"); break;
                        case 2: Console.Write(" two"); break;
                        case 3: Console.Write(" three"); break;
                        case 4: Console.Write(" four"); break;
                        case 5: Console.Write(" five"); break;
                        case 6: Console.Write(" six"); break;
                        case 7: Console.Write(" seven"); break;
                        case 8: Console.Write(" eight"); break;
                        case 9: Console.Write(" nine"); break;
                    }
                }
                if (tens == 0)
                {
                    int units = (number % 100);
                    switch (units)
                    {
                        case 1: Console.Write(" and one"); break;
                        case 2: Console.Write(" and two"); break;
                        case 3: Console.Write(" and three"); break;
                        case 4: Console.Write(" and four"); break;
                        case 5: Console.Write(" and five"); break;
                        case 6: Console.Write(" and six"); break;
                        case 7: Console.Write(" and seven"); break;
                        case 8: Console.Write(" and eight"); break;
                        case 9: Console.Write(" and nine"); break;
                    }
                }
                if (tens == 1)
                {
                    int units1 = (number % 100) % 10;
                    switch (units1)
                    {
                        case 1: Console.Write(" and eleven"); break;
                        case 2: Console.Write(" and twelve"); break;
                        case 3: Console.Write(" and thirteen"); break;
                        case 4: Console.Write(" and fourteen"); break;
                        case 5: Console.Write(" and fifteen"); break;
                        case 6: Console.Write(" and sixteen"); break;
                        case 7: Console.Write(" and seventeen"); break;
                        case 8: Console.Write(" and eighteen"); break;
                        case 9: Console.Write(" and nineteen"); break;
                    }
                }
            }
            else//example 051;(51);
            {
                if (tens > 1)//example:51
                {
                    switch (tens)//defines tens
                    {
                        case 2: Console.Write("twenty"); break;
                        case 3: Console.Write("thirty"); break;
                        case 4: Console.Write("fourty"); break;
                        case 5: Console.Write("fifty"); break;
                        case 6: Console.Write("sixty"); break;
                        case 7: Console.Write("seventy"); break;
                        case 8: Console.Write("eighty"); break;
                        case 9: Console.Write("ninety"); break;
                    }
                    int units = ((number % 100) % (tens * 10));//defines units
                    switch (units)
                    {
                        case 1: Console.Write(" one"); break;
                        case 2: Console.Write(" two"); break;
                        case 3: Console.Write(" three"); break;
                        case 4: Console.Write(" four"); break;
                        case 5: Console.Write(" five"); break;
                        case 6: Console.Write(" six"); break;
                        case 7: Console.Write(" seven"); break;
                        case 8: Console.Write(" eight"); break;
                        case 9: Console.Write(" nine"); break;
                    }

                }
                else if (tens == 0)//example: 001;(1);
                {
                    int units3 = (number % 100);
                    switch (units3)
                    {
                        case 1: Console.Write("one"); break;
                        case 2: Console.Write("two"); break;
                        case 3: Console.Write("three"); break;
                        case 4: Console.Write("four"); break;
                        case 5: Console.Write("five"); break;
                        case 6: Console.Write("six"); break;
                        case 7: Console.Write("seven"); break;
                        case 8: Console.Write("eight"); break;
                        case 9: Console.Write("nine"); break;
                    }

                }
                if (tens == 1)//011;
                {
                    int units4 = (number % 100) % 10;
                    switch (units4)
                    {
                        case 1: Console.Write("eleven"); break;
                        case 2: Console.Write("twelve"); break;
                        case 3: Console.Write("thirteen"); break;
                        case 4: Console.Write("fourteen"); break;
                        case 5: Console.Write("fifteen"); break;
                        case 6: Console.Write("sixteen"); break;
                        case 7: Console.Write("seventeen"); break;
                        case 8: Console.Write("eighteen"); break;
                        case 9: Console.Write("nineteen"); break;
                    }

                }

            }
        }
        Console.WriteLine();
        Console.WriteLine("Good Bye!");
    }
}

