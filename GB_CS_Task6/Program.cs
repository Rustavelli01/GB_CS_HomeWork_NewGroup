﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//--------------------------Схема-----------------------
//1. Задать числа
//2. Сравинить заданные числа
//3. Выдать результат
//-------------------------Решение---------------------


Console.Clear();

Console.WriteLine("Я кибер мозг, дайте мне число: ");
int userInput = Convert.ToInt32(Console.ReadLine());
int num = userInput % 2;
Console.WriteLine("Обрабатываю. . .");
Console.WriteLine(" .");
Console.WriteLine(" .");
Console.WriteLine(" .");
Console.WriteLine(" .");
Console.WriteLine(" ."); // Хотел сделть здесь небольшую паузу, для вида как обрабатывается информация. но как то все быстро происходит:-D
Console.Clear();
if (num == 0)
{
    Console.Write($"#{userInput} -> Это число ЧЕТНОЕ!");
}
else
{
    Console.Write($"#{userInput} -> Это число НЕ ЧЕТНОЕ!");
}
