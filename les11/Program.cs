// урок 11 Инкремент и дикремент. Постфиксный и префиксный

/*int a = 1;
a = ++a * a;
System.Console.WriteLine(a);*/

// урок 12 операторы отношений. операции сравнения.

/*== равно
!= не равно
> больше
< меньше
>= больше или равно
<= меньше или равно*/
/*int a = 4;
int b = 5;
System.Console.WriteLine(a==b);
System.Console.WriteLine(a!=b);
System.Console.WriteLine(a>b);
System.Console.WriteLine(a<b);
System.Console.WriteLine(a>=b);
System.Console.WriteLine(a<=b);*/

// урок 13 конструкция if else

/*if (утверждение или выражение)
{
    действие 1
}
else
{
    действие 2
}*/
/*bool isInfected = false;
if (isInfected)
{
    System.Console.WriteLine("Персонаж инфецирован!");
}
else
{
    System.Console.WriteLine("Персонаж здоров!");
}*/

/*int a;
a = int.Parse(Console.ReadLine());
if (a == 5)
{
    System.Console.WriteLine("a равно 5");
}
else
{
    System.Console.WriteLine("a не равно 5");
}*/

// урок 14 логические операторы

//&& сокращенное И
//& И
//|| сокращенное ИЛИ
// | ИЛИ
// ! НЕ

/*bool isInfected = true;//false;
if (!isInfected)
{
    System.Console.WriteLine("Персонаж здоров!");
}
else
{
    System.Console.WriteLine("Персонаж инфицирован!");
}*/

bool GetTemperature()
{
    return true;
}
bool GetCoolingStatus()
{
    return true;
}
    if (GetTemperature() | GetCoolingStatus())
    {
        System.Console.WriteLine("Угроза повреждения процессора!");
    }

/*int fanSpeen = 0;
bool isHighTemperature = false;
bool hasNoCooling = fanSpeen <= 0;
if (isHighTemperature || hasNoCooling)
{
    System.Console.WriteLine("Угроза повреждения процессора!");
}*/

