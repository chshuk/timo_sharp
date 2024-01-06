Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = -n;

while (i <= n)
{
    Console.Write(i + " ");
    i++;
}