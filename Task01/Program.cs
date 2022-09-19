// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Enter M (beginning of the bucket): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N (ending of the bucket): ");
int n = Convert.ToInt32(Console.ReadLine());

if (m == 0 || n == 0)
{
    Console.WriteLine("Ooops...Entered numbers are incorrect");
}
while(m <= n)
{
    Console.Write(m + " ");
    m++;
}