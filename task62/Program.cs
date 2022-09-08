// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int n = 4;
int[,] matrix = new int[n, n];
int num = 1;

for (int shift = 0; shift < n - 2; shift++)
{
    for (int j = 0 + shift; j < n - shift; j++)  //верхняя строка слева-направо
    {
        matrix[0 + shift, j] = num;
        num++;
    }
    num--;

    for (int i = 0 + shift; i < n - shift; i++)  //правый столбец сверху-вниз
    {
        matrix[i, n - 1 - shift] = num;
        num++;
    }
    num--;

    for (int j = n - 1 - shift; j >= 0 + shift; j--)  //нижняя строка справа-налево
    {
        matrix[n - 1 - shift, j] = num;
        num++;
    }
    num--;

    for (int i = n - 1 - shift; i >= 1 + shift; i--)  //левый столбец снизу вверх
    {
        matrix[i, 0 + shift] = num;
        num++;
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);