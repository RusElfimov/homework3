//Подсчитать сумму цифр в числе.
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "0");
int res = 0;
while (number/ 10 != 0 || number % 10 != 0)
{
    res = res + (number % 10);
    number = number / 10;
}
if (res < 0) res=res*-1;
Console.WriteLine($"Сумма чисел {res}");
