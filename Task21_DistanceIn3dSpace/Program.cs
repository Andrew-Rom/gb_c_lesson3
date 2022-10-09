/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/

int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

Console.WriteLine("Введите координаты первой точки (А)");
int xA = GetNumFromUser("- по оси х: ");
int yA = GetNumFromUser("- по оси y: ");
int zA = GetNumFromUser("- по оси z: ");
Console.WriteLine("Введите координаты второй точки (B)");
int xB = GetNumFromUser("- по оси х: ");
int yB = GetNumFromUser("- по оси y: ");
int zB = GetNumFromUser("- по оси z: ");

double AB = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
AB = Math.Round(AB, 2);
Console.WriteLine("Расстояние между указанными точками в 3D пространстве: " + AB);
