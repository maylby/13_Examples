// 13_(Л-02)
// Лекция 2. Знакомство с функциями и массивами

// 0:12:00
// Задача 1
// * Решение с помощью функций

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
int a2 = 12;
int b2 = 23;
int c2 = 32123;
int a3 = 13;
int b3 = 2113;
int c3 = 313;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);

// * Решение стихийным методом

// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Console.WriteLine(max1); // Строка используется для обоих приведённых выше методов