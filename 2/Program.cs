Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = int.Parse(Console.ReadLine());
int numberMax = 0;

if (numberA > numberB)
{
    numberMax = numberA;
}
else
{
    numberMax = numberB;
}

if (numberMax < numberC)
{
    numberMax = numberC;
}

Console.WriteLine(numberMax);
