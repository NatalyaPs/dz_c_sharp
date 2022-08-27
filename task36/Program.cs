// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введите количество элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] array = new int[kol];


for (int i = 0; i < kol; i++)
{
    array[i] = rnd.Next(-100, 100);
}
Console.WriteLine($"Ваш массив: " + '[' + string.Join(", ", array) + ']');


int sum = 0;                      
for(int i = 1; i < kol; i+=2)      //по рекомендации преподавателя счетчик заменила с i++ на i+=2
{                                  //тогда условие if не нужно. Это оптимизирует программу
    sum +=array[i];
    // if (i % 2 == 1)
    // {
    //     sum +=array[i];
    // }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
