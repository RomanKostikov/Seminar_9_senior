// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    Console.Clear();
    Console.WriteLine("Return number M:");
    int M = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Return number N:");
    int N = int.Parse(Console.ReadLine()!);
    Console.WriteLine("The sum of the natural numbers between M and N:");
    Console.WriteLine(NumbersSumm(M, N));
}
int NumbersSumm(int m, int n)
{
    if (m > n) return 0;
    else return m + NumbersSumm(m + 1, n);
}
Main();