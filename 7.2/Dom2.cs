//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.WriteLine("Введите номер строки");
int one= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int two= Convert.ToInt32(Console.ReadLine());

int [,] Gob = new int[10,10];

for (int i = 0; i < Gob.GetLength(0); i++)
{
    for (int j = 0; j < Gob.GetLength(1); j++)
    {
        Gob[i,j]= new Random().Next(100);
        Console.Write(Gob[i,j]+" ");
    }
     Console.WriteLine();
}
if (one<=Gob.GetLength(0)&&two<=Gob.GetLength(1))
{
    Console.Write(Gob[one-1,two-1]);
}
else
{
    Console.Write("Такого числа в массиве нет");
}