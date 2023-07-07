Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int Num = 0;
while (Num < number)
{
    Num = (Num + 2);
    Console.Write(Num);
}