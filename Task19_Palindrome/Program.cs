/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

// Модуль проверки, является ли оно палиндромом
bool IsPalindromicNum (int checkNum)
{
    // Формирование зеркального числа для последующей проверки
    int tempNum = checkNum;
    int reverseNum = 0;
    while (tempNum > 0)
    {
    reverseNum = reverseNum *10 + tempNum % 10;
    tempNum /= 10;        
    }

    // Сравнение исходного значения с его зеркальным отображением
    if (reverseNum == checkNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int a = GetNumFromUser("Введите натуральное число (больше нуля): ");

if (a > 0 && IsPalindromicNum(a) == true)
{
    Console.WriteLine("Да, введенное число является палиндромом");    
}
else if (a > 0 && IsPalindromicNum(a) == false)
{
    Console.WriteLine("Нет, введенное число не является палиндромом");
}
else
{
    Console.WriteLine("Введенное число не является натуральным и не может являться палиндромом");
}