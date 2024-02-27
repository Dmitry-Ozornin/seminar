// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int[] FillRandomArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 1000);
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

int IsInteresting(int[] arr)
{   
    int count = 0;
    foreach ( int el in arr)
    {
        if ( HaveOne(el) && MultySeven(el))
        {
            count++;
        }
    }
    return count;
}

bool HaveOne (int num)
{
    bool Have = false;
    if ( num % 10 == 1)
    {
        return true;
    }
    return false;
}
bool MultySeven (int num)
{
    if ( num % 7 == 0)
    {
        return true;
    }
    return false;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillRandomArray(length); 
PrintArray(arr);
Console.WriteLine($"Количество чисел удовлеьтворяющее условиям: {IsInteresting(arr)}");