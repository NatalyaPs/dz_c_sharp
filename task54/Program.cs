// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задайте двумерный массив m x n:");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Random random = new Random();
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.Next(1, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();


int num = new int();
int max = new int();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)             
    {
        for (int k = j+1; k < n; k++)      
        {
            max = matrix[i, j];               
            if (matrix[i, k] > max)
            {
                max = matrix[i, k];
                num = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = num;
            }
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();