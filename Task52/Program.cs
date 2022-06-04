/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


(int, int) GetArraySize()
{
    int rowSize = 0;
    int colSize = 0;
    string enteredSymbol = string.Empty;
    do
    {
        Console.Clear();
        Console.Write("Создать случайный 2D массив? Нажмите y/n: ");
        enteredSymbol = Console.ReadLine();
        if (enteredSymbol == "y")
        {
            rowSize = new Random().Next(2, 11);
            colSize = new Random().Next(2, 11);
            Console.WriteLine("Значение m: {0}", rowSize);
            Console.WriteLine("Значение n: {0}", colSize);
            Console.WriteLine();
            break;
        }
        else if (enteredSymbol == "n")
        {
            Console.Write("Введите значение m:");
            rowSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение n:");
            colSize = Convert.ToInt32(Console.ReadLine());
            break;
        }
    } while (true);

    return (rowSize, colSize);
}
void Print2DArray(int[,] ArrayToPrint)
{
    Console.Write("[X]\t");
    for (int i = 0; i < ArrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t", i);
    }
    Console.WriteLine();
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t", i);
        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            if (i == rowColoredElement
                && j == colColoredElement)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (ArrayToPrint[i, j] < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Write(ArrayToPrint[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
static void Fill2DArray(int[,] ArrayToFill, int deviation = 10)