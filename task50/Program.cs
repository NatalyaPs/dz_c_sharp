// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет


Console.WriteLine("Задайте двумерный массив m x n:");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];
Random random = new Random();
Console.WriteLine();
for(int i=0; i< m; i++)
{
    for(int j=0; j<n; j++)
    {
        matrix[i,j] = random.Next(1, 10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Введите индекс элемента m: ");
int am = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс элемента n: ");
int an = Convert.ToInt32(Console.ReadLine());

if (am <= m && an <= n)
    {
        Console.WriteLine(matrix[am,an] + "\t");
    }
else Console.Write($"Такого элемента в массиве нет \n");
Console.WriteLine();
    