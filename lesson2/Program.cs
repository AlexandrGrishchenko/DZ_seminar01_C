// Максимальное трех RANDOM чисел

Console.Clear();
int number1 = new Random().Next (1, 101);
Console.WriteLine(number1);
int number2 = new Random().Next (1, 101);
Console.WriteLine(number2);
int number3 = new Random().Next (1, 101);
Console.WriteLine(number3);

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"Максимальное число {max}");
