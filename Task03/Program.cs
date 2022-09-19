// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int functionAkkerman = Ack(m, n);

Console.Write($"The Akkermann function = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ack(m - 1, 1);
    if (m > 0 && n > 0) return Ack(m - 1, Ack(m, n - 1));
    return Ack(m,n);            
}