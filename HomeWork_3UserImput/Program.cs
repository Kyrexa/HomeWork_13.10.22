// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.(Вводит пользователь) Console.Clear();
Console.Clear();
int[] array = new int[8];
for (int i = 0; i <= 7; i++)
{
    int serialNumber = i + 1;
    Console.WriteLine("Введите 8 чисел - число №: " + serialNumber);
    int a = Convert.ToInt32(Console.ReadLine());
    array[i] = a;
}
Console.WriteLine($"[{string.Join(", ", array)}]");