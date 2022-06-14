// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
double Promt(string message)

{
    Console.Write(message);
    string param = Console.ReadLine();
    return double.Parse(param);
}

double N = Promt("Enter N => ");
double index = 1;
double result = 1;

while (index <= N)
{
    result = index * index * index;
    //result = Math.Pow(index,3);
    index++;
    Console.Write($"{result} | ");
}