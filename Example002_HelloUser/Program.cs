// Вывод текста столбиком ("WriteLine"):
Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();
Console.WriteLine("Привет, "); // Не выводит введенное имя, хотя раньше выводил
Console.WriteLine(username);

// Вывод текста одной строкой ("Write")
Console.Write("Введите ваше имя: ");
string username2 = Console.ReadLine();
Console.Write("Привет, "); // Не выводит введенное имя
Console.Write(username2);