/* Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/* Решение 1
int InputIntNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintResult(int Num)
{
     if (Num > 1)
     {
        Console.Write(Num + ", ");
        PrintResult(Num - 1);
     }
     else
     {
        Console.Write(Num);
     }
}

int Num = InputIntNum("Введите целое число: ");
Console.Write("N=" + Num + " -> '");
PrintResult(Num);
Console.Write("'");
*/

/* Тест 1
PS D:\Home_Works\CS_HW_9> dotnet run
Введите целое число:  5
N=5 -> '5, 4, 3, 2, 1'
PS D:\Home_Works\CS_HW_9> dotnet run
Введите целое число:  8
N=8 -> '8, 7, 6, 5, 4, 3, 2, 1'
*/

/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/* Решение 2
int InputIntNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int Summ(int M, int N)
{
     if (M == N)
     {
        return N;
     }
     else
     {
        return M + Summ(M + 1,N);
     }

}

int M = InputIntNum("Введите стартовое число: ");
int N = InputIntNum("Введите конечное число: ");
Console.Write("M="+ M + "; N=" + N + " -> ");
Console.Write(Summ(M, N));
*/

/* Тест 2
PS D:\Home_Works\CS_HW_9> dotnet run
Введите стартовое число:  1
Введите конечное число:  15
M=1; N=15 -> 120
PS D:\Home_Works\CS_HW_9> dotnet run
Введите стартовое число:  4
Введите конечное число:  8
M=4; N=8 -> 30
*/

/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/* Решение 3
int InputIntNum(string message) //ввод целочисленных чисел
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int M, int N)
{
    if (M == 0) 
    {
        return N + 1;
    }
    else if (N == 0) 
    {
        return Akkerman(M - 1, 1);
    }
    else 
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }
}


int M = InputIntNum("Введите значение M: ");
int N = InputIntNum("Введите значение N: ");

Console.Write($"Функция Аккермана равно {Akkerman(M, N)} ");
*/

/* Тест 3
PS D:\Home_Works\CS_HW_9> dotnet run
Введите значение M:  2
Введите значение N:  3
Функция Аккермана равно 9 
PS D:\Home_Works\CS_HW_9> dotnet run
Введите значение M:  3
Введите значение N:  2
Функция Аккермана равно 29 
*/