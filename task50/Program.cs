// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] matr) //- фцнкция печати массива на экран
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
Console.WriteLine();
}
}

void FillArray(double[,] matr)  //Функция заполнения массива случайными числами
{
  for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr [i, j] = new Random().Next(1, 99);
    }
}  
}

int m = GetInfo("Введите номер строки: ");
int n = GetInfo("Введите номер столбца: ");
double[,] matrix = new double[10, 23];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
if (m < matrix.GetLength(0) && n < matrix.GetLength(1)) 
{
    Console.WriteLine(matrix[m, n]);
}
else Console.WriteLine($"{m} {n} -> такого числа в массиве нет");