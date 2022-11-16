// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void Main()
{
    Console.Clear();
    Console.WriteLine("Return number N:");
    int number = int.Parse(Console.ReadLine()!);
    EvenNumber(number);
}
void EvenNumber(int n)
{
    if (n <= 1) return;
    else
    {
        if (n % 2 == 0)
        {
            Console.Write($"{n}, ");
            EvenNumber(n - 2);
        }
        else
        {
            n--;
            Console.Write($"{n}, ");
            EvenNumber(n - 2);
        }

    }
}
Main();