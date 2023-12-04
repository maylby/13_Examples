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


// 00:33:10
// Отдельный метод вместо копипаста кода

public Roots Solve(double a, double b, double c) 
// Метод принимает три коэффициента и возвращает корни
{
    var d = b * b - 4 * a * c;
    double x1 = (-b + Math.Sgrt(d)) / (2 * a);
    double x2 = (-b + Math.Sgrt(d)) / (2 * a);
    return new Roots {X1 = x1, X2 = x2};
}
// Написать метод и трижды его использовать, лучше, чем трижды копипастить код

// 00:41:00
// Пример кода
// Увеличение значения заданных координат

using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,5)" // строка, содержащая 4 точки
                .Replace("(", "") // заменяем отрывающую скобку на пробел
                .Replace(")", "") // заменяем закрывающую скобку на пробел
                ;
Console.WriteLine(text); // в результате получаем строку без скобок 

var data = text.Split(" ") // разбиваем строку на составляющие, исключая пробел
// тип данных "var" позволяет работать с заранее неизвестным типом переменных
                .Select(item => item.Split(',')) // разделяем каждую пару чисел запятой,
                // получаем массив из двух чисел, двух координат по осям X и Y
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // -> заменяет внутренний цикл "k",
                .Where(e => e.x % 2 == 0) // выбрать, только координаты с чётным значением
                .Select(point => (point.x * 10, point.y + 10)) // формирует из массива массивов массив кортежей
                // данные об изменении значений координат заданы в коде
                .ToArray(); // результат оформляем, как массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]); // <- изъял из вывода ".Item1*10"
    // 4 строки, содержащих координату каждой точки
    // добавление в запись ".Item1*10" увеличивает первую координату в 10 раз
    // данное указание не требуется, если оно внесено в ".Select(point => (...))"

    // for (int k = 0; k < data[i].Length; k++)
    // // внутренний цикл "k" нужен, если отсутствует "int.Parse()" (см. выше)
    // {
    //     Console.Write(data[i][k]); // "data[i][k]" - это подмассив массива "data[i]"
    // }
    // Console.WriteLine(); // пробел для разделение каждой пары координат
}
