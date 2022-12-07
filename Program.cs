// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам

string[] ArrTask; //объявляем массив
Console.WriteLine("Введите массив строк через запятую (без пробелов):"); // сообщение пользователю программы
string stroka = Console.ReadLine(); //принимаем введенное значение пользователем с клавиатуры, присваеваем переменной stroka
ArrTask = stroka.Split(','); // разбиваем массив на подстроки при помощи .Split, разделителем используем ','
var result = new string[ArrTask.Length]; // объявляем переменную result, тип var так как мы не хнаем какие данные будут в переменной
var realSize = 0; // объявляем переменную realSize присваеваем значение = 0, 
foreach (var value in ArrTask) // пробегаемся циклом по массиву ArrTask
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true); // ожидание ввода пользователем любого символа с клавиатуры для завершения работы прграмы
