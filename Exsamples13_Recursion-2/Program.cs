// 13_(Л-07) Рекурсия продолжение
// Урок 7. Дополнительная лекция. Рекурсия: продолжение
// <https://gb.ru/lessons/362976>


// 00:04:30
// Собрать строку с числами от меньшего к большему, от a до b, a <= b

// Код:

string NumbersFor(int a, int b) // Итеративный подход (01)
{
    string result = String.Empty; // "пустая строка" для записи
    for (int i = a; i <= b; i++) // перебор от "a" до "b" с увеличением счётчика на единицу
    {
        result += $"{i} "; // запись очередного значения, в случае выполнения условия ("for")
    }
    return result; // в противном случае, возврат прежних значений
}

string NumbersRec(int a, int b) // Рекурсивный подход (02)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b); 
    // возврат значений от "a" до "b", где каждое следующее значение "а" больше на единицу
    else return String.Empty; // возврат "пустой строки", при невыполнении условия (a <= b)
}

System.Console.WriteLine(NumbersFor(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 <- (01)
System.Console.WriteLine(NumbersRec(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 <- (02)



// 00:06:30
// Собрать строку с числами в обратном порядке, от большего к меньшему

// Код:

string NumbersForBack(int a, int b) // Итеративный подход (01)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--) // Меняем "<=" на ">=" и "i++" на "i--"
    {
        result += $"{i}, ";
    }
    return result;
}

string NumbersRecBack(int a, int b) // Рекурсивный подход (02)
{
    if (a <= b) return NumbersRecBack(a + 1, b) + $"{a} "; // метод "NumbersRec" ставим впереди
    else return String.Empty;
}

string NumbersRecBack2(int a, int b) // Рекурсивный подход (03)
{
    if (a > b) return String.Empty;
    else return NumbersRecBack2(a + 1, b) + $"{a}, ";
}

System.Console.WriteLine(NumbersForBack(10, 1)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 <- (01)
System.Console.WriteLine(NumbersRecBack(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 <- (02)
System.Console.WriteLine(NumbersRecBack2(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 <- (03)


// 00:07:00
// Сумма чисел от 1 до N

int SumFor(int n) // Итеративный подход (01)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n) // Рекурсивный подход (02)
{
    if (n == 0) return 0; // или, при "(n == 1) return 1", на один вызов рекурсии меньше 
    else return n + SumRec(n - 1);
}

System.Console.WriteLine(SumFor(10)); // 55
System.Console.WriteLine(SumRec(10)); // 55



// 00:08:00
// Факториал числа

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1 || n == 0) return 1; // <- условие выхода из рекурсии -> N = 1 или N = 0
    // в условии следует указать, что факториал числа "0" тоже равен единице
    else return n * FactorialRec(n - 1);
    // возврат произведения "n" на число, меньше "n" на единицу
}

System.Console.WriteLine(FactorialFor(10)); // 3628800
System.Console.WriteLine(FactorialRec(10)); // 3628800



// 00:09:00
// Вычислить "a" в степени "n"

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{   // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // <- вариант записи в одну строку
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n) // Сокращённое возведение в степень (см. скриншот "13_(Л-07)_img")
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    // при чётном показателе степени, число умножаем на себя, уменьшая в два раза показатель степени
    else return PowerRecMath(a, n - 1) * a; // иначе, 
}

System.Console.WriteLine(PowerFor(2, 10)); // 1024
System.Console.WriteLine(PowerRec(2, 10)); // 1024
System.Console.WriteLine(PowerRecMath(2, 10));


// 00:12:00
// Перебор слов

char[] s = { 'a', 'b', 'c', 'd'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
            }
        }
    }
}


// 00:16:00

// Общее решение задачи перебора слов
// Рекурсия избавляет от привязки к количеству циклов, набираемых руками

int m = 1;
void FindWords(string alphabet, char[] word, int length = 0)
// "void FindWords" - метод, принимающий алфавит
// "string alphabet" - строка, куда будет производится запись
// "char[] word" - массив из букв, составляющих новое слово
// "int length" - длина слова на текущей итерации
{
    if (length == word.Length) // Условие выхода: длина слова совпала с указанным значением
    {
        System.Console.WriteLine($"{m++} {new String(word)}"); return; // вывод слова
    }
    for (int i = 0; i < alphabet.Length; i++) // Цикл сбора нового слова, по заданным буквам
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
    System.Console.WriteLine();
}

FindWords("фыва", new char[3]); // Буквы и длина слова заданы заранее

System.Console.Write("Input length: "); // ввод длины слова
int word = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input letters: "); // ввод набора букв, составлющих слово
// Не выводит на экран кирилицу (???)
string alph = Console.ReadLine(); 
FindWords(alph, new char[word]);



// 00:20:00

// Директория
// Вызов даты и времени создания объекта, просмотр содержимого

string path = "C:/Users/Vitaliy/GeekBrains/13_Examples/Example001_HelloConsole"; // путь к папке
DirectoryInfo di = new DirectoryInfo(path); // "DirectoryInfo" - класс обращения к папкам
System.Console.WriteLine(di.CreationTime); // дата и время создания вызванной папки ("di")
FileInfo[] fi = di.GetFiles(); // "FileInfo" - класс обращения к файлам выбранной папки
// Конструкция "GetFiles" позволяет просмотреть (перебрать) файлы в указанной папке

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name); // <- вызов конкретного элемента массива ("fi[i]"), 
    // с нужными нам свойствами, например, "Name" (имя)
}


