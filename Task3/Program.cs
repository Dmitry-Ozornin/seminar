// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.

// Console.Write("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());

// while (true)
// {
//     if (( num <= 999) && ( num >= 100)) break;
//     Console.WriteLine("введено не трехзначное число: ");
//     Console.Write("Введено трехзначное число: ");
//     num = Convert.ToInt32(Console.ReadLine());
// }

// int num1 = num %10;
// int num2 = num /100;
// Console.WriteLine($"Сумма {num1} и {num2} равна {num1+num2}");

// int num3 = num /10 % 10;
// Console.WriteLine(num3);

// int num = new Random().Next(100, 1000);

// int num1 = num %10;
// int num2 = num /100;

// Console.WriteLine($"Сумма {num}. {num1} и {num2} равна {num1+num2}");

Console.Write("Введите трехзначное число ");
string num = Console.ReadLine()!;
Console.WriteLine(Convert.ToInt32(Convert.ToString(num[0]))+
                     Convert.ToInt32(Convert.ToString(num[2])));
