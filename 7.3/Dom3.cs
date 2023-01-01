//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4 //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите колличество строк");
 int one = Convert.ToInt32 (Console.ReadLine());

 Console.WriteLine("Введите колличество столбцов");
 int two= Convert.ToInt32 (Console.ReadLine());

 int [,] matrix = new int[one,two];
 FillArrayRandomNumbers(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
 {
   double result = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
       result = (result + matrix[i,j]);
    }
    result = result/one;
     Console.WriteLine(result + ";");
 }
Console.WriteLine();

PrintArray(matrix);

void FillArrayRandomNumbers(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
     {
           array[i, j] = new Random().Next(0, 10);
       }
    }
}
void PrintArray(int[,] array)
{     for (int i = 0; i < array.GetLength(0); i++)
   {
       Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
         Console.WriteLine("");
     }

 }