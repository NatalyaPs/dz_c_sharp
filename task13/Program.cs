/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6       */
//можно через массив или через if-else (1шт) и while (1шт)
                        
 Console.WriteLine("Введите число: ");
 int namber = Convert.ToInt32(Console.ReadLine());

if  (namber< 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string str = namber.ToString();
    int[]array=new int[str.Length];
    Console.WriteLine($"Третья цифра в данном числе {str[2]}");
}
