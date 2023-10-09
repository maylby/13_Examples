// Знакомство с языками программирования (лекции)
// Лекция 3. "Функции: продолжение"
// https://gb.ru/lessons/362972

// !!! - Папка-дубль ранее созданной папки "Example003_Sum"
// Создана с целью проверки ошибок и некоректной работы кода
// Код отработал корректно.

// 20:00
// Задание на форматирование текста

// Дан текст. 
// В тексте все пробелы нужно заменить чёрточками.
// Маленькие буквы "к" заменить большими "К".
// Большие "С" заменить маленькими "с".

// Ясна ли задача?

// Что значит дан текст?
// Ввёл пользователь, считали из базы данных, скопировали с сервиса???
// *В нашем случае, текст будет храниться, как отдельная строка.
// Что значит чёрточками?
// Тире, дефис, минус, нижнее подчёркивание, слеш (правый, левый, вертикальный)??? 
// Какого алфавита буквы "к", "К", "с", "С" ???
// Ясна ли задача?

// string text = "- Я думаю, сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие русского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// 22:00
// string s = "qwerty" (Подряд набранные знаки клавиатуры) 
//             012
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
// 	string result = string.Empty;
	
// 	int length = text.Length;
// 	for (int i = 0; i < length; i++)
// 	{
// 		if(text[i] == oldValue) result = result + $"{newValue}";
// 		else result = result + $"{text[i]}";
// 	}
// 	return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine(); // Пустая строка - разрыв текста
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();

// 28:30
// Поиск минимального элемента массива

// int[] arr = {1, 2, 5, 4, 3, 7, 1, 6, 2, 1};

// void PrintArray(int[] array) // Метод вывода массива на экран
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length ; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);