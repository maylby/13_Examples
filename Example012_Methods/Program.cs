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


// Вид 1 Не принимающий и не возвращающий метод
void Method1()
{
    System.Console.WriteLine("Автор ...");
}
Method1(); // вызов метода


// Вид 2 Принимающий, но не возвращающий метод
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения"); // вызов метода
Console.WriteLine(); // Пустая строка


// Вид 2.1 Именованный метод (принрмает, но не возвращает)
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


// Вид 3 Не принимающий, но возвращающий метод
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);
Console.WriteLine(); // Пустая строка


// Вид Принимающий и возвращающий метод
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

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винцегероде, "
+ "вы бы взяли приступом согласие русского короляб. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
	string result = string.Empty;
	int length = text.Length;
	for (int i = 0; i < length; i++)
	{
		if(text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text}";
	}
	return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();

// !!! - Код данной задачи сработал не корректно.
// !!! - Вместо выполнения прописанных команд, многократно множит текст
// !!! - Частично был скопирован с текстом из PDF-файла презентации к лекции
// !!! - После чего, в тексте появились некие команды, которых я не писал
// !!! - По сути, мешали писать код, внося не нужные правки.
// !!! - Сначала закрыл команды слешами, позже удалил.

