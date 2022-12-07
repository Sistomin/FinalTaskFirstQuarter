// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам

string[] ArrTask; //объявляем массив
Console.WriteLine("Введите массив строк через запятую (без пробелов):"); // сообщение пользователю программы
string stroka = Console.ReadLine(); //принимаем введенное значение пользователем с клавиатуры, присваеваем переменной stroka
ArrTask = stroka.Split(','); // разбиваем массив на подстроки при помощи .Split, разделителем используем ','
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
