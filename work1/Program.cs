//Найти кубы чисел от 1 до N.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
while (count <= number)
{
    int res = count*count*count;
    Console.WriteLine($"{res} куб {count}");
    count++;
}