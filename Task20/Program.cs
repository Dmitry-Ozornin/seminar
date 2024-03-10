// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.

string CharOfString(char[] arr) //создание строки
{
    string st = "";
    foreach (var item in arr)
    {
        st += item;
    }
    return st;
}

char[] chars = new char[] { 'a', 'b', 'c', 'd'}; //начало
Console.WriteLine(CharOfString(chars)); // вывод на экран