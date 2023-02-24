// // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int isPalindrom(int num)
{
    int n = num;
    int rev = 0;
    while (n)
    {
        int r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
    }
    return (num == rev);
}
if (isPalindrom(n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
