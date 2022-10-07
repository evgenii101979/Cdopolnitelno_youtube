// урок 10 Несколько проектов в одном решении

// дз 1 среднее арифметическое 2 чисел

/*double firstValue, secondValue;
Console.WriteLine("Введите число 1 ");
firstValue = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число 2 ");
secondValue = double.Parse(Console.ReadLine());
double result = (firstValue + secondValue) / 2;
System.Console.WriteLine("среднее арифметическое 2 чисел = " + result);*/

// дз 2 ввести 3 числа и вывести значение суммы и произведения этих чисел

/*double firstValue, secondValue, therdValue;
Console.WriteLine("Введите число 1 ");
firstValue = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число 2 ");
secondValue = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число 3 ");
therdValue = double.Parse(Console.ReadLine());
double sumResult = firstValue + secondValue + therdValue;
double multResult = firstValue * secondValue * therdValue;
System.Console.WriteLine("Сумма 3 чисел = " + sumResult);
System.Console.WriteLine("Произведение 3 чисел = " + multResult);*/

// дз 3 напишите простой конвертер валют (без возможности
// динамического выбора валюты пользователем).
// валюты заданы хардкором и не изменяются. Тип валют на выбор программиста.

double UsdToRub = 55.36;
double UsdToEvro = 0.95;
double USD;
System.Console.WriteLine("введите сумму в USD ");
USD = double.Parse(Console.ReadLine());
System.Console.WriteLine(USD + " USD в RUB = " + USD * UsdToRub);
System.Console.WriteLine(USD + " USD в EVRO = " + USD * UsdToEvro);


