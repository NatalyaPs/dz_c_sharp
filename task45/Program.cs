// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
int[] copyArray = new int[array.Length];

for (int i = 0; i < array.Length; i ++)
{
    copyArray[i] = array[i];
}
Console.WriteLine($"Копия массива: " + '[' + string.Join(", ", copyArray) + ']');