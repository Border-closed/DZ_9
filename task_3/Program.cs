// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//  Ввод числа N и M пользователем
Console.WriteLine("Введите натуральное положительное число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное положительное число N");
int N = int.Parse(Console.ReadLine());

//Проверка
if (M>0 & N>0)
{

//Нахождение функции Аккермана
int Akk (int M, int N)
{
    if (M==0)
    {
        return N+1;
    }
    else if (M>0 & N==0)
    {
        return Akk(M-1,1);
    }
    return  Akk(M-1, Akk(M,N-1));
}

// Вывод результата
Console.WriteLine("Функция Аккермана от "+M+" и "+N+" :  "+Akk(M,N));

}
else
{
    Console.WriteLine("Вы ввели отрицательные числа");
}