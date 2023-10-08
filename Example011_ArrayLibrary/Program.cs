// Лекция 2. Знакомство с функциями и массивами

// 0:33:00

// * Код создания массива

void FillArray(int[] collection) // "void" - метод, который ничего не возвращает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // В агрумент "collection" на позицию "index" положить новое случайное целое число от 1 до 10
        index++; // В методе "void" не применим оператор "return"
    }
}

// * Код вывода массива в печать (на экран)

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[10]; // Смысл конструкции "new int[10]" - создать новый массив из 10 элементов

FillArray(array); // Методу "FillArray" передаём массив "array"
PrintArray(array); // "PrintArray" распечатает переданный массив

