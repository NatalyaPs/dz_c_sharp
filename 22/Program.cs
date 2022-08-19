/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  

Console.WriteLine("Введите пятизначное число: ");
int nam = Convert.ToInt32(Console.ReadLine());
string str = nam.ToString();

if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}  */




/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12    */


/*
Console.WriteLine("Введите число:");
int namber=Convert.ToInt32(Console.ReadLine());
namber=Math.Abs(namber);
/////           string str=namber.ToString();
int count=0;
int sum=0;
int nam=0;
while(namber==0)
{
    nam=namber%10;
    sum+=nam;
    count++;
}

Console.WriteLine($"Сумма цифр в числе равна {sum}");

*/

/*
int count=0;
int sum=0;
int nam=0;
int namber=555;
while(namber%10==0);
{nam=namber%10;
    sum=sum+nam;
    count++;}
   Console.WriteLine($"{sum}");*/


   /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12    */
/*
Console.WriteLine("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
namber = Math.Abs(namber);  
int[]array=new int[namber.Length];
int sum=0;
if(sum<namber.Length)
{
    sum+=array[namber.Length];
}*/

/*for (int i = 0; i < array.Length; i++)
{
    sum=sum+array[i];
}*/
//Console.WriteLine($"Сума цифр с числе равна {sum}");




Console.WriteLine("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
namber = Math.Abs(namber);
int sum = 0;

while (namber > 0)    
{   
        sum = sum + namber % 10;
    namber = namber / 10;
}
Console.WriteLine($"Сумма цифр в числе равна {sum}");