using Pastel;
using System;
using System.Drawing;

namespace Arrays_2D
{
    internal class Arrays_2D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a program for displaying arrays.\nWhat should be the dimensions of your array?");
            Console.WriteLine("Please enter the number of rows.");
            int rows = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the number of columns.");
            int columns = Convert.ToInt16(Console.ReadLine());
            //array initialized after user input with no values
            string[,] array2D = new string[rows, columns];
            //setting up variables for putting grid in the array
            int gridColumns = columns * 4 + 1; // because of grid upper and lower boundaries +---+
            string gridLines = "+";
            //RGB variable for color:
            int rgb = 255;
            //constants for array content selection
            const char NUMBERS_CHOSEN = '1';
            const char SYMBOLS_CHOSEN = '2';
            const char INDICES_CHOSEN = '3';
            for (int i = 1; i < gridColumns; i++)
            {
                if (i % 4 == 0)
                {
                    gridLines += "+";
                }
                else
                {
                    gridLines += "-";
                }
            }

            Console.WriteLine("Do you prefer the contents of the array should be numbers, alternating symbols or indices?\nPress 1 for numbers. 2 for symbols. 3 for showing indices as content.");
            Console.WriteLine("You chose:");
            char arraysContentSelection = Console.ReadKey().KeyChar;

            int runningValueIncrement = 0;
            //numbers selected as content for 2D Array
            if (arraysContentSelection == NUMBERS_CHOSEN)
            {
                //filling of 2D Array with values
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array2D[i, j] = Convert.ToString(++runningValueIncrement);
                    }
                }
            }
            //symbols selected as content for 2D array
            if (arraysContentSelection == SYMBOLS_CHOSEN)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            array2D[i, j] = "X".Pastel(Color.White).PastelBg("000000");
                        }
                        else
                        {
                            array2D[i, j] = "O".Pastel(Color.Black).PastelBg("FFFFFF");
                        }
                    }
                }
            }
            //indices selected as content for 2D array
            if (arraysContentSelection == INDICES_CHOSEN)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array2D[i, j] = $"{i},{j}";
                    }
                }
            }
            Console.WriteLine("\nDo you want to have a grid for your array or not? Press y or n.");
            string gridSelection = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine("\nYour array is:");
            if (gridSelection == "y")               //outputting of 2D array to Console with grid
            {
                Console.WriteLine(gridLines);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write("|");
                        if (rows == 4)
                        {
                            if (j % columns == 0)
                            {
                                Console.Write($"{array2D[i, j],3}".Pastel(Color.FromArgb(rgb, 0, 0)));
                            }
                            if (j % columns == 1)
                            {
                                Console.Write($"{array2D[i, j],3}".Pastel(Color.FromArgb(0, rgb, 0)));
                            }
                            if (j % columns == 2)
                            {
                                Console.Write($"{array2D[i, j],3}".Pastel(Color.FromArgb(0, 0, rgb)));
                            }
                            if (j % columns == 3)
                            {
                                Console.Write($"{array2D[i, j],3}".Pastel(Color.FromArgb(rgb, rgb, 0)));
                            }
                        }
                        else
                        {
                            Console.Write($"{array2D[i, j],3}");
                        }

                    }
                    Console.WriteLine("|");
                    Console.WriteLine(gridLines);
                }
            }
            if (gridSelection == "n")               //outputting of 2D array to Console without grid
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{array2D[i, j],3}");
                    }
                    Console.WriteLine($"");
                }
            }
        }
    }
}
