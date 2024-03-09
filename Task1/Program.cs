// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;


bool Is_Even(int num)                              //Возвращает бул о сумме четности цифр числа
{
    int sum = 0;
    bool Even = false;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    if (sum % 2 == 0)
    {
        Even = true;
        System.Console.WriteLine("Сумма цифр в числе четная. Конец программы.");
    }
    return Even;
}

while (true)
{
    System.Console.WriteLine("Введите число:");
    string input = Console.ReadLine();
    int num;
    bool is_num = int.TryParse(input, out num);

    if (is_num == false)
    {
        if (input == "q")                             
        {
            System.Console.WriteLine("Введено 'q'. Конец программы!");
            break;
        }
        else
        {
            System.Console.WriteLine("Введите число или q!");
        }
    }
    else if(is_num == true)
    {
        if (Is_Even(num) == true)
        {
            break;
        }
    }






}
