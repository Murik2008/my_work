// Дан двумерный массив. Определить:
// а) сумму всех элементов третьей строки массива;
// б) сумму всех элементов s-го столбца массива.
int[,] matrix = {
    {1,2,3},
    {5,9,10},
    {11,25,80},
    {34,67,15}
};
//a)
int FindSummRows(int[,] matrix, int i)
{
    int sumRows = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumRows += matrix[i,j];
    }
    return sumRows;
}
Console.WriteLine(FindSummRows(matrix,3));
//b)
int FindSummColumns(int[,] matrix, int s)
{
    int sumColumns = 0;
    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        sumColumns += matrix[l,s];
    }
    return sumColumns;
}
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSummColumns(matrix, s));