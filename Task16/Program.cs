// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 

int[] FillRandomArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr; 
}

void PrintArray(int[] arr)
{
    foreach (var el in arr)
    {
         Console.Write($"{el} ");
    }
    Console.WriteLine();
}

double num(int[] col) // 1 4 8 7 8 7 4 9
{
    double n = 0;
    foreach (var item in col)
    {
        n = n * 10 + item;
    }
    return n;
}
// 1
// 14 * 10 + 4 = 14
// 148 * 10 + 7 = 1487...

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillRandomArray(length); 
PrintArray(arr);
Console.WriteLine(num(arr));