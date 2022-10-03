
// урок 6 ютуба. конвертация строки в др. типы. исправление введеннной точки на запятую.

using System.Globalization;
string str = "1.9";

NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
{
    NumberDecimalSeparator = ".",
};


double a = Convert.ToDouble(str, numberFormatInfo);

System.Console.WriteLine(a);


