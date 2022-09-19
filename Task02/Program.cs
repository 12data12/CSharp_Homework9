// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Enter M (beginning of the bucket): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N (ending of the bucket): ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (m <= n)
{
    Console.WriteLine("Ooops...Entered numbers are incorrect");
}
if (m < n)
{
    while(m <= n)
    {
        Console.Write(m + " ");
        sum += m;
        m++;
    }
    Console.WriteLine();
    Console.WriteLine("Sum is " + sum);
}
else
{
    while (n <= m)
    {
        Console.Write(n + " ");
        sum += n;
        n++;
    }
    Console.WriteLine();
    Console.WriteLine("Sum is " + sum);
}