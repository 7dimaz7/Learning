namespace Learning.Array1.Task;

internal class BootstrapArray1
{
    public void Run()
    {
        int[][] array = new[]
        {
            new[] { 1, 4, 3, 4 },
            new[] { 2, 4, 6, 7 },
            new[] { 3, 4, 5, 6 },
            new[] { 4, 4, 6, 7 },
        };
        int secondRowSum = 0;
        int firstColumnProduct = 1;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < array.Length; i++)
        {
            firstColumnProduct *= array[i][0];
        }

        for (int i = 0; i < array[1].Length; i++)
        {
            secondRowSum = secondRowSum + array[1][i];
        }

        Console.WriteLine(secondRowSum + " Сумма");
        Console.WriteLine(firstColumnProduct + " Произведение");
    }
}
