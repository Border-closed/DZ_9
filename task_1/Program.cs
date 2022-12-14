// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//  Ввод числа N пользователем
Console.WriteLine("Введите натуральное число N");
int N = int.Parse(Console.ReadLine());

// Метод определения ряда натуральных чисел (рекурсия)
int res (int N)
{
    if (N==1)
    {
        return 1;
    }
    return  1 + res (N-1);
}

// Вывод результата
Console.Write("Промежуток чисел от N до 1:  ");
for (int i = N; i > 0; i--)
{
    Console.Write(res(i));
    Console.Write(", ");
}