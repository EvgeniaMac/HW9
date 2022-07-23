// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.Write("Введите положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int start, int end)
{
    if (start == 0) return end + 1;
    if (start > 0 && end==0) return AckermanFunction(start- 1, 1);
    return (AckermanFunction(start-1, +AckermanFunction(start, end-1)));


}
Console.WriteLine(AckermanFunction(M, N));