// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Без использования массива. Для любова числа.
//При вводе числа столкнулся с проблемой что не хватает int если ввожу число длинее 10 символов, поменял на Int64.
Int64 Promt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return Int64.Parse(param);
}

Int64 number = Promt("Enter number => ");
Int64 copy = number;
Int64 reverse = 0;

while (number > 0) // переворачиваем исходное число наоборот.
{
    Int64 del = number % 10;
    reverse = reverse * 10 + del;
    number = number / 10;
}

if (copy == reverse)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
