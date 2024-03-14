// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.

using System.Text; //подключение библиотеки( помогло писать на русском)
Console.InputEncoding = Encoding.Unicode; // для русского языка
Console.OutputEncoding = Encoding.Unicode; // для русского языка



Console.WriteLine("введите слово");
string str = Console.ReadLine()!;

void Buk(string str)
{
    if (str == "")
    {
        return;
    }
    string vowel = "aoueiAOUEI";
    if (!vowel.Contains(str[0]))
    {
    Console.Write(str[0]);
    }
    Buk(str[1..]);   //Hello[2..] получиться llo
}

Buk(str);