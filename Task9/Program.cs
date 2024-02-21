// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num2 = 0;
// if (num < 0) num = - num;
// if (num <100)
// {
//     Console.WriteLine("Третьей цицрф нет");
// }
// else
// {
//     while (num > 100)
//     {
//         num2 = num % 10;
//         num /= 10; // num = num / 10
//     }
//     Console.WriteLine(num2);
// }

// Способ 2

string num = Console.ReadLine()!;
if (num.Length < 3)
{
    Console.WriteLine("Третьей цицрф нет");
}
else
{
    Console.WriteLine(num[2]);
}
