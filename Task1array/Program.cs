// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// С использованием массива. Для любова числа.
//При вводе числа столкнулся с проблемой что не хватает int если ввожу число длинее 10 символов, поменял на Int64.

Int64 Promt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return Int64.Parse(param);
}

Int64 number = Promt("Enter number => ");

Int64 count1 = 0, del = number;

if (number < 100)
{
    Console.WriteLine($"Вы ввели число меньше 100, число {number} не подходит под условие,третьей цифры нет.");
    return;
}

while (del > 0)
{
    del = del / 10;
    count1++;
}

Int64[] array = new Int64[count1];
Int64 index = array.Length - 1;
while (index >= 0)
{
    array[index] = number % 10;
    number = number / 10;
    index--;
}

Int64 count2 = count1 / 2;
index = 0;

while (index < count2)
    if (array[index] == array[count1 - 1])
    {
        index++;
        count1--;
    }
    else
    {
        Console.WriteLine("No.");
        Environment.Exit(0);
    }

Console.WriteLine("Yes.");