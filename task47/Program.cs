/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] generate2DArray(int higth, int wigth, int randomStart, int randomEnd) // генерируем массив. [,] означает, что по обе стороны от запятой есть два индекса
{
    double[,] twoDArray = new double[higth, wigth]; // создаем 2D массив, задаем ему имя
    for (int i = 0; i < higth; i++)
    {
        for (int j = 0; j < wigth; j++)
        {
            twoDArray[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; // + 1 нужна, чтобы в строка 44 включалось 100 _generate2DArray(7,5, 10,100)
            //array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(double[,] arrayToPrint)
{
    Console.Write("\t"); // вертикальная маркировка строк
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t"); 
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t"); // горизонтальная маркировка столбцов
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t"); // \t - автотабуляция 
        }
        Console.WriteLine();
    }
}

double[,] generatedArray = generate2DArray(3,4, -100, 100); // семь на пять и от десяти до ста
print2DArray(generatedArray);
