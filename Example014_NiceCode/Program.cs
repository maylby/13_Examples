// Знакомство с языками программирования (лекции)
// Урок 6. Как не нужно писать код: принципы и антипаттерны
// https://gb.ru/lessons/362975

// 00:23:20

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

DrawText("Intensive C# Demo text", 629, 360);