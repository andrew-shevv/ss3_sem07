// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

int rows = 4;
int columns = 5;

int[,] array2D = new int[rows, columns];

Random rand = new Random();

int sumDiagonal = 0;

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        array2D[i, j] = rand.Next(1, 10);
        Console.Write($" {array2D[i, j]} ");
        if (i == j){
            sumDiagonal += array2D[i, j];
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"Sum of elements on main diagonal = {sumDiagonal}");