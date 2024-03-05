// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
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
Console.Write("Введите размерность м ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }
}

int[,] Sq(int[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ( i % 2 == 0 && j % 2 == 0) 
            {
                arry[i, j] = arry[i, j] * arry[i, j];
            }
        }
    }
    return arry;
}
Print_arr(arr);
Console.WriteLine();
Print_arr(Sq(arr));
