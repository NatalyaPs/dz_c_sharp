// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2    -> 2
// 1, -7, 567, 89, 223   -> 3

Console.WriteLine("Сколько чисел вы хотите ввести? ");
int nambers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[nambers];


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());   
}
Console.WriteLine($"Вы ввели следующие числа: " + string.Join(", ", array));


int sum = 0;
for (int j = 0; j < array.Length; j++)
{
    if(array[j] < 0)
    {
        sum+=1;
    }   
}
Console.WriteLine($"Из них {sum} отрицательных чисел");