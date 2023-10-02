// Сложение двух целых чисел

// int numbrerA = 3;
// int numbrerB = 7;
// int result = numbrerA + numbrerB;
// Console.WriteLine(result);


// Сложение двух целых случайных чисел
// "Random" - генератор случайных чисел

int numbrerA = new Random().Next(1, 10); // 1 2 3 ... 9
Console.WriteLine(numbrerA);
int numbrerB = new Random().Next(1, 10);
Console.WriteLine(numbrerB);
int result = numbrerA + numbrerB;
Console.WriteLine(result);