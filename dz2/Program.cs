// проверка числа на четность
System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    System.Console.WriteLine("Число " +a +" четное");
}
else
{
    System.Console.WriteLine("Число " +a +" нечетное");
}