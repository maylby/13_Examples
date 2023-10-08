// Лекция 2. Знакомство с функциями и массивами

// 0:33:00

int[] array = new int[10]; // Смысл конструкции "new int[10]": создать новый массив из 10 элементов

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // В агрумент "collection" на позицию "index" положить новое случайное целое число от 1 до 10
        index++;
    }
}