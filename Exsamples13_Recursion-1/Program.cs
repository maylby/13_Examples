// // Знакомство с языками программирования (лекции)
// // Урок 4. Рекурсия и двумерные массивы
// // https://gb.ru/lessons/362973

// // string[,] table = new string[2, 5];
// // // String.Empty - иниицализация строк
// // // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] // строка 1 (index = 0), index столбцов от 0 до 5
// // // table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] // строка 2 (index = 1), index столбцов тот же

// // table[1, 2] = "слово";

// // for (int rows = 0; rows < 2; rows++)
// // {
// //     for (int column = 0; column < 5; column++)
// //     {
// //         Console.WriteLine($"-{table[rows, column]}-");
// //     }
// // }

// // 00:07:00
// // Числа в таблице 

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// // 00:10:00
// // Метод печати (вывод на экран)

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine();


// // 00:11:45
// // Метод заполнения таблицы произвольными значениями

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10); // [1; 10) - полуинтервал (?) от 1 до 10
//         }
//     }
// }

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// // 00:14:00

// // 00:19:30
// // Закрашиваем замкнутую область (контур)

// int[,] pic = new int[,] // под этой строкой должны быть размещены данные рисунка

// // Метод печати

// void PrintImage(int[,] image) 
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }


// // Метод заполнения массива

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         // Ниже рекурсия, метод вызывает сам себя
//         FillImage(row - 1, col); // Шаг вверх 
//         FillImage(row, col - 1); // Шаг влево
//         FillImage(row + 1, col); // Шаг вверх
//         FillImage(row, col + 1); // Шаг вправо
//     }
// }

// PrintImage(pic);
// FillImage(13, 13); // точка старта (произвольно выбранная)
// PrintImage(pic);


// 00:25:00
// Рекурсия

// Факториал числа
// 5! = 5*4*3*2*1
    // 5*4!
        // 4*3!
            // 3*2!
                // 2*1!

double Factorial(int n) // заменил тип данных "int" на "double" для больших чисел
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
