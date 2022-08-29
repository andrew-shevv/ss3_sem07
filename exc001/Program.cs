// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int rows = 5;
int columns = 4;

int[,] array2D = new int[rows, columns];

Random rand = new Random();

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        array2D[i, j] = rand.Next(-19, 20);
        Console.Write($" {array2D[i, j]} ");
    }
    Console.WriteLine();
}