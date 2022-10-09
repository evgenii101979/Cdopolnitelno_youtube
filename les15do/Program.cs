// урок 15 условный оператор switch


/*int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1:
    /*System.Console.WriteLine("Вы ввели число 1 ");// свитч смотрит по номеру кейса и введенному числу совпадение
    break;*/
/* case 2:
     System.Console.WriteLine("Вы ввели число 1 или 2 ");
     break;
 default:
     System.Console.WriteLine("ХЗ что вы ввели ");
     break;
}*/

// вариант со строками

/*string a = Console.ReadLine();
switch (a)
{
    case "+":
        System.Console.WriteLine("Вы ввели + ");// свитч смотрит по номеру кейса и введенному числу совпадение
        break;
    case "-":
        System.Console.WriteLine("Вы ввели - ");
        break;
    default:
        System.Console.WriteLine("ХЗ что вы ввели ");
        break;
}
*/

// вариант 
static void Main(string[] args)   //должна выдавать список кейсов клавиатуры
{
    ConsoleKey consoleKey = Console.ReadKey().Key;
    switch (consoleKey)
    {
        default:
    }
}
