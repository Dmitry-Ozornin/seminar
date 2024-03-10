// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре  и верхнем регистре. Выяснить, сколько среди
// введённых букв гласных.

using System.Text; //подключение библиотеки( помогло писать на русском)
Console.InputEncoding = Encoding.Unicode; // для русского языка
Console.OutputEncoding = Encoding.Unicode; // для русского языка

string vowel = "aoueiAOUEIАОУЕЁИЮЯаоуеёиюя";


Console.WriteLine("введите строку");
string inputString = Console.ReadLine()!;
int count = 0;
foreach (var item in inputString)
{
    foreach (var i in vowel)
    {
        if (item == i)
        {
            Console.Write($"{i} "); //вывод гласных на экран
            count++;
        }
    
        
    }
}
Console.WriteLine();
Console.Write($"Количество гласных симоволов: {count}");