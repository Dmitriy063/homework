// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numC = int.Parse(Console.ReadLine());
if (numA > numB && numA > numC)
{
    Console.Write($"Максимальное число {numA}");
}
if (numB > numC && numB > numA)
{
    Console.Write($"Максимальное число {numB}");
}
if(numC > numB && numC > numA)
{
    Console.Write($"Максимальное число {numC}");
}
