// урок 7- ютуба. 
//1. преобразование строк parse и tryparse.


string str = "100";
int a;
bool result = int.TryParse(str, out a);

if (result)
{
    System.Console.WriteLine("Операция успешна " + a);
}
else
{
    System.Console.WriteLine("Не удалось конвертировать");
}
