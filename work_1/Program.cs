/* 
Задайте значения M и N. 
Напишите программу, которая выведет 
все чётные натуральные числа 
в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

void ShowNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
    if (numberM % 2 == 0) System.Console.Write($"{numberM} ");
    else
    {
        numberM++;
        System.Console.Write($"{numberM} ");
    }
    ShowNumbers(numberM + 2, numberN);
}

Console.Write("Ввеод числа M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввод числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"M = {m}; N = {n} ->");
if (m < n) ShowNumbers(m, n);
else System.Console.WriteLine("Не верные значения");