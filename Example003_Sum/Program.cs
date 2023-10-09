// Знакомство с языками программирования (лекции)
// Лекция 3. "Функции: продолжение"

// 03:00
// Виды методов

// Методы условно делятся на возвращающие и невозвращающие
// 1) Невозвращающие методы - это те, которые 
// * Ничего не принимают и ничего не возвращают
// * Что-то принимают, но ничего не возвращают
// 2) Возвращающие методы - это те которые
// * (?) Ничего не принимают, но что-то возваращают 
// * Что-то принимают и что-то возвращают

// * Вид 1 (невозвращающий и не принимающий)
// Метод "void"

// void Method1()
// {
//     Console.WriteLine("Автор ");
// }
// Method(); // Вызов метода, ставь круглые скобки "();" и точку с запятой после имени метода

// 0:05:00
// Вид 2 (принимающий, но не возвращающий)

// void Method2(string msg) // метод принимает некий аргумент
// {
//     Console.WriteLine(msg); // аргумент помещаем в круглые скобки
// }
// Method2("Текст сообщения"); // Вызов метода, в скобках - "<сообщение>"


// 0:07:50
// Именованные аргументы
// Используются, когда аргументов несколько


// void Method21(string msg, int count) // метод принимает некий аргумент
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg); // аргумент помещаем в круглые скобки
//         i++;
//     } 
// }
// Method21(msg: "Текст", 4); // В скобках: "<Сообщение>" и, через запятую, "4" (число повторов)
// Method21(count: 4, msg: "Новый текст"); 
// Если именованы все аргументы, то порядок их размещения может быть любым


// 0:10:00

// Вид 3 (возвращающий, но не принимающий)

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// 0:10:40

// Вид 4 (принимающий и возвращающий)

// string Method4(int count, string text) 
// {
//     int i = 0;
//     string result = String.Empty; // "String.Empty"- "Пустая Строка"; можно написать "0", но так не принято
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result; // в операторе "return" указываем имя переменной "result"
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// N.B.
// Для изменения имени какой-либо переменной во всём тексте программы, 
// выделяем её имя, правой кнопкой вызываем панель, выбираем строку "Rename Symbol"


// 0:15:00

// Цикл "for"

// string Method4(int count, string text) 
// {
//     string result = String.Empty; // "String.Empty"- "Пустая Строка"; можно написать "0", но так не принято
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result; // в операторе "return" указываем имя переменной "result"
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);


// 0:17:00

// Таблица умножения

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


// 0:20:30

// Решение задач с помощью цикла "for"

// * Трениролвочная задача


// Сложение двух целых чисел

// int numbrerA = 3;
// int numbrerB = 7;
// int result = numbrerA + numbrerB;
// Console.WriteLine(result);


// Сложение двух целых случайных чисел
// "Random" - генератор случайных чисел

// int numbrerA = new Random().Next(1, 10); // 1 2 3 ... 9
// Console.WriteLine(numbrerA);
// int numbrerB = new Random().Next(1, 10);
// Console.WriteLine(numbrerB);
// int result = numbrerA + numbrerB;
// Console.WriteLine(result);