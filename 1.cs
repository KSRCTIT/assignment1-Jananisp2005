using System;

class TwoDimArr {
    static void Main() {
        // Declare and initialize a 2D array
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Loop through the array and print the elements
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine(); // New line after each row
        }
    }
}
