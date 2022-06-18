// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int count = 2;
if(N>0)
{
   while(count < N)
{
    Console.Write($"{count} ");
    count += 2;
} 
}
else
{
    Console.Write($"Число {N} меньше нуля, задача невыполнима");
}

