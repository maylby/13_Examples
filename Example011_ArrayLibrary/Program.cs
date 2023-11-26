// Знакомство с языками программирования (лекции)
// Лекция 2. Знакомство с функциями и массивами
// https://gb.ru/lessons/362971#s951

// 0:33:00

// * Код Метода создания массива

// void FillArray(int[] collection) // "void" - метод, который ничего не возвращает
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         // В агрумент "collection" на позицию "index" положить новое случайное целое число от 1 до 10
//         index++; // В методе "void" не применим оператор "return"
//     }
// }

// // * Код вывода массива в печать (на экран)

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position] + " ");
//         position++;
//     }
// }

// // * Метод поиска позиции заданного элемента в массиве

// // Код отработал с ошибками, результат не выдан

// int IndexOf(int collection, int find)
// {
//     int count = collection.Length; // "int" не содержит определения "Length", 
//     // и не удалось найти доступный метод расширения "Length", 
//     // принимающий тип "int" в качестве первого аргумента 
//     // (возможно, пропущена директива using или ссылка на сборку)
//     int index = 0;
//     int position = -1; // "-1" выводится на экран, в случае отсутствия элемента в массиве
    
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break; // Завершить, как только будет найдена позиция первого заданного элемента
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10]; // "new int[10]" означает: создать новый массив из 10 элементов

// FillArray(array); // Методу "FillArray" передаём массив "array"
// PrintArray(array); // "PrintArray" распечатает переданный массив
// Console.WriteLine(); // Пустая строка для разделения массива и индекса искомого элемента

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);

