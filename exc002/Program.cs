// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int rows = 5;
int columns = 4;

int[,] array2D = new int[rows, columns];

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        array2D[i, j] = i + j;
        Console.Write($" {array2D[i, j]} ");
    }
    Console.WriteLine();
}