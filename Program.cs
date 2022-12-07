﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам

string[] ArrTask;
Console.WriteLine("Введите массив строк через запятую (без пробелов):");
string stroka = Console.ReadLine();
ArrTask = stroka.Split(',');
var result = new string[ArrTask.Length];
var realSize = 0;
foreach (var value in ArrTask)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);
