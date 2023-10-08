// Лекция 2. Знакомство с функциями и массивами


// 0:21:30
// * Массивы

// Задача 1

// Пишем код поиска максимума из трёх аргументов
// Наличие кода, позволяет вносить необходимые правки в запись в одном месте
// Решение стало более универсальным 

int Max(int arg1,int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} //            0   1   2    3   4    5     6   7     8 // индексы массива
int[] array = {11, 21, 31, 411, 15, 612, 1117, 18, 1911};

// можно дать любое имя переменной, присваивающей значение "Max(...)",
// например, изменить "max" на "result"
// int max = Max( 
int result = Max(
Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8])
);
// Console.WriteLine(max);
Console.WriteLine(result);
