// Знакомство с языками программирования (лекции)
// Урок 6. Как не нужно писать код: принципы и антипаттерны
// https://gb.ru/lessons/362975

// 00:23:20

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

DrawText("Intensive C# Demo text", 629, 360); // Непонятные числа!


// 00:26:56
// Улучшение кода

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length / 2);
int screenHeightPosition = Console.WindowHeigth / 2;

DrawText(caption, screenWidthPosition, screenHeightPosition);

DrawText(
    text: caption, 
    left: screenWidthPosition, 
    top: screenHeightPosition
    );