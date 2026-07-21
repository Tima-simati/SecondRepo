using System;
using System.Drawing;
using Console = Colorful.Console;

namespace Arrays_2D
{
    internal class Arrays_2D
    {
        static void Main(string[] args)
        {
            /*dynamic grid sizes; let the user select how many rows and cols should be displayed
                fill the grid with values; you can either put random symbols or let the user decide how to fill value, be creative
                print the content of the grid
                modify the specific ranges; you can try to mark the cells of the grid like a chess board 
                where alternating cells are marked or display the border of the grid

            added fun:try to color the the output on the console 
            steps:
            ask the user about the dimensions of the grid
            create a grid and fill with values
            output that array
            implement multiple modes that display your grid differently
             */
            Console.WriteLine("This is a program for displaying arrays.\nWhat should be the dimensions of your array?");
            Console.WriteLine("Please enter the number of rows.");
            int rows = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the number of columns.");
            int columns = Convert.ToInt16(Console.ReadLine());
            //array initialized after user input with no values
            string[,] array2D = new string[rows, columns];
            //setting up variables for putting grid in the array
            int gridColumns = columns * 4 + 1;
            string gridLines = "+";
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
            Console.WriteLine("\nYour array is:");
            int runningValueIncrement = 0;
            //numbers selected as content for 2D Array
            if (arraysContentSelection == '1')
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
            if (arraysContentSelection == '2')
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (runningValueIncrement % 2 == 0)
                        {
                            array2D[i, j] = "X";
                        }
                        else
                        {
                            array2D[i, j] = "O";
                        }
                        ++runningValueIncrement;
                    }
                }

            }
            //indices selected as content for 2D array
            if (arraysContentSelection == '3')
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array2D[i, j] = $"{i},{j} ";
                    }
                }
            }
            Console.WriteLine("Do you want to have a grid for your array or not? Press y or n.");
            string gridSelection = Console.ReadLine().ToLower();
            if (gridSelection == "y")               //outputting of 2D array to Console with grid
            {
                Console.WriteLine(gridLines);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"| {array2D[i, j]} ");
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
                        Console.Write($"{array2D[i, j]} ", Color.Green);
                    }
                    Console.WriteLine($"");
                }
            }
        }
    }
}
