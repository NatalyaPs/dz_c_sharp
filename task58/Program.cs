// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Определение.
// Результатом умножения матриц Am×n и Bn×k будет матрица Cm×k такая, 
// что элемент матрицы C, стоящий в i-той строке и j-том столбце (Cij), 
// равен сумме произведений элементов i-той строки матрицы A 
// на соответствующие элементы j-того столбца матрицы B:

// cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj

Console.WriteLine("Задайте двумерный массив A размером m x n:");
Console.WriteLine("Введите m матрицы А: ");
int ma = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n матрицы В: ");
int na = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[ma, na];
Random random = new Random();
Console.WriteLine();
for (int i = 0; i < ma; i++)
{
    for (int j = 0; j < na; j++)
    {
        matrixA[i, j] = random.Next(1, 10);
        Console.Write(matrixA[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Задайте двумерный массив В размером m x n:");
Console.WriteLine("Введите m: ");
int mb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int nb = Convert.ToInt32(Console.ReadLine());

int[,] matrixB = new int[mb, nb];
Console.WriteLine();
for (int i = 0; i < mb; i++)
{
    for (int j = 0; j < nb; j++)
    {
        matrixB[i, j] = random.Next(1, 10);
        Console.Write(matrixB[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

if (ma != mb && na != nb && ma!= na && mb!=nb) 
{
    Console.WriteLine("Размеры матриц должны совпадать!");
}


int[,] matrixC = new int[ma,na];
for (int i = 0; i < ma; i++)
{
    for (int j = 0; j < nb; j++)  
    {
        for(int k=0; k < nb; k++)
        {
            matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
        }
        Console.Write(matrixC[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();