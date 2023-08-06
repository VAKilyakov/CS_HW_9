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

