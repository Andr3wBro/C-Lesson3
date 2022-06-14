// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Promt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int Ax = Promt("Enter x for point A => ");
int Ay = Promt("Enter y for point A => ");
int Az = Promt("Enter z for point A => ");
int Bx = Promt("Enter x for point B => ");
int By = Promt("Enter y for point B => ");
int Bz = Promt("Enter z for point B => ");

double distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return result;
}

double distanceNew = distance(Ax, Bx, Ay, By, Az, Bz);
Console.WriteLine($"Distance between point A and B in 3D perspective = {distanceNew}");