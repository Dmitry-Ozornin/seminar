// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

int num = Convert.ToInt32(Console.ReadLine());  //Вввод числа пользователем
// int num = new Random().Next(100,1000); программа сама задает рандомное чиcло
Console.WriteLine(num);

if (num <= 999 && num >= 100)
{
    int num_3 = num % 10;
    int num_2 = num / 10 % 10;
    Console.WriteLine(Math.Pow(num_2, num_3));
}
else
{
    Console.WriteLine("Число не трехзначное");
}
