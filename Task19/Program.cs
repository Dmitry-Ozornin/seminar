// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

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

double[] mas_one(int[,] arr)
{
    double[] mas = new double[arr.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        mas[i] = sum / arr.GetLength(1);
    }
    return mas;
}

void Print_arr_one(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}   ");
    }
    Console.WriteLine();
}

Console.Write("Введите размерность м ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillRandomArray(new int[m, n]);
Print_arr(arr);

double[] arr_one = mas_one(arr);
Console.WriteLine();
Print_arr_one(arr_one);

