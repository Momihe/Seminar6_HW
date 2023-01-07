/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

void max(int[] array)
{
    int i = 0;
    foreach (int element in array)
    {
        if (element > 0) i++;
    }
    Console.Write($"Количество чисел больше нуля равно: {i}");
}

Console.Clear();
Console.Write("Введите элементы массива: ");
int[] array = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
max(array);
