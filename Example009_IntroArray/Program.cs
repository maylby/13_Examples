// Лекция 2. Знакомство с функциями и массивами

// 0:21:30
// * Массивы

// Задача 1
// * Решение с помощью функций

// Пишем код поиска максимума из трёх аргументов
// Наличие кода, позволяет вносить необходимые правки в запись в одном месте
// Решение стало более универсальным 

int Max(int arg1,int arg2, int arg3)
{
    int resalt = arg1;
    if(arg2 > resalt) resalt = arg2;
    if(arg3 > resalt) resalt = arg3;
    return resalt;
}

int a1 = 13;
int b1 = 21;
int c1 = 39;
int a2 = 1211111;
int b2 = 23;
int c2 = 32123;
int a3 = 13;
int b3 = 2113;
int c3 = 313;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
