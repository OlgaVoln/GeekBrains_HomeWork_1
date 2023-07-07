Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше {numberB}");
}
if (numberA < numberB)
{
    Console.WriteLine($"Число {numberA} меньше {numberB}");
}
else
{
    Console.WriteLine("Числа равны");
}
