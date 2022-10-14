// See https://aka.ms/new-console-template for more information
//Шаблон консольного приложения .NET 6 C# создает инструкции верхнего уровня
// Пользователь вводит с клавиатуры некоторый текст.
// Приложение должно изменять регистр первой буквы каждого
// предложения на букву в верхнем регистре

using System.Reflection;

Console.Title = " Пример использования инструментов класса Console"; // оформление
Console.BackgroundColor = ConsoleColor.Black; //изменяет цвет фона
Console.ForegroundColor = ConsoleColor.DarkGreen;//изменяет цвет текста
Console.SetWindowSize(100, 30);//устанавливаем размер окна консоли


Console.WriteLine("Введите строку со знаками препинания. Использование точки обязательно:\t");
Console.WriteLine(); // перенос на новую строку
string str1 = Console.ReadLine();
Console.WriteLine($"строка {str1}");
string replaced = str1?.Replace("  ", " ");
Console.WriteLine($"убираем пробелы {replaced}");
string new2;
if (str1.Length > 0)
{
    int v_int = 0;
    v_int++;
    string new2 = Char.ToUpper(str1[0]) + str1.Substring(v_int);
    Console.WriteLine($"Мы это сделали {new2}");
}
foreach (var s in str1.Split("1")) ;
{
    Console.WriteLine($"строчка {new2}");
}
//делит строку на слова,
//разделенные указанными символами,
//каждую часть записывает в отдельную переменную типа string и выполняет для нее код ниже
// предложения на букву в верхнем регистре

//static string Line(string str1)
//{
//    return str1.Split(' ').Aggregate("", (x, y) => x + char.ToUpper(y[0]) + string.Join("", y.Skip(1)));
//}
//Line(str1);
//Console.WriteLine(str1.Split(' ').Aggregate("", (x, y) => x + char.ToUpper(y[0]) + string.Join("", y.Skip(1))));

//var strWithoutSpaces = str1.Replace(" ", "");
//Console.WriteLine(strWithoutSpaces); //somestr
//Console.WriteLine(str1); // перенос на новую строку
//Console.WriteLine(); // перенос на новую строку
//Console.WriteLine("строка после преобразования"); // перенос на новую строку


// Split(' ') Split - строку конвертирует в массив строк, в качестве разделителя используется символ пробела
// Aggregate("", (x, y) => x 
//Console.WriteLine(" ", str1.Split(' ').Aggregate(" ", (x, y) => x + char.ToUpper(y[0]) + string.Join(" ", y.Skip(0))));
// char.ToUpper(y[1]) - ToUpper	Преобразует символ в верхний регистр
//   String.Join	Создание новой строки с помощью объединения массива строк.
// string.Join("", y.Skip(1))))  Join - объединяет массив строк обратно в общую строку, разделяя их пробелами

//Console.WriteLine(str1.Split(' ').Aggregate(" ", (x, y) => x + char.ToUpper(y[0]) + string.Join("", y.Skip(0))));

Console.WriteLine(DateTime.Now); // перенос на новую строку





