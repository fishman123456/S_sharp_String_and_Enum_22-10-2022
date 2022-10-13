// See https://aka.ms/new-console-template for more information
// Пользователь вводит с клавиатуры некоторый текст.
// Приложение должно изменять регистр первой буквы каждого
// предложения на букву в верхнем регистре
Console.Title = " Пример использования инструментов класса Console"; // оформление
Console.BackgroundColor = ConsoleColor.Black; //изменяет цвет фона
Console.ForegroundColor = ConsoleColor.DarkGreen;//изменяет цвет текста
Console.SetWindowSize(100, 30);//устанавливаем размер окна консоли

Console.WriteLine("Введите строку со знаками препинания. Использование точки обязательно:\t");
Console.WriteLine(); // перенос на новую строку
string str1 = Console.ReadLine();       