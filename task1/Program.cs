// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Не использовать строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int value1 = Prompt("Введите пятизначное число > ");
if (value1 > 10000 && value1 < 100000)
{
    int number1 = value1 % 10;
    int value2 = value1 / 10;
    int number2 = value2 % 10;
    int value3 = value2 / 10;
    int number3 = value3 % 10;
    int value4 = value3 / 10;
    int number4 = value4 % 10;
    int value5 = value4 / 10;
    int number5 = value5;
    int result = number1 * 10000 + number2 * 1000 + number3 * 100 + number4 * 10 + number5;
    if (value1 == result)
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}
