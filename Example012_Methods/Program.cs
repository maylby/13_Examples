// Знакомство с языками программирования (лекции)
// Урок 3. Функции: продолжение
// https://gb.ru/lessons/362972


// Вид 1 Не принимающий и не возвращающий метод
void Method1()
{
    System.Console.WriteLine("Автор ...");
}
Method1(); // вызов метода


// Вид 2 Принимающий, но не возвращающий метод
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения"); // вызов метода

// Вид 2.1 Именованный метод (принрмает, но не возвращает)
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        count++;
    }
}
Method2("Текст", 4) // вызов метода



