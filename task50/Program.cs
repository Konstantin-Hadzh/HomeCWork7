/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/



Console.Write("введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] user2DArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

if (n > user2DArray.GetLength(0) || m > user2DArray.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {user2DArray[n-1,m-1]}");
}
Console.WriteLine();

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
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

print2DArray(user2DArray);
Console.WriteLine();
