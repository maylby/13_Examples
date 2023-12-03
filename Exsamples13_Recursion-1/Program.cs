﻿// Знакомство с языками программирования (лекции)
// Урок 4. Рекурсия и двумерные массивы
// https://gb.ru/lessons/362973

string[,] table = new string[2, 5];
// String.Empty - иниицализация строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] // строка 1 (index = 0), index столбцов от 0 до 5
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] // строка 2 (index = 1), index столбцов тот же

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.WriteLine($"-{table[rows, column]}-");
    }
}