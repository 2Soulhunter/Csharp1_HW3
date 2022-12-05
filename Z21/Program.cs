/*                      Домашнее задание к семинару 3 С#
Задача 21: 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Например:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int aX, aY, aZ;
int bX, bY, bZ;
double resultDoub;

try     // Пытается выполнить программый код
{
    Console.WriteLine("Введите посследовательность координат: ");
    Console.Write("aX: ");
    aX = Convert.ToInt32(Console.ReadLine());
    Console.Write("aY: ");
    aY = Convert.ToInt32(Console.ReadLine());
    Console.Write("aZ: ");
    aZ = Convert.ToInt32(Console.ReadLine());
    Console.Write("bX: ");
    bX = Convert.ToInt32(Console.ReadLine());
    Console.Write("bY: ");
    bY = Convert.ToInt32(Console.ReadLine());
    Console.Write("bZ: ");
    bZ = Convert.ToInt32(Console.ReadLine());
    DistanceXYin3D(aX, aY, aZ, bX, bY, bZ);
}

catch   // Если не получилось (пользователь ввел не число, а букву), то уходим в этот блок
{
    Console.WriteLine("Некорректный ввод: вводить нужно число!");
}

void DistanceXYin3D(int aX, int aY, int aZ, int bX, int bY, int bZ)
{
    resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
    resultDoub = Math.Sqrt(resultDoub);
    resultDoub = Math.Round(resultDoub, 2);
    Console.WriteLine(resultDoub);
}  
