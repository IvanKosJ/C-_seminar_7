// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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
        matr [i, j] = new Random().Next(-99, 99)/10.0;
    }
}  
}

int m = GetInfo("Введите количество строк: ");
int n = GetInfo("Введите количество столбцов: ");
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
