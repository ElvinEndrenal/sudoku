/*  DESC:   Sudoku is a logic-based, combinatorial number-placement puzzle.
            Each 3x3 grid must contain values 1-9 without repetition and all values must be given.

    TASK:   Create the function code for checking if a given integer grid is a valid sudoku grid called "ValidGrid".
            It returns TRUE if it is a valid grid, otherwise, FALSE.



    AUTHOR: J.E.ENDRENAL
    SECTION: ICT201-A
    SUBJECT: COMPG04
    LAB EXERCISE 8.1
*/

class Sudoku
{
    static bool ValidGrid(int[,] grid)
    {

        int[] flatArray = new int[grid.Length];
        int index = 0;

        foreach (int value in grid)
        {
            flatArray[index++] = value; // Assign the current value from grid to flatArray at the current index

        }

        Array.Sort(flatArray);
        
        /*
        I've used this to check if the array is sorted

        foreach(int i in flatArray){   
            Console.Write(i + " ");
        }
        Console.WriteLine();
        */

        for (int i = 0; i < flatArray.Length; i++)
        {
            // Check if the current int is the same as the previous int
            if (i > 0 && flatArray[i] == flatArray[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        int[,] sudoku = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] nudoku = {
            {1, 2, 3},
            {4, 2, 5},
            {6, 7, 9}
        };

        bool test1 = ValidGrid(sudoku);
        Console.WriteLine(test1); //true

        bool test2 = ValidGrid(nudoku);
        Console.WriteLine(test2); //false
    }
}
