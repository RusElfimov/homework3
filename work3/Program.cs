// Написать программу вычисления произведения чисел от 1 до N.
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "0");
int sch = 1;
for (int i=1; i<=number;i++)
{
sch = sch * i;
Console.WriteLine(sch);
}