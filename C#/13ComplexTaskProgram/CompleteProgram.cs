//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//		Create appropriate methods.
//		Provide a simple text-based menu for the user to choose which task to solve.
//		Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompleteProgram
{
    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine("Welcome! Please,choose what task You want to solve by entering its digit.");
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("1.Reverse the digits of a number.");
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("2.Calculate the average of a sequence of integers.");
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("3.Solve a linear equation of the type: a * x + b = 0.");
        Console.WriteLine(new string('-', 20));
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1": ReverseNumber(); Continue(); break;
            case "2": Average(); Continue(); break;
            case "3": Linear(); Continue(); break;
            default: Console.WriteLine("Invalid Choice"); Menu();
                break;
        }
    }
    static void ReverseNumber()
    {
        Console.Write("Enter number to be reversed:");
        bool parsing = false;
        string input = string.Empty;
        decimal number=0;
        while (parsing == false)
        {
            input = Console.ReadLine();
            parsing = decimal.TryParse(input, out number);

            if (input == string.Empty)
            {
                Console.WriteLine("Input can NOT be Empty String");
            }
            if (parsing == false)
            {
                Console.Write("Please, enter valid decimal :");
            }
        }
        string digits = number.ToString();
        char[] chars = new char[digits.Length];
        chars = digits.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);
        decimal result = decimal.Parse(reversed);
        Console.WriteLine(result);
    }
    static void Average()
    {
        int sum = 0;
        int counter = 0;
        int number;
        string stop = "r";
        string input = string.Empty;
        bool parsing;
        Console.WriteLine("Enter sequence of integers. When ready, please write \"r\":");
        while (input != stop) 
        {
            input = Console.ReadLine();
            if (input == string.Empty)
            {
                Console.WriteLine("Input can NOT be Empty String");
                Average();
            }
            else
            {
                parsing = int.TryParse(input, out number);
                if (parsing)
                {
                    sum += number;
                    counter++;
                }
            }
        }
        if (counter==0)
        {
            Average();
        }
        else
        {
            Console.WriteLine("Average Sum: {0}", sum / counter);
        }
        
    }
    static void Linear()
    {
        int x = 0;
        int a=1;
        int b=0;
        string input = string.Empty;
        bool parsingA=false;
        bool parsingB=false;
        Console.Write("Enter number for \"a\" (\"a\" must NOT be zero):");
        while (parsingA == false||a==0)
        {
            
            input = Console.ReadLine();
            parsingA = int.TryParse(input, out a);
            if (a==0)
            {
                Console.WriteLine("\"a\" can NOT be zero");
                Console.Write("Please, enter valid integer :");
            }
            else if (input == string.Empty)
            {
                Console.WriteLine("Input can NOT be Empty String");
            }
            else if (parsingA == false)
            {
                Console.Write("Please, enter valid integer :");
            }
        }
        Console.Write("Enter number for \"b\":");
        while (parsingB==false)
        {
            input = Console.ReadLine();
            parsingB = int.TryParse(input, out b);

            if (input == string.Empty)
            {
                Console.WriteLine("Input can NOT be Empty String");
            }
            if (parsingB == false)
            {
                Console.Write("Please, enter valid integer :");
            }
        }
        x = b * -1 / a;
        Console.WriteLine("X= {0}",x);         
    }
    private static void Continue()
    {
        Console.WriteLine();
        Console.WriteLine("Do you want to solve something else? (Y/N)");
        string cont = Console.ReadLine();
        switch (cont)
        {
            case "y": Menu(); break;
            case "Y":Menu(); break;
            case "N": Console.WriteLine("Thank you for using the program!");
                Console.WriteLine("Please, come back again!");break;
            case "n": Console.WriteLine("Thank you for using the program!");
                Console.WriteLine("Please, come back again!"); break;
            default: Console.WriteLine("Please, enter a correct answer!");
                Continue();
                break;
        }
    }
}
    
    

