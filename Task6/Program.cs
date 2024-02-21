// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа. Запишем через рандом числа.

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int s = num/100*10 + num%10;
Console.WriteLine(s);
Console.WriteLine(num/100 + "" + num%10);