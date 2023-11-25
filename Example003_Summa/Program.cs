// Знакомство с языками программирования (лекции)
// Урок 1. Знакомство с языком программирования C#
// https://gb.ru/lessons/362970#s951

// В математике множество всех целых чисел обозначают буквой "Z".
// Множество действительных чисел Обозначают буквой "R".

// В C# (CSharp) есть свои обохначнения для различных типов данных:
// int - целые числа
// double - вещественные числа (дроби)
// string - строка
// bool - логичекий тип данных (falce /ложь/, true /истина/)

// Ручной ввод значений
int numberA = 31;
int numberB = 5;
int result = numberA + numberB;
System.Console.WriteLine(result);

// Ввод значений с поимощью генератора случайных чисел "Random()"
int numberA2 = new Random().Next(1, 10); // 1 2 3 ... 9
System.Console.WriteLine(numberA2);
int numberB2 = new Random().Next(1, 10);
System.Console.WriteLine(numberB2);
int result2 = numberA2 + numberB2;
System.Console.WriteLine(result2);