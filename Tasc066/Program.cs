// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("M= ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N= ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(M,N));

int SumNumbers (int start, int end)
{
    if (start==end) return start++;
    return (start + SumNumbers(start+1, end));
}