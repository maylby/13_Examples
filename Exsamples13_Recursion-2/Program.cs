// 13_(Л-07) Рекурсия продолжение
// Урок 7. Дополнительная лекция. Рекурсия: продолжение
// <https://gb.ru/lessons/362976>

// 00:04:30

// Собрать строку с числами от меньшего к большему, от a до b, a <= b

// Код:

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = 0; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// System.Console.WriteLine(NumbersFor(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
// System.Console.WriteLine(NumbersRec(1, 10)); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10


// 00:06:30

// Собрать строку с числами в обратном порядке, от большего к меньшему

// Код:

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = 0; i >= b; i--) // Меняем "<=" на ">=" и "i++" на "i--"
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; // Здесь, метод "NumbersRec" ставим впереди
//     else return String.Empty;
// }

// System.Console.WriteLine(NumbersFor(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
// System.Console.WriteLine(NumbersRec(1, 10)); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1


// 00:07:00
// Сумма чисел от 1 до N

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
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
//     if (n == 1) return 1; // <- условие выхода из рекурсии -> N = 1
//     else return n * FactorialRec(n - 1);
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
//     else return PowerRecMath(a, n - 1) * a;
// }

// System.Console.WriteLine(PowerFor(2, 10)); // 1024
// System.Console.WriteLine(PowerRec(2, 10)); // 1024
// System.Console.WriteLine(PowerRecMath(2, 10));


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
                System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]{s[l]}}");
            }
        }
    }
}
