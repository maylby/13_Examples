// Знакомство с языками программирования (лекции)
// Урок 3. Функции: продолжение
// https://gb.ru/lessons/362972

// Методы условно делятся на возвращающие и невозвращающие

// 1) Невозвращающие методы - это те, которые 
// * Ничего не принимают и ничего не возвращают
// * Что-то принимают, но ничего не возвращают
// 2) Возвращающие методы - это те которые
// * (?) Ничего не принимают, но что-то возваращают 
// * Что-то принимают и что-то возвращают


// Вид 1 
// (НЕ принимающий и НЕ возвращающий метод)

void Method1()
{
    System.Console.WriteLine("Автор ...");
}
Method1(); // вызов метода


// 00:05:00
// Вид 2 
// (Принимающий, но НЕ возвращающий метод)

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения"); // вызов метода
Console.WriteLine(); // Пустая строка


// 00:06:00
// Вид 2.1 
// (Именованный метод (принимает, но НЕ возвращает))

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // Неименованные аргументы пишутся в строгом порядке
Method21(count: 4, msg: "новый текст"); // Именованные - в произвольном
Console.WriteLine(); // Пустая строка - разрыв


// 00:09:15
// Вид 3 
// (Возвращающий, но ничего НЕ принимающий метод)

int Method3()
{
    return DateTime.Now.Year; // "return" - оператор возвращения результата
}
int year = Method3(); // "int year" - оператор присваивания, принимает результат работы метода 
Console.WriteLine(year); // вывод на экран, в печать ("year" - идентификатор присваивания)
Console.WriteLine(); // Пустая строка


// 00:10:40
// Вид 4 
// (Принимающий и возвращающий метод)

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // "Empty" - пустая строка ("String") для записи "result"

    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string res = Method4(5, "z");
System.Console.WriteLine(res);


// Цикл "for"

string Method4For(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}

string res2 = Method4For(5, "z");
System.Console.WriteLine(res2);
Console.WriteLine(); // Пустая строка


// 00:18:40
// Цикл в цикле

// Таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine(); // Пустая строка
}


// 0:20:30

// Решение задач с помощью цикла "for"

// * Тренировочная задача
// // Задание на форматирование текста

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
Console.WriteLine();

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо нашего милого Винцегероде, "
                + "вы бы взяли приступом согласие русского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"  (Подряд набранные знаки клавиатуры) 
//             012      (индексы знаков строки, начиная с нуля)
// s[3] // r            ("r" - 4-ый символ имеет индекс "3")

string Replase(string text, char oldValue, char newValue)
{
	string result = String.Empty;
	int length = text.Length;
	for (int i = 0; i < length; i++)
	{
		if(text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'с', '*');
Console.WriteLine(newText);
Console.WriteLine();


// 28:30
// Поиск минимального элемента массива

// 1. Найти позицию минимального элемента в неотсотированной части массива 
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть неотсортированные элементы

int[] arr = {3, 2, 1, 5, 4, 2, 8, 3, 7, 9, 1, 6};

void PrintArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]}, ");
	}
    System.Console.WriteLine();
}


void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;

		for (int j = i + 1; j < array.Length; j++)
		{
			if(array[j] > array[minPosition]) 
            // Смена знака "<",">" меняет порядок сортировки на противоположный
			{
				minPosition = j;
			}
		}
		int temporary = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temporary;
	}
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
