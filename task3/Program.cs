// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

Random array = new Random();
int[] n = new int[8];
for (int i = 0; i < n.Length; i++)
{
    n[i] = new Random().Next(0, 2);
    Console.Write(" " +n[i]);
}
