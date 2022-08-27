// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76


Console.Write("Введите количество элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[kol];

for (int i = 0; i < kol; i++)
{
    Console.WriteLine($"Введите {i} элемент массива (например 1,12): ");
    arr[i] = double.Parse(Console.ReadLine());   //или arr[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Ваш массив: " + '[' + string.Join(", ", arr) + ']');


double max = arr[0];
for (int j = 1; j < arr.Length; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.WriteLine($"Максимальный элемент массива: {max}");


double min = arr[0];
for (int g = 1; g < arr.Length; g++)
{
    if (arr[g] < min)
    {
        min = arr[g];
    }
}
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");

