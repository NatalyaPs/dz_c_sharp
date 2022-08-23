// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Введите количество элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] array = new int[kol];


for (int i = 0; i < kol; i++)
{
    array[i] = rnd.Next(100, 1000);
}
Console.WriteLine($"Ваш массив: " + '[' + string.Join(", ", array) + ']');


int nam2 = 0;
for(int i = 0; i < kol; i++)
{
    if(array[i] % 2 == 0)
    {
        nam2+=1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {nam2}");