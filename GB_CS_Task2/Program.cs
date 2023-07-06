// Задача 2: Напишите программу, которая на вход приминиает два числа и выдает, какое число больше, а какое меньше.


Console.Clear();
Console.Write("Ваше первое число, Хозяин!: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Ваше второе число, Хозяин!: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.Write($"Хозяин, Ваше первое число: " + A + ", больше второго: " + B);
}
else
{
    Console.Write($"Хозяин, Ваше первое число: " + A + ", меньше второго: " + B);
}