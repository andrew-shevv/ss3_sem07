// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.WriteLine("Creating array: ");

int rows = 5;
int columns = 4;

int[,] array2D = new int[rows, columns];

Random rand = new Random();

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        array2D[i, j] = rand.Next(-9, 10);
        Console.Write($" {array2D[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nNewly altered array: ");

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        if (i % 2 == 0 && j % 2 == 0){
            array2D[i, j] *= array2D[i, j];
        }
        Console.Write($" {array2D[i, j]} ");
    }
    Console.WriteLine();
}
