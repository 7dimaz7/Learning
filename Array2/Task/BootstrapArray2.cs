namespace ConsoleApp1.Array2;

public class BootstrapArray2
{
    public void Run()
    {
        int[,] arr = new int[10, 10]
        {
            { 12, 98, 34, 5, 76, 87, 98, 22, 11, 99 },
            { 98, 44, 76, 33, 87, 15, 9, 76, 99, 54 },
            { 23, 11, 87, 98, 45, 76, 32, 99, 14, 87 },
            { 55, 12, 76, 43, 22, 98, 99, 87, 26, 33 },
            { 76, 9, 14, 98, 87, 12, 55, 44, 99, 21 },
            { 87, 45, 98, 76, 33, 11, 23, 98, 54, 87 },
            { 32, 76, 99, 87, 44, 98, 15, 33, 76, 12 },
            { 98, 21, 87, 14, 99, 76, 32, 87, 45, 98 },
            { 76, 33, 98, 87, 12, 55, 22, 76, 98, 44 },
            { 99, 87, 45, 76, 98, 33, 14, 87, 76, 12 }
        };
        int max = arr[0, 0];
        
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max) 
                {
                    max = arr[i, j];
                }
            }
        }
        
        Console.WriteLine("Исходая матрица");

        for (int l = 0; l < arr.GetLength(0); l++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write(arr[l, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Полученная матрица");
        for (int z = 0; z < arr.GetLength(0); z++)
        {
            for (int v = 0; v < arr.GetLength(1); v++)
            {
                if (arr[z, v] == max)
                {
                    arr[z, v] = 0;
                }
                Console.Write(arr[z, v] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Максимальное значение" + " " + max);
    }
}