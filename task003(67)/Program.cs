// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

void Main()
{
    Console.Clear();
    int newNumber = 1;
    Console.WriteLine("Return number: ");
    int number = int.Parse(Console.ReadLine()!);
    int result = SumDigital(number);
    Console.Write(result);
}
    int SumDigital(int number)
    {
        if (number == 0) return 0;
        return number % 10 + SumDigital(number / 10);
    }

Main();