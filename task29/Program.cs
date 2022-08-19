/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]   */

Console.Write("Введите количество элементов массива: ");
int el = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int[] array = new int[el];

for(int i = 0; i < el; i++)
{
    array [i] = rand.Next(0, 100);
}
Console.Write("Наш массив: " + '[' + string.Join(", ", array) + ']');
Console.WriteLine();