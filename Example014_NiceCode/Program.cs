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
// Смысл: Позиция по длине экрана равна разности длины экрана и длины строки делённой пополам 
int screenHeightPosition = Console.WindowHeigth / 2; // Аналогично с позицией по высоте

DrawText(caption, screenWidthPosition, screenHeightPosition); 
// Передаём полученные значения методу для последующей обработки
// Ниже, разделение кода на смысловые составляющие для удобства последующей работы
DrawText(
    text: caption, 
    left: screenWidthPosition, 
    top: screenHeightPosition
    ); // Логика кода стала более понятной