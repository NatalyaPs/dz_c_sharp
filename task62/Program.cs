// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] matrix = new int[n, n];
int num = 1;
//int shift = 0;

for (int shift = 0; shift < n - 2; shift++)
{
    Console.WriteLine();
    for (int i = 0 + shift; i < n - shift; i++)  // верхняя строка. слева-направо  
    {
        for (int j = 0 + shift; j < n - shift; j++)
        {
            matrix[0 + shift, j] = num;
            num++;
            //shift++;
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    num--;

    Console.WriteLine();
    for (int j = 0 + shift; j < n - shift; j++)  //правый столбец. сверху-вниз
    {
        for (int i = 0 + shift; i < n - shift; i++)
        {
            matrix[j, n-1 - shift] = num;
            num++;
            //shift++;
            Console.Write(matrix[j, i] + "\t");
        }
        Console.WriteLine();
    }
    num--;

    Console.WriteLine();
    for (int i = n - 1 - shift; i >= 0 + shift; i--)  //нижняя строка. справа-налево
    {
        for (int j = n - 1 - shift; j >= 0 + shift; j--)
        {
            matrix[n-1 - shift, j] = num;
            num++;
            //shift++;
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    num--;

    Console.WriteLine();
    for (int j = n - 1 - shift; j >= 1 + shift; j--)  //левый столбец. снизу вверх
    {
        for (int i = n - 1 - shift; i >= 0 + shift; i--)
        {
            matrix[j, 0 + shift] = num;
            num++;
            //shift++;
            Console.Write(matrix[j, i] + "\t");
        }
        Console.WriteLine();
    }
    num--;
}

