/*                      Домашнее задание к семинару 3 С#
Задача 23: 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Например:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

try     // Пытается выполнить программый код
{
    Console.WriteLine("Программа вычисления кубов от 1 до введённого числа");
    Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    CalcCubeFrom1toN(N);
}
catch   // Если не получилось (пользователь ввел не число, а букву), то уходим в этот блок
{
    Console.WriteLine("Некорректный ввод: вводить нужно число!");
}  
    
void CalcCubeFrom1toN(int N)
{
    int cube;
    int temp = 1;
    if (N >= 1)
    {
        while (temp<=N) 
        {
        cube = temp * temp * temp;
        Console.Write ($"{cube}, ");
        temp++;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод!");
    }
}