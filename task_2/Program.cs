// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//  Ввод числа N и M пользователем
Console.WriteLine("Введите натуральное число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int N = int.Parse(Console.ReadLine());

int sum = 0;
for (int x = M; x < N+1; x++)
    {
     sum = sum+x;   
    }
Console.WriteLine("Сумма числел от " +M + " до " +N+" = "+sum);