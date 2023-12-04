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


// 00:29:00
// Инициализация строки (переменной)

string label = ""; // не правильный (малопонятный) способ инициализации переменной
string address = String.Empty; // инициализация в виде константы "Пустая строка" ("String.Empty")


// 00:29:00
// Копипаст кода

// Пример 1
double a = 1, b = -26, c = 120;
var d = b * b - 4 * a * c;
double x1 = (-b + Math.Sgrt(d)) / (2 * a);
double x2 = (-b + Math.Sgrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

// Пример 2
a = 2, b = 1, c = -3;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sgrt(d)) / (2 * a);
x2 = (-b + Math.Sgrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

// Пример 3
a = 1, b = 1, c = -6;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sgrt(d)) / (2 * a);
x2 = (-b + Math.Sgrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");



