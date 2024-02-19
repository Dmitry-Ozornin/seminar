// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.

Console.Write("Введите перове число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
// int.Parse("cczczczxc");
// Convert.ToInt32("1125546");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("NO");
// }


// if (number1 == Math.Pow(number2,2))
// {
//     Console.WriteLine($"Квадрат числа {number2} равен {number1}");
// }
// else
// {
//     Console.WriteLine("Квадрат числа {1} не равен {0}", number2, number1);
// }

if (number1 == Math.Pow(number2,2)) Console.WriteLine($"Квадрат числа {number2} равен {number1}");

else Console.WriteLine("Квадрат числа {1} не равен {0}", number2, number1);
