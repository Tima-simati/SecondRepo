using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;


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
            //array created after user input
            int[,] array2D = new int[rows, columns];
            int lastIndexOfRows = rows - 1;
            int lastIndexOfColumns = columns - 1;
            Console.WriteLine("Do you want to have a grid for your array or not? Press y or n.");
            string gridSelection = Console.ReadLine().ToLower();
            Console.WriteLine("Do you prefer the contents of the array should be numbers, alternating symbols or indices?\nPress 1 for numbers. 2 for symbols. 3 for showing indices as content.");
            int runningIncrement = 1;
            for (int i = 0; i < lastIndexOfRows; i++)
            {
                for (int j = 0; j < lastIndexOfColumns; j++)
                {
                    array2D[i, j] = runningIncrement++;
                }
            }

            for (int i = 0; i < lastIndexOfRows; i++)
            {
                for (int j = 0; j < lastIndexOfColumns; j++)
                {
                    Console.Write($"| {array2D[i,j]} ");
                }

            }

        }
    }
}
