/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Введите размер первой матрицы:");
int[,] a = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (i = 0; i < a.GetLength(0); i++)
{
    for (j = 0; j < a.GetLength(1); j++)
    {
        Console.Write("a[{i}, {j}] = ", i, j);
        a[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размер второй матрицы:");
int[,] b = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (i = 0; i < b.GetLength(0); i++)
{
    for (j = 0; j < a.GetLength(1); j++)
    {
        Console.Write("b[{i}, {j}] = ", i, j);
        a[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица b:");
Print(a);
Console.WriteLine("Матрица b:");
Print(a);
  Console.WriteLine("Матрица c = a * b:");
int[,] c = Multiplication(a, b);
Print(c);
/*}
else
{
    int[,] c = new int[m, q];
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < q; j++)
        {
            c[i, j] = 0;
            for (int k = 0; k < n; k++)
            {
                c[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    Console.WriteLine("Произведение двух матриц равно :");
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            Console.Write(c[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
*/



