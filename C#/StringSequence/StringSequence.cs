//We are given a matrix of strings of size N x M. Sequences in the matrix we define
//as sets of several neighbor elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StringSequence
    {
        static void Main()
        {
            string[,] arr =new string[,]{
                                 {"vod","qwe","qwe","haha"},
                                 {"jaja","haha","haha","fafa"},
                                 {"ra","haha","haha","qwe"}};
            string safe = "";
            byte maxSequence = byte.MinValue; 
            Rows(arr,out maxSequence,out safe);
            Cols(arr, ref maxSequence, ref safe);
            DiagonalLeft(arr, ref maxSequence, ref safe);
            DiagonalRight(arr, ref maxSequence, ref safe);
            Print(maxSequence, safe);
        }
        static void Rows(string[,] matrix,out byte maxSeq,out string safe)
        {
            byte counter = 1;
            maxSeq = byte.MinValue;
            safe = "";
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1)-1; cols++)
                {
                    if (matrix[rows,cols]==matrix[rows,cols+1])
                    {
                        counter++;
                    }
                    if (counter>maxSeq)
                    {
                        maxSeq = counter;
                        safe = matrix[rows, cols];
                    }
                }
                counter = 1;
            }
        }
        static void Cols(string[,] matrix, ref byte maxSeq, ref string safe)
        {
            byte counter = 1;
            for (int cols = 0; cols < matrix.GetLength(0); cols++)
            {
                for (int rows = 0; rows < matrix.GetLength(1) - 1; rows++)
                {
                    if (matrix[rows, cols] == matrix[rows, cols + 1])
                    {
                        counter++;
                    }
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        safe = matrix[cols, rows];
                    }
                }
                counter = 1;
            }
        }
        static void DiagonalRight(string[,] matrix, ref byte maxSeq, ref string safe)
        {
            byte counter = 1;
            int row = matrix.GetLength(0) - 2;
            int col = 0;
            int tempRow = row;
            int tempCol = 0;
            for (int diagonal = 0; diagonal < (matrix.GetLength(0) + matrix.GetLength(1) - 2); diagonal++)
            {

                row = tempRow;
                if (row < 0)
                {
                    row = 0;
                }
                if (col >= matrix.GetLength(1) - 1)
                {
                    tempCol++;
                    col = tempCol;

                }
                else
                {
                    col = 0;
                }
                while (row <= matrix.GetLength(0) - 2 && col <= matrix.GetLength(1) - 2)
                {


                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        safe = matrix[row, col];
                    }
                    row++;
                    col++;
                }

                tempRow--;

                counter = 1;
            }
        }
    
        static void DiagonalLeft(string[,] matrix, ref byte maxSeq, ref string safe)
        {
            byte counter = 1;
            int col = 1;
            int row = 0;
            int tempCol = col;
            int tempRow = 0;
            for (int diagonal = 0; diagonal < (matrix.GetLength(0) + matrix.GetLength(1) - 3); diagonal++)
            {
                col = tempCol;
                if (col > matrix.GetLength(1) - 1)
                {
                    col = matrix.GetLength(1) - 1;
                    tempRow++;
                    row = tempRow;
                }
                else
                {
                    row = 0;
                }
                while (row < matrix.GetLength(0) - 1 && col > 0)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        safe = matrix[row, col];
                    }
                    row++;
                    col--;
                }
                tempCol++;
                counter = 1;
            }
        }
        static void Print(byte times, string word)
        {
            Console.WriteLine("string {0} is found {1} times in the array",word,times );
        }
    }

