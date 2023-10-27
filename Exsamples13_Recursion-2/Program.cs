// 13_(Л-07) Рекурсия продолжение

// 00:04:30

// Собрать строку с числами от a до b, a <= b

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

System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine(NumbersRec(1, 10));
