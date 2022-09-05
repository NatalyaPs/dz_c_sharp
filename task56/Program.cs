// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка
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

int[] array = new int[n];
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum += matrix[i, j];
        array[i] = sum;
    }
    Console.Write(array[i] + "\t");
    Console.WriteLine();
}
Console.WriteLine();


int min = array[0];
int count = new int();
for (int i = 0; i < n; i++)
{
      if (array[i] < min)
    {
        min = array[i];
        count = i+1;
    }
}  
Console.Write($"Наименьшая сумма элементов {min} в {count} строке");
Console.WriteLine();

