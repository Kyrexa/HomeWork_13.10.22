// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Напишите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
while(n > 0)
{
     int j = n % 10;
    n = n / 10;
    s = s + j;
}
Console.WriteLine("Сумма цифр: " + s);
