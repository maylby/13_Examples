// 13_(Л-07) Рекурсия продолжение
// Урок 7. Дополнительная лекция. Рекурсия: продолжение
// <https://gb.ru/lessons/362976>

// 00:04:30

// Собрать строку с числами от меньшего к большему, от a до b, a <= b

// Код:

// string NumbersFor(int a, int b) // Итеративный подход (01)
// {
//     string result = String.Empty; // "пустая строка" для записи
//     for (int i = a; i <= b; i++) // перебор от "a" до "b" с увеличением счётчика на единицу
//     {
//         result += $"{i} "; // запись очередного значения, в случае выполнения условия ("for")
//     }
//     return result; // в противном случае, возврат прежних значений
// }

// string NumbersRec(int a, int b) // Рекурсивный подход (02)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b); 
//     // возврат значений от "a" до "b", где каждое следующее значение "а" больше на единицу
//     else return String.Empty; // возврат "пустой строки", при невыполнении условия (a <= b)
// }

// string NumbersRec2(int a, int b) // (06:10) уменьшение на единицу числа вызов рекурсии (03)
// {
//     if (a > b) return String.Empty;
//     else return $"{a}, " + NumbersRec2(a + 1, b);
// }

// System.Console.WriteLine(NumbersFor(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 <- (01)
// System.Console.WriteLine(NumbersRec(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 <- (02)
// System.Console.WriteLine(NumbersRec2(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 <- (03)


// 00:06:30

// Собрать строку с числами в обратном порядке, от большего к меньшему

// Код:

// string NumbersFor(int a, int b) // Итеративный подход (01)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--) // Меняем "<=" на ">=" и "i++" на "i--"
//     {
//         result += $"{i}, "; // (???) Не выводит на экран!
//     }
//     return result;
// }

// string NumbersRec(int a, int b) // Рекурсивный подход (02)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; // метод "NumbersRec" ставим впереди
//     else return String.Empty;
// }

// System.Console.WriteLine(NumbersFor(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 <- (01)
// System.Console.WriteLine(NumbersRec(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 <- (02)



// 00:07:00
// Сумма чисел от 1 до N

// int SumFor(int n) // Итеративный подход (01)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n) // Рекурсивный подход (02)
// {
//     if (n == 0) return 0; // или, при "(n == 1) return 1", на один вызов рекурсии меньше 
//     else return n + SumRec(n - 1);
// }

// System.Console.WriteLine(SumFor(10)); // 55
// System.Console.WriteLine(SumRec(10)); // 55


// // 00:08:00
// // Факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }
// int FactorialRec(int n)
// {
//     if (n == 1 || n == 0) return 1; // <- условие выхода из рекурсии -> N = 1 или N = 0
//     // в условии следует указать, что факториал числа "0" тоже равен единице
//     else return n * FactorialRec(n - 1);
//     // возврат произведения "n" на число, меньше "n" на единицу
// }

// System.Console.WriteLine(FactorialFor(10)); // 3628800
// System.Console.WriteLine(FactorialRec(10)); // 3628800


// // 00:09:00
// // Вычислить "a" в степени "n"

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {   // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // <- вариант записи в одну строку
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n) // Сокращённое возведение в степень (см. скриншот "13_(Л-07)_img")
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     // при чётном показателе степени, число умножаем на себя, уменьшая в два раза показатель степени
//     else return PowerRecMath(a, n - 1) * a; // иначе, 
// }

// System.Console.WriteLine(PowerFor(2, 10)); // 1024
// System.Console.WriteLine(PowerRec(2, 10)); // 1024
// System.Console.WriteLine(PowerRecMath(2, 10));


// 00:12:00
// Перебор слов

// char[] s = { 'a', 'b', 'c', 'd'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
//             }
//         }
//     }
// }

// // 00:16:00

// // Общее решение задачи перебора слов
// Рекурсия избавляет от привязки к количеству циклов, набираемых руками

// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// // "void FindWords" - метод, принимающий алфавит
// // "string alphabet" - строка, куда будет производится запись
// // "char[] word" - массив из букв, составляющих новое слово
// // "int length" - длина слова на текущей итерации
// {
//     if (length == word.Length) // Условие выхода: длина слова совпала с указанным значением
//     {
//         System.Console.WriteLine($"{n++} {new String(word)}"); return; // вывод слова
//     }
//     for (int i = 0; i < alphabet.Length; i++) // Цикл сбора нового слова, по заданным буквам
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
//     System.Console.WriteLine();
// }

// // FindWords("abcd", new char[3]); Буквы и длина слова заданы заранее

// System.Console.Write("Input length: "); // ввод длины слова
// int word = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input letters: "); // ввода набора букв, составлющих слово
// string alphabet = Console.ReadLine(); 
// FindWords(alphabet, new char[word]);


// 00:20:00

// Директория
// Вызов даты и времени создания объекта, просмотр содержимого

// string path = "C:/Users/Vitaliy/GeekBrains/13_Examples/Example001_HelloConsole"; // путь к папке
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles(); // при наведении курсора на "GetFiles" всплывает доп. информация
// // Данная конструкция позволяет просмотреть файлы и папки в указанной папке

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name); // <- вызов конкретного элемента массива ("fi[i]"), 
//     // с нужными нам свойствами, например, "Name" (имя)
// }

// 00:23:00

// Рекурсия для перемещения по папкам

// void CatalogInfo(string path, string index = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         System.Console.WriteLine($"{index}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, index + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         System.Console.WriteLine($"{index}{files[i].Name}");
//     }
// }
// string path = @"/Users/Vitaliy/GeekBrains/13_Examples/Example001_HelloConsole"; 
// CatalogInfo(path);


// 00:27:00
// "Ханойские башни"

// void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     System.Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();


// 00:29:00
// Обход структур
// https://en.wikipedia.org/wiki/Tree_traversal - "Обход дерева" (статья)

// string emp = String.Empty;
// string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
// //                0    1    2     3    4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int rigth = 2 * pos + 1;
//          if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         System.Console.Write(tree[pos]);
//         if (rigth < tree.Length && !String.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
//     }
// }
// InOrderTraversal();