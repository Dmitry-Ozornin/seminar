// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
void Print_arr(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]}\t ");

        }
        Console.WriteLine();
    }
}

int[,] FillRandomArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 11);
        }
    }
    return arr;
}

int FindSumOfDianogal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += arr[i, j];
            }
        }
    }
    return sum;

}

Console.Write("Введите размерность м ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillRandomArray(new int[m, n]);
Print_arr(arr);

int sum = FindSumOfDianogal(arr);
Console.WriteLine($"{sum}");