// 00:23:00

// Рекурсия для перемещения по папкам

void CatalogInfo(string path2, string index = "") // путь ("path") и отступ (index = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path); 
    // директория "catalog", в которую зашли по указанному пути "path" (перенесён вниз)

    DirectoryInfo[] catalogs = catalog.GetDirectories(); // массив всех файлов папки
    for (int i = 0; i < catalogs.Length; i++) // пробегаем по всему массиву
    {
        System.Console.WriteLine($"{index}{catalogs[i].Name}"); // вывод нинформации о каталоге
        CatalogInfo(catalogs[i].FullName, index + " "); // рекурсивный просмотр полученых файлов 
    }
    FileInfo[] files = catalog.GetFiles(); // весь список файлов текущей директории (каталога)

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{index}{files[i].Name}"); // вывод результата на экран
    }
}
string path2 = @"/Users/Vitaliy/GeekBrains/13_Examples/Example001_HelloConsole"; 
CatalogInfo(path2);



// 00:27:00
// "Ханойские башни"

void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count - 1);
    System.Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();



// 00:29:00
// Обход структур
// https://en.wikipedia.org/wiki/Tree_traversal - "Обход дерева" (статья)

string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos; // Левая часть равна "2i" (i = pos)
        int rigth = 2 * pos + 1; // Правая - "2i + 1" 
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
         // Если в левом поддереве не вышли за границы и элемент не является пустым ("emp"),
         // то программа выполняет рекурсивный обход текущей левой позиции
        Console.Write(tree[pos] + " "); // вывод узла (значение - операция или число)
        if (rigth < tree.Length && !String.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
         // аналогично для правого поддерева
    }
}
InOrderTraversal();


// 00:38:26

// Числа Фибоначчи
// Нахождение последовательности двумя методами, рекурсивным и итерационным

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int k)
{
    fRec++;
    return k == 0 || k == 1 ? 1 : FibonacciRecursion(k - 1) + FibonacciRecursion(k - 2);
    // Краткая запись конструкции "if", "else", означает следующее:
    // При "n" равном 0 или 1, возвращает 1 (единицу),
    // в других случаях, возвращает выражение, указанное после двоеточия (:)
}

decimal FibonacciIteration(int k)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= k; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();

DateTime dt = DateTime.Now;
for (int k = 1; k < 40; k++)
{
    Console.WriteLine($"FibonacciIteration({k}) = {FibonacciIteration(k)} fIte = {fIte}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

System.Console.WriteLine();
Console.ReadLine();

dt = DateTime.Now;
for (int k = 1; k < 40; k++)
{
    Console.WriteLine($"FibonacciRecursion({k}) = {FibonacciRecursion(k)} fRec = {fRec}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


// Ускорение рекурсии Фибоначи (Метод 3)
// Нужно написать алгоритм, который, для получения нового числа Фибоначи, 
// не пересчитывает всё занаово, а использует только последние два найденных числа.

// То, что ниже - чуть более длинная запись той же самой рекурсии, которая считает так же долго.

decimal fRec2 = 0;
decimal FibonacciRecFast(int k)
{
    fRec2++;
    if (k == 0 || k == 1) return 1;
    else
    {
        return FibonacciRecFast(k - 1) + FibonacciRecFast(k - 2);
    }
}

System.Console.WriteLine();
Console.ReadLine();

dt = DateTime.Now; // Счётчик времени работы метода
for (int k = 0; k < 40; k++)
{
    Console.WriteLine($"FibonacciRecursionFast({k}) = {FibonacciRecFast(k)} fRec2 = {fRec2}");
    fRec2 = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); 
// вывод разности начала и конца работы программы


// 00:46:30

// Закрашивание прямоугольной области

int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}

PrintImage(pic);
FillImage(1,1);
System.Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            // System.Console.WriteLine($"{image[i, j]} ");
            if (image[i, j] == 0) System.Console.Write($" ");
            else System.Console.Write($"+");
        }
        System.Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] =1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}