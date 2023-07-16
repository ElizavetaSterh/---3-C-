// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int lenght = num.Length;

if (lenght == 5)
{
 if (num[0] == num[4] && num[1] == num[3])
    {
 Console.WriteLine($"Число {num} является палиндромом");
    }
 else
    {
 Console.WriteLine($"Число {num} не является палиндром");
    }
}

