// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0)
{
    number1 = number1*(-1);
}
int index = - number1;
while (index <= number1)
{
    Console.Write($"{index} ");
    index++; //index = index + 1;
    // index--; index = index -1;
    // index += 2; //index = index + 2;
}
