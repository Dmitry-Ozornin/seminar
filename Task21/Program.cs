// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

using System.Text; //подключение библиотеки( помогло писать на русском)
char[] stringToCharArray(string inputString)
{
    char[]  charArray = new char[inputString.Length];
    for (int i = 0; i < inputString.Length; i++)
    {
        charArray[i] = inputString[i];
    }
    return charArray;
}

void PrintCharArray(char[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"'{item}' ");
    }
}

Console.InputEncoding = Encoding.Unicode; // для русского языка
Console.OutputEncoding = Encoding.Unicode; // для русского языка
Console.Write("введите строку ");
string inputString = Console.ReadLine()!;
PrintCharArray(stringToCharArray(inputString));