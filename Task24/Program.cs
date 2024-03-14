// Задайте значение N. Напишите программу, которая выведет  все натуральные числа в промежутке от 1 до N.

string GetListNum(int num, int index = 1)
{
    if ( index == num)
    {
        return Convert.ToString(index);
    }
    return index + " " + GetListNum(num, index + 1);

}


Console.WriteLine("введите число");
int num =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetListNum(num));
