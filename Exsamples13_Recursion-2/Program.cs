// 13_(Л-07) Рекурсия продолжение
// Урок 7. Дополнительная лекция. Рекурсия: продолжение
// <https://gb.ru/lessons/362976>

// 00:04:30

// Собрать строку с числами от меньшего к большему, от a до b, a <= b

// Код:

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = 0; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

System.Console.WriteLine(NumbersFor(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
System.Console.WriteLine(NumbersRec(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10


// 00:06:30

// Собрать строку с числами в обратном порядке, от большего к меньшему

// Код:

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = 0; i >= b; i--) // Меняем "<=" на ">=" и "i++" на "i--"
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; // Здесь, метод "NumbersRec" ставим впереди
    else return String.Empty;
}

System.Console.WriteLine(NumbersFor(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
System.Console.WriteLine(NumbersRec(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1