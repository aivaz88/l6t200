// Задача 2*. Написать программу, которая принимает от пользователя положительные числа и считает среднее значение этих чисел.
// Ввод числе осуществляется до тех пор, пока пользовател не введёт -1. Ввод чисел и расчёт должен происходит в рекурсии

Console.Clear();
Console.WriteLine("Воведите целые положительные числа поочередно: ");
AverageValue();


void AverageValue(double sum = 0, double count = 0, double averageVal = 0)
{
    double number = double.Parse(Console.ReadLine()!);
    if (number > -1) AverageValue(sum = sum + number, ++count);
    else Console.WriteLine($"Среднее значение равно: {sum / count}");
}