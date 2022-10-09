/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int n = GetNumFromUser("Введите число N (при N > 1): ");
if (n <= 1)
{
    Console.WriteLine("Введено неверное число.");
}
else
{
    double[] arrayN = new double[n];
    for (int i = 0; i < n; i++)
    {
        arrayN[i] = Math.Pow((i + 1), 3);
    }
    string result = string.Join(", ", arrayN);
    Console.WriteLine($"Таблица кубов чисел от 1 до {n}: {result}.");
}
