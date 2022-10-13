// Напишите цикл, который принммет на вход два числа (А и B) и возводит число А в натуральную степень B
Console.Clear();
Console.WriteLine("Напишите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for(int i = 1;i < b; i++)
{
    result = result * a;
}
Console.WriteLine("А в натуральной степени B ровняется: " + result);