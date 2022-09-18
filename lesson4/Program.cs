/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.WriteLine("Введите число");
int numberUser = Convert.ToInt32(Console.ReadLine());
int num = 1;

while (num <= numberUser)
{
    if (num % 2 == 0)
    {
        Console.Write($"{num}, ");
    }
num++;
}
