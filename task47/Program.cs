// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте двумерный массив m x n:");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[m,n];
Random random = new Random();

for(int i=0; i< m; i++)
{
    for(int j=0; j<n; j++)
    {
        matrix[i,j] = random.NextDouble() * 10 -5;                 // NextDouble() >= 0,0 && <1,0
        Console.Write(Math.Round(matrix[i,j], 1) + "\t");
    }
    Console.WriteLine();
}

// https://docs.microsoft.com/ru-ru/dotnet/api/system.random.next?view=net-6.0
// // Generate and display [rows * cols] random doubles.
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//                 Console.Write("{0,12:F8}", randObj.NextDouble());
//             Console.WriteLine();
//         }

//         Console.WriteLine(
//             "\nRandom integers generated with the Next() " +
//             "method:\n");